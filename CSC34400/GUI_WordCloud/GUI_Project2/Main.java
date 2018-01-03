
/*
 FILE: Main.java
 AUTHOR: Zhuocheng Shang
 DATE: 27/10/2017
 PURPOSE: This is the Main source file for GUI_WordCloud_project2
*/

package GUI_Project2;

import javafx.application.Application;
import javafx.geometry.*;
import javafx.scene.Scene;
import javafx.scene.layout.*;
import javafx.scene.shape.Rectangle;
import javafx.stage.Modality;
import javafx.stage.Stage;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.chart.PieChart;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;
import javafx.scene.paint.Color;
import javafx.scene.text.Font;
import java.lang.*;



import java.util.*;

public class Main extends Application {


    private TextField textArea;  //text filed to enter words
    private Pane wordCloud; // word cloud to hold words
    private Label newWord; // word be added
    private PieChart circleChart; //pie chart to count words
    private PieChart.Data Slice; //pie chart slice to hold value
    private EventHandler sliceHandler; //handle event when click on pi chart
    private EventHandler labelHandler; //handle event when click on word

    Map<String,Label> wordMap = new HashMap<String, Label>(); //word map contain word string and label
    Map<String,PieChart.Data> sliceMap = new HashMap<String,PieChart.Data>(); // slice map contain word string and slice value

    private double radius=5;  // current radius along spiral
    private double  deg=0; //current degree along spiral
    private double currX;  //current x point
    private double currY;  // current y point

    @Override
    public void start(Stage primaryStage) {

           //whole layout structure
        VBox root = new VBox();

        /*************Title************************/

            //HBox to hold title
        HBox t = new HBox();
            //put at the center
        t.setAlignment(Pos.CENTER);
            //give the title
        String Title = "~ Play With Word Cloud ! ~";
            //show title on stage
        Label theTitle = new Label(Title);
        theTitle.setFont(new Font("Arial", 30)); //title font and size
        theTitle.setStyle("-fx-padding:10;"); //set padding
        t.getChildren().add(theTitle);


        /**********Word & PieChart******************/

           //HBox contains wordCloud and pieChart
        HBox wordContent = new HBox();
        wordContent.setStyle("-fx-padding:45;");

           //initialize world cloud
        wordCloud = new Pane();
        wordCloud.setStyle("-fx-border-style:solid inside;"+"-fx-border-color: black;");
        wordCloud.setMinWidth(600);
        wordCloud.setMinHeight(600);
        wordCloud.setMaxWidth(600);
        wordCloud.setMaxHeight(600);

            //call applyCss and layout
        wordCloud.applyCss();
        wordCloud.layout();

            //initialize piechart
        Pane PieChartHolder = new Pane();
        PieChartHolder.setBackground(
                new Background(new BackgroundFill(Color.DARKSALMON,null,null))
        );
        circleChart = new PieChart();

        PieChartHolder.getChildren().add(circleChart);




        /****************Control Buttons**************/

          //HBox contains all control buttons
        HBox controlButton = new HBox();
        controlButton.setStyle("-fx-padding:50;"+"-fx-alignment: center;");

          //text area
        textArea = new TextField();

          //control buttons
        Button addButton = new Button("Add Word");
        Button clearButton = new Button("Clear All");
        Button quitButton = new Button("Quit");

        controlButton.getChildren().addAll(textArea, addButton, clearButton,quitButton);


        /***** addButton action *********************************
         1. word will show in pie chart
         2. word show up in word area
            //check duplication
               (if dup slice increase by1 ;
                  word size increase by 2 -> check overlapping
           //words should not go over bound
         ********************************************************/

        addButton.setOnAction(new EventHandler<ActionEvent>() {

            @Override
            public void handle(ActionEvent event) {
                  //get input text
                String wordInput = textArea.getText();
                  //word as label
                newWord = new Label(wordInput);

                      /***--check input validation -***/
                if(checkInput(wordInput)) {

                    /*****--if not duplicate--****/
                    if (!checkDup(wordInput) && !wordInput.equals("")) {

                          //add to stage
                        wordCloud.getChildren().add(newWord);
                          //click on word, word size increase by 2
                        newWord.setOnMouseClicked(labelHandler);
                          //map
                        wordMap.put(wordInput, newWord);


                          //add data to pie chart
                        Slice = new PieChart.Data(wordInput, 1);
                           //put slices into pie chart
                        circleChart.getData().add(Slice);
                           //click on slice, slice value increase by 1
                        Slice.getNode().setOnMouseClicked(sliceHandler);
                           //map
                        sliceMap.put(wordInput, Slice);


                           //check overlap
                        moveToOpenSlot(newWord);

                    }  else {

                        /*****--if duplicate--****/
                         //slice value +1
                         //word size +2
                        changeSizeValue(wordInput);
                    }

                }else{

                       //pop a alert window
                    inputTypeAlert Alert = new inputTypeAlert();
                    Alert.initModality(Modality.APPLICATION_MODAL);
                    Alert.showAndWait();
                }

                   //clear text filed
                textArea.setText("");

            }
        });


        /***** click on pie chart action **********************
         1.click on pie chart
           slice increase by 1
           word size increase by 2
           -> check overlapping
         ******************************************************/

            sliceHandler = new EventHandler<MouseEvent>() {
                @Override
                public void handle(MouseEvent ev) {

                    PieChart.Data foundSlice = null;

                       //get the value of clicked pie chart slice
                    for (PieChart.Data slice : circleChart.getData()) {
                        if (slice.getNode() == ev.getSource())
                           foundSlice = slice;
                    }
                       //get the response word
                    String word = foundSlice.getName();
                       //call change size and value function
                    changeSizeValue(word);

                }
            };



        /***** click on word action **************************
         1.click on word:
            pie chart slice increase by 1
            word size increase by 2
            -> check overlapping
         ***********************************************/

       labelHandler = new EventHandler<MouseEvent>() {

            @Override
            public void handle(MouseEvent ev) {

                 //get the value of clicked word
               Label l = (Label)ev.getSource();
               String word = l.getText();
                 //call change size and value function
               changeSizeValue(word);

            }
        };


        /*******clearButton Action**************/

        clearButton.setOnAction(new EventHandler<ActionEvent>() {

            @Override
            public void handle(ActionEvent event) {

                  //pup up a window
                clearAlert clearMessage = new clearAlert(wordMap,wordCloud,sliceMap,circleChart);
                clearMessage.initModality(Modality.APPLICATION_MODAL);
                clearMessage.showAndWait();

            }
        });


        /*******quitButton Action**************/

        quitButton.setOnAction(new EventHandler<ActionEvent>() {

            @Override
            public void handle(ActionEvent event) {
                   //pup up a window
                quitAlert quitMessage = new quitAlert();
                quitMessage.initModality(Modality.APPLICATION_MODAL);
                quitMessage.showAndWait();
            }
        });


        Rectangle myClipper = new Rectangle(600,600);

           //set clip, word will not show if they out of the bound
        wordCloud.setClip(myClipper);

        wordContent.getChildren().addAll(wordCloud,PieChartHolder);
        root.getChildren().addAll(t,wordContent,controlButton);


        Scene scene = new Scene(root);

        primaryStage.setTitle("GUI_Porject_02");
        primaryStage.setScene(scene);
        primaryStage.show();

        primaryStage.setMinWidth(primaryStage.getWidth());
        primaryStage.setMinHeight(primaryStage.getHeight());

        primaryStage.setMaxWidth(primaryStage.getWidth());
        primaryStage.setMaxHeight(primaryStage.getHeight());
    }


    /********************************** FUNCTIONS & METHODS **************************************/


    /**************** Check Input ***********************/

    public boolean checkInput(String input){

           //only characters and numbers are valid input
        String validChars = "^[0-9a-zA-Z]+$";

        return input.matches(validChars);

    }

    /************ Check Duplication ********************/

    public boolean checkDup(String input){

            //containKey
        if(sliceMap.containsKey(input))
            return true;  //if the word is not in the map, add to word cloud.
        else
            return false; //if the word already in the map, cannot add to word cloud.
    }

    /*********** Change Font and Pie Slice Value Function ***********/

    public void changeSizeValue(String input)
    {
           //slice value add one
        PieChart.Data foundSlice = null;
        foundSlice = sliceMap.get(input);
        foundSlice.setPieValue(foundSlice.getPieValue() + 1);

          //word size increase by 2
        Label wordFound = wordMap.get(input);
        double theX = wordFound.getScaleX() +0.5;
        double theY = wordFound.getScaleY() +0.5;
        wordFound.setScaleX(theX);
        wordFound.setScaleY(theY);

          //check overlap
        moveToOpenSlot(wordFound);

    }


      /*************** Go Through Nap *****************/

      public boolean anyIntersecting (Label el1) {

          boolean intersect = false;

            //go through map
          for (Map.Entry entry : wordMap.entrySet()) {

                 //do not check overlap with itself
              if (!el1.getText().equals(entry.getKey())) {

                  Label check = (Label) entry.getValue();
                  if (checkOverlap(el1, check)) {
                      intersect = true;
                      return true;
                  }
              }

          }
          return intersect;
      }

    /**************** Check overlapping *******************/

    public boolean checkOverlap(Label el1, Label el2){

          //call applyCss and layout
        wordCloud.applyCss();
        wordCloud.layout();
        el1.applyCss();
        el1.layout();
        el2.applyCss();
        el2.layout();

          //check intersection
        boolean ans;
        if(el1.getBoundsInParent().intersects(el2.getBoundsInParent())) {
            ans = true;
        }
        else{
            ans = false;
        }

        return ans;

        }


    /***************** Change Location ****************/

    public void changeLocation(Label l)
    {
          //call applyCss and layout
        wordCloud.applyCss();
        wordCloud.layout();
        l.applyCss();
        l.layout();

          //update degree and rdius
        deg += 10;
            if (deg>=360)
           {
             deg=0;
            radius += 5;
            }

           //change current x and y
        double angle = Math.toRadians(deg);
        currX =  300.0+radius * Math.cos(angle);
        currY =  300.0+radius * Math.sin(angle);
    }


    /*************** Change Rotation *******************/

    public boolean tryRots(Label l){

          //call applyCss and layout
        wordCloud.applyCss();
        wordCloud.layout();
        l.applyCss();
        l.layout();

          // try 0 degs
        l.setStyle(" -fx-rotate: 0;");
        boolean inter = anyIntersecting(l); //check overlap
        if (!inter) //if not overlap, we can go out of the loop
            return true;

          // try 90 degs
        l.setStyle(" -fx-rotate: 90;");
       inter = anyIntersecting(l);  //check overlap
        if (!inter) //if not overlap, we can go out of the loop
            return true;

        return false;

    }


    /******************** MoveToOpenSlot *****************/

    public void moveToOpenSlot(Label l){

           //call applyCss and layout
        wordCloud.applyCss();
        wordCloud.layout();
        l.applyCss();
        l.layout();

          //start at the center
        currX = 300.0;
        currY = 300.0;
        l.setLayoutX(currX);
        l.setLayoutY(currY);
        radius=0;
        deg=0;

        boolean success = !anyIntersecting(l); //done if the word is not intersected with others

        while(!success)  //if not done, find another position and check again
        {
              //update x, y, radius and deg
            changeLocation(l);

            l.setLayoutX(currX); //get the new x location
            l.setLayoutY(currY); //get the new y location

            success = tryRots(l); // try rotate
        }

    }



    public static void main(String[] args) {
        launch(args);
    }
}

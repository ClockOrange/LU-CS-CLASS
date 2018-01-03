
/*
 FILE: quitAlert.java
 AUTHOR: Zhuocheng Shang
 DATE: 27/10/2017
 PURPOSE: This is a pop up window to confirm "clear" Button.
*/


package GUI_Project2;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.chart.PieChart;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Pane;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;
import java.util.Map;

public class clearAlert extends Stage {

    public clearAlert(Map word,Pane A,Map slice,PieChart B)
    {

            //VBox contains alertText and control buttons
        VBox root = new VBox();
            //give alert text
        Label alertText = new Label("Are you sure to clear out yor word cloud?");
        alertText.setWrapText(true);

            //control buttons
        HBox controls = new HBox();
        Button clearButton = new Button("Clear");
        Button cancelButton = new Button("Cancel");

        controls.setStyle("-fx-alignment: center;");
        root.setStyle("-fx-alignment: center;");

           //when click Clear
        clearButton.setOnAction(new EventHandler<ActionEvent>() {

            @Override
            public void handle(ActionEvent event) {

                  //claer word cloud and wordMap
                word.clear();
                A.getChildren().clear();

                  //pie chart date cloud and sliceMap
                slice.clear();
                B.getData().clear();

                  //close window
                close();
            }
        });

       cancelButton.setOnAction(new EventHandler<ActionEvent>() {

            @Override
            public void handle(ActionEvent event) {

                close(); //close window
            }
        });

        controls.getChildren().addAll(clearButton,cancelButton);
        root.getChildren().addAll(alertText,controls);
        Scene scene = new Scene(root, 300, 100);
        setScene(scene);
    }
}


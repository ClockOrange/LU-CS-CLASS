
/*
 FILE: quitAlert.java
 AUTHOR: Zhuocheng Shang
 DATE: 27/10/2017
 PURPOSE: This is a pop up window to confirm "Quit" Button.
*/


package GUI_Project2;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.layout.HBox;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

public class quitAlert extends Stage {

    public quitAlert() {

           //VBox contains alertText and control buttons
        VBox root = new VBox();

            //give alert text
        Label alertText = new Label("Are you sure to quit this application?");

            //control buttons
        HBox controls = new HBox();
        Button okButton = new Button("Quit");
        Button cancelButon = new Button("Cancel");

        controls.getChildren().addAll(okButton,cancelButon);

            //put buttons at the center
        controls.setStyle("-fx-alignment: center;");
        root.setStyle("-fx-alignment: center;");

            //when click OK
        okButton.setOnAction(new EventHandler<ActionEvent>() {

            @Override
            public void handle(ActionEvent event) {

                System.exit(0); //quit the application
            }
        });

           //when click Cancel
        cancelButon.setOnAction(new EventHandler<ActionEvent>() {

            @Override
            public void handle(ActionEvent event) {

                close();  //close window
            }
        });


        root.getChildren().addAll(alertText,controls);

        Scene scene = new Scene(root, 300, 100);

        setScene(scene);


    }
}
/*
 FILE: inputTypeAlert.java
 AUTHOR: Zhuocheng Shang
 DATE: 27/10/2017
 PURPOSE: This is a pop up window.
          Show up when user enter something rather than characters and digits.
*/

package GUI_Project2;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

public class inputTypeAlert extends Stage {

    public inputTypeAlert() {

          //VBox contains alertText and control buttons
        VBox root = new VBox();

          //give alert text
        Label alertText = new Label("Please check your input.Only characters and numbers are allowed.");
        alertText.setWrapText(true);

           //Ok button
        Button okButton = new Button("OK");

        root.setStyle("-fx-alignment: center;");

           //when click OK
        okButton.setOnAction(new EventHandler<ActionEvent>() {

            @Override
            public void handle(ActionEvent event) {

                close(); //close window
            }
        });


        root.getChildren().addAll(alertText,okButton);
        Scene scene = new Scene(root, 300, 100);

        setScene(scene);


    }
}
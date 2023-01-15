/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.sr.recetas.controllers;

import es.iespuertodelacruz.sr.recetas.models.*;
import java.io.IOException;

import java.net.URL;
import java.util.ResourceBundle;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

public class AgregarController implements Initializable{
    
    private ManejarFichero mf;
    @FXML
    private Button btnSave;
    @FXML
    private Button btnExit;
    @FXML
    private TextField txfNombre;
    @FXML
    private TextField txfContraseña;
    @FXML
    private TextField txfRol;
    @FXML
    private Label lblName;
    @FXML
    private Label lblApellidos;
    @FXML
    private Label lblEdad;
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        mf = new ManejarFichero("src\\es\\iespuertodelacruz\\sr\\txts\\users.txt");
    }

    @FXML
    private void Save_onClick(ActionEvent event) throws IOException {
        if (txfNombre.getText().length() < 1) {
            Alert error = new Alert(Alert.AlertType.ERROR);
            error.setHeaderText(null);
            error.setTitle("Error");
            error.setResizable(true);
            error.setContentText("Se necesita poner un nombre al nuevo usuario que guardar");
            error.showAndWait();
        } else if (txfContraseña.getText().length() < 1) {
            Alert error = new Alert(Alert.AlertType.ERROR);
            error.setHeaderText(null);
            error.setTitle("Error");
            error.setResizable(true);
            error.setContentText("Se necesita poner una contraseña al nuevo usuario que guardar");
            error.showAndWait();
        } else if (txfRol.getText().length() < 1) {
            Alert error = new Alert(Alert.AlertType.ERROR);
            error.setHeaderText(null);
            error.setTitle("Error");
            error.setResizable(true);
            error.setContentText("Se necesita poner un rol al nuevo usuario que guardar");
            error.showAndWait();
        } else if (!"profesor".equals(txfRol.getText()) && !"alumno".equals(txfRol.getText())) {
            Alert error = new Alert(Alert.AlertType.ERROR);
            error.setHeaderText(null);
            error.setTitle("Error");
            error.setResizable(true);
            error.setContentText("Se tiene que elegir un rol entre 'profesor' o 'alumno'");
            error.showAndWait();
        } else {
                if (mf.AñadirUsuario(new Usuario(
                                                        txfNombre.getText(),
                                                        txfContraseña.getText(),
                                                        txfRol.getText()
                                                            )
                                                )
                ) {
                    Alert alert = new Alert(Alert.AlertType.INFORMATION);
                    alert.setHeaderText(null);
                    alert.setTitle("Informacion");
                    alert.setResizable(true);
                    alert.setContentText("Se ha añadido el nuevo usuario correctamente");
                    alert.showAndWait();
                } else {
                    Alert alert = new Alert(Alert.AlertType.ERROR);
                    alert.setHeaderText(null);
                    alert.setResizable(true);
                    alert.setTitle("ERROR");
                    alert.setContentText("Ha ocurrido un error, aseguresé de que el nombre y la contraseña "
                                        + "del usuario a añadir no pertenezca actualmente a otro usuario ya añadido. "
                                        + "Si no se repite el nombre y la contraseña de otra persona, entonces ha ocurrido "
                                        + "un error al intentar añadir un usuario al fichero.");
                    alert.showAndWait();
                }
        }
        
        Stage stage = (Stage) btnSave.getScene().getWindow();
        stage.close();
    }

    @FXML
    private void Exit_onClick(ActionEvent event) {
        Stage stage = (Stage) btnExit.getScene().getWindow();
        stage.close();
    }
    
}

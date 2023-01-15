/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.sr.recetas.controllers;

import es.iespuertodelacruz.sr.recetas.models.*;
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

public class FXMLModificarController implements Initializable{

    private ManejarFichero mf;
    
    private Usuario u;
    
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
    private Button btnModificar;
    @FXML
    private Label lblName;
    @FXML
    private Label lblApellidos;
    @FXML
    private Label lblEdad;

    public Usuario getUsuariomodificar() {
        return u;
    }

    public void setPersonamodificar(Usuario usuariomodificar) {
        this.u = usuariomodificar;
        CargarDatos();
    }

    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        mf = new ManejarFichero("src\\es\\iespuertodelacruz\\sr\\txts\\users.txt");
    }
    
    @FXML
    private void Modificar_onClick(ActionEvent event) {
        String nombreusuarioantiguo = u.getNombre();
        String contraseñausuarioantiguo = u.getContraseña();
        String rolusuarioantiguo = u.getRol();
        if (txfNombre.getText().length() < 1) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setHeaderText(null);
            alert.setTitle("Error");
            alert.setResizable(true);
            alert.setContentText("Se necesita poner un nombre nuevo al usuario que se desea modificar");
            alert.showAndWait();
        } else if (txfContraseña.getText().length() < 1) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setHeaderText(null);
            alert.setTitle("Error");
            alert.setResizable(true);
            alert.setContentText("Se necesita poner una contraseña nueva al usuario que se desea modificar");
            alert.showAndWait();
        } else if (txfRol.getText().length() < 1) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setHeaderText(null);
            alert.setTitle("Error");
            alert.setResizable(true);
            alert.setContentText("Se necesita poner un rol nuevo al usuario que se desea modificar");
            alert.showAndWait();
        Stage stage = (Stage) btnSave.getScene().getWindow();
        stage.close();
        } else {
                u.setNombre(txfNombre.getText());
                u.setContraseña(txfContraseña.getText());
                u.setRol(txfRol.getText());
                mf.UpdateUsuarioById(nombreusuarioantiguo, contraseñausuarioantiguo, u);
                Alert alert = new Alert(Alert.AlertType.INFORMATION);
                alert.setHeaderText(null);
                alert.setTitle("Informacion");
                alert.setResizable(true);
                alert.setContentText("Se ha modificado el usuario correctamente");
                alert.showAndWait();
        }
        
        Stage stage = (Stage) btnExit.getScene().getWindow();
        stage.close();
    }
    
    @FXML
    private void Salir_onClick(ActionEvent event) {
        Stage stage = (Stage) btnExit.getScene().getWindow();
        stage.close();
    }
    
    private void CargarDatos() {
        txfNombre.setText(u.getNombre());
        txfContraseña.setText(u.getContraseña());
        txfRol.setText(u.getRol());
    }
    
}

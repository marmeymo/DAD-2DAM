/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.sr.recetas.controllers;

import java.net.URL;
import java.util.ArrayList;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Alert;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField;
import javafx.stage.Stage;
import es.iespuertodelacruz.sr.recetas.models.*;

public class FXMLUsuariosController implements Initializable {
    
    Usuario usuario;
    
    ManejarFichero mf;
    
    @FXML
    private TextField tfNombre;
    @FXML
    private PasswordField pfContraseña;

    public Usuario getUsuario() {
        return usuario;
    }
    
    /**
     * Initializes the controller class.
     * @param url
     * @param rb 
     */
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        mf = new ManejarFichero("src\\es\\iespuertodelacruz\\sr\\txts\\users.txt");
        // TODO
    }    
    
    @FXML
    private void Login_onClick(ActionEvent event) {
        if ("".equals(tfNombre.getText()) || "".equals(pfContraseña.getText())) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setHeaderText(null);
            alert.setTitle("Error al logearse");
            alert.setContentText("Contraseña o nombre de usuario no introducido");
            alert.setResizable(true);
            alert.showAndWait();
        } else {
            ArrayList<String> listausuarios = mf.LeerFicheroDevolverArrayList();
            for (String u : listausuarios) {
                String[] usuarioarray = u.split(":");
                for (int i = 0; i < usuarioarray.length; i++) {
                    if (tfNombre.getText().equals(usuarioarray[i]) && pfContraseña.getText().equals(usuarioarray[i+1])) {
                        usuario = new Usuario(tfNombre.getText(), pfContraseña.getText(), usuarioarray[2]);
                        Stage stage = (Stage) tfNombre.getScene().getWindow();
                        stage.close();
                        break;
                    }
                }
            }
            if (usuario == null) {
                Alert alert = new Alert(Alert.AlertType.ERROR);
                alert.setHeaderText(null);
                alert.setTitle("Error al logearse");
                alert.setContentText("No existe tal usuario ingresado");
                alert.setResizable(true);
                alert.showAndWait();
                tfNombre.setText("");
                pfContraseña.setText("");
            }
        }
    }
    
}

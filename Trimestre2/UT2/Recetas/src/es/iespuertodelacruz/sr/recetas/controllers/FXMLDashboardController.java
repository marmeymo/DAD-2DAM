/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.sr.recetas.controllers;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Label;
import javafx.scene.input.MouseEvent;
import javafx.stage.Modality;
import javafx.stage.Stage;

import es.iespuertodelacruz.sr.recetas.models.*;
import javafx.scene.image.ImageView;
import javafx.scene.layout.Pane;

public class FXMLDashboardController implements Initializable {

    @FXML
    private Label label;
    @FXML
    private Pane paneUsuarios;
    @FXML
    private Pane paneNotas;
    @FXML
    private ImageView minimize;
    @FXML
    private ImageView maximize;
    @FXML
    private ImageView close;

    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }
    
    @FXML
    private void Estadistica_onClick(MouseEvent event) throws IOException {
        FXMLLoader loader = new FXMLLoader(getClass().getResource("/es/iespuertodelacruz/sr/recetas/vistas/FXMLEstadistica.fxml"));
        Parent root = loader.load();
        Scene scene = new Scene(root);
        Stage stage = new Stage();
        stage.initModality(Modality.APPLICATION_MODAL);
        stage.setScene(scene);
        stage.showAndWait();
    }
    
    @FXML
    private void Usuarios_onClick(MouseEvent event) throws IOException {
        FXMLLoader loader = new FXMLLoader(getClass().getResource("/es/iespuertodelacruz/sr/recetas/vistas/FXMLUsuarios.fxml"));

        Parent root = loader.load();

        FXMLUsuariosController usuarioscontroller = loader.getController();

        Scene scene = new Scene(root);
        Stage stage = new Stage();
        stage.initModality(Modality.APPLICATION_MODAL);
        stage.setScene(scene);
        stage.showAndWait();

        Usuario u = usuarioscontroller.getUsuario();
        if (u != null) {
            switch (u.getRol()) {
                case "alumno":
                    paneUsuarios.setVisible(false);
                    paneUsuarios.setDisable(true);
                    paneNotas.setVisible(false);
                    paneNotas.setDisable(true);
                    break;
                case "profesor":
                    FXMLLoader loader2 = new FXMLLoader(getClass().getResource("/es/iespuertodelacruz/sr/recetas/vistas/FXMLUsuariosGestion.fxml"));
                    Parent root2 = loader2.load();
                    Scene scene2 = new Scene(root2);
                    Stage stage2 = new Stage();
                    stage2.initModality(Modality.APPLICATION_MODAL);
                    stage2.setScene(scene2);
                    stage2.showAndWait();
                    break;
            }
        }

    }
    
    @FXML
    private void Minimizar_onClick(MouseEvent event) {
        Stage stage = (Stage) paneUsuarios.getScene().getWindow();
        stage.setIconified(true);
    }
    
    @FXML
    private void Maximizar_onClick(MouseEvent event) {
        Stage stage = (Stage) paneUsuarios.getScene().getWindow();
        stage.setMaximized(true);
    }
    
    @FXML
    private void Cerrar_onClick(MouseEvent event) {
        Stage stage = (Stage) paneUsuarios.getScene().getWindow();
        stage.close();
    }

}

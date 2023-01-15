/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.sr.recetas.controllers;

import java.io.IOException;
import java.net.URL;
import java.util.ArrayList;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.stage.Modality;
import javafx.stage.Stage;
import es.iespuertodelacruz.sr.recetas.models.*;

public class FXMLGestionUsuariosController implements Initializable {

    ManejarFichero mf;
    
    @FXML
    private TableColumn<?, ?> tbcNombre;
    @FXML
    private Button btnAgregar;
    @FXML
    private Button btnEliminar;
    @FXML
    private Button btnModificar;
    @FXML
    private TableView tbvUsuarios;
    @FXML
    private TableColumn<?, ?> tbcContraseña;
    @FXML
    private TableColumn<?, ?> tbcRol;


    /**
     * Initializes the controller class.
     * @param url
     * @param rb 
     */
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
        mf = new ManejarFichero("src\\es\\iespuertodelacruz\\sr\\txts\\users.txt");
        CargarTableView();
    }
    
    private void CargarTableView() {
        tbvUsuarios.getItems().clear();
        ArrayList<Usuario> listausuarios = mf.LeerFicheroDevolverUsuarioLista();
        if (listausuarios.isEmpty()) {
            Alert alert = new Alert(Alert.AlertType.INFORMATION);
            alert.setHeaderText(null);
            alert.setTitle("Informacion");
            alert.setContentText("No existe ninguna persona así que no se mostrará ninguna en la lista");
            alert.setResizable(true);
            alert.showAndWait();
        } else {
            
            tbcNombre.setCellValueFactory(new PropertyValueFactory<>("nombre"));

            tbcContraseña.setCellValueFactory(new PropertyValueFactory<>("contraseña"));

            tbcRol.setCellValueFactory(new PropertyValueFactory<>("rol"));
        
            for (int i = 0; i < listausuarios.size(); i++) {
                Usuario get = listausuarios.get(i);
                tbvUsuarios.getItems().add(get);
            }
        }
    }    
    
    @FXML
    private void Agregar_onClick(ActionEvent event) throws IOException {
        FXMLLoader loader = new FXMLLoader(getClass().getResource("/es/iespuertodelacruz/sr/recetas/vistas/AgregarView.fxml"));
        Parent root = loader.load();
        Scene scene = new Scene(root);
        Stage stage = new Stage();
        stage.initModality(Modality.APPLICATION_MODAL);
        stage.setScene(scene);
        stage.showAndWait();
        CargarTableView();
    }
    
    @FXML
    private void Eliminar_onClick(ActionEvent event) {
        if (tbvUsuarios.getSelectionModel().getSelectedItem() == null) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setHeaderText(null);
            alert.setTitle("Error");
            alert.setResizable(true);
            alert.setContentText("Se debe de seleccionar un usuario de la lista para eliminarla");
            alert.showAndWait();
        } else {
            Usuario userleccionado = (Usuario) tbvUsuarios.getSelectionModel().getSelectedItem();
            mf.DeleteUserById(userleccionado);
            CargarTableView();
        }
    }
    
    @FXML
    private void Modificar_onClick(ActionEvent event) throws IOException {
        if (tbvUsuarios.getSelectionModel().getSelectedItem() == null) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setHeaderText(null);
            alert.setTitle("Error");
            alert.setResizable(true);
            alert.setContentText("Se debe de seleccionar un usuario de la lista para modificarla");
            alert.showAndWait();
        } else {
            Usuario useleccionado = (Usuario) tbvUsuarios.getSelectionModel().getSelectedItem();
                
            FXMLLoader loader = new FXMLLoader(getClass().getResource("/es/iespuertodelacruz/sr/recetas/vistas/ModificarView.fxml"));
            
            Parent root = loader.load();
            
            FXMLModificarController modificarcontroller = loader.getController();
            modificarcontroller.setPersonamodificar(useleccionado);
            
            Scene scene = new Scene(root);
            Stage stage = new Stage();
            stage.initModality(Modality.APPLICATION_MODAL);
            stage.setScene(scene);
            stage.showAndWait();
            
            Usuario u = modificarcontroller.getUsuariomodificar();
            CargarTableView();
        }
    }

    
}

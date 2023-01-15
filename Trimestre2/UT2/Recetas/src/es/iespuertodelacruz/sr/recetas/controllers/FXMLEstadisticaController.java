/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.sr.recetas.controllers;

import java.net.URL;
import java.util.ArrayList;
import java.util.ResourceBundle;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.chart.BarChart;
import javafx.scene.chart.CategoryAxis;
import javafx.scene.chart.NumberAxis;
import javafx.scene.chart.PieChart;
import javafx.scene.chart.XYChart;
import es.iespuertodelacruz.sr.recetas.models.*;

public class FXMLEstadisticaController implements Initializable {

    ManejarFichero mf;
    @FXML
    private BarChart<?, ?> RecetasGrafico;
    @FXML
    private NumberAxis GraficoY;
    @FXML
    private CategoryAxis GraficoX;
    @FXML
    private PieChart PieChart;

    /**
     * 
     * @param url
     * @param rb 
     */
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        mf = new ManejarFichero("src\\es\\iespuertodelacruz\\sr\\txts\\recetas.txt");
        GraficoBarras();
        PieChart();
        // TODO
    }
    
    /**
     * Autocompleta el grafico de barras mediante los datos obtenidos de un fichero "recetas"
     */
    private void GraficoBarras() {
        ArrayList<String> listarecetas = mf.LeerFicheroDevolverArrayList();
        int numentrantes, numprimero, numsegundo, numpostre;
        numentrantes = numprimero = numsegundo = numpostre = 0;
        XYChart.Series aux = new XYChart.Series<>();
        
        for (String receta : listarecetas) {
            String[] recetaarray = receta.split(";");
            for (String recetaarray1 : recetaarray) {
                switch (recetaarray1) {
                    case "Postres":
                        numpostre++;
                        break;
                    case "Segundo":
                        numsegundo++;
                        break;
                    case "Entrante":
                        numentrantes++;
                        break;
                    case "Primero":
                        numprimero++;
                        break;
                }
            }
        }
        aux.getData().add(new XYChart.Data("Entrantes", numentrantes));
        aux.getData().add(new XYChart.Data("Primero", numprimero));
        aux.getData().add(new XYChart.Data("Segundo", numsegundo));
        aux.getData().add(new XYChart.Data("Postre", numpostre));
        
        RecetasGrafico.getData().addAll(aux);
    }
    
    /**
     * Autocompleta el PieChart mediante los datos obtenidos de un fichero "recetas"
     */
    private void PieChart() {
        ArrayList<String> listarecetas = mf.LeerFicheroDevolverArrayList();
        ArrayList<String> nombresrecetas = new ArrayList<>();
        ArrayList<Integer> kcalrecetas = new ArrayList<>();
        for (String receta : listarecetas) {
            String[] recetaarray = receta.split(";");
            for (int i = 0; i < recetaarray.length; i++) {
                switch(i) {
                    case 0:
                        nombresrecetas.add(recetaarray[i]);
                        break;
                    case 6:
                        kcalrecetas.add(Integer.parseInt(recetaarray[i]));
                        break;
                }
            }
        }
        
        ObservableList<PieChart.Data> piechartdata = FXCollections.observableArrayList();
        for (int i = 0; i < nombresrecetas.size(); i++) {
            piechartdata.add(new PieChart.Data(nombresrecetas.get(i), kcalrecetas.get(i)));
        }
        PieChart.setData(piechartdata);
        PieChart.setTitle("Kcal por recetas");
    }

    
}

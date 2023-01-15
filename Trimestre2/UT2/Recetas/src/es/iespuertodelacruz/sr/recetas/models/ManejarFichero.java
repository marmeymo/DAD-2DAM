/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.sr.recetas.models;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;

public class ManejarFichero {
    File fichero;
    
    public ManejarFichero(String nombre) {
        fichero = new File(nombre);
    }
    
    public ArrayList<String> LeerFicheroDevolverArrayList() {
        ArrayList<String> recetaslista = new ArrayList<>();
        
        try(BufferedReader br = new BufferedReader(new FileReader(fichero))) {
            String linea;
            while((linea = br.readLine()) != null) {
                recetaslista.add(linea);
            }
            
        }catch (Exception ex) {return recetaslista;}
        return recetaslista;
    }
    
    public ArrayList<Usuario> LeerFicheroDevolverUsuarioLista() {
        ArrayList<Usuario> usuariolista = new ArrayList<>();
        
        try(BufferedReader br = new BufferedReader(new FileReader(fichero))) {
            String linea;
            while((linea = br.readLine()) != null) {
                String[] lineaarr = linea.split(":");
                Usuario usuario = new Usuario(lineaarr[0], lineaarr[1], lineaarr[2]);
                usuariolista.add(usuario);
            }
            
        }catch (Exception ex) {return usuariolista;}
        return usuariolista;    
    }
    
    public Boolean AñadirUsuario(Usuario u) {
        if (!RepetidaUsuario(u)) {
            try(BufferedWriter bw = new BufferedWriter(new FileWriter(fichero, true))) {
                bw.write(u.toString()+"\n");
                return true;
            }catch (IOException ex) {
                return false;
            }
        }
        return false;
    }
    
    public void UpdateUsuarioById(String idnombre, String idcontraseña, Usuario usuariomodificado) {
        ArrayList<Usuario> listausuario = LeerFicheroDevolverUsuarioLista();
        
        try(BufferedReader br = new BufferedReader(new FileReader(fichero))) {
            String linea;
            int x = 0;
            while((linea = br.readLine()) != null) {
                String[] arrlinea = linea.split(":");
                if (idnombre.equals(arrlinea[0]) && idcontraseña.equals(arrlinea[1])) {
                    listausuario.get(x).setNombre(usuariomodificado.getNombre());
                    listausuario.get(x).setContraseña(usuariomodificado.getContraseña());
                    listausuario.get(x).setRol(usuariomodificado.getRol());
                }
                    
                x++;
            }
            UpdateListUsuarios(listausuario);
        }catch (IOException ex) {
            
        }
        
    }
    
    private Boolean RepetidaUsuario(Usuario u) {
        try(BufferedReader br = new BufferedReader(new FileReader(fichero))) {
            String linea;
            while((linea = br.readLine()) != null) {
                String[] arrlinea = linea.split(";");
                if (arrlinea[0].equals(u.getNombre()) && arrlinea[1].equals(u.getContraseña()))
                    return true;
            }
            return false;
        }catch (IOException ex) {
            return true;
        }
    }
    
    private void UpdateListUsuarios(ArrayList<Usuario> listpersonaupdate) {
        LimpiarFichero();
        try(BufferedWriter bw = new BufferedWriter(new FileWriter(fichero, true))) {
            for (int i = 0; i < listpersonaupdate.size(); i++) {
                bw.write(listpersonaupdate.get(i).toString() + "\n");
            }
            
        }catch (IOException ex) {
        
        }
    }
    
    private void LimpiarFichero() {
        try(PrintWriter pw = new PrintWriter(fichero)){
            pw.print("");
        }catch (IOException ex) {}
    }
    
    public void DeleteUserById(Usuario userdelet) {
        ArrayList<Usuario> listausuario = LeerFicheroDevolverUsuarioLista();
        for (int i = 0; i < listausuario.size(); i++) {
            String[] arrusuario = listausuario.get(i).toString().split(":");
            if (userdelet.getContraseña().equals(arrusuario[1]) && userdelet.getNombre().equals(arrusuario[0]))
                listausuario.remove(i);
        }
        UpdateListUsuarios(listausuario);
    }
}

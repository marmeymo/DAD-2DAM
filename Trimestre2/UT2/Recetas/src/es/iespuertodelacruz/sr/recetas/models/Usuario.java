/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package es.iespuertodelacruz.sr.recetas.models;

public class Usuario {
    String nombre;
    String contraseña;
    String rol;

    public Usuario(String nombre, String contraseña) {
        this.nombre = nombre;
        this.contraseña = contraseña;
    }
    
    public Usuario(String nombre, String contraseña, String rol) {
        this.nombre = nombre;
        this.contraseña = contraseña;
        this.rol = rol;
    }
    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getContraseña() {
        return contraseña;
    }

    public void setContraseña(String contraseña) {
        this.contraseña = contraseña;
    }

    public String getRol() {
        return rol;
    }

    public void setRol(String rol) {
        this.rol = rol;
    }

    @Override
    public String toString() {
        return nombre + ":" + contraseña + ":" + rol;
    }
    
    
    
    
}

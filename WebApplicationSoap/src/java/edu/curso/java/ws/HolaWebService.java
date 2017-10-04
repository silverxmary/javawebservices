/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.curso.java.ws;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author educacionit
 */
@WebService(serviceName = "HolaWebService")
public class HolaWebService {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
    
    @WebMethod(operationName = "reuperarPersona")
    public Persona reuperarPersona(@WebParam(name = "id") int id) {
        return new Persona (id , "Ejemplo persona");
    }
  
    
    @WebMethod(operationName = "reuperarPersonas")
    public Persona[] reuperarPersonas() {
        Persona[] personas = new Persona[3];
        
        personas[0]  = new Persona(1, "Ejemplo1");
        personas[1]  = new Persona(2, "Ejemplo2");
        personas[2]  = new Persona(3, "Ejemplo3");

       
        return personas;
    }
  
    
    
    
}

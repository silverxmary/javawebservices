/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplicationcliws;

import edu.curso.java.cliente.HolaWebService_Service;
import edu.curso.java.cliente.Persona;
import java.util.ArrayList;
import java.util.List;
import javax.jws.WebService;

/**
 *
 * @author educacionit
 */
public class JavaApplicationCliws {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        HolaWebService_Service clienteSoap = new HolaWebService_Service();
       // WebService service = 
       Persona p = clienteSoap.getHolaWebServicePort().reuperarPersona(22);
        System.out.println("Persona: " + p.getNombre() + " id " + p.getId());
        
        //List<Persona> personas = new  ArrayList<>();
       // personas = clienteSoap.getHolaWebServicePort().reuperarPersonas();
        
    }
    
}

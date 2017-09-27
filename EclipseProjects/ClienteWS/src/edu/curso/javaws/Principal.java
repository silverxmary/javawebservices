package edu.curso.javaws;

import java.rmi.RemoteException;

import javax.xml.rpc.ServiceException;

public class Principal {

	public static void main(String[] args) {
		HolaMundoCalculadoraServiceLocator locator = new HolaMundoCalculadoraServiceLocator();
		
		try {
			HolaMundoCalculadora calculadora = locator.getHolaMundoCalculadora();
			System.out.println(calculadora.sumar(10, 10));
			
		} catch (Exception e) {
			
			e.printStackTrace();
		
		}
	}
}

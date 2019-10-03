package iesserpis.ed;

import java.util.Scanner;

public class HolaMundo {

	public static void main(String[] args) {
		Scanner prueba = new Scanner(System.in);
	    System.out.println("Ingresa tu nombre");
	    String nombre = prueba.nextLine();
	    System.out.println("Tu nombre es: " + nombre);
	}

}

package iesserpis.ed;

import java.util.Random;
import java.util.Scanner;

public class adivina {

	public static void main(String[] args) {
		Random random = new Random();
		int numeroAleatorio = random.nextInt(1000) + 1;
		System.out.println("Numero aleatorio = " + numeroAleatorio);
		
		Scanner scanner = new Scanner(System.in);
		int numeroIntroducido;
		int contadorIntentos = 0;
		int extremoIzquierdo = 1;
		int extremoDerecho = 1000;
		
		do {
			contadorIntentos++;
			System.out.printf("Adivina el numero [intento %s] (entre %s y %s): ", contadorIntentos, extremoIzquierdo, extremoDerecho);
			numeroIntroducido = scanner.nextInt();
			if (numeroIntroducido < numeroAleatorio) {
				extremoIzquierdo = numeroIntroducido + 1;
			} else if (numeroIntroducido > numeroAleatorio) {
				extremoDerecho = numeroIntroducido - 1;
			} 
		} while (numeroIntroducido != numeroAleatorio);
			
			System.out.printf("Enhorabuena, has acertado en %s intentos.%n", contadorIntentos);
	}

}

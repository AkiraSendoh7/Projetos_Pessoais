package exercicios;
import java.util.Scanner;

public class p1_main_sobc 
{
    public static void main(String args[]) 
    {
        Scanner entrada = new Scanner(System.in);
        p1_sobc sobc = new p1_sobc();

        System.out.print("Digite o 1º lado da figura: ");
        double x = entrada.nextDouble();

        System.out.print("Digite o 2º lado da figura: ");
        double y = entrada.nextDouble();

        sobc.setArea(x, y);

        if (x == y)
            System.out.print("A área do quadrado é: " + sobc.getArea());
        else
            System.out.print("A área do retângulo é: " + sobc.getArea());

        entrada.close();

    }    
}

package exercicios;
import java.util.*;

public class p1_main_enc 
{   
    public static void main(String args[]) 
    {
        Scanner entrada = new Scanner(System.in);
        p1_enc enc = new p1_enc();

        System.out.print("Digite o 1º lado da figura: ");
        double x = entrada.nextDouble();

        System.out.print("Digite o 2º lado da figura: ");
        double y = entrada.nextDouble();

        enc.setArea(x, y);

        if (x == y)
            System.out.print("A área do quadrado é: " + enc.getArea());
        else
            System.out.print("A área do retângulo é: " + enc.getArea());
        
        entrada.close();
    }
}

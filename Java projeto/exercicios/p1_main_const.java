package exercicios;
import java.util.*;

public class p1_main_const 
{
    public static void main(String args[]) 
    {
        Scanner entrada = new Scanner(System.in);

        System.out.print("Digite o 1º lado da figura: ");
        double x = entrada.nextDouble();

        System.out.print("Digite o 2º lado da figura: ");
        double y = entrada.nextDouble();
         
        new p1_const(x, y);
        
        entrada.close();

    }
}

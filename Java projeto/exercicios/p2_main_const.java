package exercicios;
import java.util.Scanner;

public class p2_main_const 
{
    public static void main(String args[]) 
    {
        Scanner entrada = new Scanner(System.in);
        System.out.print("Valor de (C) = ");
        int c = entrada.nextInt();

        new p2_const(c);

        entrada.close();

    }
}

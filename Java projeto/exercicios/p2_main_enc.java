package exercicios;
import java.util.Scanner;

public class p2_main_enc 
{
    public static void main(String args[]) 
    {
        Scanner entrada = new Scanner(System.in);
        p2_enc enc = new p2_enc();

        System.out.print("Valor de (C) = ");
        int c = entrada.nextInt();

        enc.setPrimeiroTermo(c);

        System.out.println(enc.getNumero());
        entrada.close();
    }
}

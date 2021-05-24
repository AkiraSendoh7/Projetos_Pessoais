package exercicios;
import java.util.Scanner;

public class p4_main 
{
    public static void main(String args[]) 
    {
        Scanner entrada = new Scanner(System.in);
        p3_sobc sobc = new p3_sobc();

        System.out.print("Deseja calcular a área de um: \n(1) - Círculo\n(2) - Quadrado\n(3) - Retângulo\nResposta: ");
        int resposta = entrada.nextInt();

        if (resposta == 1) 
        {
            System.out.print("Digite o raio do círculo: ");
            int raio = entrada.nextInt();

            sobc.setCalcArea(raio);

            System.out.print("A área do círculo é: " + sobc.getArea());
        }

        else if (resposta == 2) 
        {
            System.out.print("Digite o lado do quadrado: ");
            int lado = entrada.nextInt();

            sobc.setCalcArea(lado, lado);

            System.out.print("A área do quadrado é: " + sobc.getArea());
        }

        else if (resposta == 3) 
        {
            System.out.print("Digite o 1º lado da figura: ");
            int x = entrada.nextInt();

            System.out.print("Digite o 2º lado da figura: ");
            int y = entrada.nextInt();

            sobc.setCalcArea(x, y);

            System.out.print("A área do retângulo é: " + sobc.getArea());
        }

        else
            System.out.println("Número errado, digite de novo.");

        entrada.close();
    }
}

/* *******************************************************************
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 23/05/2020
 * Autores do Projeto: Murilo Santos Lopes Carvalho - 50190398
 *                     Eduardo Elias Ferreira de Lima - 50190374
 * 
 * Turma: 3ºF  Disciplina: Programação POO- II
 * Avaliação parcial referente ao 2 - Bimestre
 * Observação: <colocar se houver>
 * 
 * Alterar.java
 * ******************************************************************/

import java.io.IOException;
import java.util.Scanner;

public class Alterar extends Incluir
{
    Alterar (int posicao, Incluir dados[]) throws InterruptedException, IOException
    {
        //Limpa o console pela 1a vez
        if (System.getProperty("os.name").contains("Windows"))
            new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
        else
            Runtime.getRuntime().exec("clear");

        Scanner entrada = new Scanner(System.in);
        for (int k = 0; k <= dados.length - 1; k++) 
        {
            if (k == posicao)
            {
                System.out.print("Simpatia: ");
                int simpatia = entrada.nextInt();

                while ((simpatia < 0) && (simpatia > 10)) 
                {
                    System.out.print("Valor inválido, pois é entre 0 e 10.\nSimpatia: ");
                    simpatia = entrada.nextInt();
                }

                System.out.print("Elegância: ");
                int elegancia = entrada.nextInt();

                while ((elegancia < 0) && (elegancia > 10)) 
                {
                    System.out.print("Valor inválido, pois é entre 0 e 10.\nElegância: ");
                    elegancia = entrada.nextInt();
                }

                System.out.print("Beleza: ");
                int beleza = entrada.nextInt();

                while ((beleza < 0) && (beleza > 10)) 
                {
                    System.out.print("Valor inválido, pois é entre 0 e 10.\nBeleza: ");
                    beleza = entrada.nextInt();
                }

                dados[posicao].setSimpatia(Integer.toString(simpatia));
                dados[posicao].setElegancia(Integer.toString(elegancia));
                dados[posicao].setBeleza(Integer.toString(beleza));
            }
        }
    }
}

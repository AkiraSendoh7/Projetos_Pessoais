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
 * Main.java
 * ******************************************************************/

import java.io.IOException;
import java.util.*;

public class Main 
{
    public static void main(String args[]) throws InterruptedException, IOException 
    {
        Scanner entrada = new Scanner(System.in);

        System.out.print("Deseja iniciar? [0] - Sim | [1] - Não\nResposta: ");
        int resposta = entrada.nextInt();
  
        //Limpa o console 
        if (System.getProperty("os.name").contains("Windows"))
            new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
        else
            Runtime.getRuntime().exec("clear");
          
        while ((resposta != 0) && (resposta != 1)) 
        {
            //Limpa o console 
            if (System.getProperty("os.name").contains("Windows"))
                new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
            else
                Runtime.getRuntime().exec("clear");
        
            System.out.println("\nSomente são válidos valores 0 e 1\n");
            System.out.print("Deseja iniciar? [0] - Sim | [1] - Não\nResposta: ");
            resposta = entrada.nextInt();
        }
        
        if (resposta == 0)
        {
            System.out.print("Número de pessoas: ");
            int quant = entrada.nextInt();
            
            while (quant < 0)  
            {
                System.out.println("\nSomente são válidos valores positivos...\n");
                System.out.print("Número de pessoas: ");
                quant = entrada.nextInt();

                if (quant > 0)
                {
                    //Limpa o console pela 2a vez
                    System.out.println("\nPressione qualquer tecla para contiunuar.....");
                    
                    if (String.format("%d", System.in.read()) != null)
                    {
                        if (System.getProperty("os.name").contains("Windows"))
                            new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
                        else
                            Runtime.getRuntime().exec("clear");
                    }
                }
            }

            Incluir dadosInclusao[] = new Incluir[quant];

            while (resposta == 0) 
            {
                System.out.println(
                        "\nQual operação deseja iniciar ?\n\n( 1 ) - Incluir;\n( 2 ) - Consultar;\n( 3 ) - Alterar;\n( 4 ) - Excluir;\n( 5 ) - Relatar;\n( 6 ) - Sair");
                int opcao = entrada.nextInt();
                
                if (opcao == 1)
                {
                    if (System.getProperty("os.name").contains("Windows"))
                        new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
                    else
                        Runtime.getRuntime().exec("clear");

                    for (int i = 0; i < quant; i++)
                    {
                        dadosInclusao[i] = new Incluir();

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

                        if (!((simpatia < 0 && simpatia > 10) && (elegancia < 0 && elegancia > 10) && (beleza < 0 && beleza > 10)))
                        {
                            dadosInclusao[i].setSimpatia(Integer.toString(simpatia));
                            dadosInclusao[i].setElegancia(Integer.toString(elegancia));
                            dadosInclusao[i].setBeleza(Integer.toString(beleza));
                        }
                    }
                }

                else if (opcao == 2)
                {
                    //Limpa o console pela 1a vez
                    if (System.getProperty("os.name").contains("Windows"))
                        new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
                    else
                        Runtime.getRuntime().exec("clear");
                        
                        new Consultar(dadosInclusao);

                    //Limpa o console pela 2a vez
                    System.out.println("\nPressione qualquer tecla para contiunuar.....");
                    
                    if (String.format("%d", System.in.read()) != null)
                    {
                        if (System.getProperty("os.name").contains("Windows"))
                            new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
                        else
                            Runtime.getRuntime().exec("clear");
                    }
                }

                else if (opcao == 3)
                {
                    if (System.getProperty("os.name").contains("Windows"))
                        new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
                    else
                        Runtime.getRuntime().exec("clear");

                    System.out.print ("Qual posição você deseja alterar?\nIniciando de 0 a n...\nResposta: ");
                    int posicao = entrada.nextInt();
                    
                    new Alterar (posicao, dadosInclusao);

                    //Limpa o console pela 2a vez
                    System.out.println("Press any key to continue.....");
                            
                    if (String.format("%d", System.in.read()) != null)
                    {
                        if (System.getProperty("os.name").contains("Windows"))
                            new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
                        else
                            Runtime.getRuntime().exec("clear");
                    }
                } 

                else if (opcao == 4)
                {
                    if (System.getProperty("os.name").contains("Windows"))
                        new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
                    else
                        Runtime.getRuntime().exec("clear");

                    System.out.print ("Deseja mesmo apagar todos os dados? [0] - Sim | [1] - Não\nResposta: ");
                    int respostaExcluir = entrada.nextInt();

                    while ((respostaExcluir != 0) && (respostaExcluir != 1)) 
                    {
                        System.out.print ("Valor inválido, pois é valido somente para 0 ou 1.\nResposta: ");
                        respostaExcluir = entrada.nextInt();
                    }

                    if (respostaExcluir == 0)
                        new Excluir(dadosInclusao);
                }

                else if (opcao == 5)
                {
                    if (System.getProperty("os.name").contains("Windows"))
                        new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
                    else
                        Runtime.getRuntime().exec("clear");
                    
                    if (!(dadosInclusao.equals(null)))
                        new Relatar(dadosInclusao);

                }

                else
                    resposta = 1;

            }

            entrada.close();
        }
    }
}

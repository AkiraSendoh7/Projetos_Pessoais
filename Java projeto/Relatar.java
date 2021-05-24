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
 * Relatar.java
 * ******************************************************************/

import java.io.IOException;

public class Relatar 
{
    Relatar (Incluir dados[]) throws IOException, InterruptedException 
    {
        System.out.println("\n\tRELATÓRIO\n_________________________________\n\n\tNOTAS                   |\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        for (int k = 0; k < dados.length; k++) 
        {
            System.out.println
            (String.format
                ("\n %dº - Nota da Simpatia:      %d  |\n %dº - Nota da Elegância:     %d  |\n %dº - Nota da Beleza:        %d  |\n %dº - Nota Final:         %.2f  |\n"
                    ,k + 1, dados[k].getNotaSimpatia(), k + 1, dados[k].getNotaElegancia(), k + 1, dados[k].getNotaBeleza(),
                    k + 1, dados[k].getClassificacao()
                )
            );

            //Limpa o console pela 2a vez
            System.out.println("\nPress any key to continue.....");
                    
            if (String.format("%d", System.in.read()) != null)
            {
                if (System.getProperty("os.name").contains("Windows"))
                    new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
                else
                    Runtime.getRuntime().exec("clear");
            }
        } 
    }
}

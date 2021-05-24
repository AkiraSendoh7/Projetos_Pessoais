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
 * Consultar.java
 * ******************************************************************/

public class Consultar extends Incluir
{
    Consultar(Incluir dados[]) 
    {  
        // Consulta das notas
        System.out.println("\tCONSULTA DAS NOTAS\n-=-=-=---=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

        for (int k = 0; k < dados.length; k++) 
        {
            if (dados[k] != null) 
                System.out.println(String.format("%dº = %.2f", k + 1, dados[k].getClassificacao()));
        
            else
                System.out.println("Não pode fazer a consulta de um vetor sem valor...");
        }
    }
}

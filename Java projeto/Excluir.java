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
 * Excluir.java
 * ******************************************************************/

public class Excluir extends Incluir
{
    Excluir (Incluir dados[])
    {
        for (int k = 0; k < dados.length; k++) 
        {
            dados[k] = null;
        } 
    }
}

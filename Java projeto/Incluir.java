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
 * Incluir.java
 * ******************************************************************/

public class Incluir 
{
    private int notaSimpatia;
    private int notaElegancia;
    private int notaBeleza;

    public void setSimpatia (String nota)
    {
        this.notaSimpatia = Integer.parseInt(nota);
    }   
    
    public int getNotaSimpatia ()
    {
        return this.notaSimpatia;
    }

    public void setElegancia (String nota)
    {
        this.notaElegancia = Integer.parseInt(nota);
    }   

    public int getNotaElegancia ()
    {
        return this.notaElegancia;
    }

    public void setBeleza (String nota)
    {
        this.notaBeleza = Integer.parseInt(nota);
    }   
    
    public int getNotaBeleza ()
    {
        return this.notaBeleza;
    }

    //Nota de classificação
    public float getClassificacao()
    {
        return (float) (getNotaSimpatia() + getNotaElegancia() * 3 + getNotaBeleza() * 4) / 8;
    }       
}

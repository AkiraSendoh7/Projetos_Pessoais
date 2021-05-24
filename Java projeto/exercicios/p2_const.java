package exercicios;
public class p2_const 
{
    private int a1;
    private int a2;
    private int a3;
    private int soma;

    p2_const(int numero)
    {
        for (int i = 1; i <= numero; i++)
        {
            if (i % 2 == 1)
            {
                this.soma = numero;
                this.a1 = (2 * numero - 12) / 6;
            }
        }

        this.a2 = a1 + 2;
        this.a3 = a2 + 2;

        System.out.println(this.a1 + " + " + a2 + " + " + a3 + " = " + this.soma);
    }
}

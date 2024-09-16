package exercicios;
public class p1_const 
{
    private String area; 
    p1_const (double x, double y)
    {
        this.area = Double.toString(x * y);

        if (x == y)
            System.out.print("A área do quadrado é: " + area);
        else
            System.out.print("A área do retângulo é: " + area);
    } 
}

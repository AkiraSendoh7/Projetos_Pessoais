package exercicios;
public class p1_enc 
{
    private String area;

    public void setArea (double x, double y)
    {
        this.area = Double.toString(x * y);
    }    

    public String getArea()
    {
        return this.area;
    }
}



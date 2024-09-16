package exercicios;
public class p1_sobc 
{
    private String area;

    public void setArea (int x, int y)
    {
        this.area = Integer.toString(x * y);
    }    

    public void setArea (double x, double y)
    {
        this.area = Double.toString(x * y);
    }    

    public String getArea()
    {
        return this.area;
    }
}

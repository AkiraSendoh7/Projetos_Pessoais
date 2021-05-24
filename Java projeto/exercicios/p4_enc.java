package exercicios;
public class p4_enc 
{
    private String area;

    public void setCalcArea (int raio)
    {
        this.area = Double.toString(Math.PI * Math.pow(raio, 2));
    }    

    public void setCalcArea (int raio1, int raio2)
    {
        this.area = Integer.toString(raio1 * raio2);
    }       

    public String getArea()
    {
        return this.area;
    }
}


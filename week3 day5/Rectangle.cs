public class Rectangle : Shape
{
   public double Width;
    public double Height;
    public Rectangle(){}
    public Rectangle(double width,double height)
    {
        Width = width;
        Height = height;
    }
    public override double ConculateArea()
    {
        return Width*Height;
    }
    
}
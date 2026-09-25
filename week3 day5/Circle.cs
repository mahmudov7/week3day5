public class Circle : Shape
{
   public double Radius;
   public const double IP = 3.14;
   public Circle(){}
   public Circle(double radius)
    {
        Radius = radius;
    }
    public override double ConculateArea()
    {
        return IP*Radius*Radius;
    }
}
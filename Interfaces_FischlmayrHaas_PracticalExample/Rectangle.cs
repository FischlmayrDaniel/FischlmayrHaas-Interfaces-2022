namespace CsharpInterface;

class Rectangle : IPolygon {

    // implementation of IPolygon interface
    public void CalculateArea() {
      
        int l = 30;
        int b = 90;
        int area = l * b;
        Console.WriteLine("Area of Rectangle: " + area);
    }
}
namespace CsharpInterface;

class Square : IPolygon {

    // implementation of IPolygon interface
    public void CalculateArea() {
      
        int l = 30;
        int area = l * l;
        Console.WriteLine("Area of Square: " + area);
    }
}
namespace Interfaces_FischlmayrHaas;

// implements two interface
class Rectangle : IPolygon, IColor {

    // implementation of IPolygon interface
    public void CalculateArea(int a, int b) {

        int area = a * b;
        Console.WriteLine($"Area of Rectangle: {area}");
    }

    // implementation of IColor interface
    public void GetColor() {

        Console.WriteLine("Red Rectangle");
            
    }
}

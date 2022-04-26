namespace Interfaces_FischlmayrHaas;

class Rectangle : IPolygon {

    // implementation of methods inside interface
    public void CalculateArea(int l, int b) {

        int area = l * b;
        Console.WriteLine("Area of Rectangle: " + area);
    }
}
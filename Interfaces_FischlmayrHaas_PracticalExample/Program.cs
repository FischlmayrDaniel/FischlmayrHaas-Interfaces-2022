using System;
using CsharpInterface;

// implements interface

class Program
{
    static void Main(string[] args)
    {
        Rectangle r1 = new Rectangle();
        r1.CalculateArea();

        Square s1 = new Square();
        s1.CalculateArea();
    }
}
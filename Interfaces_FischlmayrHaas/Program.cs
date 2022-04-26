using System;
using System.Drawing;

namespace Interfaces_FischlmayrHaas{
    static class Program {
        static void Main (string [] args) {

            // using reference variable of interface
            IPolygon r1 = new Rectangle();
            IColor r2 = new Rectangle();
    
            r1.CalculateArea(100, 200);
            r2.GetColor();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Formeeeeeeeeee
{
    public class Quadrato : Rettangolo, IForma
    {
        public new double Lati;
      
        public double Perimetro(double Lati) 
        {
            return Lati * 4;
        }
        public double Area(double Lati) 
        {
            Double sup = Lati * Lati;
            return sup;
        }
        double IForma.Perimetro()
        {
            throw new NotImplementedException();
        }

        double IForma.Area()
        {
            throw new NotImplementedException();
        }
    }
}
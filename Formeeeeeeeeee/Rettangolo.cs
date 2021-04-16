using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Formeeeeeeeeee
{
    public class Rettangolo : IForma
    {
      public double Lati;
      public double Altezza;

       public double Perimetro(double Lati, double Altezza)
        {
            Double perimetro = (Altezza + Lati) * 2;
            return perimetro;
        }
       public double Area(double Lati, double Altezza) 
        {
            Double area = (Altezza * Lati) / 2;
            return area;

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
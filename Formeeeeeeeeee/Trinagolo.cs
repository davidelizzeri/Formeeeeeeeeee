using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Formeeeeeeeeee
{
    public class Trinagolo : IForma
    {
       public double Lati;
       public double Altezza;

        public double Perimetro(double Lati) 
        {
            return Lati * 3;
        
        }
        public double Area(double Lati,double Altezza) 
        {
            Double area = (Lati * Altezza) / 2;
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
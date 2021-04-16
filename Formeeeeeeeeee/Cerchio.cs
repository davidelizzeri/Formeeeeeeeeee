using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Formeeeeeeeeee
{
    public class Cerchio : IForma
    {
        public double Raggio;
        Double PGreco = 3.14;

        public double Perimetro( double Raggio)
        {
            
            Double circonferenza = 2 * PGreco * Raggio;
            return circonferenza;

        }
        
        public double Area (double Raggio)
        {
            Double superficie = (Raggio * Raggio)*PGreco;
            return superficie;
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
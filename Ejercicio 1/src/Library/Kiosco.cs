using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = Conversor.ConvertirAPesos(dinero, moneda);
            return pesos >= Alfajor.Precio(a);
        }

        //No cumple con SRP porque tiene mas de una responsabilidad
        //el total del valor de alfajor sera creado en un metodo en alfajor
        
    }
}
using System;
using System.Text;

namespace Library
{
    //Se crean las clases CLIENTE, DOCTOR Y PLACE para que sean los responsables
    //de los datos de cada uno, en este caso solo validan que no sean nulos
    //pero podría por ejemplo buscarse en una lista, o base de datos,
    // y en caso de no encontrarse que se tenga que agregar 
    public class Cliente
    {
        public static bool IsValid(string algo)
        {
            if (string.IsNullOrEmpty(algo))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       
    }    

}
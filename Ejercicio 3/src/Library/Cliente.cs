using System;
using System.Text;

namespace Library
{
    //Aplicando SRP crearía dos clases más, una con los datos de los Doctores y otra con los datos
    //de los Pacientes, y aplicando EXPERT haría que AppointmentService le pida la informacion a los 
    //expertos de la informacion Doctores y Pacientes
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
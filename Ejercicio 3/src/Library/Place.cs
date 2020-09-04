using System;
using System.Text;

namespace Library
{
     //Aplicando SRP crearía dos clases más, una con los datos de los Doctores y otra con los datos
    //de los Pacientes, y aplicando EXPERT haría que AppointmentService le pida la informacion a los 
    //expertos de la informacion Doctores y Pacientes
    public class Place
    {
        public static string CreatePlace(string appoinmentPlace)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            
            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }
            if (isValid)
            {
                stringBuilder.Append("Lugar creado correctamente");
                
            }

            return stringBuilder.ToString(); 
        }

    }
}
using System;
using System.Text;

namespace Library
{
     //Aplicando SRP crearía dos clases más, una con los datos de los Doctores y otra con los datos
    //de los Pacientes, y aplicando EXPERT haría que AppointmentService le pida la informacion a los 
    //expertos de la informacion Doctores y Pacientes
    public class Paciente
    {
        public static string CreatePaciente(string name, string id, string phoneNumber)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }
           if (isValid)
            {
                stringBuilder.Append("Paciente creado correctamente");
            }

            return stringBuilder.ToString();
            
        }

    }
}
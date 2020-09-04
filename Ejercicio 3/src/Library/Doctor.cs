using System;
using System.Text;

namespace Library
{
     //Aplicando SRP crearía dos clases más, una con los datos de los Doctores y otra con los datos
    //de los Pacientes, y aplicando EXPERT haría que AppointmentService le pida la informacion a los 
    //expertos de la informacion Doctores y Pacientes
    public class Doctor
    {
        public static string CreateDoctor(string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;


            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }


            if (isValid)
            {
                stringBuilder.Append("Doctor creado correctamente");
            }

            return stringBuilder.ToString();
        }

    }
}
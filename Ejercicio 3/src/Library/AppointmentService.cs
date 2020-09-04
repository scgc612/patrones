using System;
using System.Text;

namespace Library
{
    //Aplicando SRP crearía dos clases más, una con los datos de los Doctores y otra con los datos
    //de los Pacientes, y aplicando EXPERT haría que AppointmentService le pida la informacion a los 
    //expertos de la informacion Doctores y Pacientes
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
            }
            else 
                stringBuilder.Append(name);

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
            }
            else 
                stringBuilder.Append(id);

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
            }
            else 
                stringBuilder.Append(phoneNumber);

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
            }
                else 
                stringBuilder.Append(appoinmentPlace);

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
            }
            else 
                stringBuilder.Append(doctorName);


            return stringBuilder.ToString();
        }

    }
}

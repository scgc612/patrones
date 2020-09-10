using System;
using System.Text;

namespace Library
{
    //Aplicando SRP crearía dos clases más, una con los datos de los Doctores y otra con los datos
    //de los Pacientes, y aplicando EXPERT haría que AppointmentService le pida la informacion a los 
    //expertos de la informacion Doctores y Pacientes
    public class AppointmentService2
    {

        public string Name { get ; set;}
        public string Id { get ; set;}

        public string PhoneNumber { get ; set;}

        public string AppoinmentPlace { get ; set;}

        public string DoctorName { get ; set;}

        public string Date { get ; set;}
        public AppointmentService2(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            if (Cliente.IsValid(name))
            {
                this.Name=name;
            }
            else
            {
                this.Name="error de ingreso";
            }
            if (Cliente.IsValid(id))
            {
                this.Id=id;
            }
            else
            {
                this.Id="error de ingreso";
            }
            if (Cliente.IsValid(phoneNumber))
            {
                this.PhoneNumber=phoneNumber;
            }
            else
            {
                this.PhoneNumber="error de ingreso";
            }
            if (Place.IsValid(appoinmentPlace))
            {
                this.AppoinmentPlace=appoinmentPlace;
            }
            else
            {
                this.AppoinmentPlace="error de ingreso";
            }
             if (Doctor.IsValid(doctorName))
            {
                this.DoctorName=DoctorName;
            }
            else
            {
                this.DoctorName="error de ingreso";
            }
        
        }
        public static string PrintTicket(AppointmentService2 X)
        {
            return @$"----Servicio de Consulta----{DateTime.Now}
            Datos del paciente: {X.Name}/n{X.Id}/n{X.PhoneNumber}
            Datos del Lugar: {X.AppoinmentPlace}
            Datos del Doctor: {X.DoctorName}";
                    
        }
    }
}
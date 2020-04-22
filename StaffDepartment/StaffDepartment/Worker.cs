using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffDepartment
{
    class Worker
    {        
        public string department;
        public string appointment;
        public string name;
        public enum Position { Name,Appointment,Department}
        public Worker (string name,string department,string appointment)
        {
            this.appointment = appointment;
            this.department = department;
            this.name = name;
        }        
    }
}

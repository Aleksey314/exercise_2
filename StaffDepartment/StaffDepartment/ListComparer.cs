using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffDepartment
{
    class ListComparer:IComparer<Worker>
    {        
        object pos;
        public ListComparer(Worker.Position pos) { this.pos = pos;  }
        public ListComparer() { }
        int IComparer<Worker>.Compare(Worker worker1, Worker worker2)
        {
            switch(pos)
            {
                case Worker.Position.Appointment: return worker1.appointment.CompareTo(worker2.appointment);
                case Worker.Position.Department: return worker1.department.CompareTo(worker2.department);
                default : return worker1.name.CompareTo(worker2.name);
            }           
        }        
    }
}

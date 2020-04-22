using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffDepartment
{
    class Program
    {
        static void Main(string[] args)
        {            
            Crew workersList = ListManager.SetList();

            ListManager.WorkerComparer(workersList, Worker.Position.Name);
            ListManager.PrintListFromCrew(workersList);

            ListManager.WorkerComparer(workersList,Worker.Position.Appointment);
            ListManager.PrintListFromCrew(workersList);

            ListManager.WorkerComparer(workersList, Worker.Position.Department);
            ListManager.PrintListFromCrew(workersList);

            
        }
    }
}

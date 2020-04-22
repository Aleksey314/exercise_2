using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StaffDepartment
{
    class ListManager
    {        
        public static Crew SetList()
        {
            Crew workers = new Crew()
            {
                new Worker("Johnny Depp","administration","director"),new Worker("Bradley Cooper","development department","principal engineer"),
                new Worker("Julianne Moore","administration","chief engineer"),new Worker("Angelina Jolie","production department","engineer"),
                new Worker("Brad Pitt","production department","department head"),new Worker("George Clooney","production department","engineer"),
                new Worker("Leonardo DiCaprio","development department","department head"),new Worker("Bruce Willis","development department","engineer"),
                new Worker("Jennifer Aniston","sales department","department head"),new Worker("Penelope Cruz","development department","engineer"),
                new Worker("Matthew McConaughey","production department","principal engineer"),new Worker("Al Pacino","sales department","dealer"),
                new Worker("Harrison Ford","sales department","dealer"),new Worker("Tom Cruise","sales department","fitter"),
                new Worker("Nicole Kidman","sales department","fitter")
            };
            return workers;
        }

        public static void PrintListFromCrew(Crew workers)
        {
            foreach(Worker worker in workers)
            {
                Console.WriteLine($"{workers.IndexOf(worker)+1,2}. {worker.name,-20}{worker.appointment,-20}{worker.department}");
                
            }
            Console.WriteLine();
        }

        public static void WorkerComparer(Crew workers,Worker.Position pos)
        {
            workers.Sort(workers,new ListComparer(pos));            
        }
    }
}

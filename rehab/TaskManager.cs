using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace rehab
{
    static class TaskManager
    { 
        static ArrayList re = new ArrayList();
        public static void AddTask(Task1 r)
        {
            re.Add(r);
        }
        public static void DeleteTask(Task1 r)
        {

            re.Remove(r);
        }
        public static int SearchForTask(Task1 r)
        {
            return re.IndexOf(r);
        
           
        }
    }
}

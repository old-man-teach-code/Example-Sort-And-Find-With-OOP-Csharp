using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfUser list = new ListOfUser();
            list.AddUser();
            list.Output();
            list.Edit();
            list.Output();
            list.Delete();
            list.Output();
        }
    }
}

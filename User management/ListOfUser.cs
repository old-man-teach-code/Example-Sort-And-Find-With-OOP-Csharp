using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class ListOfUser
    {
        public List<User> list = new List<User>();


        public void AddUser()
        {
            do
            {
                User user = new User();
                user.AddUser();
                list.Add(user);

                Console.Write("Do u want to add more user?(y/n):");
                string st = Console.ReadLine();
                if(st.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

            } while (true);
        }

        public void Output()
        {
            foreach(var item in list)
            {
                item.Output();
            }
        }
        public void Edit()
        {
            Console.Write("Enter user u want to edit: ");
            string name = Console.ReadLine();
            foreach(User item in list)
            {
                if(item.Username == name)
                {
                    item.AddUser();
                }
            }
        }
        public void Delete()
        {
            Console.Write("Enter user u want to delete: ");
            string name = Console.ReadLine();
            foreach (var item in list)
            {
                if (item.Username == name)
                {
                    item.Delete();
                }
            }
        }
    }

}

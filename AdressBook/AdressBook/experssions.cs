using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    public  class experssions
    {
        public List<PersionalDetails> persionalDetails;
        public experssions()
        {
           foreach(var item in persionalDetails)
            {
                Console.WriteLine(item);
            }
        }
    }

}

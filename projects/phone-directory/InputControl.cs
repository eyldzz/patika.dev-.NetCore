using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_directory
{
    public static class InputControl
    {
        public static bool IsNull(string param)
        {
            if(param == "" || param == " ")
            {
                Console.WriteLine("***** Boş veri girişi yapmayınız !!! *****\n");
                return true;
            }
            else
                return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFApply
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length <= 0 || args[0] == null)
                args = new string[] { "El DevF rockea" };

            ReverseString(args[0].ToString());
        }

        static void ReverseString(string data)
        {
            if (String.IsNullOrEmpty(data))
                return;

            char[] array = data.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(new String(array));
            Console.WriteLine(data.Count(w => w.ToString().ToLower() == "e"));
            Console.WriteLine("Press any key to quit...");
            Console.ReadLine();
        }
    }
}

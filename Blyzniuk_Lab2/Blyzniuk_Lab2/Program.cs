using System;
using System.Linq;
using System.Text;

namespace Blyzniuk_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {           
            string delimeter = new string('-', 44);
            StringBuilder result = new StringBuilder(
                string.Format("{0}\n|{1,-20}|{2,-10}|{3,-10}|\n{0}\n",
                    delimeter, "City", "Code", "Rate"
                )
            );
            PhoneTalkContext context = new PhoneTalkContext();
            try
            {
                foreach (var city in context.Cities.OrderBy(f => f.Name).ToList())
                    result.Append(string.Format("|{1,-20}|{2,-10}|{3,-10}|\n{0}\n",
                        delimeter, city.Name, city.Code, city.Rate
                    ));
            }
            catch (Exception e)
            {
                result.Clear().Append(e.Message);
            }
            finally
            {
                Console.Write(result);
                Console.WriteLine("Press any key to continue!...");
                Console.ReadKey();
            }
        }
    }
}

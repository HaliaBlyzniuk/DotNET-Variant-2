using System;
using System.Data.SqlClient;

namespace Blyzniuk_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PhoneTalk;Integrated Security=True");
            try {
                connection.Open();
                string query =
                   " select FirstName + ' ' + MiddleName + ' ' + LastName as Caller,"
	                  +" Name as Callee,"
	                  +" Time as Duration,"
	                  +" Rate* Time as Price"
                  +" from UsersCities as uc"
                  +" inner join Users as u on uc.UserId = u.Id"
                  +" inner join Cities as c on uc.CityId = c.Id";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    string delimeter = new string('-', 70);
                    Console.WriteLine(delimeter);
                    Console.WriteLine(string.Format("|{0,-25}|{1,-20}|{2,-10}|{3,-10}|",
                        reader.GetName(0),
                        reader.GetName(1),
                        reader.GetName(2),
                        reader.GetName(3)
                    ));
                    Console.WriteLine(delimeter);
                    while (reader.Read())
                    {
                        Console.WriteLine(string.Format("|{0,-25}|{1,-20}|{2,-10}|{3,-10}|",
                            reader.GetValue(0),
                            reader.GetValue(1),
                            reader.GetValue(2),
                            reader.GetValue(3)
                        ));
                        Console.WriteLine(delimeter);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Press any key to continue!...");
                Console.ReadKey();
            }
        }
    }
}

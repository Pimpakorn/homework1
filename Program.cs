using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            bool status = false;
            if (int.TryParse(password, out int number) && number >= 100000 && number <= 999999)
            {
                Console.WriteLine("agency");
                string agency = Console.ReadLine();
                bool unit = int.TryParse(password[5].ToString(), out int n_unit);
                bool hundred = int.TryParse(password[3].ToString(), out int n_handred);
                bool thousands = int.TryParse(password[2].ToString(), out int n_thou);
                bool ten_thou = int.TryParse(password[1].ToString(), out int n_tenthou);
                bool hundred_thou = int.TryParse(password[0].ToString(), out int n_hthou);
                if (agency == "CIA")
                {
                    if ((n_unit % 3 == 0) && 
                        (n_handred != 1) && (n_handred != 3) && (n_handred != 5) && 
                        (n_thou > 6) && (n_thou != 8))
                    { 
                        status = !status;
                    }
                }
                if (agency == "FBI")
                {
                    if ((n_hthou >= 4 && n_hthou <= 7) && 
                     (n_handred % 2 == 0) && (n_handred != 6) && 
                      (n_tenthou % 2 != 0))
                    { 
                        status = !status;

                    }
                }
                if (agency == "NSA")
                {
                    if ((30 % n_unit == 0) &&  
                     (n_handred % 3 == 0 && n_handred % 2 != 0) &&  
                      password.Contains("7"))
                    { 
                        status = !status;
                    }


                }


            }
            Console.WriteLine(status);
        } 
    }
}

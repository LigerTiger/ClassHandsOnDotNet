using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    class BookTicket
    {
        public static string Book(int no)
        {
            try
            {
                if(no>5)
                {
                    throw new TicketException(no);
                }
                else
                {
                    return @"Transaction Success." + "\n" +
                        "You pay the Amount Rs." + (no * 123).ToString("F2");
                }
            }
            catch(TicketException ex)
            {
              //  Console.WriteLine(ex.Message);
                throw;
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter no of tickets..");
            int no = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Book(no));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}

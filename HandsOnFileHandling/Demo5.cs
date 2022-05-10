using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    internal class Demo5
    {
        static void Main()
        {
            try
            {
                int a = 10, b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.ToString());
                //Save Exeption Details in a File.
                using (StreamWriter sw = new StreamWriter("errInfo.txt",true))
                {
                    string content = @"Date:" + DateTime.Now +
                        " Message:" + ex.Message;
                    sw.WriteLine(content);
                 }

            }
        }
    }
}

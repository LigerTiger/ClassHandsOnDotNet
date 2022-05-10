using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    //Custom exception
    internal class AgeException : SystemException
    {
        string message;

        public AgeException() { }
        public AgeException(string message)
        {
            this.message = message;
        }

        public override string Message
        {

            get
            {
                if (message == null)
                    return "Age Should not be less than 18 or more than 34";
                else
                    return message;
            }
        }
    }

}

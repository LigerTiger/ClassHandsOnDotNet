using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    class TicketException:SystemException
    {
        string msg;
        public TicketException(int no)
        {
            msg = string.Format("You can not book {0} tickets\n Transaction failed", no);
        }
        public override string Message
        {
            get { return msg; }
        }

    }
   
}

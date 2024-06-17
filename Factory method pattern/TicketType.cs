using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumTicketSystem.Factory_method_pattern
{
    public class TicketType
    {
        public string Name;
        public string Description;

        public virtual void FetchingTicket() 
        {
            Console.WriteLine("Fetching Your Ticket....");
        }

        public virtual void PreparingTicket() 
        {
            Console.WriteLine("Preparing Your Ticket......");
        }
    }
}

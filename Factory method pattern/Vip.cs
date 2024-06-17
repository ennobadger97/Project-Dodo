using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumTicketSystem.Factory_method_pattern
{
    class Vip : TicketType
    {
        public Vip() 
        {
            this.Name = "Vip Seat";
            this.Description = "Your selected seat is in the vip area, 25 metres from the ground";
        }
    }
}

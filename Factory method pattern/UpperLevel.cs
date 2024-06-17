using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumTicketSystem.Factory_method_pattern
{
    class UpperLevel : TicketType
    {
        public UpperLevel() 
        {
            this.Name = "UpperLevel Seat";
            this.Description = "Your selected seat is in the upper level, 30 metres from the ground";
        }
    }
}

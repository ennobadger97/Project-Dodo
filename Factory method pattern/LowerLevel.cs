using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumTicketSystem.Factory_method_pattern
{
    class LowerLevel : TicketType
    {
        public LowerLevel() 
        {
            this.Name = "LowerLevel Seat";
            this.Description = "Your selected seat is in the lower level, 10 metres from the ground";
        } 
    }
}

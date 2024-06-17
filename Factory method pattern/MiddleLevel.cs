using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StadiumTicketSystem.Factory_method_pattern
{
    class MiddleLevel : TicketType
    {
        public MiddleLevel() 
        {
            this.Name = "MiddleLevel Seat";
            this.Description = "Your selected seat is in the middle level, 20 metres from the ground";
        }
    }
}

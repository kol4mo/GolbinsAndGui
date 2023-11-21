using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolbinsAndGui.model
{
    internal class Dialogue
    {
        // relationship between npcs and dialogue is the responsibility of the character
        public Response dialogueStart { get; set; }
    }
}

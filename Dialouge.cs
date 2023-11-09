using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolbinsAndGui
{
    internal class Dialouge
    {
        static int dialougePosition;
        public static bool prevChoice;
        public static int adventurer1(Controller controller)
        {
            if (dialougePosition >= 0 && dialougePosition < 2)
            {
                switch (dialougePosition)
                {
                    case 0:
                        controller.changeOtherText("idk");
                        controller.changePlayerChoices("idk", "idc");
                        break;
                    case 1:
                        controller.changeOtherText("harhar");
                        return 1;
                }
                dialougePosition++;
            }
            return 0;
        }
    }
}

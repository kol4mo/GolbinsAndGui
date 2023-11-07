using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolbinsAndGui
{
    public class Controller
    {
        public Player m_player;

        public void initPlayer(string name)
        {
            m_player.setPlayer(name);
        }
    }
}

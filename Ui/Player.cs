using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GolbinsAndGui.Ui
{
    internal class Player : INotifyPropertyChanged
    {
        private int intellegence;
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string caller = "")
        {
            if(PropertyChanged!= null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
        public int Intellegence
        {
            get 
            {
                return this.intellegence;    
            } 
            set
            {
                this.intellegence = value;
                NotifyPropertyChanged();
            }
        }
    }
}

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
        private string name;
        private string pClass;
        private int intellegence = 12;
        private int strength = 12;
        private int constitution = 12;
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; NotifyPropertyChanged(); }
        }
        public string PClass
        {
            get { return this.pClass; }
            set { this.pClass = value; NotifyPropertyChanged(); }
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
        public int Strength
        {
            get
            {
                return this.strength;
            }
            set { this.strength = value; NotifyPropertyChanged(); }
        }

        public int Constitution
        {
            get { return this.constitution; }
            set { this.constitution = value; NotifyPropertyChanged(); }
        }
    }
}

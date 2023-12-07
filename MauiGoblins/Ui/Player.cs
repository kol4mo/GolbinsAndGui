using Microsoft.Maui.Graphics.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiGoblins.Ui
{
    internal class Player : INotifyPropertyChanged
    {
        private string name;
        private string pClass = "Wizard";
        private int intellegence = 12;
        private int strength = 12;
        private int constitution = 12;
        private int dextarity = 12;
        private int wisdom = 12;
        public event PropertyChangedEventHandler PropertyChanged;
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

        public int Dextarity
        {
            get { return this.dextarity; }
            set { this.dextarity = value; NotifyPropertyChanged(); }
        }

        public int Wisdom
        {
            get { return this.wisdom; }
            set { this.wisdom = value; NotifyPropertyChanged(); }
        }
    }
}

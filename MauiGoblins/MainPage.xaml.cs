using MauiGoblins.Ui;
using Microsoft.Maui.Controls;
using System.Numerics;

namespace MauiGoblins
{
    public partial class setupChar : ContentPage
    {
        Player player;
        Controller controller = new Controller();
        IList<string> classes;
        public setupChar()
        {
            InitializeComponent();
            player = new Ui.Player();
            this.BindingContext = this.player;
            classes = new List<string>();
            classes.Add("Fighter");
            classes.Add("Wizard");
            classes.Add("Paladin");
            classBox.ItemsSource = (System.Collections.IList)classes;     
        }
        private void submitCharacter_Click(object sender, EventArgs e)
        {
            if (classBox.SelectedItem == null)
            {
                classBox.SelectedItem = "Fighter";
            }
            controller.initPlayer(player.Name, player.PClass, player.Intellegence, player.Strength, player.Constitution, player.Dextarity, player.Wisdom);
            controller.newEvent(this);
        }
        #region rug
        private void intellegenceUP(object sender, EventArgs e)
        {
            if (player.Intellegence < 18)
            {
                player.Intellegence = player.Intellegence + 1;
            }
        }
        private void intellegenceDown(object sender, EventArgs e)
        {
            if (player.Intellegence > 10)
            {
                player.Intellegence = player.Intellegence - 1;
            }
        }
        private void strengthUP(object sender, EventArgs e)
        {
            if (player.Strength < 18)
            {
                player.Strength = player.Strength + 1;
            }
        }
        private void strengthDown(object sender, EventArgs e)
        {
            if (player.Strength > 10)
            {
                player.Strength = player.Strength - 1;
            }
        }
        private void ConstUP(object sender, EventArgs e)
        {
            if (player.Constitution < 18)
            {
                player.Constitution = player.Constitution + 1;
            }
        }
        private void ConstDown(object sender, EventArgs e)
        {
            if (player.Constitution > 10)
            {
                player.Constitution = player.Constitution - 1;
            }
        }
        private void DexUP(object sender, EventArgs e)
        {
            if (player.Dextarity< 18)
            {
                player.Dextarity = player.Dextarity + 1;
            }
        }
        private void DexDown(object sender, EventArgs e)
        {
            if (player.Dextarity > 10)
            {
                player.Dextarity = player.Dextarity - 1;
            }
        }
        private void WisUP(object sender, EventArgs e)
        {
            if (player.Wisdom < 18)
            {
                player.Wisdom = player.Wisdom + 1;
            }
        }
        private void WisDown(object sender, EventArgs e)
        {
            if (player.Wisdom > 10)
            {
                player.Wisdom = player.Wisdom - 1;
            }
        }
        #endregion
    }
}
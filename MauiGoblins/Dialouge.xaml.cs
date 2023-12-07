using MauiGoblins.Ui;
using Microsoft.Maui.Controls;
using System.Numerics;

namespace MauiGoblins
{
    public partial class Dialouge : ContentPage
    {
        Controller controller;
        public Dialouge()
        {
            InitializeComponent();
        }

        public void setController(Controller controller)
        {
            this.controller = controller;
        }
        public void setName(string name)
        {
            OtherName.Text = name;
        }
        public void setText(string text)
        {
            OtherSpeak.Text = text;
        }
        public void setchoices(string choice0, string choice1)
        {
            this.Choice0.Text = choice0;
            this.Choice1.Text = choice1;
        }

        private void Choice0_Click(object sender, EventArgs e)
        {
            controller.moveDialogue(0);
        }

        private void Choice1_Click(object sender, EventArgs e)
        {
            controller.moveDialogue(1);
        }
    }
}
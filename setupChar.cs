using GolbinsAndGui.model;

namespace GolbinsAndGui
{
    public partial class setupChar : Form
    {
        Ui.Player player;
        Controller controller = new Controller();
        public setupChar()
        {
            InitializeComponent();
            player = new Ui.Player();
            initializeCharacterComponent();
        }

        private void initializeCharacterComponent()
        {
            nameBox.DataBindings.Add("Text", player, "name", false, DataSourceUpdateMode.OnPropertyChanged);
            classSelect.DataBindings.Add("Text", player, "pClass", false, DataSourceUpdateMode.OnPropertyChanged);
            Intellegence.DataBindings.Add("Value", player, "intellegence", false, DataSourceUpdateMode.OnPropertyChanged);
            Strength.DataBindings.Add("Value", player, "strength", false, DataSourceUpdateMode.OnPropertyChanged);
            Constitution.DataBindings.Add("Value", player, "constitution", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public void SetController(Controller controller)
        {
            m_owner = controller;
        }
        private void submitCharacter_Click(object sender, EventArgs e)
        {
            if (classSelect.Text != "Wizard" || classSelect.Text != "Fighter" || classSelect.Text != "Paladin")
            {
                classSelect.Text = "Wizard";
            }
            controller.initPlayer(player.Name, player.PClass, player.Intellegence, player.Strength, player.Constitution);
            controller.newEvent(this);
        }

        private void classSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Intellegence_ValueChanged(object sender, EventArgs e)
        {
            statCheck();
        }

        private void Strength_ValueChanged(object sender, EventArgs e)
        {
            statCheck();
        }

        private void Constitution_ValueChanged(object sender, EventArgs e)
        {
            statCheck();
        }
        public void statCheck()
        {
            int temp = 40 - (int)(Intellegence.Value + Strength.Value + Constitution.Value);
            Intellegence.Maximum = temp + Intellegence.Value;
            Strength.Maximum = temp + Strength.Value;
            Constitution.Maximum = temp + Constitution.Value;
            points.Text = "Points Available: " + temp;
        }

    }
}
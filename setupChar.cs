namespace GolbinsAndGui
{
    public partial class setupChar : Form
    {
        public setupChar()
        {
            InitializeComponent();
        }

        public void SetController(Controller controller)
        {
            m_owner = controller;
        }
        private void submitCharacter_Click(object sender, EventArgs e)
        {
            m_owner.initPlayer(nameBox.Text);
        }
    }
}
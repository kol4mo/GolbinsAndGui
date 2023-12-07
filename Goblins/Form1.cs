namespace GolbinsAndGui
{
    public partial class Form1 : Form
    {
        Controller m_owner;
        public Form1()
        {
            InitializeComponent();
        }
        public void SetController(Controller controller)
        {
            m_owner = controller;
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
            m_owner.moveDialogue(0);
        }

        private void Choice1_Click(object sender, EventArgs e)
        {
            m_owner.moveDialogue(1);
        }
    }
}

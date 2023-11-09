namespace GolbinsAndGui
{
    partial class setupChar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameBox = new TextBox();
            submitCharacter = new Button();
            classSelect = new ComboBox();
            Intellegence = new NumericUpDown();
            Strength = new NumericUpDown();
            Constitution = new NumericUpDown();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            points = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Intellegence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Strength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Constitution).BeginInit();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Location = new Point(99, 50);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(161, 31);
            nameBox.TabIndex = 0;
            nameBox.Text = "name";
            // 
            // submitCharacter
            // 
            submitCharacter.Location = new Point(614, 374);
            submitCharacter.Name = "submitCharacter";
            submitCharacter.Size = new Size(112, 34);
            submitCharacter.TabIndex = 1;
            submitCharacter.Text = "Submit";
            submitCharacter.UseVisualStyleBackColor = true;
            submitCharacter.Click += submitCharacter_Click;
            // 
            // classSelect
            // 
            classSelect.FormattingEnabled = true;
            classSelect.Items.AddRange(new object[] { "Wizard", "Fighter", "Paladin" });
            classSelect.Location = new Point(102, 107);
            classSelect.Name = "classSelect";
            classSelect.Size = new Size(182, 33);
            classSelect.TabIndex = 2;
            classSelect.SelectedIndexChanged += classSelect_SelectedIndexChanged;
            // 
            // Intellegence
            // 
            Intellegence.Location = new Point(606, 49);
            Intellegence.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            Intellegence.Name = "Intellegence";
            Intellegence.Size = new Size(180, 31);
            Intellegence.TabIndex = 3;
            Intellegence.ValueChanged += Intellegence_ValueChanged;
            // 
            // Strength
            // 
            Strength.Location = new Point(606, 95);
            Strength.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            Strength.Name = "Strength";
            Strength.Size = new Size(180, 31);
            Strength.TabIndex = 4;
            Strength.ValueChanged += Strength_ValueChanged;
            // 
            // Constitution
            // 
            Constitution.Location = new Point(606, 141);
            Constitution.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            Constitution.Name = "Constitution";
            Constitution.Size = new Size(180, 31);
            Constitution.TabIndex = 5;
            Constitution.ValueChanged += Constitution_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(450, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 6;
            textBox1.Text = "Intellegence";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(450, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 7;
            textBox2.Text = "Strength";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(450, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 8;
            textBox3.Text = "Constitution";
            // 
            // points
            // 
            points.Location = new Point(469, 197);
            points.Name = "points";
            points.Size = new Size(267, 31);
            points.TabIndex = 9;
            points.Text = "Available Points: 40";
            // 
            // setupChar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 471);
            Controls.Add(points);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Constitution);
            Controls.Add(Strength);
            Controls.Add(Intellegence);
            Controls.Add(classSelect);
            Controls.Add(submitCharacter);
            Controls.Add(nameBox);
            Name = "setupChar";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Intellegence).EndInit();
            ((System.ComponentModel.ISupportInitialize)Strength).EndInit();
            ((System.ComponentModel.ISupportInitialize)Constitution).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox nameBox;
        private Button submitCharacter;
        Controller m_owner;
        private ComboBox classSelect;
        private NumericUpDown Intellegence;
        private NumericUpDown Strength;
        private NumericUpDown Constitution;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox points;
    }
}
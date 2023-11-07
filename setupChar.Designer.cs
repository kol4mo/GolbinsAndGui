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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitCharacter);
            Controls.Add(nameBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox;
        private Button submitCharacter;
        Controller m_owner;
    }
}
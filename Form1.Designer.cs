namespace GolbinsAndGui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Choice0 = new Button();
            OtherName = new Label();
            Choice1 = new Button();
            OtherSpeak = new TextBox();
            SuspendLayout();
            // 
            // Choice0
            // 
            Choice0.Location = new Point(63, 287);
            Choice0.Name = "Choice0";
            Choice0.Size = new Size(324, 115);
            Choice0.TabIndex = 0;
            Choice0.Text = "no";
            Choice0.UseVisualStyleBackColor = true;
            Choice0.Click += Choice0_Click;
            // 
            // OtherName
            // 
            OtherName.AutoSize = true;
            OtherName.Location = new Point(63, 38);
            OtherName.Name = "OtherName";
            OtherName.Size = new Size(54, 25);
            OtherName.TabIndex = 1;
            OtherName.Text = "other";
            // 
            // Choice1
            // 
            Choice1.Location = new Point(393, 287);
            Choice1.Name = "Choice1";
            Choice1.Size = new Size(313, 115);
            Choice1.TabIndex = 2;
            Choice1.Text = "hi";
            Choice1.UseVisualStyleBackColor = true;
            Choice1.Click += Choice1_Click;
            // 
            // OtherSpeak
            // 
            OtherSpeak.Location = new Point(63, 95);
            OtherSpeak.Multiline = true;
            OtherSpeak.Name = "OtherSpeak";
            OtherSpeak.Size = new Size(643, 108);
            OtherSpeak.TabIndex = 3;
            OtherSpeak.Text = "'ello";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OtherSpeak);
            Controls.Add(Choice1);
            Controls.Add(OtherName);
            Controls.Add(Choice0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Choice0;
        private Label OtherName;
        private Button Choice1;
        private TextBox OtherSpeak;
    }
}
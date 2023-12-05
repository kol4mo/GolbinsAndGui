namespace GolbinsAndGui
{
    partial class Combat
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
            Attack3 = new Button();
            Attack4 = new Button();
            Attack1 = new Button();
            Attack2 = new Button();
            EnemyHP = new ProgressBar();
            PlayerHP = new ProgressBar();
            gameResponse = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Attack3
            // 
            Attack3.Location = new Point(20, 350);
            Attack3.Name = "Attack3";
            Attack3.Size = new Size(340, 75);
            Attack3.TabIndex = 0;
            Attack3.Text = "Attack 3";
            Attack3.UseVisualStyleBackColor = true;
            Attack3.Click += Attack3_Click;
            // 
            // Attack4
            // 
            Attack4.Location = new Point(400, 350);
            Attack4.Name = "Attack4";
            Attack4.Size = new Size(340, 75);
            Attack4.TabIndex = 1;
            Attack4.Text = "Attack 4";
            Attack4.UseVisualStyleBackColor = true;
            Attack4.Click += Attack4_Click;
            // 
            // Attack1
            // 
            Attack1.Location = new Point(20, 269);
            Attack1.Name = "Attack1";
            Attack1.Size = new Size(340, 75);
            Attack1.TabIndex = 2;
            Attack1.Text = "Attack 1";
            Attack1.UseVisualStyleBackColor = true;
            Attack1.Click += Attack1_Click;
            // 
            // Attack2
            // 
            Attack2.Location = new Point(400, 269);
            Attack2.Name = "Attack2";
            Attack2.Size = new Size(340, 75);
            Attack2.TabIndex = 3;
            Attack2.Text = "Attack 2";
            Attack2.UseVisualStyleBackColor = true;
            Attack2.Click += Attack2_Click;
            // 
            // EnemyHP
            // 
            EnemyHP.Location = new Point(500, 12);
            EnemyHP.Name = "EnemyHP";
            EnemyHP.Size = new Size(240, 34);
            EnemyHP.Step = 1;
            EnemyHP.TabIndex = 4;
            EnemyHP.Value = 10;
            // 
            // PlayerHP
            // 
            PlayerHP.ForeColor = Color.Red;
            PlayerHP.Location = new Point(20, 12);
            PlayerHP.Name = "PlayerHP";
            PlayerHP.Size = new Size(240, 34);
            PlayerHP.Step = 1;
            PlayerHP.TabIndex = 5;
            PlayerHP.Value = 10;
            // 
            // gameResponse
            // 
            gameResponse.Location = new Point(20, 160);
            gameResponse.Multiline = true;
            gameResponse.Name = "gameResponse";
            gameResponse.Size = new Size(720, 95);
            gameResponse.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 80);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // Combat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(gameResponse);
            Controls.Add(PlayerHP);
            Controls.Add(EnemyHP);
            Controls.Add(Attack2);
            Controls.Add(Attack1);
            Controls.Add(Attack4);
            Controls.Add(Attack3);
            Name = "Combat";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Attack3;
        private Button Attack4;
        private Button Attack1;
        private Button Attack2;
        private ProgressBar EnemyHP;
        private ProgressBar PlayerHP;
        private TextBox gameResponse;
        private Label label1;
    }
}
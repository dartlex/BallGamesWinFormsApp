namespace BallGamesWinFormsApp
{
    partial class MainForm
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
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(647, 12);
            button3.Name = "button3";
            button3.Size = new Size(141, 68);
            button3.TabIndex = 2;
            button3.Text = "Остановить все шарики";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(502, 12);
            button4.Name = "button4";
            button4.Size = new Size(139, 68);
            button4.TabIndex = 3;
            button4.Text = "Начать игру";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Name = "MainForm";
            Text = "Мячики";
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Button button4;
    }
}

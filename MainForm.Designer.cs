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
            StopButton = new Button();
            StartButton = new Button();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // StopButton
            // 
            StopButton.Location = new Point(649, 58);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(140, 40);
            StopButton.TabIndex = 2;
            StopButton.Text = "Остановить";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += button3_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(649, 12);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(140, 40);
            StartButton.TabIndex = 3;
            StartButton.Text = "Создать";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += button4_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(649, 104);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(140, 40);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearButton);
            Controls.Add(StartButton);
            Controls.Add(StopButton);
            Name = "MainForm";
            Text = "Мячики";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button StopButton;
        private Button StartButton;
        private Button ClearButton;
    }
}

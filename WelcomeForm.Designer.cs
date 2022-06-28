namespace _2048WinFormsApp
{
    partial class WelcomeForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            this.button4x4 = new System.Windows.Forms.Button();
            this.button5x5 = new System.Windows.Forms.Button();
            this.button6x6 = new System.Windows.Forms.Button();
            this.button7x7 = new System.Windows.Forms.Button();
            this.button8x8 = new System.Windows.Forms.Button();
            this.button9x9 = new System.Windows.Forms.Button();
            this.selectMapSizeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(20, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(275, 25);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Приветствую Вас в игре 2048!";
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterNameLabel.Location = new System.Drawing.Point(20, 83);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(182, 25);
            this.enterNameLabel.TabIndex = 1;
            this.enterNameLabel.Text = "Введите Ваше имя:";
            // 
            // enterNameTextBox
            // 
            this.enterNameTextBox.Location = new System.Drawing.Point(20, 133);
            this.enterNameTextBox.Name = "enterNameTextBox";
            this.enterNameTextBox.Size = new System.Drawing.Size(312, 27);
            this.enterNameTextBox.TabIndex = 2;
            // 
            // button4x4
            // 
            this.button4x4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4x4.Location = new System.Drawing.Point(20, 214);
            this.button4x4.Name = "button4x4";
            this.button4x4.Size = new System.Drawing.Size(100, 100);
            this.button4x4.TabIndex = 3;
            this.button4x4.Text = "4x4";
            this.button4x4.UseVisualStyleBackColor = true;
            this.button4x4.Click += new System.EventHandler(this.button4x4_Click);
            // 
            // button5x5
            // 
            this.button5x5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5x5.Location = new System.Drawing.Point(126, 214);
            this.button5x5.Name = "button5x5";
            this.button5x5.Size = new System.Drawing.Size(100, 100);
            this.button5x5.TabIndex = 4;
            this.button5x5.Text = "5x5";
            this.button5x5.UseVisualStyleBackColor = true;
            this.button5x5.Click += new System.EventHandler(this.button5x5_Click);
            // 
            // button6x6
            // 
            this.button6x6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6x6.Location = new System.Drawing.Point(232, 214);
            this.button6x6.Name = "button6x6";
            this.button6x6.Size = new System.Drawing.Size(100, 100);
            this.button6x6.TabIndex = 5;
            this.button6x6.Text = "6x6";
            this.button6x6.UseVisualStyleBackColor = true;
            this.button6x6.Click += new System.EventHandler(this.button6x6_Click);
            // 
            // button7x7
            // 
            this.button7x7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7x7.Location = new System.Drawing.Point(20, 320);
            this.button7x7.Name = "button7x7";
            this.button7x7.Size = new System.Drawing.Size(100, 100);
            this.button7x7.TabIndex = 6;
            this.button7x7.Text = "7x7";
            this.button7x7.UseVisualStyleBackColor = true;
            this.button7x7.Click += new System.EventHandler(this.button7x7_Click);
            // 
            // button8x8
            // 
            this.button8x8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8x8.Location = new System.Drawing.Point(126, 320);
            this.button8x8.Name = "button8x8";
            this.button8x8.Size = new System.Drawing.Size(100, 100);
            this.button8x8.TabIndex = 7;
            this.button8x8.Text = "8x8";
            this.button8x8.UseVisualStyleBackColor = true;
            this.button8x8.Click += new System.EventHandler(this.button8x8_Click);
            // 
            // button9x9
            // 
            this.button9x9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9x9.Location = new System.Drawing.Point(232, 320);
            this.button9x9.Name = "button9x9";
            this.button9x9.Size = new System.Drawing.Size(100, 100);
            this.button9x9.TabIndex = 8;
            this.button9x9.Text = "9x9";
            this.button9x9.UseVisualStyleBackColor = true;
            this.button9x9.Click += new System.EventHandler(this.button9x9_Click);
            // 
            // selectMapSizeLabel
            // 
            this.selectMapSizeLabel.AutoSize = true;
            this.selectMapSizeLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectMapSizeLabel.Location = new System.Drawing.Point(20, 173);
            this.selectMapSizeLabel.Name = "selectMapSizeLabel";
            this.selectMapSizeLabel.Size = new System.Drawing.Size(272, 25);
            this.selectMapSizeLabel.TabIndex = 9;
            this.selectMapSizeLabel.Text = "Выберите размер поля игры:";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(190, 449);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(142, 49);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 510);
            this.ControlBox = false;
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.selectMapSizeLabel);
            this.Controls.Add(this.button9x9);
            this.Controls.Add(this.button8x8);
            this.Controls.Add(this.button7x7);
            this.Controls.Add(this.button6x6);
            this.Controls.Add(this.button5x5);
            this.Controls.Add(this.button4x4);
            this.Controls.Add(this.enterNameTextBox);
            this.Controls.Add(this.enterNameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "WelcomeForm";
            this.Text = "2048";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeLabel;
        private Label enterNameLabel;
        public TextBox enterNameTextBox;
        private Button button4x4;
        private Button button5x5;
        private Button button6x6;
        private Button button7x7;
        private Button button8x8;
        private Button button9x9;
        private Label selectMapSizeLabel;
        private Button startButton;
    }
}
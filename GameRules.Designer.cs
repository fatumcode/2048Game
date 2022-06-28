namespace _2048WinFormsApp
{
    partial class GameRules
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
            this.rulesTextListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rulesTextListBox
            // 
            this.rulesTextListBox.FormattingEnabled = true;
            this.rulesTextListBox.ItemHeight = 20;
            this.rulesTextListBox.Items.AddRange(new object[] {
            "Приветствую в игре 2048!",
            "Ваша задача соеденять одинаковые цифры по горизонтали и вертикали, ",
            "путем нажатия на стрелки клавиатуры.",
            "Игра закончится тогда, когда все ячейки заполнятся цифрами,",
            "и у Вас не останется возможности передвигать ячейки."});
            this.rulesTextListBox.Location = new System.Drawing.Point(12, 11);
            this.rulesTextListBox.Name = "rulesTextListBox";
            this.rulesTextListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rulesTextListBox.Size = new System.Drawing.Size(538, 144);
            this.rulesTextListBox.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(445, 165);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 29);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Закрыть!";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // GameRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 206);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rulesTextListBox);
            this.Name = "GameRules";
            this.Text = "Правила игры 2048";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox rulesTextListBox;
        private Button exitButton;
    }
}
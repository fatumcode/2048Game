namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }


        public static int MapSize = WelcomeForm.sizeMap;
        private Label[,] labelsMap;
        private static Random random = new Random();
        User user;
        private int score = 0;
        private int bestScore = UsersResultStorage.BestResult();
        public int sizeFormX = 40 + MapSize * 70 + 6 * 3;
        public int sizeFormY = 100 + MapSize * 70 + 6 * 3;

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(sizeFormX, sizeFormY);

            InitMap();
            GenerateNumber();
            ShowScore();
            ShowBestScore();

            user = new User(WelcomeForm.userName);

        }

        private void ShowBestScore()
        {
            if (score > bestScore)
                bestScoreLabel.Text = score.ToString();
            else
                bestScoreLabel.Text = bestScore.ToString();
        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
        }

        private void InitMap()
        {

            labelsMap = new Label[MapSize, MapSize];
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }
        private void GenerateNumber()
        {
            var emptyMap = 0;
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = MapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == String.Empty)
                    {
                        emptyMap++;
                    }
                }
            }

            while (emptyMap > 0) 
            {
                var randomNumberLabel = random.Next(MapSize * MapSize);
                var indexRow = randomNumberLabel / MapSize;
                var indexColumn = randomNumberLabel % MapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    var randomPercentNumber = random.Next(1, 5);
                    if (randomPercentNumber <= 3)
                    {
                        labelsMap[indexRow, indexColumn].Text = "2";
                        labelsMap[indexRow, indexColumn].BackColor = Color.FromArgb(150, 230, 0);
                    }
                    else
                    {
                        labelsMap[indexRow, indexColumn].Text = "4";
                        labelsMap[indexRow, indexColumn].BackColor = Color.FromArgb(150, 220, 0);
                    }
                    break;
                }
            }
        }
        private void GenerateBackColor(Label label, int number)
        {
            int colorCounter = 0;
            while (number != 1)
            {
                number /= 2;
                colorCounter++;
            }


            label.BackColor = Color.FromArgb(150, 250 - (colorCounter * 10), 0);
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            SuspendLayout();
            label.BackColor = SystemColors.AppWorkspace;
            label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label.Size = new Size(70, 70);
            label.TabIndex = 0;
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = 10 + indexColumn * 76;
            int y = 50 + indexRow * 76;
            label.Location = new Point(x, y);
            return label;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
            {
                return;
            }
            RightKeyClick(sender, e);
            LeftKeyClick(sender, e);
            UpKeyClick(sender, e);
            DownKeyClick(sender, e);

            GenerateNumber();
            ShowScore();
            ShowBestScore();

            if (EndGame())
            {
                MessageBox.Show("Игра закончена!");
                return;
            }
        }


        public void RightKeyClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = MapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text != String.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != String.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        GenerateBackColor(labelsMap[i, j], number * 2);
                                        labelsMap[i, k].Text = String.Empty;
                                        labelsMap[i, k].BackColor = SystemColors.AppWorkspace;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = MapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text == String.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {

                                if (labelsMap[i, j].Text != labelsMap[i, k].Text)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    GenerateBackColor(labelsMap[i, j], int.Parse(labelsMap[i, j].Text) * 2);
                                    labelsMap[i, k].Text = String.Empty;
                                    labelsMap[i, k].BackColor = SystemColors.AppWorkspace;
                                    break;
                                }
                            }
                        }
                    }
                }
                
            }
        }
        public void LeftKeyClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = 0; j < MapSize; j++)
                    {
                        if (labelsMap[i, j].Text != String.Empty)
                        {
                            for (int k = j + 1; k < MapSize; k++)
                            {
                                if (labelsMap[i, k].Text != String.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        GenerateBackColor(labelsMap[i, j], number * 2);
                                        labelsMap[i, k].Text = String.Empty;
                                        labelsMap[i, k].BackColor = SystemColors.AppWorkspace;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = 0; j < MapSize; j++)
                    {
                        if (labelsMap[i, j].Text == String.Empty)
                        {
                            for (int k = j + 1; k < MapSize; k++)
                            {

                                if (labelsMap[i, j].Text != labelsMap[i, k].Text)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    GenerateBackColor(labelsMap[i, j], int.Parse(labelsMap[i, j].Text) * 2);
                                    labelsMap[i, k].Text = String.Empty;
                                    labelsMap[i, k].BackColor = SystemColors.AppWorkspace;
                                    break;
                                }
                            }
                        }
                    }
                }
               
            }
        }
        public void UpKeyClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = 0; j < MapSize; j++)
                    {
                        if (labelsMap[i, j].Text != String.Empty)
                        {
                            for (int k = i + 1; k < MapSize; k++)
                            {
                                if (labelsMap[k, j].Text != String.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                    {
                                        var number = int.Parse(labelsMap[k, j].Text);
                                        score += number * 2;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        GenerateBackColor(labelsMap[i, j], number * 2);
                                        labelsMap[k, j].Text = String.Empty;
                                        labelsMap[k, j].BackColor = SystemColors.AppWorkspace;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = 0; j < MapSize; j++)
                    {
                        if (labelsMap[i, j].Text == String.Empty)
                        {
                            for (int k = i + 1; k < MapSize; k++)
                            {

                                if (labelsMap[i, j].Text != labelsMap[k, j].Text)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    GenerateBackColor(labelsMap[i, j], int.Parse(labelsMap[i, j].Text) * 2);
                                    labelsMap[k, j].Text = String.Empty;
                                    labelsMap[k, j].BackColor = SystemColors.AppWorkspace;
                                    break;
                                }
                            }
                        }
                    }
                }
                
            }
        }
        public void DownKeyClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                for (int i = MapSize - 1; i >= 0; i--)
                {
                    for (int j = MapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text != String.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != String.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                    {
                                        var number = int.Parse(labelsMap[k, j].Text);
                                        score += number * 2;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        GenerateBackColor(labelsMap[i, j], number * 2);
                                        labelsMap[k, j].Text = String.Empty;
                                        labelsMap[k, j].BackColor = SystemColors.AppWorkspace;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = MapSize - 1; i >= 0; i--)
                {
                    for (int j = MapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text == String.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {

                                if (labelsMap[i, j].Text != labelsMap[k, j].Text)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    GenerateBackColor(labelsMap[i, j], int.Parse(labelsMap[i, j].Text) * 2);
                                    labelsMap[k, j].Text = String.Empty;
                                    labelsMap[k, j].BackColor = SystemColors.AppWorkspace;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            
        }

        private bool EndGame ()
        {
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    if (labelsMap[i, j].Text == "")
                    {
                        return false;
                    }
                }
            }
            for (int i = 0; i < MapSize-1; i++)
            {
                for (int j = 0; j < MapSize - 1; j++)
                {
                    if(labelsMap[i, j].Text == labelsMap[i, j+1].Text || labelsMap[i, j].Text == labelsMap[i+1, j].Text || labelsMap[i+1, j].Text == labelsMap[i+1,j+1].Text)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameRules = new GameRules();
            gameRules.Show();

        }
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user.Result = score;
            UsersResultStorage.Append(user);
            Application.Restart();

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user.Result = score;
            UsersResultStorage.Append(user);
            this.Close();
        }

        private void previousResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var previousResults = new PreviousResultsForm();
            previousResults.Show();
        }

        private void gameSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sizeMap = new WelcomeForm();
            sizeMap.Show();
        }
    }
}



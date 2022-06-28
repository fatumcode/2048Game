
namespace _2048WinFormsApp
{
    public partial class PreviousResultsForm : Form
    {

        public PreviousResultsForm()
        {
            InitializeComponent();
            Show();

        }

        private void Show()
        {
            try
            {

                var results = UsersResultStorage.GetAll();
                if (results.Count == 0)
                    throw new Exception();
                else
                {
                    foreach (var result in results)
                    {
                        resultsDataGridView.Rows.Add(result.Name, result.Result);
                    }
                }
            }
            catch (Exception)
            {
                var exceptionMessage = MessageBox.Show("База результатов пуста!", "Внимание!", MessageBoxButtons.OK);
                if (exceptionMessage == DialogResult.OK)
                {
                    return;
                }
            }

        }
    }
}

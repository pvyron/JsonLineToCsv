using JsonLineToCsv.Interface.Models;
using JsonLineToCsv.Interface.Workers;
using System.Drawing.Printing;

namespace JsonLineToCsv.Interface
{
    public partial class MainForm : Form
    {
        private string _sourcePath;

        private string sourcePath
        {
            get => _sourcePath;
            set
            {
                sourcePathTextBox.Text = value;
                _sourcePath = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sourceBrowseButton_Click(object sender, EventArgs e)
        {
            if (sourceFileDialog.ShowDialog() != DialogResult.OK)
                return;

            sourcePath = sourceFileDialog.FileName;
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourcePath))
                return;

            if (targetSaveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string targetPath = targetSaveFileDialog.FileName;

            if (string.IsNullOrEmpty(targetPath))
                return;

            List<SourceObject> sourceObjects = new InputFileConverter(sourcePath).GetSourceObjects();
            List<OutputObject> outputObjects = sourceObjects.Select(o => o.ToOutputObject()).ToList();
            List<CsvLine> csvLines = outputObjects.SelectMany(o => o.GetCsvLines()).ToList();
            csvLines.SaveAs(targetPath);

            MessageBox.Show("Done", "Result");
        }
    }
}
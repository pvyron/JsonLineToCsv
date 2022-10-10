using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace JlineToCsv.FrameworkUI
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
            try
            {
                if (string.IsNullOrEmpty(sourcePath))
                    return;

                if (targetSaveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                string targetPath = targetSaveFileDialog.FileName;

                if (string.IsNullOrEmpty(targetPath))
                    return;

                using (var writer = File.CreateText(targetPath))
                {
                    foreach (var line in File.ReadLines(sourcePath))
                    {
                        JObject JLine = JObject.Parse(line);

                        if (!JLine.ContainsKey("series_id"))
                            continue;

                        foreach (var token in JLine["data"])
                        {
                            writer.WriteLine($"{JLine["series_id"]},{JLine["name"]},{JLine["units"]},{JLine["last_updated"]},{token[0]},{token[1]}");
                        }
                    }
                }

                MessageBox.Show("Done", "Result");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, "Error");
            }
        }
    }
}

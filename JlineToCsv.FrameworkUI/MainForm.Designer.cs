using System.Windows.Forms;

namespace JlineToCsv.FrameworkUI
{
    partial class MainForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.targetSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.sourceBrowseButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.sourcePathTextBox = new System.Windows.Forms.TextBox();
            this.sourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // targetSaveFileDialog
            // 
            this.targetSaveFileDialog.DefaultExt = "csv";
            this.targetSaveFileDialog.Filter = "Csv file (*.csv)|*.csv";
            // 
            // sourceBrowseButton
            // 
            this.sourceBrowseButton.Location = new System.Drawing.Point(415, 23);
            this.sourceBrowseButton.Name = "sourceBrowseButton";
            this.sourceBrowseButton.Size = new System.Drawing.Size(50, 25);
            this.sourceBrowseButton.TabIndex = 0;
            this.sourceBrowseButton.Text = "...";
            this.sourceBrowseButton.UseVisualStyleBackColor = true;
            this.sourceBrowseButton.Click += new System.EventHandler(this.sourceBrowseButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(390, 103);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(75, 25);
            this.saveAsButton.TabIndex = 1;
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 103);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sourcePathTextBox
            // 
            this.sourcePathTextBox.Enabled = false;
            this.sourcePathTextBox.Location = new System.Drawing.Point(12, 25);
            this.sourcePathTextBox.Name = "sourcePathTextBox";
            this.sourcePathTextBox.Size = new System.Drawing.Size(397, 23);
            this.sourcePathTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 157);
            this.Controls.Add(this.sourcePathTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.sourceBrowseButton);
            this.Name = "MainForm";
            this.Text = "JLine To Csv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SaveFileDialog targetSaveFileDialog;
        private Button sourceBrowseButton;
        private Button saveAsButton;
        private Button exitButton;
        private TextBox sourcePathTextBox;
        private OpenFileDialog sourceFileDialog;
    }
}
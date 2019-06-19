using System;
using System.Windows.Forms;
using TextSearcher.Views;
using TextSearcher.Presenters;
    
namespace TextSearcher
{
    public partial class MainForm : Form,ITxtSearcher
    {
        public string RootDirectory
        {
            get => txtBoxDir.Text; set => txtBoxDir.Text = value;
        }

        public string PatternFileName
        {
            get => txtBoxPatternFileName.Text; set => txtBoxPatternFileName.Text = value;
        }

        public string Pattern
        {
            get => txtBoxPattern.Text; set => txtBoxPattern.Text = value;
        }

        public int CountProcessingFile
        {
            get => int.Parse(txtCountFile.Text); set => txtCountFile.Text = "Number of processed files: " + value.ToString();
        }

        public string FoundFiles
        {
            get => txtBoxFound.Text; set => txtBoxFound.Lines= value.Split('\n');
        }

        public string SearchStatus
        {
            get => SearchStatus; set => SetStatus(value.ToString());
        }

        public string ElapsedTime
        {
            get => txtElapsedTime.Text; set => txtElapsedTime.Text = "Elapsed time: " + value;
        }

        TxtSearchPresenter txtSearcher;
        public MainForm()
        {
            InitializeComponent();
            BtnPauseSearch.Enabled = false;
            BtnStopSearch.Enabled = false;
            txtSearcher = new TxtSearchPresenter(this);
            txtBoxDir.Text = Properties.Settings.Default.PathToDirectory;
            txtBoxPattern.Text = Properties.Settings.Default.PatternText;
            txtBoxPatternFileName.Text = Properties.Settings.Default.PatternFileName;
        }

        private void BtnSetDir_click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtBoxDir.Text = folderBrowserDialog1.SelectedPath;
            Properties.Settings.Default.PathToDirectory = txtBoxDir.Text;
        }

        private async void BtnStartSearch_click(object sender, EventArgs e)
        {

            if (!(String.IsNullOrEmpty(txtBoxPattern.Text) && String.IsNullOrEmpty(txtBoxPatternFileName.Text) 
                && String.IsNullOrEmpty(txtBoxDir.Text)))
            {
                BtnSetDir.Enabled = false;
                BtnStartSearch.Enabled = false;
                BtnPauseSearch.Enabled = true;
                BtnStopSearch.Enabled = true;
                this.UseWaitCursor = true;
               
                await txtSearcher.StartSearchTxt(); // Start task

                UseWaitCursor = false;
                MessageBox.Show("Search completed, found files: " + (txtBoxFound.Lines.Length -1));
                BtnPauseSearch.Enabled = false;
                BtnStopSearch.Enabled = false;
                BtnStartSearch.Enabled = true;
                BtnSetDir.Enabled = true;
            } else
            {
                MessageBox.Show("Please, set value in empty box");
            }
            
        }

        private void BtnStopSearch_Click(object sender, EventArgs e)
        {
            txtSearcher.StopSearchTxt();
            UseWaitCursor = false;
        }

        private void BtnPauseSearch_Click(object sender, EventArgs e)
        {
            txtSearcher.PauseSearchTxt(); 
            UseWaitCursor = false;
        }

        private void SetStatus(string status)
        {
            if(status=="Running")
            {
                txtStatus.Text = "Search is running, please wait";
            }
            else
            {
                txtStatus.Text = "Search status: " + status;
            }
              
        }

        //save user pref
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PatternFileName = txtBoxPatternFileName.Text;
            Properties.Settings.Default.PatternText = txtBoxPattern.Text;
            Properties.Settings.Default.Save();
        }
    }
}

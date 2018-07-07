using System;
using System.Diagnostics;
using System.Windows.Forms;
namespace EZ_HAC
{
    using static Properties.Resources;
    public partial class FormMain : Form
    {
        Process Hactool;
        public void RunHactool(string args)
        {
            Hactool = new Process();
            Hactool.StartInfo.FileName = Binary;
            Hactool.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Hactool.StartInfo.Arguments = args;
            Hactool.Start();
            Hactool.WaitForExit();
        }

        public FormMain()
        {
            HacChecks.RunChecks();
            InitializeComponent();
            HactoolVersion.Text += HacChecks.HacVersionId;
        }

        private void UpdateDescription(string Text)
        {
            DescriptionLabel.Text = DescStrDefault + Text;
        }

        private void XciExtractionTab_Enter(object sender, EventArgs e)
        {
            UpdateDescription(DescStrXCI);
        }

        private void NcaExtractionTab_Enter(object sender, EventArgs e)
        {
            UpdateDescription(DescStrNCA);
        }

        private void NcaExtract_Click(object sender, EventArgs e)
        {
            if (NcaPath.Text == null)
            {
                MessageBox.Show(ErrInvalidInputNCAPath, ErrHeader, MessageBoxButtons.OK);
                return;
            }

            if (NcaOutputPath.Text == null)
            {
                MessageBox.Show(ErrInvalidOutputNCAPath, ErrHeader, MessageBoxButtons.OK);
                return;
            }

            foreach (TabPage Page in HacTab.TabPages) Page.Enabled = false;

            if (NcaEmulatorExtract.Checked)
            {
                if (NcaTitleKey.Text != "")
                {
                    RunHactool(Keyfile + Quote + NcaPath.Text + Quote + Titlekey + NcaTitleKey.Text + ExeFSDir + NcaOutputPath.Text + Quote + RomFS + NcaOutputPath.Text + RomFSExt);
                }

                else
                {
                    RunHactool(Keyfile + Quote + NcaPath.Text + Quote + ExeFSDir + NcaOutputPath.Text + Quote + RomFS + NcaOutputPath.Text + RomFSExt);
                }
            }
            else
            {
                if (NcaTitleKey.Text != "")
                {
                    RunHactool(Keyfile + Quote + NcaPath.Text + Quote + Titlekey + NcaTitleKey.Text + ExeFSDir + NcaOutputPath.Text + ExeFS + RomFSDir + NcaOutputPath.Text + RomFSFol);
                }

                else
                {
                    RunHactool(Keyfile + Quote + NcaPath.Text + Quote + ExeFSDir + NcaOutputPath.Text + ExeFS + RomFSDir + NcaOutputPath.Text + RomFSFol);
                }
            }

            foreach (TabPage Page in HacTab.TabPages) Page.Enabled = true;
            MessageBox.Show(DoneNCAMsg, DoneHeader, MessageBoxButtons.OK);
        }
        private void NcaBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog NcaDialog = new OpenFileDialog
            {
                Title = DialogNCAInTitle,
                Filter = NCAFilter,
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (NcaDialog.ShowDialog() == DialogResult.OK)
            {
                NcaPath.Text = NcaDialog.FileName;
            }
        }

        private void NcaOutputBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog NcaOutputDialog = new FolderBrowserDialog
            {
                Description = DescStrDialogXCIOut,
                SelectedPath = Application.StartupPath
            };

            if (NcaOutputDialog.ShowDialog() == DialogResult.OK)
            {
                NcaOutputPath.Text = NcaOutputDialog.SelectedPath;
            }
        }

        private void XciBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog XciDialog = new OpenFileDialog
            {
                Title = DialogXCIInTitle,
                Filter = XCIFilter,
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (XciDialog.ShowDialog() == DialogResult.OK)
            {
                XciPath.Text = XciDialog.FileName;
            }
        }

        private void XciOutputBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog XciOutputDialog = new FolderBrowserDialog
            {
                Description = DescStrDialogXCIOut,
                SelectedPath = Application.StartupPath
            };

            if (XciOutputDialog.ShowDialog() == DialogResult.OK)
            {
                XciOutputPath.Text = XciOutputDialog.SelectedPath;
            }
        }

        private void XciExtract_Click(object sender, EventArgs e)
        {
            if (XciPath.Text == null)
            {
                MessageBox.Show(ErrInvalidInputNCAPath, ErrHeaderFatal, MessageBoxButtons.OK);
                return;
            }

            if (XciOutputPath.Text == null)
            {
                MessageBox.Show(ErrInvalidOutputNCAPath, ErrHeaderFatal, MessageBoxButtons.OK);
                return;
            }

            foreach (TabPage Page in HacTab.TabPages) Page.Enabled = false;
            RunHactool(Keyfile + TypeXCI + Quote + XciPath.Text + Quote + Outdir + XciOutputPath.Text + Quote);
            foreach (TabPage Page in HacTab.TabPages) Page.Enabled = true;
            MessageBox.Show(DoneXCIMsg, DoneHeader, MessageBoxButtons.OK);
        }
    }
}

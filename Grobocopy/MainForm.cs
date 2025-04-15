using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Grobocopy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtSource.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtDestination.Text = dialog.SelectedPath;
                }
            }
        }

        private void InitializeComponent()
        {
            txtSource = new TextBox();
            txtDestination = new TextBox();
            txtOutput = new TextBox();
            btnBrowseSource = new Button();
            btnBrowseDesntination = new Button();
            btnStartCopy = new Button();
            lblSource = new Label();
            lblDestination = new Label();
            grpOptions = new GroupBox();
            tabControl1 = new TabControl();
            tabOpt = new TabPage();
            numLev = new NumericUpDown();
            chkS = new CheckBox();
            chkLev = new CheckBox();
            chkE = new CheckBox();
            tabPage2 = new TabPage();
            grpOutput = new GroupBox();
            txtCommand = new TextBox();
            btnPreview = new Button();
            btnAbout = new Button();
            grpOptions.SuspendLayout();
            tabControl1.SuspendLayout();
            tabOpt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLev).BeginInit();
            grpOutput.SuspendLayout();
            SuspendLayout();
            // 
            // txtSource
            // 
            txtSource.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSource.Location = new Point(127, 31);
            txtSource.Name = "txtSource";
            txtSource.PlaceholderText = "Source";
            txtSource.Size = new Size(411, 23);
            txtSource.TabIndex = 0;
            // 
            // txtDestination
            // 
            txtDestination.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDestination.Location = new Point(127, 80);
            txtDestination.Name = "txtDestination";
            txtDestination.PlaceholderText = "Destination";
            txtDestination.Size = new Size(411, 23);
            txtDestination.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOutput.BackColor = SystemColors.Window;
            txtOutput.ForeColor = SystemColors.WindowText;
            txtOutput.Location = new Point(18, 64);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(613, 149);
            txtOutput.TabIndex = 2;
            txtOutput.Text = "Command output";
            // 
            // btnBrowseSource
            // 
            btnBrowseSource.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseSource.Location = new Point(556, 31);
            btnBrowseSource.Name = "btnBrowseSource";
            btnBrowseSource.Size = new Size(75, 23);
            btnBrowseSource.TabIndex = 3;
            btnBrowseSource.Text = "Browse";
            btnBrowseSource.UseVisualStyleBackColor = true;
            btnBrowseSource.Click += btnBrowseSource_Click;
            // 
            // btnBrowseDesntination
            // 
            btnBrowseDesntination.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseDesntination.Location = new Point(556, 80);
            btnBrowseDesntination.Name = "btnBrowseDesntination";
            btnBrowseDesntination.Size = new Size(75, 23);
            btnBrowseDesntination.TabIndex = 4;
            btnBrowseDesntination.Text = "Browse";
            btnBrowseDesntination.UseVisualStyleBackColor = true;
            btnBrowseDesntination.Click += btnBrowseDestination_Click;
            // 
            // btnStartCopy
            // 
            btnStartCopy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnStartCopy.Location = new Point(617, 549);
            btnStartCopy.Name = "btnStartCopy";
            btnStartCopy.Size = new Size(75, 23);
            btnStartCopy.TabIndex = 5;
            btnStartCopy.Text = "Start";
            btnStartCopy.UseVisualStyleBackColor = true;
            btnStartCopy.Click += btnStartCopy_Click;
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Location = new Point(6, 31);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(79, 15);
            lblSource.TabIndex = 6;
            lblSource.Text = "Source Folder";
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Location = new Point(6, 80);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(103, 15);
            lblDestination.TabIndex = 7;
            lblDestination.Text = "Destination Folder";
            // 
            // grpOptions
            // 
            grpOptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpOptions.Controls.Add(tabControl1);
            grpOptions.Controls.Add(lblSource);
            grpOptions.Controls.Add(lblDestination);
            grpOptions.Controls.Add(txtSource);
            grpOptions.Controls.Add(txtDestination);
            grpOptions.Controls.Add(btnBrowseSource);
            grpOptions.Controls.Add(btnBrowseDesntination);
            grpOptions.Location = new Point(29, 12);
            grpOptions.Name = "grpOptions";
            grpOptions.Size = new Size(663, 294);
            grpOptions.TabIndex = 8;
            grpOptions.TabStop = false;
            grpOptions.Text = "Options";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabOpt);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(18, 110);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(622, 171);
            tabControl1.TabIndex = 14;
            // 
            // tabOpt
            // 
            tabOpt.AutoScroll = true;
            tabOpt.Controls.Add(numLev);
            tabOpt.Controls.Add(chkS);
            tabOpt.Controls.Add(chkLev);
            tabOpt.Controls.Add(chkE);
            tabOpt.Location = new Point(4, 24);
            tabOpt.Name = "tabOpt";
            tabOpt.Padding = new Padding(3);
            tabOpt.Size = new Size(614, 143);
            tabOpt.TabIndex = 0;
            tabOpt.Text = "Copy";
            tabOpt.UseVisualStyleBackColor = true;
            // 
            // numLev
            // 
            numLev.Location = new Point(35, 77);
            numLev.Name = "numLev";
            numLev.Size = new Size(47, 23);
            numLev.TabIndex = 12;
            // 
            // chkS
            // 
            chkS.AutoSize = true;
            chkS.Location = new Point(6, 6);
            chkS.Name = "chkS";
            chkS.Size = new Size(153, 19);
            chkS.TabIndex = 9;
            chkS.Text = "Copy subdirectories (/S)";
            chkS.UseVisualStyleBackColor = true;
            // 
            // chkLev
            // 
            chkLev.AutoSize = true;
            chkLev.Location = new Point(6, 53);
            chkLev.Name = "chkLev";
            chkLev.Size = new Size(356, 19);
            chkLev.TabIndex = 10;
            chkLev.Text = "Only copy the top n LEVels of the source directory tree (/LEV:n)";
            chkLev.UseVisualStyleBackColor = true;
            // 
            // chkE
            // 
            chkE.AutoSize = true;
            chkE.Location = new Point(6, 31);
            chkE.Name = "chkE";
            chkE.Size = new Size(277, 19);
            chkE.TabIndex = 8;
            chkE.Text = "Copy subdirectories, including Empty ones  (/E)";
            chkE.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(614, 143);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "File Selection";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpOutput
            // 
            grpOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpOutput.Controls.Add(txtCommand);
            grpOutput.Controls.Add(txtOutput);
            grpOutput.Location = new Point(29, 312);
            grpOutput.Name = "grpOutput";
            grpOutput.Size = new Size(663, 219);
            grpOutput.TabIndex = 9;
            grpOutput.TabStop = false;
            grpOutput.Text = "Output";
            // 
            // txtCommand
            // 
            txtCommand.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCommand.BackColor = SystemColors.Window;
            txtCommand.ForeColor = SystemColors.WindowText;
            txtCommand.Location = new Point(18, 22);
            txtCommand.Name = "txtCommand";
            txtCommand.ReadOnly = true;
            txtCommand.Size = new Size(613, 23);
            txtCommand.TabIndex = 3;
            txtCommand.Text = "Command preview";
            // 
            // btnPreview
            // 
            btnPreview.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPreview.Location = new Point(536, 549);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(75, 23);
            btnPreview.TabIndex = 10;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += btnPreview_Click;
            // 
            // btnAbout
            // 
            btnAbout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAbout.Location = new Point(29, 549);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(75, 23);
            btnAbout.TabIndex = 11;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(724, 584);
            Controls.Add(btnAbout);
            Controls.Add(btnPreview);
            Controls.Add(grpOutput);
            Controls.Add(grpOptions);
            Controls.Add(btnStartCopy);
            Name = "MainForm";
            Text = "Grobocopy";
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabOpt.ResumeLayout(false);
            tabOpt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numLev).EndInit();
            grpOutput.ResumeLayout(false);
            grpOutput.PerformLayout();
            ResumeLayout(false);
        }

        private async void btnStartCopy_Click(object sender, EventArgs e)
        {
            string source = txtSource.Text;
            string destination = txtDestination.Text;

            if (string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("Please select both source and destination directories.");
                return;
            }

            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = "robocopy",
                Arguments = getArguments(),
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = processInfo })
            {
                process.OutputDataReceived += (s, args) =>
                {
                    if (args.Data != null)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            txtOutput.AppendText(args.Data + Environment.NewLine);
                        });
                    }
                };

                process.Start();
                process.BeginOutputReadLine();

                await Task.Run(() => process.WaitForExit());
            }
        }

        private string getArguments()
        {
            string source = txtSource.Text;
            string destination = txtDestination.Text;

            if (string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(destination))
            {
                return "-1";
            }

            // Base command
            string arguments = $"\"{source}\" \"{destination}\"";

            // Add /S switch if the checkbox is checked
            if (chkS.Checked)
            {
                arguments += " /S";
            }

            // Add /E switch if the checkbox is checked
            if (chkE.Checked)
            {
                arguments += " /E";
            }

            // LEV:n
            if (chkLev.Checked)
            {
                arguments += " /LEV:" + numLev.Value;
            }


            // Add other default switches
            arguments += " /R:0 /W:0";

            return arguments;
        }


        private TextBox txtSource;
        private TextBox txtDestination;
        private TextBox txtOutput;
        private Button btnBrowseSource;
        private Button btnBrowseDesntination;
        private Label lblSource;
        private Label lblDestination;
        private GroupBox grpOptions;
        private GroupBox grpOutput;
        private TextBox txtCommand;
        private Button btnPreview;
        private Button btnAbout;
        private Button btnStartCopy;
        private CheckBox chkE;
        private CheckBox chkS;
        private NumericUpDown numLev;
        private CheckBox chkLev;
        private TabControl tabControl1;
        private TabPage tabOpt;
        private TabPage tabPage2;
        private string version = "0.03";

        private void btnPreview_Click(object sender, EventArgs e)
        {

            txtCommand.Text = "";
            string arguments = getArguments();

            if (arguments == "-1")
            {
                MessageBox.Show("Please select both source and destination directories.");
                return;
            }

            txtCommand.Text = "robocopy " + arguments;

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grobocopy v" + version + "\n\nA simple GUI for Robocopy.\n\nCreated by Dan MacCormac\n\nGitHub: https://www.github.com/dmaccormac", "About Grobocopy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

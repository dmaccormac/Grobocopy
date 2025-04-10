using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RobocopyFrontend
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
            grpOutput = new GroupBox();
            txtCommand = new TextBox();
            btnPreview = new Button();
            btnAbout = new Button();
            grpOptions.SuspendLayout();
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
            txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOutput.Location = new Point(18, 65);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(613, 223);
            txtOutput.TabIndex = 2;
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
            btnStartCopy.Location = new Point(617, 501);
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
            grpOptions.Controls.Add(lblSource);
            grpOptions.Controls.Add(lblDestination);
            grpOptions.Controls.Add(txtSource);
            grpOptions.Controls.Add(txtDestination);
            grpOptions.Controls.Add(btnBrowseSource);
            grpOptions.Controls.Add(btnBrowseDesntination);
            grpOptions.Location = new Point(29, 12);
            grpOptions.Name = "grpOptions";
            grpOptions.Size = new Size(663, 148);
            grpOptions.TabIndex = 8;
            grpOptions.TabStop = false;
            grpOptions.Text = "Job Options";
            // 
            // grpOutput
            // 
            grpOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpOutput.Controls.Add(txtCommand);
            grpOutput.Controls.Add(txtOutput);
            grpOutput.Location = new Point(29, 189);
            grpOutput.Name = "grpOutput";
            grpOutput.Size = new Size(663, 294);
            grpOutput.TabIndex = 9;
            grpOutput.TabStop = false;
            grpOutput.Text = "Output";
            // 
            // txtCommand
            // 
            txtCommand.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCommand.Location = new Point(18, 36);
            txtCommand.Name = "txtCommand";
            txtCommand.ReadOnly = true;
            txtCommand.Size = new Size(613, 23);
            txtCommand.TabIndex = 3;
            // 
            // btnPreview
            // 
            btnPreview.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPreview.Location = new Point(536, 501);
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
            btnAbout.Location = new Point(29, 501);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(75, 23);
            btnAbout.TabIndex = 11;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(724, 536);
            Controls.Add(btnAbout);
            Controls.Add(btnPreview);
            Controls.Add(grpOutput);
            Controls.Add(grpOptions);
            Controls.Add(btnStartCopy);
            Name = "MainForm";
            Text = "Grobocopy v" + version;
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
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
                return ("-1");

            }
            string command = $"\"{source}\" \"{destination}\" /E /R:0 /W:0";
            return command;

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

        private string version = "0.02";

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

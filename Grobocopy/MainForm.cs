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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtSource
            // 
            txtSource.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSource.Location = new Point(127, 27);
            txtSource.Name = "txtSource";
            txtSource.PlaceholderText = "Source";
            txtSource.Size = new Size(411, 23);
            txtSource.TabIndex = 0;
            // 
            // txtDestination
            // 
            txtDestination.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDestination.Location = new Point(127, 72);
            txtDestination.Name = "txtDestination";
            txtDestination.PlaceholderText = "Destination";
            txtDestination.Size = new Size(411, 23);
            txtDestination.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOutput.Location = new Point(6, 22);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(651, 259);
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
            btnBrowseDesntination.Location = new Point(556, 76);
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
            lblSource.Location = new Point(6, 35);
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
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblSource);
            groupBox1.Controls.Add(lblDestination);
            groupBox1.Controls.Add(txtSource);
            groupBox1.Controls.Add(txtDestination);
            groupBox1.Controls.Add(btnBrowseSource);
            groupBox1.Controls.Add(btnBrowseDesntination);
            groupBox1.Location = new Point(29, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(663, 148);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Job Options";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Location = new Point(29, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(663, 287);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output";
            // 
            // MainForm
            // 
            ClientSize = new Size(724, 536);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnStartCopy);
            Name = "MainForm";
            Text = "Grobocopy v0.01";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
                Arguments = $"\"{source}\" \"{destination}\" /E /R:0 /W:0",
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


        private TextBox txtSource;
        private TextBox txtDestination;
        private TextBox txtOutput;
        private Button btnBrowseSource;
        private Button btnBrowseDesntination;
        private Label lblSource;
        private Label lblDestination;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnStartCopy;
    }
}

using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;

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
        private Label lblANEG;
        private Label lblAPOS;
        private NumericUpDown numMT;
        private SplitContainer splitContainer;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            tabCopy = new TabPage();
            numMT = new NumericUpDown();
            lblAPOS = new Label();
            lblANEG = new Label();
            chkMOVE = new CheckBox();
            label3 = new Label();
            txtIPG = new TextBox();
            txtSPARSE = new TextBox();
            txtDCOPY = new TextBox();
            txtMON = new TextBox();
            txtRH = new TextBox();
            txtMOT = new TextBox();
            txtANEG = new TextBox();
            txtAPOS = new TextBox();
            lblDCOPY = new Label();
            chkNOOFFLOAD = new CheckBox();
            chkCOMPRESS = new CheckBox();
            chkNOCLONE = new CheckBox();
            chkNODCOPY = new CheckBox();
            chkSPARSE = new CheckBox();
            chkDCOPY = new CheckBox();
            chkMT = new CheckBox();
            chkIPG = new CheckBox();
            chkSJ = new CheckBox();
            chkSL = new CheckBox();
            chkPF = new CheckBox();
            chkRH = new CheckBox();
            chkMOT = new CheckBox();
            chkMON = new CheckBox();
            chk256 = new CheckBox();
            chkFAT = new CheckBox();
            chkCREATE = new CheckBox();
            chkANEG = new CheckBox();
            chkAPOS = new CheckBox();
            chkMOV = new CheckBox();
            chkMIR = new CheckBox();
            chkPURGE = new CheckBox();
            chkTIMFIX = new CheckBox();
            chkSECFIX = new CheckBox();
            chkNOCOPY = new CheckBox();
            chkCOPYALL = new CheckBox();
            chkSEC = new CheckBox();
            txtCOPY = new TextBox();
            lblCOPY = new Label();
            chkCOPY = new CheckBox();
            chkEFSRAW = new CheckBox();
            chkJ = new CheckBox();
            chkZB = new CheckBox();
            chkB = new CheckBox();
            chkZ = new CheckBox();
            numLev = new NumericUpDown();
            chkS = new CheckBox();
            chkLev = new CheckBox();
            chkE = new CheckBox();
            tabThrottling = new TabPage();
            tabSelection = new TabPage();
            tabRetry = new TabPage();
            tabLogging = new TabPage();
            tabJob = new TabPage();
            tabRemarks = new TabPage();
            txtRemarks = new Label();
            grpOutput = new GroupBox();
            txtCommand = new TextBox();
            btnPreview = new Button();
            btnAbout = new Button();
            splitContainer = new SplitContainer();
            grpOptions.SuspendLayout();
            tabControl1.SuspendLayout();
            tabCopy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLev).BeginInit();
            tabRemarks.SuspendLayout();
            grpOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // txtSource
            // 
            txtSource.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSource.Location = new Point(134, 29);
            txtSource.Name = "txtSource";
            txtSource.PlaceholderText = "drive:\\path or \\\\server\\share\\path";
            txtSource.Size = new Size(504, 23);
            txtSource.TabIndex = 0;
            // 
            // txtDestination
            // 
            txtDestination.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDestination.Location = new Point(134, 58);
            txtDestination.Name = "txtDestination";
            txtDestination.PlaceholderText = "drive:\\path or \\\\server\\share\\path";
            txtDestination.Size = new Size(504, 23);
            txtDestination.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOutput.BackColor = SystemColors.Window;
            txtOutput.ForeColor = SystemColors.WindowText;
            txtOutput.Location = new Point(14, 70);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(705, 261);
            txtOutput.TabIndex = 2;
            txtOutput.Text = "Command output";
            // 
            // btnBrowseSource
            // 
            btnBrowseSource.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseSource.Location = new Point(644, 29);
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
            btnBrowseDesntination.Location = new Point(644, 57);
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
            btnStartCopy.Location = new Point(618, 349);
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
            lblSource.Location = new Point(13, 33);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(79, 15);
            lblSource.TabIndex = 6;
            lblSource.Text = "Source Folder";
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Location = new Point(13, 62);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(103, 15);
            lblDestination.TabIndex = 7;
            lblDestination.Text = "Destination Folder";
            // 
            // grpOptions
            // 
            grpOptions.Controls.Add(tabControl1);
            grpOptions.Controls.Add(lblSource);
            grpOptions.Controls.Add(lblDestination);
            grpOptions.Controls.Add(txtSource);
            grpOptions.Controls.Add(txtDestination);
            grpOptions.Controls.Add(btnBrowseSource);
            grpOptions.Controls.Add(btnBrowseDesntination);
            grpOptions.Dock = DockStyle.Fill;
            grpOptions.Location = new Point(0, 0);
            grpOptions.Name = "grpOptions";
            grpOptions.Padding = new Padding(10);
            grpOptions.Size = new Size(732, 300);
            grpOptions.TabIndex = 8;
            grpOptions.TabStop = false;
            grpOptions.Text = "Options";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabCopy);
            tabControl1.Controls.Add(tabThrottling);
            tabControl1.Controls.Add(tabSelection);
            tabControl1.Controls.Add(tabRetry);
            tabControl1.Controls.Add(tabLogging);
            tabControl1.Controls.Add(tabJob);
            tabControl1.Controls.Add(tabRemarks);
            tabControl1.Location = new Point(10, 97);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(713, 203);
            tabControl1.TabIndex = 14;
            // 
            // tabCopy
            // 
            tabCopy.AutoScroll = true;
            tabCopy.Controls.Add(numMT);
            tabCopy.Controls.Add(lblAPOS);
            tabCopy.Controls.Add(lblANEG);
            tabCopy.Controls.Add(chkMOVE);
            tabCopy.Controls.Add(label3);
            tabCopy.Controls.Add(txtIPG);
            tabCopy.Controls.Add(txtSPARSE);
            tabCopy.Controls.Add(txtDCOPY);
            tabCopy.Controls.Add(txtMON);
            tabCopy.Controls.Add(txtRH);
            tabCopy.Controls.Add(txtMOT);
            tabCopy.Controls.Add(txtANEG);
            tabCopy.Controls.Add(txtAPOS);
            tabCopy.Controls.Add(lblDCOPY);
            tabCopy.Controls.Add(chkNOOFFLOAD);
            tabCopy.Controls.Add(chkCOMPRESS);
            tabCopy.Controls.Add(chkNOCLONE);
            tabCopy.Controls.Add(chkNODCOPY);
            tabCopy.Controls.Add(chkSPARSE);
            tabCopy.Controls.Add(chkDCOPY);
            tabCopy.Controls.Add(chkMT);
            tabCopy.Controls.Add(chkIPG);
            tabCopy.Controls.Add(chkSJ);
            tabCopy.Controls.Add(chkSL);
            tabCopy.Controls.Add(chkPF);
            tabCopy.Controls.Add(chkRH);
            tabCopy.Controls.Add(chkMOT);
            tabCopy.Controls.Add(chkMON);
            tabCopy.Controls.Add(chk256);
            tabCopy.Controls.Add(chkFAT);
            tabCopy.Controls.Add(chkCREATE);
            tabCopy.Controls.Add(chkANEG);
            tabCopy.Controls.Add(chkAPOS);
            tabCopy.Controls.Add(chkMOV);
            tabCopy.Controls.Add(chkMIR);
            tabCopy.Controls.Add(chkPURGE);
            tabCopy.Controls.Add(chkTIMFIX);
            tabCopy.Controls.Add(chkSECFIX);
            tabCopy.Controls.Add(chkNOCOPY);
            tabCopy.Controls.Add(chkCOPYALL);
            tabCopy.Controls.Add(chkSEC);
            tabCopy.Controls.Add(txtCOPY);
            tabCopy.Controls.Add(lblCOPY);
            tabCopy.Controls.Add(chkCOPY);
            tabCopy.Controls.Add(chkEFSRAW);
            tabCopy.Controls.Add(chkJ);
            tabCopy.Controls.Add(chkZB);
            tabCopy.Controls.Add(chkB);
            tabCopy.Controls.Add(chkZ);
            tabCopy.Controls.Add(numLev);
            tabCopy.Controls.Add(chkS);
            tabCopy.Controls.Add(chkLev);
            tabCopy.Controls.Add(chkE);
            tabCopy.Location = new Point(4, 24);
            tabCopy.Name = "tabCopy";
            tabCopy.Padding = new Padding(3);
            tabCopy.Size = new Size(705, 175);
            tabCopy.TabIndex = 0;
            tabCopy.Text = "Copy";
            tabCopy.UseVisualStyleBackColor = true;
            // 
            // numMT
            // 
            numMT.Location = new Point(38, 1128);
            numMT.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            numMT.Name = "numMT";
            numMT.Size = new Size(43, 23);
            numMT.TabIndex = 63;
            numMT.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // lblAPOS
            // 
            lblAPOS.AutoSize = true;
            lblAPOS.Location = new Point(30, 614);
            lblAPOS.Name = "lblAPOS";
            lblAPOS.Size = new Size(502, 15);
            lblAPOS.TabIndex = 62;
            lblAPOS.Text = "Read only, Archive, System, Hidden, Compressed, Not content indexed, Encrypted, Temporary";
            // 
            // lblANEG
            // 
            lblANEG.AutoSize = true;
            lblANEG.Location = new Point(24, 696);
            lblANEG.Name = "lblANEG";
            lblANEG.Size = new Size(544, 15);
            lblANEG.TabIndex = 61;
            lblANEG.Text = "Read only, Archive, System, Hidden, Compressed, Not content indexed, Encrypted, Temporary, Offline";
            // 
            // chkMOVE
            // 
            chkMOVE.AutoSize = true;
            chkMOVE.Location = new Point(7, 540);
            chkMOVE.Name = "chkMOVE";
            chkMOVE.Size = new Size(366, 19);
            chkMOVE.TabIndex = 60;
            chkMOVE.Text = "/MOVE :: MOVE files AND dirs (delete from source after copying)";
            chkMOVE.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 1164);
            label3.Name = "label3";
            label3.Size = new Size(343, 45);
            label3.TabIndex = 50;
            label3.Text = "n must be at least 1 and not greater than 128.\r\nThis option is incompatible with the /IPG and /EFSRAW options.\r\nRedirect output using /LOG option for better performance.";
            // 
            // txtIPG
            // 
            txtIPG.Location = new Point(36, 1012);
            txtIPG.Name = "txtIPG";
            txtIPG.PlaceholderText = "n";
            txtIPG.Size = new Size(103, 23);
            txtIPG.TabIndex = 59;
            // 
            // txtSPARSE
            // 
            txtSPARSE.Location = new Point(29, 1392);
            txtSPARSE.Name = "txtSPARSE";
            txtSPARSE.PlaceholderText = "Y/N";
            txtSPARSE.Size = new Size(40, 23);
            txtSPARSE.TabIndex = 58;
            // 
            // txtDCOPY
            // 
            txtDCOPY.Location = new Point(45, 1237);
            txtDCOPY.Name = "txtDCOPY";
            txtDCOPY.PlaceholderText = "copyflag[s]";
            txtDCOPY.Size = new Size(89, 23);
            txtDCOPY.TabIndex = 57;
            // 
            // txtMON
            // 
            txtMON.Location = new Point(39, 820);
            txtMON.Name = "txtMON";
            txtMON.PlaceholderText = "n";
            txtMON.Size = new Size(94, 23);
            txtMON.TabIndex = 56;
            // 
            // txtRH
            // 
            txtRH.Location = new Point(39, 922);
            txtRH.Name = "txtRH";
            txtRH.PlaceholderText = "hhmm-hhmm";
            txtRH.Size = new Size(100, 23);
            txtRH.TabIndex = 55;
            // 
            // txtMOT
            // 
            txtMOT.Location = new Point(39, 872);
            txtMOT.Name = "txtMOT";
            txtMOT.PlaceholderText = "m";
            txtMOT.Size = new Size(94, 23);
            txtMOT.TabIndex = 54;
            // 
            // txtANEG
            // 
            txtANEG.Location = new Point(24, 670);
            txtANEG.Name = "txtANEG";
            txtANEG.PlaceholderText = "RASHCNETO";
            txtANEG.Size = new Size(100, 23);
            txtANEG.TabIndex = 53;
            // 
            // txtAPOS
            // 
            txtAPOS.Location = new Point(34, 588);
            txtAPOS.Name = "txtAPOS";
            txtAPOS.PlaceholderText = "RASHCNET";
            txtAPOS.Size = new Size(100, 23);
            txtAPOS.TabIndex = 52;
            // 
            // lblDCOPY
            // 
            lblDCOPY.AutoSize = true;
            lblDCOPY.Location = new Point(45, 1263);
            lblDCOPY.Name = "lblDCOPY";
            lblDCOPY.Size = new Size(378, 15);
            lblDCOPY.TabIndex = 51;
            lblDCOPY.Text = " D=Data, A=Attributes, T=Timestamps, E=EAs, X=Skip alt data streams";
            // 
            // chkNOOFFLOAD
            // 
            chkNOOFFLOAD.AutoSize = true;
            chkNOOFFLOAD.Location = new Point(8, 1317);
            chkNOOFFLOAD.Name = "chkNOOFFLOAD";
            chkNOOFFLOAD.Size = new Size(450, 19);
            chkNOOFFLOAD.TabIndex = 49;
            chkNOOFFLOAD.Text = "/NOOFFLOAD :: copy files without using the Windows Copy Offload mechanism";
            chkNOOFFLOAD.UseVisualStyleBackColor = true;
            // 
            // chkCOMPRESS
            // 
            chkCOMPRESS.AutoSize = true;
            chkCOMPRESS.Location = new Point(8, 1342);
            chkCOMPRESS.Name = "chkCOMPRESS";
            chkCOMPRESS.Size = new Size(432, 19);
            chkCOMPRESS.TabIndex = 48;
            chkCOMPRESS.Text = "/COMPRESS :: Request network compression during file transfer, if applicable";
            chkCOMPRESS.UseVisualStyleBackColor = true;
            // 
            // chkNOCLONE
            // 
            chkNOCLONE.AutoSize = true;
            chkNOCLONE.Location = new Point(8, 1422);
            chkNOCLONE.Name = "chkNOCLONE";
            chkNOCLONE.Size = new Size(355, 19);
            chkNOCLONE.TabIndex = 47;
            chkNOCLONE.Text = "/NOCLONE :: Do not attempt block cloning as an optimization";
            chkNOCLONE.UseVisualStyleBackColor = true;
            // 
            // chkNODCOPY
            // 
            chkNODCOPY.AutoSize = true;
            chkNODCOPY.Location = new Point(8, 1292);
            chkNODCOPY.Name = "chkNODCOPY";
            chkNODCOPY.Size = new Size(400, 19);
            chkNODCOPY.TabIndex = 46;
            chkNODCOPY.Text = " /NODCOPY :: COPY NO directory info (by default /DCOPY:DA is done)";
            chkNODCOPY.UseVisualStyleBackColor = true;
            // 
            // chkSPARSE
            // 
            chkSPARSE.AutoSize = true;
            chkSPARSE.Location = new Point(8, 1367);
            chkSPARSE.Name = "chkSPARSE";
            chkSPARSE.Size = new Size(404, 19);
            chkSPARSE.TabIndex = 45;
            chkSPARSE.Text = "/SPARSE[:Y/N] :: Enable or disable retaining the sparse state during copy";
            chkSPARSE.UseVisualStyleBackColor = true;
            // 
            // chkDCOPY
            // 
            chkDCOPY.AutoSize = true;
            chkDCOPY.Location = new Point(8, 1212);
            chkDCOPY.Name = "chkDCOPY";
            chkDCOPY.Size = new Size(422, 19);
            chkDCOPY.TabIndex = 44;
            chkDCOPY.Text = " /DCOPY:copyflag[s] :: what to COPY for directories (default is /DCOPY:DA)";
            chkDCOPY.UseVisualStyleBackColor = true;
            // 
            // chkMT
            // 
            chkMT.AutoSize = true;
            chkMT.Location = new Point(8, 1099);
            chkMT.Name = "chkMT";
            chkMT.Size = new Size(349, 19);
            chkMT.TabIndex = 43;
            chkMT.Text = "/MT[:n] :: Do multi-threaded copies with n threads (default 8)";
            chkMT.UseVisualStyleBackColor = true;
            // 
            // chkIPG
            // 
            chkIPG.AutoSize = true;
            chkIPG.Location = new Point(8, 987);
            chkIPG.Name = "chkIPG";
            chkIPG.Size = new Size(357, 19);
            chkIPG.TabIndex = 42;
            chkIPG.Text = "/IPG:n :: Inter-Packet Gap (ms), to free bandwidth on slow lines";
            chkIPG.UseVisualStyleBackColor = true;
            // 
            // chkSJ
            // 
            chkSJ.AutoSize = true;
            chkSJ.Location = new Point(8, 1047);
            chkSJ.Name = "chkSJ";
            chkSJ.Size = new Size(373, 19);
            chkSJ.TabIndex = 41;
            chkSJ.Text = "/SJ :: copy Junctions as junctions instead of as the junction targets";
            chkSJ.UseVisualStyleBackColor = true;
            // 
            // chkSL
            // 
            chkSL.AutoSize = true;
            chkSL.Location = new Point(8, 1072);
            chkSL.Name = "chkSL";
            chkSL.Size = new Size(354, 19);
            chkSL.TabIndex = 40;
            chkSL.Text = "/SL :: copy Symbolic Links as links instead of as the link targets";
            chkSL.UseVisualStyleBackColor = true;
            // 
            // chkPF
            // 
            chkPF.AutoSize = true;
            chkPF.Location = new Point(8, 962);
            chkPF.Name = "chkPF";
            chkPF.Size = new Size(312, 19);
            chkPF.TabIndex = 39;
            chkPF.Text = "/PF :: check run hours on a Per File (not per pass) basis";
            chkPF.UseVisualStyleBackColor = true;
            // 
            // chkRH
            // 
            chkRH.AutoSize = true;
            chkRH.Location = new Point(8, 897);
            chkRH.Name = "chkRH";
            chkRH.Size = new Size(410, 19);
            chkRH.TabIndex = 38;
            chkRH.Text = "/RH:hhmm-hhmm :: Run Hours - times when new copies may be started";
            chkRH.UseVisualStyleBackColor = true;
            // 
            // chkMOT
            // 
            chkMOT.AutoSize = true;
            chkMOT.Location = new Point(8, 847);
            chkMOT.Name = "chkMOT";
            chkMOT.Size = new Size(387, 19);
            chkMOT.TabIndex = 37;
            chkMOT.Text = "/MOT:m :: MOnitor source; run again in m minutes Time, if changed";
            chkMOT.UseVisualStyleBackColor = true;
            // 
            // chkMON
            // 
            chkMON.AutoSize = true;
            chkMON.Location = new Point(8, 802);
            chkMON.Name = "chkMON";
            chkMON.Size = new Size(397, 19);
            chkMON.TabIndex = 36;
            chkMON.Text = "/MON:n :: MONitor source; run again when more than n changes seen";
            chkMON.UseVisualStyleBackColor = true;
            // 
            // chk256
            // 
            chk256.AutoSize = true;
            chk256.Location = new Point(8, 777);
            chk256.Name = "chk256";
            chk256.Size = new Size(321, 19);
            chk256.TabIndex = 35;
            chk256.Text = "/256 :: turn off very long path (> 256 characters) support";
            chk256.UseVisualStyleBackColor = true;
            // 
            // chkFAT
            // 
            chkFAT.AutoSize = true;
            chkFAT.Location = new Point(8, 752);
            chkFAT.Name = "chkFAT";
            chkFAT.Size = new Size(335, 19);
            chkFAT.TabIndex = 34;
            chkFAT.Text = "/FAT :: create destination files using 8.3 FAT file names only";
            chkFAT.UseVisualStyleBackColor = true;
            // 
            // chkCREATE
            // 
            chkCREATE.AutoSize = true;
            chkCREATE.Location = new Point(8, 727);
            chkCREATE.Name = "chkCREATE";
            chkCREATE.Size = new Size(335, 19);
            chkCREATE.TabIndex = 33;
            chkCREATE.Text = "/CREATE :: CREATE directory tree and zero-length files only";
            chkCREATE.UseVisualStyleBackColor = true;
            // 
            // chkANEG
            // 
            chkANEG.AutoSize = true;
            chkANEG.Location = new Point(6, 645);
            chkANEG.Name = "chkANEG";
            chkANEG.Size = new Size(371, 19);
            chkANEG.TabIndex = 32;
            chkANEG.Text = "/A-:[RASHCNETO]:: remove the given Attributes from copied files";
            chkANEG.UseVisualStyleBackColor = true;
            // 
            // chkAPOS
            // 
            chkAPOS.AutoSize = true;
            chkAPOS.Location = new Point(8, 565);
            chkAPOS.Name = "chkAPOS";
            chkAPOS.Size = new Size(334, 19);
            chkAPOS.TabIndex = 31;
            chkAPOS.Text = "/A+:[RASHCNET] :: add the given Attributes to copied files";
            chkAPOS.UseVisualStyleBackColor = true;
            // 
            // chkMOV
            // 
            chkMOV.AutoSize = true;
            chkMOV.Location = new Point(8, 515);
            chkMOV.Name = "chkMOV";
            chkMOV.Size = new Size(309, 19);
            chkMOV.TabIndex = 29;
            chkMOV.Text = "/MOV :: MOVe files (delete from source after copying)";
            chkMOV.UseVisualStyleBackColor = true;
            // 
            // chkMIR
            // 
            chkMIR.AutoSize = true;
            chkMIR.Location = new Point(8, 490);
            chkMIR.Name = "chkMIR";
            chkMIR.Size = new Size(345, 19);
            chkMIR.TabIndex = 28;
            chkMIR.Text = "/MIR :: MIRror a directory tree (equivalent to /E plus /PURGE)";
            chkMIR.UseVisualStyleBackColor = true;
            // 
            // chkPURGE
            // 
            chkPURGE.AutoSize = true;
            chkPURGE.Location = new Point(8, 465);
            chkPURGE.Name = "chkPURGE";
            chkPURGE.Size = new Size(339, 19);
            chkPURGE.TabIndex = 27;
            chkPURGE.Text = "/PURGE :: delete dest files/dirs that no longer exist in source";
            chkPURGE.UseVisualStyleBackColor = true;
            // 
            // chkTIMFIX
            // 
            chkTIMFIX.AutoSize = true;
            chkTIMFIX.Location = new Point(8, 440);
            chkTIMFIX.Name = "chkTIMFIX";
            chkTIMFIX.Size = new Size(305, 19);
            chkTIMFIX.TabIndex = 26;
            chkTIMFIX.Text = "/TIMFIX :: FIX file TIMes on all files, even skipped files";
            chkTIMFIX.UseVisualStyleBackColor = true;
            // 
            // chkSECFIX
            // 
            chkSECFIX.AutoSize = true;
            chkSECFIX.Location = new Point(8, 415);
            chkSECFIX.Name = "chkSECFIX";
            chkSECFIX.Size = new Size(316, 19);
            chkSECFIX.TabIndex = 25;
            chkSECFIX.Text = "/SECFIX :: FIX file SECurity on all files, even skipped files";
            chkSECFIX.UseVisualStyleBackColor = true;
            // 
            // chkNOCOPY
            // 
            chkNOCOPY.AutoSize = true;
            chkNOCOPY.Location = new Point(8, 390);
            chkNOCOPY.Name = "chkNOCOPY";
            chkNOCOPY.Size = new Size(300, 19);
            chkNOCOPY.TabIndex = 24;
            chkNOCOPY.Text = "/NOCOPY :: COPY NO file info (useful with /PURGE)";
            chkNOCOPY.UseVisualStyleBackColor = true;
            // 
            // chkCOPYALL
            // 
            chkCOPYALL.AutoSize = true;
            chkCOPYALL.Location = new Point(8, 365);
            chkCOPYALL.Name = "chkCOPYALL";
            chkCOPYALL.Size = new Size(357, 19);
            chkCOPYALL.TabIndex = 23;
            chkCOPYALL.Text = "/COPYALL :: COPY ALL file info (equivalent to /COPY:DATSOU)";
            chkCOPYALL.UseVisualStyleBackColor = true;
            // 
            // chkSEC
            // 
            chkSEC.AutoSize = true;
            chkSEC.Location = new Point(7, 341);
            chkSEC.Name = "chkSEC";
            chkSEC.Size = new Size(336, 19);
            chkSEC.TabIndex = 22;
            chkSEC.Text = "/SEC :: copy files with SECurity (equivalent to /COPY:DATS)";
            chkSEC.UseVisualStyleBackColor = true;
            // 
            // txtCOPY
            // 
            txtCOPY.Location = new Point(34, 275);
            txtCOPY.Name = "txtCOPY";
            txtCOPY.PlaceholderText = "copyflag[s]";
            txtCOPY.Size = new Size(94, 23);
            txtCOPY.TabIndex = 21;
            // 
            // lblCOPY
            // 
            lblCOPY.AutoSize = true;
            lblCOPY.Location = new Point(34, 301);
            lblCOPY.Name = "lblCOPY";
            lblCOPY.Size = new Size(455, 30);
            lblCOPY.TabIndex = 19;
            lblCOPY.Text = "D=Data, A=Attributes, T=Timestamps, X=Skip alt data streams (X ignored if /B or /ZB\r\nS=Security=NTFS ACLs, O=Owner info, U=aUditing info";
            // 
            // chkCOPY
            // 
            chkCOPY.AutoSize = true;
            chkCOPY.Location = new Point(9, 252);
            chkCOPY.Name = "chkCOPY";
            chkCOPY.Size = new Size(375, 19);
            chkCOPY.TabIndex = 18;
            chkCOPY.Text = "/COPY:copyflag[s] :: what to COPY for files (default is /COPY:DAT)";
            chkCOPY.UseVisualStyleBackColor = true;
            // 
            // chkEFSRAW
            // 
            chkEFSRAW.AutoSize = true;
            chkEFSRAW.Location = new Point(8, 228);
            chkEFSRAW.Name = "chkEFSRAW";
            chkEFSRAW.Size = new Size(303, 19);
            chkEFSRAW.TabIndex = 17;
            chkEFSRAW.Text = "/EFSRAW :: copy all encrypted files in EFS RAW mode";
            chkEFSRAW.UseVisualStyleBackColor = true;
            // 
            // chkJ
            // 
            chkJ.AutoSize = true;
            chkJ.Location = new Point(8, 203);
            chkJ.Name = "chkJ";
            chkJ.Size = new Size(350, 19);
            chkJ.TabIndex = 16;
            chkJ.Text = " /J :: copy using unbuffered I/O (recommended for large files)";
            chkJ.UseVisualStyleBackColor = true;
            // 
            // chkZB
            // 
            chkZB.AutoSize = true;
            chkZB.Location = new Point(8, 178);
            chkZB.Name = "chkZB";
            chkZB.Size = new Size(353, 19);
            chkZB.TabIndex = 15;
            chkZB.Text = "/ZB :: use restartable mode; if access denied use Backup mode";
            chkZB.UseVisualStyleBackColor = true;
            // 
            // chkB
            // 
            chkB.AutoSize = true;
            chkB.Location = new Point(8, 153);
            chkB.Name = "chkB";
            chkB.Size = new Size(189, 19);
            chkB.TabIndex = 14;
            chkB.Text = "/B :: copy files in Backup mode";
            chkB.UseVisualStyleBackColor = true;
            // 
            // chkZ
            // 
            chkZ.AutoSize = true;
            chkZ.Location = new Point(8, 128);
            chkZ.Name = "chkZ";
            chkZ.Size = new Size(205, 19);
            chkZ.TabIndex = 13;
            chkZ.Text = "/Z :: copy files in restartable mode";
            chkZ.UseVisualStyleBackColor = true;
            // 
            // numLev
            // 
            numLev.Location = new Point(33, 88);
            numLev.Name = "numLev";
            numLev.Size = new Size(47, 23);
            numLev.TabIndex = 12;
            // 
            // chkS
            // 
            chkS.AutoSize = true;
            chkS.Location = new Point(8, 13);
            chkS.Name = "chkS";
            chkS.Size = new Size(263, 19);
            chkS.TabIndex = 9;
            chkS.Text = "/S :: copy Subdirectories, but not empty ones";
            chkS.UseVisualStyleBackColor = true;
            chkS.CheckedChanged += chkS_CheckedChanged;
            // 
            // chkLev
            // 
            chkLev.AutoSize = true;
            chkLev.Location = new Point(8, 63);
            chkLev.Name = "chkLev";
            chkLev.Size = new Size(358, 19);
            chkLev.TabIndex = 10;
            chkLev.Text = " /LEV:n :: only copy the top n LEVels of the source directory tree";
            chkLev.UseVisualStyleBackColor = true;
            // 
            // chkE
            // 
            chkE.AutoSize = true;
            chkE.Location = new Point(8, 38);
            chkE.Name = "chkE";
            chkE.Size = new Size(273, 19);
            chkE.TabIndex = 8;
            chkE.Text = "/E :: copy subdirectories, including Empty ones";
            chkE.UseVisualStyleBackColor = true;
            // 
            // tabThrottling
            // 
            tabThrottling.Location = new Point(4, 24);
            tabThrottling.Name = "tabThrottling";
            tabThrottling.Padding = new Padding(3);
            tabThrottling.Size = new Size(705, 175);
            tabThrottling.TabIndex = 1;
            tabThrottling.Text = "File Throttling";
            tabThrottling.UseVisualStyleBackColor = true;
            // 
            // tabSelection
            // 
            tabSelection.Location = new Point(4, 24);
            tabSelection.Name = "tabSelection";
            tabSelection.Size = new Size(705, 175);
            tabSelection.TabIndex = 2;
            tabSelection.Text = "File Selection";
            tabSelection.UseVisualStyleBackColor = true;
            // 
            // tabRetry
            // 
            tabRetry.Location = new Point(4, 24);
            tabRetry.Name = "tabRetry";
            tabRetry.Size = new Size(705, 175);
            tabRetry.TabIndex = 3;
            tabRetry.Text = "Retry";
            tabRetry.UseVisualStyleBackColor = true;
            // 
            // tabLogging
            // 
            tabLogging.Location = new Point(4, 24);
            tabLogging.Name = "tabLogging";
            tabLogging.Size = new Size(705, 175);
            tabLogging.TabIndex = 4;
            tabLogging.Text = "Logging";
            tabLogging.UseVisualStyleBackColor = true;
            // 
            // tabJob
            // 
            tabJob.Location = new Point(4, 24);
            tabJob.Name = "tabJob";
            tabJob.Size = new Size(705, 175);
            tabJob.TabIndex = 5;
            tabJob.Text = "Job";
            tabJob.UseVisualStyleBackColor = true;
            // 
            // tabRemarks
            // 
            tabRemarks.AutoScroll = true;
            tabRemarks.Controls.Add(txtRemarks);
            tabRemarks.Location = new Point(4, 24);
            tabRemarks.Name = "tabRemarks";
            tabRemarks.Size = new Size(705, 175);
            tabRemarks.TabIndex = 6;
            tabRemarks.Text = "Remarks";
            tabRemarks.UseVisualStyleBackColor = true;
            // 
            // txtRemarks
            // 
            txtRemarks.AutoSize = true;
            txtRemarks.Location = new Point(120, 16);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(429, 525);
            txtRemarks.TabIndex = 0;
            txtRemarks.Text = resources.GetString("txtRemarks.Text");
            // 
            // grpOutput
            // 
            grpOutput.Controls.Add(txtCommand);
            grpOutput.Controls.Add(btnPreview);
            grpOutput.Controls.Add(btnStartCopy);
            grpOutput.Controls.Add(txtOutput);
            grpOutput.Dock = DockStyle.Fill;
            grpOutput.Location = new Point(0, 0);
            grpOutput.Name = "grpOutput";
            grpOutput.Padding = new Padding(10);
            grpOutput.Size = new Size(732, 385);
            grpOutput.TabIndex = 9;
            grpOutput.TabStop = false;
            grpOutput.Text = "Output";
            // 
            // txtCommand
            // 
            txtCommand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCommand.BackColor = SystemColors.Window;
            txtCommand.ForeColor = SystemColors.WindowText;
            txtCommand.Location = new Point(14, 30);
            txtCommand.Name = "txtCommand";
            txtCommand.ReadOnly = true;
            txtCommand.Size = new Size(705, 23);
            txtCommand.TabIndex = 3;
            txtCommand.Text = "Command preview";
            // 
            // btnPreview
            // 
            btnPreview.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPreview.Location = new Point(527, 350);
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
            btnAbout.Location = new Point(29, 654);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(75, 23);
            btnAbout.TabIndex = 11;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(grpOptions);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(grpOutput);
            splitContainer.Size = new Size(732, 689);
            splitContainer.SplitterDistance = 300;
            splitContainer.TabIndex = 12;
            // 
            // MainForm
            // 
            ClientSize = new Size(732, 689);
            Controls.Add(btnAbout);
            Controls.Add(splitContainer);
            Name = "MainForm";
            Text = "Grobocopy";
            Load += MainForm_Load;
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabCopy.ResumeLayout(false);
            tabCopy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMT).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLev).EndInit();
            tabRemarks.ResumeLayout(false);
            tabRemarks.PerformLayout();
            grpOutput.ResumeLayout(false);
            grpOutput.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
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
                        this.Invoke((System.Windows.Forms.MethodInvoker)delegate
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

            // Base arguments
            string arguments = $"\"{source}\" \"{destination}\"";

            // Add other switches based on checkboxes
            if (chkS.Checked)
            {
                arguments += " /S";
            }
            if (chkE.Checked)
            if (chkE.Checked)
            {
                arguments += " /E";
            }            
            if (chkLev.Checked)
            {
                arguments += " /LEV:" + numLev.Value;
            }            
            if (chkZ.Checked)
            {
                arguments += " /Z";
            }
            if (chkB.Checked)
            {
                arguments += " /B";
            }
            if (chkZB.Checked)
            {
                arguments += " /ZB";
            }
            if (chkJ.Checked)
            {
                arguments += " /J";
            }
            if (chkEFSRAW.Checked)
            {
                arguments += " /EFSRAW";
            }
            if (chkCOPY.Checked)
            {
                arguments += " /COPY:" + txtCOPY.Text;
            }
            if (chkSEC.Checked)
            {
                arguments += " /SEC";
            }
            if (chkCOPYALL.Checked)
            {
                arguments += " /COPYALL";
            }
            if (chkNOCOPY.Checked)
            {
                arguments += " /NOCOPY";
            }
            if (chkSECFIX.Checked)
            {
                arguments += " /SECFIX";
            }
            if (chkTIMFIX.Checked)
            {
                arguments += " /TIMFIX";
            }
            if (chkPURGE.Checked)
            {
                arguments += " /PURGE";
            }
            if (chkMIR.Checked)
            {
                arguments += " /MIR";
            }
            if (chkMOV.Checked)
            {
                arguments += " /MOV";
            }
            if (chkMOVE.Checked)
            {
                arguments += " /MOVE";
            }
            if (chkAPOS.Checked)
            {
                arguments += " /A+:" + txtAPOS.Text;
            }
            if (chkANEG.Checked)
            {
                arguments += " /A-:" + txtANEG.Text;
            }
            if (chkCREATE.Checked)
            {
                arguments += " /CREATE";
            }
            if (chkFAT.Checked)
            {
                arguments += " /FAT";
            }
            if (chk256.Checked)
            {
                arguments += " /256";
            }
            if (chkMON.Checked)
            {
                arguments += " /MON:" + txtMON.Text;
            }
            if (chkMOT.Checked)
            {
                arguments += " /MOT:" + txtMOT.Text;
            }
            if (chkRH.Checked)
            {
                arguments += " /RH:" + txtRH.Text;
            }
            if (chkPF.Checked)
            {
                arguments += " /PF";
            }
            if (chkIPG.Checked)
            {
                arguments += " /IPG:" + txtIPG.Text;
            }
            if (chkSJ.Checked)
            {
                arguments += " /SJ";
            }
            if (chkSL.Checked)
            {
                arguments += " /SL";
            }
            if (chkMT.Checked)
            {
                arguments += " /MT:" + numMT.Text;
            }
            if (chkDCOPY.Checked)
            {
                arguments += " /DCOPY:" + txtDCOPY.Text;
            }
            if (chkNOCOPY.Checked)
            {
                arguments += " /NOCOPY";
            }
            if (chkNOOFFLOAD.Checked)
            {
                arguments += " /NOOFFLOAD";
            }
            if (chkCOMPRESS.Checked)
            {
                arguments += " /COMPRESS";
            }
            if (chkSPARSE.Checked)
            {
                arguments += " /SPARSE:" + txtSPARSE.Text;
            }
            if (chkNOCLONE.Checked)
            {
                arguments += " /NOCLONE";
            }




            // Add other default switches
            //arguments += " /R:0 /W:0";

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
        private TabPage tabCopy;
        private TabPage tabThrottling;
        private CheckBox chkZB;
        private CheckBox chkB;
        private CheckBox chkZ;
        private CheckBox chkJ;
        private TextBox txtCOPY;
        private Label lblCOPY;
        private CheckBox chkCOPY;
        private CheckBox chkEFSRAW;
        private CheckBox chkTIMFIX;
        private CheckBox chkSECFIX;
        private CheckBox chkNOCOPY;
        private CheckBox chkCOPYALL;
        private CheckBox chkSEC;
        private CheckBox chkMOV;
        private CheckBox chkMIR;
        private CheckBox chkPURGE;
        private CheckBox chkPF;
        private CheckBox chkRH;
        private CheckBox chkMOT;
        private CheckBox chkMON;
        private CheckBox chk256;
        private CheckBox chkFAT;
        private CheckBox chkCREATE;
        private CheckBox chkANEG;
        private CheckBox chkAPOS;
        private CheckBox chkIPG;
        private CheckBox chkSJ;
        private CheckBox chkSL;
        private Label label3;
        private CheckBox chkNOOFFLOAD;
        private CheckBox chkCOMPRESS;
        private CheckBox chkNOCLONE;
        private CheckBox chkNODCOPY;
        private CheckBox chkSPARSE;
        private CheckBox chkDCOPY;
        private CheckBox chkMT;
        private Label lblDCOPY;
        private TextBox txtRH;
        private TextBox txtMOT;
        private TextBox txtANEG;
        private TextBox txtAPOS;
        private TextBox txtSPARSE;
        private TextBox txtDCOPY;
        private TextBox txtMON;
        private TextBox txtIPG;
        private CheckBox chkMOVE;
        private TabPage tabSelection;
        private TabPage tabRetry;
        private Label txtRemarks;
        private TabPage tabLogging;
        private TabPage tabJob;
        private TabPage tabRemarks;

        //get version
       private string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
       //private string version = "0.04";

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

        private void chkS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

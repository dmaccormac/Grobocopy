using System.Diagnostics;

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
        private TextBox txtIoMaxSize;
        private CheckBox chkThreshold;
        private CheckBox chkIoRate;
        private CheckBox chkIoMaxSize;
        private TextBox txtIoRate;
        private TextBox txtThreshold;
        private TextBox txtXA;
        private TextBox txtIA;
        private CheckBox chkDST;
        private CheckBox chkFFT;
        private CheckBox chkXX;
        private CheckBox chkXO;
        private CheckBox chkXL;
        private CheckBox chkXN;
        private CheckBox chkXC;
        private CheckBox chkIS;
        private CheckBox chkMIN;
        private CheckBox chkXD;
        private CheckBox chkXF;
        private CheckBox chkXA;
        private CheckBox chkIA;
        private CheckBox chkM;
        private CheckBox chkA;
        private Label lblIA;
        private Label label1;
        private TextBox txtXD;
        private TextBox txtXF;
        private CheckBox chkIT;
        private TextBox txtMIN;
        private TextBox txtMAXLAD;
        private CheckBox chkMINLAD;
        private CheckBox chkMAX;
        private CheckBox chkMAXAGE;
        private CheckBox chkMAXLAD;
        private CheckBox chkMINAGE;
        private TextBox txtMAXAGE;
        private TextBox txtMINAGE;
        private TextBox txtMAX;
        private CheckBox chkXJF;
        private CheckBox chkIM;
        private TextBox txtMINLAD;
        private Label lblMINLAD;
        private CheckBox chkXJ;
        private CheckBox chkXJD;
        private CheckBox chkLFSMn;
        private CheckBox chkLFSM;
        private CheckBox chkTBD;
        private CheckBox chkREG;
        private CheckBox chkW;
        private CheckBox chkR;
        private TextBox txtLFSMn;
        private TextBox txtW;
        private TextBox txtR;
        private TextBox textBox1;
        private Button button1;
        private CheckBox chkFP;
        private CheckBox chkTS;
        private CheckBox chkV;
        private CheckBox chkX;
        private CheckBox chkL;
        private CheckBox chkNFL;
        private CheckBox chkNC;
        private CheckBox chkNS;
        private CheckBox chkBYTES;
        private TextBox txtUNILOGAPPEND;
        private TextBox txtUNILOG;
        private TextBox txtLOGAPPEND;
        private TextBox txtLOG;
        private CheckBox chkUNILOGAPPEND;
        private CheckBox chkUNILOG;
        private CheckBox chkLOGAPPEND;
        private CheckBox chkLOG;
        private CheckBox chkETA;
        private CheckBox chkNP;
        private CheckBox chkNDL;
        private CheckBox chkUNICODE;
        private CheckBox chkNJS;
        private CheckBox chkNJH;
        private CheckBox chkTEE;
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
            txtThreshold = new TextBox();
            txtIoRate = new TextBox();
            txtIoMaxSize = new TextBox();
            chkThreshold = new CheckBox();
            chkIoRate = new CheckBox();
            chkIoMaxSize = new CheckBox();
            tabSelection = new TabPage();
            chkXJ = new CheckBox();
            chkXJD = new CheckBox();
            lblMINLAD = new Label();
            txtMINLAD = new TextBox();
            txtMAX = new TextBox();
            txtMIN = new TextBox();
            txtMAXAGE = new TextBox();
            txtMAXLAD = new TextBox();
            txtMINAGE = new TextBox();
            chkMINLAD = new CheckBox();
            chkMINAGE = new CheckBox();
            chkMAXLAD = new CheckBox();
            chkMAXAGE = new CheckBox();
            chkMAX = new CheckBox();
            chkXJF = new CheckBox();
            chkIM = new CheckBox();
            chkIT = new CheckBox();
            txtXD = new TextBox();
            txtXF = new TextBox();
            label1 = new Label();
            lblIA = new Label();
            txtXA = new TextBox();
            txtIA = new TextBox();
            chkDST = new CheckBox();
            chkFFT = new CheckBox();
            chkXX = new CheckBox();
            chkXO = new CheckBox();
            chkXL = new CheckBox();
            chkXN = new CheckBox();
            chkXC = new CheckBox();
            chkMIN = new CheckBox();
            chkIS = new CheckBox();
            chkXD = new CheckBox();
            chkXF = new CheckBox();
            chkXA = new CheckBox();
            chkIA = new CheckBox();
            chkM = new CheckBox();
            chkA = new CheckBox();
            tabRetry = new TabPage();
            txtLFSMn = new TextBox();
            txtW = new TextBox();
            txtR = new TextBox();
            chkLFSMn = new CheckBox();
            chkLFSM = new CheckBox();
            chkTBD = new CheckBox();
            chkREG = new CheckBox();
            chkW = new CheckBox();
            chkR = new CheckBox();
            tabLogging = new TabPage();
            tabJob = new TabPage();
            tabRemarks = new TabPage();
            textBox1 = new TextBox();
            grpOutput = new GroupBox();
            button1 = new Button();
            txtCommand = new TextBox();
            btnPreview = new Button();
            btnAbout = new Button();
            splitContainer = new SplitContainer();
            chkFP = new CheckBox();
            chkTS = new CheckBox();
            chkV = new CheckBox();
            chkX = new CheckBox();
            chkL = new CheckBox();
            chkNFL = new CheckBox();
            chkNC = new CheckBox();
            chkNS = new CheckBox();
            chkBYTES = new CheckBox();
            chkETA = new CheckBox();
            chkNP = new CheckBox();
            chkNDL = new CheckBox();
            chkLOG = new CheckBox();
            chkLOGAPPEND = new CheckBox();
            chkUNILOG = new CheckBox();
            chkUNILOGAPPEND = new CheckBox();
            txtLOG = new TextBox();
            txtLOGAPPEND = new TextBox();
            txtUNILOG = new TextBox();
            txtUNILOGAPPEND = new TextBox();
            chkTEE = new CheckBox();
            chkNJH = new CheckBox();
            chkNJS = new CheckBox();
            chkUNICODE = new CheckBox();
            grpOptions.SuspendLayout();
            tabControl1.SuspendLayout();
            tabCopy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLev).BeginInit();
            tabThrottling.SuspendLayout();
            tabSelection.SuspendLayout();
            tabRetry.SuspendLayout();
            tabLogging.SuspendLayout();
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
            tabControl1.Location = new Point(12, 97);
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
            lblAPOS.Size = new Size(505, 15);
            lblAPOS.TabIndex = 62;
            lblAPOS.Text = "Read only, Archive, System, Hidden, Compressed, Not content indexed, Encrypted, Temporary.";
            // 
            // lblANEG
            // 
            lblANEG.AutoSize = true;
            lblANEG.Location = new Point(24, 696);
            lblANEG.Name = "lblANEG";
            lblANEG.Size = new Size(547, 15);
            lblANEG.TabIndex = 61;
            lblANEG.Text = "Read only, Archive, System, Hidden, Compressed, Not content indexed, Encrypted, Temporary, Offline.";
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
            lblDCOPY.Size = new Size(381, 15);
            lblDCOPY.TabIndex = 51;
            lblDCOPY.Text = " D=Data, A=Attributes, T=Timestamps, E=EAs, X=Skip alt data streams.";
            // 
            // chkNOOFFLOAD
            // 
            chkNOOFFLOAD.AutoSize = true;
            chkNOOFFLOAD.Location = new Point(8, 1317);
            chkNOOFFLOAD.Name = "chkNOOFFLOAD";
            chkNOOFFLOAD.Size = new Size(453, 19);
            chkNOOFFLOAD.TabIndex = 49;
            chkNOOFFLOAD.Text = "/NOOFFLOAD :: copy files without using the Windows Copy Offload mechanism.";
            chkNOOFFLOAD.UseVisualStyleBackColor = true;
            // 
            // chkCOMPRESS
            // 
            chkCOMPRESS.AutoSize = true;
            chkCOMPRESS.Location = new Point(8, 1342);
            chkCOMPRESS.Name = "chkCOMPRESS";
            chkCOMPRESS.Size = new Size(435, 19);
            chkCOMPRESS.TabIndex = 48;
            chkCOMPRESS.Text = "/COMPRESS :: Request network compression during file transfer, if applicable.";
            chkCOMPRESS.UseVisualStyleBackColor = true;
            // 
            // chkNOCLONE
            // 
            chkNOCLONE.AutoSize = true;
            chkNOCLONE.Location = new Point(8, 1422);
            chkNOCLONE.Name = "chkNOCLONE";
            chkNOCLONE.Size = new Size(358, 19);
            chkNOCLONE.TabIndex = 47;
            chkNOCLONE.Text = "/NOCLONE :: Do not attempt block cloning as an optimization.";
            chkNOCLONE.UseVisualStyleBackColor = true;
            // 
            // chkNODCOPY
            // 
            chkNODCOPY.AutoSize = true;
            chkNODCOPY.Location = new Point(8, 1292);
            chkNODCOPY.Name = "chkNODCOPY";
            chkNODCOPY.Size = new Size(403, 19);
            chkNODCOPY.TabIndex = 46;
            chkNODCOPY.Text = " /NODCOPY :: COPY NO directory info (by default /DCOPY:DA is done).";
            chkNODCOPY.UseVisualStyleBackColor = true;
            // 
            // chkSPARSE
            // 
            chkSPARSE.AutoSize = true;
            chkSPARSE.Location = new Point(8, 1367);
            chkSPARSE.Name = "chkSPARSE";
            chkSPARSE.Size = new Size(407, 19);
            chkSPARSE.TabIndex = 45;
            chkSPARSE.Text = "/SPARSE[:Y/N] :: Enable or disable retaining the sparse state during copy.";
            chkSPARSE.UseVisualStyleBackColor = true;
            // 
            // chkDCOPY
            // 
            chkDCOPY.AutoSize = true;
            chkDCOPY.Location = new Point(8, 1212);
            chkDCOPY.Name = "chkDCOPY";
            chkDCOPY.Size = new Size(425, 19);
            chkDCOPY.TabIndex = 44;
            chkDCOPY.Text = " /DCOPY:copyflag[s] :: what to COPY for directories (default is /DCOPY:DA).";
            chkDCOPY.UseVisualStyleBackColor = true;
            // 
            // chkMT
            // 
            chkMT.AutoSize = true;
            chkMT.Location = new Point(8, 1099);
            chkMT.Name = "chkMT";
            chkMT.Size = new Size(352, 19);
            chkMT.TabIndex = 43;
            chkMT.Text = "/MT[:n] :: Do multi-threaded copies with n threads (default 8).";
            chkMT.UseVisualStyleBackColor = true;
            // 
            // chkIPG
            // 
            chkIPG.AutoSize = true;
            chkIPG.Location = new Point(8, 987);
            chkIPG.Name = "chkIPG";
            chkIPG.Size = new Size(360, 19);
            chkIPG.TabIndex = 42;
            chkIPG.Text = "/IPG:n :: Inter-Packet Gap (ms), to free bandwidth on slow lines.";
            chkIPG.UseVisualStyleBackColor = true;
            // 
            // chkSJ
            // 
            chkSJ.AutoSize = true;
            chkSJ.Location = new Point(8, 1047);
            chkSJ.Name = "chkSJ";
            chkSJ.Size = new Size(376, 19);
            chkSJ.TabIndex = 41;
            chkSJ.Text = "/SJ :: copy Junctions as junctions instead of as the junction targets.";
            chkSJ.UseVisualStyleBackColor = true;
            // 
            // chkSL
            // 
            chkSL.AutoSize = true;
            chkSL.Location = new Point(8, 1072);
            chkSL.Name = "chkSL";
            chkSL.Size = new Size(357, 19);
            chkSL.TabIndex = 40;
            chkSL.Text = "/SL :: copy Symbolic Links as links instead of as the link targets.";
            chkSL.UseVisualStyleBackColor = true;
            // 
            // chkPF
            // 
            chkPF.AutoSize = true;
            chkPF.Location = new Point(8, 962);
            chkPF.Name = "chkPF";
            chkPF.Size = new Size(315, 19);
            chkPF.TabIndex = 39;
            chkPF.Text = "/PF :: check run hours on a Per File (not per pass) basis.";
            chkPF.UseVisualStyleBackColor = true;
            // 
            // chkRH
            // 
            chkRH.AutoSize = true;
            chkRH.Location = new Point(8, 897);
            chkRH.Name = "chkRH";
            chkRH.Size = new Size(413, 19);
            chkRH.TabIndex = 38;
            chkRH.Text = "/RH:hhmm-hhmm :: Run Hours - times when new copies may be started.";
            chkRH.UseVisualStyleBackColor = true;
            // 
            // chkMOT
            // 
            chkMOT.AutoSize = true;
            chkMOT.Location = new Point(8, 847);
            chkMOT.Name = "chkMOT";
            chkMOT.Size = new Size(390, 19);
            chkMOT.TabIndex = 37;
            chkMOT.Text = "/MOT:m :: MOnitor source; run again in m minutes Time, if changed.";
            chkMOT.UseVisualStyleBackColor = true;
            // 
            // chkMON
            // 
            chkMON.AutoSize = true;
            chkMON.Location = new Point(8, 802);
            chkMON.Name = "chkMON";
            chkMON.Size = new Size(400, 19);
            chkMON.TabIndex = 36;
            chkMON.Text = "/MON:n :: MONitor source; run again when more than n changes seen.";
            chkMON.UseVisualStyleBackColor = true;
            // 
            // chk256
            // 
            chk256.AutoSize = true;
            chk256.Location = new Point(8, 777);
            chk256.Name = "chk256";
            chk256.Size = new Size(324, 19);
            chk256.TabIndex = 35;
            chk256.Text = "/256 :: turn off very long path (> 256 characters) support.";
            chk256.UseVisualStyleBackColor = true;
            // 
            // chkFAT
            // 
            chkFAT.AutoSize = true;
            chkFAT.Location = new Point(8, 752);
            chkFAT.Name = "chkFAT";
            chkFAT.Size = new Size(338, 19);
            chkFAT.TabIndex = 34;
            chkFAT.Text = "/FAT :: create destination files using 8.3 FAT file names only.";
            chkFAT.UseVisualStyleBackColor = true;
            // 
            // chkCREATE
            // 
            chkCREATE.AutoSize = true;
            chkCREATE.Location = new Point(8, 727);
            chkCREATE.Name = "chkCREATE";
            chkCREATE.Size = new Size(338, 19);
            chkCREATE.TabIndex = 33;
            chkCREATE.Text = "/CREATE :: CREATE directory tree and zero-length files only.";
            chkCREATE.UseVisualStyleBackColor = true;
            // 
            // chkANEG
            // 
            chkANEG.AutoSize = true;
            chkANEG.Location = new Point(6, 645);
            chkANEG.Name = "chkANEG";
            chkANEG.Size = new Size(374, 19);
            chkANEG.TabIndex = 32;
            chkANEG.Text = "/A-:[RASHCNETO]:: remove the given Attributes from copied files.";
            chkANEG.UseVisualStyleBackColor = true;
            // 
            // chkAPOS
            // 
            chkAPOS.AutoSize = true;
            chkAPOS.Location = new Point(8, 565);
            chkAPOS.Name = "chkAPOS";
            chkAPOS.Size = new Size(337, 19);
            chkAPOS.TabIndex = 31;
            chkAPOS.Text = "/A+:[RASHCNET] :: add the given Attributes to copied files.";
            chkAPOS.UseVisualStyleBackColor = true;
            // 
            // chkMOV
            // 
            chkMOV.AutoSize = true;
            chkMOV.Location = new Point(8, 515);
            chkMOV.Name = "chkMOV";
            chkMOV.Size = new Size(312, 19);
            chkMOV.TabIndex = 29;
            chkMOV.Text = "/MOV :: MOVe files (delete from source after copying).";
            chkMOV.UseVisualStyleBackColor = true;
            // 
            // chkMIR
            // 
            chkMIR.AutoSize = true;
            chkMIR.Location = new Point(8, 490);
            chkMIR.Name = "chkMIR";
            chkMIR.Size = new Size(348, 19);
            chkMIR.TabIndex = 28;
            chkMIR.Text = "/MIR :: MIRror a directory tree (equivalent to /E plus /PURGE).";
            chkMIR.UseVisualStyleBackColor = true;
            // 
            // chkPURGE
            // 
            chkPURGE.AutoSize = true;
            chkPURGE.Location = new Point(8, 465);
            chkPURGE.Name = "chkPURGE";
            chkPURGE.Size = new Size(342, 19);
            chkPURGE.TabIndex = 27;
            chkPURGE.Text = "/PURGE :: delete dest files/dirs that no longer exist in source.";
            chkPURGE.UseVisualStyleBackColor = true;
            // 
            // chkTIMFIX
            // 
            chkTIMFIX.AutoSize = true;
            chkTIMFIX.Location = new Point(8, 440);
            chkTIMFIX.Name = "chkTIMFIX";
            chkTIMFIX.Size = new Size(308, 19);
            chkTIMFIX.TabIndex = 26;
            chkTIMFIX.Text = "/TIMFIX :: FIX file TIMes on all files, even skipped files.";
            chkTIMFIX.UseVisualStyleBackColor = true;
            // 
            // chkSECFIX
            // 
            chkSECFIX.AutoSize = true;
            chkSECFIX.Location = new Point(8, 415);
            chkSECFIX.Name = "chkSECFIX";
            chkSECFIX.Size = new Size(319, 19);
            chkSECFIX.TabIndex = 25;
            chkSECFIX.Text = "/SECFIX :: FIX file SECurity on all files, even skipped files.";
            chkSECFIX.UseVisualStyleBackColor = true;
            // 
            // chkNOCOPY
            // 
            chkNOCOPY.AutoSize = true;
            chkNOCOPY.Location = new Point(8, 390);
            chkNOCOPY.Name = "chkNOCOPY";
            chkNOCOPY.Size = new Size(303, 19);
            chkNOCOPY.TabIndex = 24;
            chkNOCOPY.Text = "/NOCOPY :: COPY NO file info (useful with /PURGE).";
            chkNOCOPY.UseVisualStyleBackColor = true;
            // 
            // chkCOPYALL
            // 
            chkCOPYALL.AutoSize = true;
            chkCOPYALL.Location = new Point(8, 365);
            chkCOPYALL.Name = "chkCOPYALL";
            chkCOPYALL.Size = new Size(360, 19);
            chkCOPYALL.TabIndex = 23;
            chkCOPYALL.Text = "/COPYALL :: COPY ALL file info (equivalent to /COPY:DATSOU).";
            chkCOPYALL.UseVisualStyleBackColor = true;
            // 
            // chkSEC
            // 
            chkSEC.AutoSize = true;
            chkSEC.Location = new Point(7, 341);
            chkSEC.Name = "chkSEC";
            chkSEC.Size = new Size(339, 19);
            chkSEC.TabIndex = 22;
            chkSEC.Text = "/SEC :: copy files with SECurity (equivalent to /COPY:DATS).";
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
            lblCOPY.Size = new Size(458, 30);
            lblCOPY.TabIndex = 19;
            lblCOPY.Text = "D=Data, A=Attributes, T=Timestamps, X=Skip alt data streams (X ignored if /B or /ZB.\r\nS=Security=NTFS ACLs, O=Owner info, U=aUditing info.";
            // 
            // chkCOPY
            // 
            chkCOPY.AutoSize = true;
            chkCOPY.Location = new Point(8, 252);
            chkCOPY.Name = "chkCOPY";
            chkCOPY.Size = new Size(378, 19);
            chkCOPY.TabIndex = 18;
            chkCOPY.Text = "/COPY:copyflag[s] :: what to COPY for files (default is /COPY:DAT).";
            chkCOPY.UseVisualStyleBackColor = true;
            // 
            // chkEFSRAW
            // 
            chkEFSRAW.AutoSize = true;
            chkEFSRAW.Location = new Point(8, 228);
            chkEFSRAW.Name = "chkEFSRAW";
            chkEFSRAW.Size = new Size(306, 19);
            chkEFSRAW.TabIndex = 17;
            chkEFSRAW.Text = "/EFSRAW :: copy all encrypted files in EFS RAW mode.";
            chkEFSRAW.UseVisualStyleBackColor = true;
            // 
            // chkJ
            // 
            chkJ.AutoSize = true;
            chkJ.Location = new Point(8, 203);
            chkJ.Name = "chkJ";
            chkJ.Size = new Size(353, 19);
            chkJ.TabIndex = 16;
            chkJ.Text = " /J :: copy using unbuffered I/O (recommended for large files).";
            chkJ.UseVisualStyleBackColor = true;
            // 
            // chkZB
            // 
            chkZB.AutoSize = true;
            chkZB.Location = new Point(8, 178);
            chkZB.Name = "chkZB";
            chkZB.Size = new Size(356, 19);
            chkZB.TabIndex = 15;
            chkZB.Text = "/ZB :: use restartable mode; if access denied use Backup mode.";
            chkZB.UseVisualStyleBackColor = true;
            // 
            // chkB
            // 
            chkB.AutoSize = true;
            chkB.Location = new Point(8, 153);
            chkB.Name = "chkB";
            chkB.Size = new Size(192, 19);
            chkB.TabIndex = 14;
            chkB.Text = "/B :: copy files in Backup mode.";
            chkB.UseVisualStyleBackColor = true;
            // 
            // chkZ
            // 
            chkZ.AutoSize = true;
            chkZ.Location = new Point(8, 128);
            chkZ.Name = "chkZ";
            chkZ.Size = new Size(208, 19);
            chkZ.TabIndex = 13;
            chkZ.Text = "/Z :: copy files in restartable mode.";
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
            chkS.Size = new Size(266, 19);
            chkS.TabIndex = 9;
            chkS.Text = "/S :: copy Subdirectories, but not empty ones.";
            chkS.UseVisualStyleBackColor = true;
            // 
            // chkLev
            // 
            chkLev.AutoSize = true;
            chkLev.Location = new Point(8, 63);
            chkLev.Name = "chkLev";
            chkLev.Size = new Size(361, 19);
            chkLev.TabIndex = 10;
            chkLev.Text = " /LEV:n :: only copy the top n LEVels of the source directory tree.";
            chkLev.UseVisualStyleBackColor = true;
            // 
            // chkE
            // 
            chkE.AutoSize = true;
            chkE.Location = new Point(8, 38);
            chkE.Name = "chkE";
            chkE.Size = new Size(276, 19);
            chkE.TabIndex = 8;
            chkE.Text = "/E :: copy subdirectories, including Empty ones.";
            chkE.UseVisualStyleBackColor = true;
            // 
            // tabThrottling
            // 
            tabThrottling.AutoScroll = true;
            tabThrottling.Controls.Add(txtThreshold);
            tabThrottling.Controls.Add(txtIoRate);
            tabThrottling.Controls.Add(txtIoMaxSize);
            tabThrottling.Controls.Add(chkThreshold);
            tabThrottling.Controls.Add(chkIoRate);
            tabThrottling.Controls.Add(chkIoMaxSize);
            tabThrottling.Location = new Point(4, 24);
            tabThrottling.Name = "tabThrottling";
            tabThrottling.Padding = new Padding(3);
            tabThrottling.Size = new Size(705, 175);
            tabThrottling.TabIndex = 1;
            tabThrottling.Text = "File Throttling";
            tabThrottling.UseVisualStyleBackColor = true;
            // 
            // txtThreshold
            // 
            txtThreshold.Location = new Point(35, 172);
            txtThreshold.Name = "txtThreshold";
            txtThreshold.Size = new Size(100, 23);
            txtThreshold.TabIndex = 12;
            txtThreshold.Text = "n[KMG]";
            // 
            // txtIoRate
            // 
            txtIoRate.Location = new Point(35, 113);
            txtIoRate.Name = "txtIoRate";
            txtIoRate.Size = new Size(100, 23);
            txtIoRate.TabIndex = 11;
            txtIoRate.Text = "n[KMG]";
            // 
            // txtIoMaxSize
            // 
            txtIoMaxSize.Location = new Point(35, 44);
            txtIoMaxSize.Name = "txtIoMaxSize";
            txtIoMaxSize.Size = new Size(100, 23);
            txtIoMaxSize.TabIndex = 3;
            txtIoMaxSize.Text = "n[KMG]";
            // 
            // chkThreshold
            // 
            chkThreshold.AutoSize = true;
            chkThreshold.Location = new Point(13, 147);
            chkThreshold.Name = "chkThreshold";
            chkThreshold.Size = new Size(480, 19);
            chkThreshold.TabIndex = 2;
            chkThreshold.Text = " /Threshold:n[KMG] :: File size threshold for throttling, in n [KMG] bytes (see Remarks).";
            chkThreshold.UseVisualStyleBackColor = true;
            // 
            // chkIoRate
            // 
            chkIoRate.AutoSize = true;
            chkIoRate.Location = new Point(13, 88);
            chkIoRate.Name = "chkIoRate";
            chkIoRate.Size = new Size(374, 19);
            chkIoRate.TabIndex = 1;
            chkIoRate.Text = "/IoRate:n[KMG] :: Requested i/o rate, in n [KMG] bytes per second.";
            chkIoRate.UseVisualStyleBackColor = true;
            // 
            // chkIoMaxSize
            // 
            chkIoMaxSize.AutoSize = true;
            chkIoMaxSize.Location = new Point(13, 19);
            chkIoMaxSize.Name = "chkIoMaxSize";
            chkIoMaxSize.Size = new Size(469, 19);
            chkIoMaxSize.TabIndex = 0;
            chkIoMaxSize.Text = "/IoMaxSize:n[KMG] :: Requested max i/o size per {read,write} cycle, in n [KMG] bytes.";
            chkIoMaxSize.UseVisualStyleBackColor = true;
            // 
            // tabSelection
            // 
            tabSelection.AutoScroll = true;
            tabSelection.Controls.Add(chkXJ);
            tabSelection.Controls.Add(chkXJD);
            tabSelection.Controls.Add(lblMINLAD);
            tabSelection.Controls.Add(txtMINLAD);
            tabSelection.Controls.Add(txtMAX);
            tabSelection.Controls.Add(txtMIN);
            tabSelection.Controls.Add(txtMAXAGE);
            tabSelection.Controls.Add(txtMAXLAD);
            tabSelection.Controls.Add(txtMINAGE);
            tabSelection.Controls.Add(chkMINLAD);
            tabSelection.Controls.Add(chkMINAGE);
            tabSelection.Controls.Add(chkMAXLAD);
            tabSelection.Controls.Add(chkMAXAGE);
            tabSelection.Controls.Add(chkMAX);
            tabSelection.Controls.Add(chkXJF);
            tabSelection.Controls.Add(chkIM);
            tabSelection.Controls.Add(chkIT);
            tabSelection.Controls.Add(txtXD);
            tabSelection.Controls.Add(txtXF);
            tabSelection.Controls.Add(label1);
            tabSelection.Controls.Add(lblIA);
            tabSelection.Controls.Add(txtXA);
            tabSelection.Controls.Add(txtIA);
            tabSelection.Controls.Add(chkDST);
            tabSelection.Controls.Add(chkFFT);
            tabSelection.Controls.Add(chkXX);
            tabSelection.Controls.Add(chkXO);
            tabSelection.Controls.Add(chkXL);
            tabSelection.Controls.Add(chkXN);
            tabSelection.Controls.Add(chkXC);
            tabSelection.Controls.Add(chkMIN);
            tabSelection.Controls.Add(chkIS);
            tabSelection.Controls.Add(chkXD);
            tabSelection.Controls.Add(chkXF);
            tabSelection.Controls.Add(chkXA);
            tabSelection.Controls.Add(chkIA);
            tabSelection.Controls.Add(chkM);
            tabSelection.Controls.Add(chkA);
            tabSelection.Location = new Point(4, 24);
            tabSelection.Name = "tabSelection";
            tabSelection.Size = new Size(705, 175);
            tabSelection.TabIndex = 2;
            tabSelection.Text = "File Selection";
            tabSelection.UseVisualStyleBackColor = true;
            // 
            // chkXJ
            // 
            chkXJ.AutoSize = true;
            chkXJ.Location = new Point(12, 977);
            chkXJ.Name = "chkXJ";
            chkXJ.Size = new Size(444, 19);
            chkXJ.TabIndex = 85;
            chkXJ.Text = "/XJ :: eXclude symbolic links (for both files and directories) and Junction points.";
            chkXJ.UseVisualStyleBackColor = true;
            // 
            // chkXJD
            // 
            chkXJD.AutoSize = true;
            chkXJD.Location = new Point(12, 1002);
            chkXJD.Name = "chkXJD";
            chkXJD.Size = new Size(370, 19);
            chkXJD.TabIndex = 83;
            chkXJD.Text = "/XJD :: eXclude symbolic links for Directories and Junction points.";
            chkXJD.UseVisualStyleBackColor = true;
            // 
            // lblMINLAD
            // 
            lblMINLAD.AutoSize = true;
            lblMINLAD.Location = new Point(28, 903);
            lblMINLAD.Name = "lblMINLAD";
            lblMINLAD.Size = new Size(303, 15);
            lblMINLAD.TabIndex = 82;
            lblMINLAD.Text = " (If n < 1900 then n = n days, else n = YYYYMMDD date).";
            // 
            // txtMINLAD
            // 
            txtMINLAD.Location = new Point(28, 872);
            txtMINLAD.Name = "txtMINLAD";
            txtMINLAD.Size = new Size(100, 23);
            txtMINLAD.TabIndex = 81;
            txtMINLAD.Text = "n";
            // 
            // txtMAX
            // 
            txtMAX.Location = new Point(28, 566);
            txtMAX.Name = "txtMAX";
            txtMAX.Size = new Size(100, 23);
            txtMAX.TabIndex = 80;
            txtMAX.Text = "n";
            // 
            // txtMIN
            // 
            txtMIN.Location = new Point(28, 631);
            txtMIN.Name = "txtMIN";
            txtMIN.Size = new Size(100, 23);
            txtMIN.TabIndex = 79;
            txtMIN.Text = "n";
            // 
            // txtMAXAGE
            // 
            txtMAXAGE.Location = new Point(28, 694);
            txtMAXAGE.Name = "txtMAXAGE";
            txtMAXAGE.Size = new Size(100, 23);
            txtMAXAGE.TabIndex = 78;
            txtMAXAGE.Text = "n";
            // 
            // txtMAXLAD
            // 
            txtMAXLAD.Location = new Point(28, 817);
            txtMAXLAD.Name = "txtMAXLAD";
            txtMAXLAD.Size = new Size(100, 23);
            txtMAXLAD.TabIndex = 77;
            txtMAXLAD.Text = "n";
            // 
            // txtMINAGE
            // 
            txtMINAGE.Location = new Point(28, 752);
            txtMINAGE.Name = "txtMINAGE";
            txtMINAGE.Size = new Size(100, 23);
            txtMINAGE.TabIndex = 76;
            txtMINAGE.Text = "n";
            // 
            // chkMINLAD
            // 
            chkMINLAD.AutoSize = true;
            chkMINLAD.Location = new Point(12, 847);
            chkMINLAD.Name = "chkMINLAD";
            chkMINLAD.Size = new Size(389, 19);
            chkMINLAD.TabIndex = 74;
            chkMINLAD.Text = "/MINLAD:n :: MINimum Last Access Date - exclude files used since n.";
            chkMINLAD.UseVisualStyleBackColor = true;
            // 
            // chkMINAGE
            // 
            chkMINAGE.AutoSize = true;
            chkMINAGE.Location = new Point(12, 727);
            chkMINAGE.Name = "chkMINAGE";
            chkMINAGE.Size = new Size(402, 19);
            chkMINAGE.TabIndex = 73;
            chkMINAGE.Text = "/MINAGE:n :: MINimum file AGE - exclude files newer than n days/date.";
            chkMINAGE.UseVisualStyleBackColor = true;
            // 
            // chkMAXLAD
            // 
            chkMAXLAD.AutoSize = true;
            chkMAXLAD.Location = new Point(12, 792);
            chkMAXLAD.Name = "chkMAXLAD";
            chkMAXLAD.Size = new Size(409, 19);
            chkMAXLAD.TabIndex = 72;
            chkMAXLAD.Text = "/MAXLAD:n :: MAXimum Last Access Date - exclude files unused since n.";
            chkMAXLAD.UseVisualStyleBackColor = true;
            // 
            // chkMAXAGE
            // 
            chkMAXAGE.AutoSize = true;
            chkMAXAGE.Location = new Point(12, 670);
            chkMAXAGE.Name = "chkMAXAGE";
            chkMAXAGE.Size = new Size(403, 19);
            chkMAXAGE.TabIndex = 71;
            chkMAXAGE.Text = "/MAXAGE:n :: MAXimum file AGE - exclude files older than n days/date.";
            chkMAXAGE.UseVisualStyleBackColor = true;
            // 
            // chkMAX
            // 
            chkMAX.AutoSize = true;
            chkMAX.Location = new Point(12, 543);
            chkMAX.Name = "chkMAX";
            chkMAX.Size = new Size(356, 19);
            chkMAX.TabIndex = 70;
            chkMAX.Text = "MAX:n :: MAXimum file size - exclude files bigger than n bytes.";
            chkMAX.UseVisualStyleBackColor = true;
            // 
            // chkXJF
            // 
            chkXJF.AutoSize = true;
            chkXJF.Location = new Point(12, 1027);
            chkXJF.Name = "chkXJF";
            chkXJF.Size = new Size(228, 19);
            chkXJF.TabIndex = 69;
            chkXJF.Text = "/XJF :: eXclude symbolic links for Files.";
            chkXJF.UseVisualStyleBackColor = true;
            // 
            // chkIM
            // 
            chkIM.AutoSize = true;
            chkIM.Location = new Point(12, 1052);
            chkIM.Name = "chkIM";
            chkIM.Size = new Size(307, 19);
            chkIM.TabIndex = 68;
            chkIM.Text = " /IM :: Include Modified files (differing change times).";
            chkIM.UseVisualStyleBackColor = true;
            // 
            // chkIT
            // 
            chkIT.AutoSize = true;
            chkIT.Location = new Point(12, 518);
            chkIT.Name = "chkIT";
            chkIT.Size = new Size(168, 19);
            chkIT.TabIndex = 67;
            chkIT.Text = "/IT :: Include Tweaked files.";
            chkIT.UseVisualStyleBackColor = true;
            // 
            // txtXD
            // 
            txtXD.Location = new Point(36, 323);
            txtXD.Name = "txtXD";
            txtXD.Size = new Size(100, 23);
            txtXD.TabIndex = 66;
            txtXD.Text = "[dirs]...";
            // 
            // txtXF
            // 
            txtXF.Location = new Point(36, 258);
            txtXF.Name = "txtXF";
            txtXF.Size = new Size(100, 23);
            txtXF.TabIndex = 65;
            txtXF.Text = "[file]...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 208);
            label1.Name = "label1";
            label1.Size = new Size(547, 15);
            label1.TabIndex = 64;
            label1.Text = "Read only, Archive, System, Hidden, Compressed, Not content indexed, Encrypted, Temporary, Offline.";
            // 
            // lblIA
            // 
            lblIA.AutoSize = true;
            lblIA.Location = new Point(49, 118);
            lblIA.Name = "lblIA";
            lblIA.Size = new Size(505, 15);
            lblIA.TabIndex = 63;
            lblIA.Text = "Read only, Archive, System, Hidden, Compressed, Not content indexed, Encrypted, Temporary.";
            // 
            // txtXA
            // 
            txtXA.Location = new Point(46, 176);
            txtXA.Name = "txtXA";
            txtXA.Size = new Size(100, 23);
            txtXA.TabIndex = 16;
            txtXA.Text = "[RASHCNETO]";
            // 
            // txtIA
            // 
            txtIA.Location = new Point(46, 88);
            txtIA.Name = "txtIA";
            txtIA.Size = new Size(100, 23);
            txtIA.TabIndex = 15;
            txtIA.Text = "[RASHCNETO]";
            // 
            // chkDST
            // 
            chkDST.AutoSize = true;
            chkDST.Location = new Point(12, 952);
            chkDST.Name = "chkDST";
            chkDST.Size = new Size(318, 19);
            chkDST.TabIndex = 14;
            chkDST.Text = " /DST :: compensate for one-hour DST time differences.";
            chkDST.UseVisualStyleBackColor = true;
            // 
            // chkFFT
            // 
            chkFFT.AutoSize = true;
            chkFFT.Location = new Point(12, 927);
            chkFFT.Name = "chkFFT";
            chkFFT.Size = new Size(303, 19);
            chkFFT.TabIndex = 13;
            chkFFT.Text = "/FFT :: assume FAT File Times (2-second granularity).";
            chkFFT.UseVisualStyleBackColor = true;
            // 
            // chkXX
            // 
            chkXX.AutoSize = true;
            chkXX.Location = new Point(12, 444);
            chkXX.Name = "chkXX";
            chkXX.Size = new Size(237, 19);
            chkXX.TabIndex = 12;
            chkXX.Text = "/XX :: eXclude eXtra files and directories.";
            chkXX.UseVisualStyleBackColor = true;
            // 
            // chkXO
            // 
            chkXO.AutoSize = true;
            chkXO.Location = new Point(12, 419);
            chkXO.Name = "chkXO";
            chkXO.Size = new Size(160, 19);
            chkXO.TabIndex = 11;
            chkXO.Text = "/XO :: eXclude Older files.";
            chkXO.UseVisualStyleBackColor = true;
            // 
            // chkXL
            // 
            chkXL.AutoSize = true;
            chkXL.Location = new Point(12, 469);
            chkXL.Name = "chkXL";
            chkXL.Size = new Size(244, 19);
            chkXL.TabIndex = 10;
            chkXL.Text = "/XL :: eXclude Lonely files and directories.";
            chkXL.UseVisualStyleBackColor = true;
            // 
            // chkXN
            // 
            chkXN.AutoSize = true;
            chkXN.Location = new Point(12, 394);
            chkXN.Name = "chkXN";
            chkXN.Size = new Size(165, 19);
            chkXN.TabIndex = 9;
            chkXN.Text = "/XN :: eXclude Newer files.";
            chkXN.UseVisualStyleBackColor = true;
            // 
            // chkXC
            // 
            chkXC.AutoSize = true;
            chkXC.Location = new Point(12, 365);
            chkXC.Name = "chkXC";
            chkXC.Size = new Size(178, 19);
            chkXC.TabIndex = 8;
            chkXC.Text = "/XC :: eXclude Changed files.";
            chkXC.UseVisualStyleBackColor = true;
            // 
            // chkMIN
            // 
            chkMIN.AutoSize = true;
            chkMIN.Location = new Point(12, 606);
            chkMIN.Name = "chkMIN";
            chkMIN.Size = new Size(362, 19);
            chkMIN.TabIndex = 7;
            chkMIN.Text = " /MIN:n :: MINimum file size - exclude files smaller than n bytes.";
            chkMIN.UseVisualStyleBackColor = true;
            // 
            // chkIS
            // 
            chkIS.AutoSize = true;
            chkIS.Location = new Point(12, 494);
            chkIS.Name = "chkIS";
            chkIS.Size = new Size(150, 19);
            chkIS.TabIndex = 6;
            chkIS.Text = "/IS :: Include Same files.";
            chkIS.UseVisualStyleBackColor = true;
            // 
            // chkXD
            // 
            chkXD.AutoSize = true;
            chkXD.Location = new Point(12, 301);
            chkXD.Name = "chkXD";
            chkXD.Size = new Size(384, 19);
            chkXD.TabIndex = 5;
            chkXD.Text = " /XD dirs [dirs]... :: eXclude Directories matching given names/paths.";
            chkXD.UseVisualStyleBackColor = true;
            // 
            // chkXF
            // 
            chkXF.AutoSize = true;
            chkXF.Location = new Point(12, 233);
            chkXF.Name = "chkXF";
            chkXF.Size = new Size(395, 19);
            chkXF.TabIndex = 4;
            chkXF.Text = "/XF file [file]... :: eXclude Files matching given names/paths/wildcards.";
            chkXF.UseVisualStyleBackColor = true;
            // 
            // chkXA
            // 
            chkXA.AutoSize = true;
            chkXA.Location = new Point(12, 151);
            chkXA.Name = "chkXA";
            chkXA.Size = new Size(393, 19);
            chkXA.TabIndex = 3;
            chkXA.Text = "/XA:[RASHCNETO] :: eXclude files with any of the given Attributes set.";
            chkXA.UseVisualStyleBackColor = true;
            // 
            // chkIA
            // 
            chkIA.AutoSize = true;
            chkIA.Location = new Point(12, 63);
            chkIA.Name = "chkIA";
            chkIA.Size = new Size(412, 19);
            chkIA.TabIndex = 2;
            chkIA.Text = "/IA:[RASHCNETO] :: Include only files with any of the given Attributes set.";
            chkIA.UseVisualStyleBackColor = true;
            // 
            // chkM
            // 
            chkM.AutoSize = true;
            chkM.Location = new Point(12, 38);
            chkM.Name = "chkM";
            chkM.Size = new Size(331, 19);
            chkM.TabIndex = 1;
            chkM.Text = "/M :: copy only files with the Archive attribute and reset it.";
            chkM.UseVisualStyleBackColor = true;
            // 
            // chkA
            // 
            chkA.AutoSize = true;
            chkA.Location = new Point(12, 15);
            chkA.Name = "chkA";
            chkA.Size = new Size(285, 19);
            chkA.TabIndex = 0;
            chkA.Text = "/A :: copy only files with the Archive attribute set.";
            chkA.UseVisualStyleBackColor = true;
            // 
            // tabRetry
            // 
            tabRetry.AutoScroll = true;
            tabRetry.Controls.Add(txtLFSMn);
            tabRetry.Controls.Add(txtW);
            tabRetry.Controls.Add(txtR);
            tabRetry.Controls.Add(chkLFSMn);
            tabRetry.Controls.Add(chkLFSM);
            tabRetry.Controls.Add(chkTBD);
            tabRetry.Controls.Add(chkREG);
            tabRetry.Controls.Add(chkW);
            tabRetry.Controls.Add(chkR);
            tabRetry.Location = new Point(4, 24);
            tabRetry.Name = "tabRetry";
            tabRetry.Size = new Size(705, 175);
            tabRetry.TabIndex = 3;
            tabRetry.Text = "Retry";
            tabRetry.UseVisualStyleBackColor = true;
            // 
            // txtLFSMn
            // 
            txtLFSMn.Location = new Point(37, 224);
            txtLFSMn.Name = "txtLFSMn";
            txtLFSMn.PlaceholderText = "n[KMG]";
            txtLFSMn.Size = new Size(100, 23);
            txtLFSMn.TabIndex = 8;
            // 
            // txtW
            // 
            txtW.Location = new Point(37, 97);
            txtW.Name = "txtW";
            txtW.PlaceholderText = "n";
            txtW.Size = new Size(100, 23);
            txtW.TabIndex = 7;
            // 
            // txtR
            // 
            txtR.Location = new Point(37, 40);
            txtR.Name = "txtR";
            txtR.PlaceholderText = "n";
            txtR.Size = new Size(100, 23);
            txtR.TabIndex = 6;
            // 
            // chkLFSMn
            // 
            chkLFSMn.AutoSize = true;
            chkLFSMn.Location = new Point(13, 199);
            chkLFSMn.Name = "chkLFSMn";
            chkLFSMn.Size = new Size(461, 19);
            chkLFSMn.TabIndex = 5;
            chkLFSMn.Text = "/LFSM:n[KMG] :: /LFSM, specifying the floor size in n [K:kilo,M:mega,G:giga] bytes.";
            chkLFSMn.UseVisualStyleBackColor = true;
            // 
            // chkLFSM
            // 
            chkLFSM.AutoSize = true;
            chkLFSM.Location = new Point(13, 175);
            chkLFSM.Name = "chkLFSM";
            chkLFSM.Size = new Size(501, 19);
            chkLFSM.TabIndex = 4;
            chkLFSM.Text = " /LFSM :: Operate in low free space mode, enabling copy pause and resume (see Remarks).";
            chkLFSM.UseVisualStyleBackColor = true;
            // 
            // chkTBD
            // 
            chkTBD.AutoSize = true;
            chkTBD.Location = new Point(13, 154);
            chkTBD.Name = "chkTBD";
            chkTBD.Size = new Size(330, 19);
            chkTBD.TabIndex = 3;
            chkTBD.Text = "/TBD :: Wait for sharenames To Be Defined (retry error 67).";
            chkTBD.UseVisualStyleBackColor = true;
            // 
            // chkREG
            // 
            chkREG.AutoSize = true;
            chkREG.Location = new Point(13, 132);
            chkREG.Name = "chkREG";
            chkREG.Size = new Size(344, 19);
            chkREG.TabIndex = 2;
            chkREG.Text = "/REG :: Save /R:n and /W:n in the Registry as default settings.";
            chkREG.UseVisualStyleBackColor = true;
            // 
            // chkW
            // 
            chkW.AutoSize = true;
            chkW.Location = new Point(13, 74);
            chkW.Name = "chkW";
            chkW.Size = new Size(316, 19);
            chkW.TabIndex = 1;
            chkW.Text = "/W:n :: Wait time between retries: default is 30 seconds.";
            chkW.UseVisualStyleBackColor = true;
            // 
            // chkR
            // 
            chkR.AutoSize = true;
            chkR.Location = new Point(13, 16);
            chkR.Name = "chkR";
            chkR.Size = new Size(335, 19);
            chkR.TabIndex = 0;
            chkR.Text = "/R:n :: number of Retries on failed copies: default 1 million.";
            chkR.UseVisualStyleBackColor = true;
            // 
            // tabLogging
            // 
            tabLogging.AutoScroll = true;
            tabLogging.Controls.Add(chkUNICODE);
            tabLogging.Controls.Add(chkNJS);
            tabLogging.Controls.Add(chkNJH);
            tabLogging.Controls.Add(chkTEE);
            tabLogging.Controls.Add(txtUNILOGAPPEND);
            tabLogging.Controls.Add(txtUNILOG);
            tabLogging.Controls.Add(txtLOGAPPEND);
            tabLogging.Controls.Add(txtLOG);
            tabLogging.Controls.Add(chkUNILOGAPPEND);
            tabLogging.Controls.Add(chkUNILOG);
            tabLogging.Controls.Add(chkLOGAPPEND);
            tabLogging.Controls.Add(chkLOG);
            tabLogging.Controls.Add(chkETA);
            tabLogging.Controls.Add(chkNP);
            tabLogging.Controls.Add(chkNDL);
            tabLogging.Controls.Add(chkFP);
            tabLogging.Controls.Add(chkTS);
            tabLogging.Controls.Add(chkV);
            tabLogging.Controls.Add(chkX);
            tabLogging.Controls.Add(chkL);
            tabLogging.Controls.Add(chkNFL);
            tabLogging.Controls.Add(chkNC);
            tabLogging.Controls.Add(chkNS);
            tabLogging.Controls.Add(chkBYTES);
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
            tabRemarks.Controls.Add(textBox1);
            tabRemarks.Location = new Point(4, 24);
            tabRemarks.Name = "tabRemarks";
            tabRemarks.Size = new Size(705, 175);
            tabRemarks.TabIndex = 6;
            tabRemarks.Text = "Remarks";
            tabRemarks.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(699, 169);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // grpOutput
            // 
            grpOutput.Controls.Add(button1);
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(657, 30);
            button1.Name = "button1";
            button1.Size = new Size(61, 23);
            button1.TabIndex = 11;
            button1.Text = "Copy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCommand
            // 
            txtCommand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCommand.BackColor = SystemColors.Window;
            txtCommand.ForeColor = SystemColors.WindowText;
            txtCommand.Location = new Point(14, 30);
            txtCommand.Name = "txtCommand";
            txtCommand.ReadOnly = true;
            txtCommand.Size = new Size(637, 23);
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
            // chkFP
            // 
            chkFP.AutoSize = true;
            chkFP.Location = new Point(13, 88);
            chkFP.Name = "chkFP";
            chkFP.Size = new Size(287, 19);
            chkFP.TabIndex = 20;
            chkFP.Text = "/FP :: include Full Pathname of files in the output.";
            chkFP.UseVisualStyleBackColor = true;
            // 
            // chkTS
            // 
            chkTS.AutoSize = true;
            chkTS.Location = new Point(13, 69);
            chkTS.Name = "chkTS";
            chkTS.Size = new Size(299, 19);
            chkTS.TabIndex = 19;
            chkTS.Text = "/TS :: include source file Time Stamps in the output.";
            chkTS.UseVisualStyleBackColor = true;
            // 
            // chkV
            // 
            chkV.AutoSize = true;
            chkV.Location = new Point(13, 50);
            chkV.Name = "chkV";
            chkV.Size = new Size(299, 19);
            chkV.TabIndex = 18;
            chkV.Text = "/V :: produce Verbose output, showing skipped files.";
            chkV.UseVisualStyleBackColor = true;
            // 
            // chkX
            // 
            chkX.AutoSize = true;
            chkX.Location = new Point(13, 31);
            chkX.Name = "chkX";
            chkX.Size = new Size(278, 19);
            chkX.TabIndex = 17;
            chkX.Text = "/X :: report all eXtra files, not just those selected.";
            chkX.UseVisualStyleBackColor = true;
            // 
            // chkL
            // 
            chkL.AutoSize = true;
            chkL.Location = new Point(13, 12);
            chkL.Name = "chkL";
            chkL.Size = new Size(322, 19);
            chkL.TabIndex = 16;
            chkL.Text = "/L :: List only - don't copy, timestamp or delete any files.";
            chkL.UseVisualStyleBackColor = true;
            // 
            // chkNFL
            // 
            chkNFL.AutoSize = true;
            chkNFL.Location = new Point(13, 166);
            chkNFL.Name = "chkNFL";
            chkNFL.Size = new Size(241, 19);
            chkNFL.TabIndex = 15;
            chkNFL.Text = "/NFL :: No File List - don't log file names.";
            chkNFL.UseVisualStyleBackColor = true;
            // 
            // chkNC
            // 
            chkNC.AutoSize = true;
            chkNC.Location = new Point(13, 145);
            chkNC.Name = "chkNC";
            chkNC.Size = new Size(226, 19);
            chkNC.TabIndex = 14;
            chkNC.Text = "/NC :: No Class - don't log file classes.";
            chkNC.UseVisualStyleBackColor = true;
            // 
            // chkNS
            // 
            chkNS.AutoSize = true;
            chkNS.Location = new Point(13, 126);
            chkNS.Name = "chkNS";
            chkNS.Size = new Size(205, 19);
            chkNS.TabIndex = 13;
            chkNS.Text = "/NS :: No Size - don't log file sizes.";
            chkNS.UseVisualStyleBackColor = true;
            // 
            // chkBYTES
            // 
            chkBYTES.AutoSize = true;
            chkBYTES.Location = new Point(13, 107);
            chkBYTES.Name = "chkBYTES";
            chkBYTES.Size = new Size(176, 19);
            chkBYTES.TabIndex = 12;
            chkBYTES.Text = "/BYTES :: Print sizes as bytes.";
            chkBYTES.UseVisualStyleBackColor = true;
            // 
            // chkETA
            // 
            chkETA.AutoSize = true;
            chkETA.Location = new Point(13, 233);
            chkETA.Name = "chkETA";
            chkETA.Size = new Size(307, 19);
            chkETA.TabIndex = 23;
            chkETA.Text = "/ETA :: show Estimated Time of Arrival of copied files.";
            chkETA.UseVisualStyleBackColor = true;
            // 
            // chkNP
            // 
            chkNP.AutoSize = true;
            chkNP.Location = new Point(13, 211);
            chkNP.Name = "chkNP";
            chkNP.Size = new Size(306, 19);
            chkNP.TabIndex = 22;
            chkNP.Text = "/NP :: No Progress - don't display percentage copied.";
            chkNP.UseVisualStyleBackColor = true;
            // 
            // chkNDL
            // 
            chkNDL.AutoSize = true;
            chkNDL.Location = new Point(13, 189);
            chkNDL.Name = "chkNDL";
            chkNDL.Size = new Size(304, 19);
            chkNDL.TabIndex = 21;
            chkNDL.Text = "/NDL :: No Directory List - don't log directory names.";
            chkNDL.UseVisualStyleBackColor = true;
            // 
            // chkLOG
            // 
            chkLOG.AutoSize = true;
            chkLOG.Location = new Point(13, 258);
            chkLOG.Name = "chkLOG";
            chkLOG.Size = new Size(340, 19);
            chkLOG.TabIndex = 24;
            chkLOG.Text = "/LOG:file :: output status to LOG file (overwrite existing log).";
            chkLOG.UseVisualStyleBackColor = true;
            // 
            // chkLOGAPPEND
            // 
            chkLOGAPPEND.AutoSize = true;
            chkLOGAPPEND.Location = new Point(13, 310);
            chkLOGAPPEND.Name = "chkLOGAPPEND";
            chkLOGAPPEND.Size = new Size(353, 19);
            chkLOGAPPEND.TabIndex = 25;
            chkLOGAPPEND.Text = "/LOG+:file :: output status to LOG file (append to existing log).";
            chkLOGAPPEND.UseVisualStyleBackColor = true;
            // 
            // chkUNILOG
            // 
            chkUNILOG.AutoSize = true;
            chkUNILOG.Location = new Point(13, 367);
            chkUNILOG.Name = "chkUNILOG";
            chkUNILOG.Size = new Size(428, 19);
            chkUNILOG.TabIndex = 26;
            chkUNILOG.Text = "/UNILOG:file :: output status to LOG file as UNICODE (overwrite existing log).";
            chkUNILOG.UseVisualStyleBackColor = true;
            // 
            // chkUNILOGAPPEND
            // 
            chkUNILOGAPPEND.AutoSize = true;
            chkUNILOGAPPEND.Location = new Point(13, 419);
            chkUNILOGAPPEND.Name = "chkUNILOGAPPEND";
            chkUNILOGAPPEND.Size = new Size(441, 19);
            chkUNILOGAPPEND.TabIndex = 27;
            chkUNILOGAPPEND.Text = "/UNILOG+:file :: output status to LOG file as UNICODE (append to existing log).";
            chkUNILOGAPPEND.UseVisualStyleBackColor = true;
            // 
            // txtLOG
            // 
            txtLOG.Location = new Point(35, 281);
            txtLOG.Name = "txtLOG";
            txtLOG.Size = new Size(331, 23);
            txtLOG.TabIndex = 28;
            // 
            // txtLOGAPPEND
            // 
            txtLOGAPPEND.Location = new Point(35, 333);
            txtLOGAPPEND.Name = "txtLOGAPPEND";
            txtLOGAPPEND.Size = new Size(331, 23);
            txtLOGAPPEND.TabIndex = 29;
            // 
            // txtUNILOG
            // 
            txtUNILOG.Location = new Point(35, 389);
            txtUNILOG.Name = "txtUNILOG";
            txtUNILOG.Size = new Size(331, 23);
            txtUNILOG.TabIndex = 30;
            // 
            // txtUNILOGAPPEND
            // 
            txtUNILOGAPPEND.Location = new Point(35, 441);
            txtUNILOGAPPEND.Name = "txtUNILOGAPPEND";
            txtUNILOGAPPEND.Size = new Size(331, 23);
            txtUNILOGAPPEND.TabIndex = 31;
            // 
            // chkTEE
            // 
            chkTEE.AutoSize = true;
            chkTEE.Location = new Point(13, 482);
            chkTEE.Name = "chkTEE";
            chkTEE.Size = new Size(318, 19);
            chkTEE.TabIndex = 32;
            chkTEE.Text = "/TEE :: output to console window, as well as the log file.";
            chkTEE.UseVisualStyleBackColor = true;
            // 
            // chkNJH
            // 
            chkNJH.AutoSize = true;
            chkNJH.Location = new Point(13, 507);
            chkNJH.Name = "chkNJH";
            chkNJH.Size = new Size(146, 19);
            chkNJH.TabIndex = 33;
            chkNJH.Text = "/NJH :: No Job Header.";
            chkNJH.UseVisualStyleBackColor = true;
            // 
            // chkNJS
            // 
            chkNJS.AutoSize = true;
            chkNJS.Location = new Point(13, 532);
            chkNJS.Name = "chkNJS";
            chkNJS.Size = new Size(156, 19);
            chkNJS.TabIndex = 34;
            chkNJS.Text = "/NJS :: No Job Summary.";
            chkNJS.UseVisualStyleBackColor = true;
            // 
            // chkUNICODE
            // 
            chkUNICODE.AutoSize = true;
            chkUNICODE.Location = new Point(13, 557);
            chkUNICODE.Name = "chkUNICODE";
            chkUNICODE.Size = new Size(235, 19);
            chkUNICODE.TabIndex = 35;
            chkUNICODE.Text = "/UNICODE :: output status as UNICODE.";
            chkUNICODE.UseVisualStyleBackColor = true;
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
            tabThrottling.ResumeLayout(false);
            tabThrottling.PerformLayout();
            tabSelection.ResumeLayout(false);
            tabSelection.PerformLayout();
            tabRetry.ResumeLayout(false);
            tabRetry.PerformLayout();
            tabLogging.ResumeLayout(false);
            tabLogging.PerformLayout();
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

            // Copy options
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

            // File throttling
            if (chkIoMaxSize.Checked)
            {
                arguments += " /IoMaxSize:" + txtIoMaxSize.Text;
            }
            if (chkIoRate.Checked)
            {
                arguments += " /IoRate:" + txtIoRate.Text;
            }
            if (chkThreshold.Checked)
            {
                arguments += " /Threshold:" + txtThreshold.Text;
            }

            // File selection
            if (chkA.Checked)
            {
                arguments += " /A";
            }
            if (chkM.Checked)
            {
                arguments += " /M";
            }
            if (chkIA.Checked)
            {
                arguments += " /IA:" + txtIA.Text;
            }
            if (chkXA.Checked)
            {
                arguments += " /XA:" + txtXA.Text;
            }
            if (chkXF.Checked)
            {
                arguments += " /XF:" + txtXF.Text;
            }
            if (chkXD.Checked)
            {
                arguments += " /XD:" + txtXD.Text;
            }
            if (chkXC.Checked)
            {
                arguments += " /XC";
            }
            if (chkXN.Checked)
            {
                arguments += " /XN";
            }
            if (chkXO.Checked)
            {
                arguments += " /XO";
            }
            if (chkXX.Checked)
            {
                arguments += " /XX";
            }
            if (chkXL.Checked)
            {
                arguments += " /XL";
            }
            if (chkIS.Checked)
            {
                arguments += " /IS";
            }
            if (chkIT.Checked)
            {
                arguments += " /IT";
            }
            if (chkMAX.Checked)
            {
                arguments += " /MAX:" + txtMAX.Text;
            }
            if (chkMIN.Checked)
            {
                arguments += " /MIN:" + txtMIN.Text;
            }
            if (chkMAXAGE.Checked)
            {
                arguments += " /MAXAGE:" + txtMAXAGE.Text;
            }
            if (chkMINAGE.Checked)
            {
                arguments += " /MINAGE:" + txtMINAGE.Text;
            }
            if (chkMAXLAD.Checked)
            {
                arguments += " /MAXLAD:" + txtMAXLAD.Text;
            }
            if (chkMINLAD.Checked)
            {
                arguments += " /MINLAD:" + txtMINLAD.Text;
            }
            if (chkFFT.Checked)
            {
                arguments += " /FFT";
            }
            if (chkDST.Checked)
            {
                arguments += " /DST";
            }
            if (chkXJ.Checked)
            {
                arguments += " /XJ";
            }
            if (chkXJD.Checked)
            {
                arguments += " /XJD";
            }
            if (chkXJF.Checked)
            {
                arguments += " /XJF";
            }
            if (chkIM.Checked)
            {
                arguments += " /IM";
            }

            // Retry
            if (chkR.Checked)
            {
                arguments += " /R:" + txtR.Text;
            }
            if (chkW.Checked)
            {
                arguments += " /W:" + txtW.Text;
            }
            if (chkREG.Checked)
            {
                arguments += " /REG";
            }
            if (chkTBD.Checked)
            {
                arguments += " /TBD";
            }
            if (chkLFSM.Checked)
            {
                arguments += " /LFSM";
            }
            if (chkLFSMn.Checked)
            {
                arguments += " /LFSM:" + txtLFSMn.Text;
            }

            // Logging

            if (chkL.Checked)
            {
                arguments += " /L";
            }
            if (chkX.Checked)
            {
                arguments += " /X";
            }
            if (chkV.Checked)
            {
                arguments += " /V";
            }
            if (chkTS.Checked)
            {
                arguments += " /TS";
            }
            if (chkFP.Checked)
            {
                arguments += " /FP";
            }
            if (chkBYTES.Checked)
            {
                arguments += " /BYTES";
            }
            if (chkNS.Checked)
            {
                arguments += " /NS";
            }
            if (chkNC.Checked)
            {
                arguments += " /NC";
            }
            if (chkNFL.Checked)
            {
                arguments += " /NFL";
            }
            if (chkNDL.Checked)
            {
                arguments += " /NDL";
            }
            if (chkNP.Checked)
            {
                arguments += " /NP";
            }
            if (chkETA.Checked)
            {
                arguments += " /ETA";
            }

            if (chkLOG.Checked)
            {
                arguments += " /LOG:" + txtLOG.Text;
            }
            if (chkLOGAPPEND.Checked)
            {
                arguments += " /LOG+:" + txtLOGAPPEND.Text;
            }
            if (chkUNILOG.Checked)
            {
                arguments += " /UNILOG:" + txtUNILOG.Text;
            }
            if (chkUNILOGAPPEND.Checked)
            {
                arguments += " /UNILOG+:" + txtUNILOGAPPEND.Text;
            }
            if (chkTEE.Checked)
            {
                arguments += " /TEE";
            }
            if (chkNJH.Checked)
            {
                arguments += " /NJH";
            }
            if (chkNJS.Checked)
            {
                arguments += " /NJS";
            }
            if (chkUNICODE.Checked)
            {
                arguments += " /UNICODE";
            }













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
        private TabPage tabLogging;
        private TabPage tabJob;
        private TabPage tabRemarks;

        //get version
        private string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();


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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Copy to clipboard
            Clipboard.SetText(txtCommand.Text);
            
        }
    }
}

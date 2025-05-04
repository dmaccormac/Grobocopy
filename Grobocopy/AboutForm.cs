namespace Grobocopy
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void lnkGithub_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openHyperlink("https://www.github.com/dmaccormac/Grobocopy");
        }

        private void openHyperlink(string url)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close the aboutForm
            this.Close();
        }

        private void picCoffee_Click(object sender, EventArgs e)
        {
            openHyperlink("https://www.buymeacoffee.com/dmaccormac");
        }
    }
}

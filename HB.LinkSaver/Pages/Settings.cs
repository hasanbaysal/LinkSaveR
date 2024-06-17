namespace HB.LinkSaver.Pages
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("do you want to back up files", "back up", MessageBoxButtons.YesNo);

            if (result == DialogResult.No) return;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var backupFolderName = "backup-" + DateTime.Now.ToString("yyyy-dd-mm-ss");

            Directory.CreateDirectory(Path.Combine(desktopPath, backupFolderName));

            File.Copy(Path.Combine(Directory.GetCurrentDirectory(), LinkManager.LinksPath), Path.Combine(desktopPath, backupFolderName, LinkManager.LinksPath));
            File.Copy(Path.Combine(Directory.GetCurrentDirectory(), LinkManager.CategoriesPath), Path.Combine(desktopPath, backupFolderName, LinkManager.CategoriesPath));

            MessageBox.Show(@"The files have been copied to the desktop. you can use these files in case you lose the files on your system. you need to add the json extension files in the backup folder to the directory where the application is running.", backupFolderName + " BACK UP FOLDER CREATED", MessageBoxButtons.OK);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            var txt = Program.GetUseServerSettingsStatus() ? "server active" : "server deactivated ";

            lblStatus.ForeColor = Program.GetUseServerSettingsStatus() ? Color.Green : Color.Red;
            lblStatus.Text = txt;


            btnServer.Text = Program.GetUseServerSettingsStatus() ? "deactivate the server" : "activate the server";

        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "user.txt");
            var status = Program.GetUseServerSettingsStatus() ? "server:0" : "server:1";
            File.WriteAllText(path, status);
            MessageBox.Show("server status changed. Application will be restart");
            Application.Restart();

        }
    }
}

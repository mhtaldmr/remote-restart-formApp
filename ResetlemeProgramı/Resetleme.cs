namespace ResetlemeProgramı
{
    public partial class Resetleme : Form
    {
        public Resetleme()
        {
            InitializeComponent();
        }
        private void Resetleme_Load(object sender, EventArgs e)
        {

        }

        private void STG_01_Click(object sender, EventArgs e)
        {
            string path1 = @"C:\ProgramData\Resetleme Komutları\Shipping Ekranları Resetleme\Shipping Ekranı - 1 - Restart.bat";
            MessageBoxItem.MessageBoxConfirm(path1);
        }

        private void STG_02_Click(object sender, EventArgs e)
        {
            string path2 = @"C:\ProgramData\Resetleme Komutları\Shipping Ekranları Resetleme\Shipping Ekranı - 2 - Restart.bat";
            MessageBoxItem.MessageBoxConfirm(path2);
        }

        private void STG_03_Click(object sender, EventArgs e)
        {
            string path3 = @"C:\ProgramData\Resetleme Komutları\Shipping Ekranları Resetleme\Shipping Ekranı - 3 - Restart.bat";
            MessageBoxItem.MessageBoxConfirm(path3);
        }
        private void STG_04_Click(object sender, EventArgs e)
        {
            string path4 = @"C:\ProgramData\Resetleme Komutları\Shipping Ekranları Resetleme\Shipping Ekranı - 4 - Restart.bat";
            MessageBoxItem.MessageBoxConfirm(path4);
        }

        private void STG_05_Click(object sender, EventArgs e)
        {
            string path5 = @"C:\ProgramData\Resetleme Komutları\Shipping Ekranları Resetleme\Shipping Ekranı - 5 - Restart.bat";
            MessageBoxItem.MessageBoxConfirm(path5);
        }

        private void STG_06_Click(object sender, EventArgs e)
        {
            string path6 = @"C:\ProgramData\Resetleme Komutları\Shipping Ekranları Resetleme\Shipping Ekranı - 6 - Restart.bat";
            MessageBoxItem.MessageBoxConfirm(path6);
        }

        private void STG_07_Click(object sender, EventArgs e)
        {
            string path7 = @"C:\ProgramData\Resetleme Komutları\Shipping Ekranları Resetleme\Shipping Ekranı - 7 - Restart.bat";
            MessageBoxItem.MessageBoxConfirm(path7);
        }

        private void STG_08_Click(object sender, EventArgs e)
        {
            string path8 = @"C:\ProgramData\Resetleme Komutları\Shipping Ekranları Resetleme\Shipping Ekranı - 8 - Restart.bat";
            MessageBoxItem.MessageBoxConfirm(path8);
        }

        private void STG_09_Click(object sender, EventArgs e)
        {
            string path9 = @"C:\ProgramData\Resetleme Komutları\Shipping Ekranları Resetleme\Shipping Ekranı - 9 - Restart.bat";
            MessageBoxItem.MessageBoxConfirm(path9);
        }

        private void STG_10_Click(object sender, EventArgs e)
        {
            string path10 = @"C:\ProgramData\Resetleme Komutları\Shipping Ekranları Resetleme\Shipping Ekranı - 10 - Restart.bat";
            MessageBoxItem.MessageBoxConfirm(path10);
        }

        private void STG_11_Click(object sender, EventArgs e)
        {
            string path11 = @"C:\ProgramData\Resetleme Komutları\Shipping Ekranları Resetleme\Shipping Ekranı - 11 - Restart.bat";
            MessageBoxItem.MessageBoxConfirm(path11);
        }
        private void STG_12_Click(object sender, EventArgs e)
        {
            string path12 = @"C:\ProgramData\Resetleme Komutları\Shipping Ekranları Resetleme\Shipping Ekranı - 12 - Restart.bat";
            MessageBoxItem.MessageBoxConfirm(path12);
        }
        private void STG_EXPRESS_Click(object sender, EventArgs e)
        {
            string path13 = @"C:\ProgramData\Resetleme Komutları\Shipping Ekranları Resetleme\Shipping Ekranı - 13 - Restart.bat";
            MessageBoxItem.MessageBoxConfirm(path13);
        }

        private void PC_GALILEO_Click(object sender, EventArgs e)
        {
            string pathGalileo = @"C:\ProgramData\Resetleme Komutları\Galileo Bilgisayarı Resetleme\Galileo Bilgisayarı Resetleme.bat";
            MessageBoxItem.MessageBoxConfirm(pathGalileo);
        }

        private void PC_WMS_Click(object sender, EventArgs e)
        {
            string pathWMS = @"C:\ProgramData\Resetleme Komutları\WMS Bilgisayarı Resetleme\WMS Bilgisayarı Resetleme.bat";
            MessageBoxItem.MessageBoxConfirm(pathWMS);
        }
    }
}
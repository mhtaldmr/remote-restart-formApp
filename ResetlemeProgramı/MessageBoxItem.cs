using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetlemeProgramı
{
    public class MessageBoxItem
    {
        public static void MessageBoxConfirm(string path)
        {
            var confirmResult = MessageBox.Show("Seçtiğiniz bilgisayarı resetlemek istediğinize emin misiniz?"
                , "Ekran Resetleme Onay"
                , MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Process.Start(path);
                Process.Start(path);
                Process.Start(path);
            }
        }
    }
}

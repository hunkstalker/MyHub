using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLauncher
{
    public partial class mainForm : Form
    {
        bool letsClose = false;
        int time;

        //string root = "\"cd /\"";
        string cmd_shutdown = "shutdown -s -t "; 
        string cmd_cancel = "shutdown -a";

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            numUpDo_Horas.Controls.RemoveAt(0);
            numUpDo_Mins.Controls.RemoveAt(0);
            dD_options.Items.Add("Shutdown");
            dD_options.Items.Add("Cancel");
        }

        private void mainForm_Closing(object sender, FormClosingEventArgs e)
        {
            if(!letsClose)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    Hide();
                    iconSystray.Visible = true;
                }
            }
        }

        private void iconSystray_DoubleClick(object sender, EventArgs e)
        {
            Show();
            iconSystray.Visible = false;
        }

        private void iconMenu_Salir_Click(object sender, EventArgs e)
        {
            letsClose = true;
            Close();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            switch (dD_options.SelectedIndex)
            {
                case 0: shutdown(); break;
                case 1:  cancel(); break;
                default: break;
            }
        }

        private void cancel()
        {
            animBtn();
            //System.Diagnostics.Process.Start("cmd.exe", root);
            System.Diagnostics.Process.Start("cmd.exe", "/C" + cmd_cancel);
        }

        private void shutdown()
        {
            animBtn();
            cmd_shutdown += timeCalc();
            //System.Diagnostics.Process.Start("CMD.exe", root);
            System.Diagnostics.Process.Start("cmd.exe", "/C " + cmd_shutdown);
        }

        private void animBtn()
        {
            btn_accept.Location = new Point(18, 70);
            Thread.Sleep(100);
            btn_accept.Location = new Point(12, 63);
        }

        private int timeCalc()
        {
            time = 0;
            time = (int)numUpDo_Horas.Value * 60 * 60;
            time = time + (int)numUpDo_Mins.Value * 60;
            return time;
        }
    }
}

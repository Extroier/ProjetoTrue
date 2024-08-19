using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ProjetoMosquitoVelho
{
    public partial class frmSplash : Form
    {
        
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        public frmSplash()
        {
            InitializeComponent();
        }

        private void PgbProgress_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Relógio do fim ligado.");
            PgbProgress.Value = PgbProgress.Value + 1;
             if (PgbProgress.Value<99)
            {
                PgbProgress.Value = PgbProgress.Value;
                lblNumberPercent.Text = PgbProgress.Value.ToString();
             
            }
             else
            {
                frmLogin open = new frmLogin();
                open.Show();
                this.Hide();
                tmrSplash.Enabled = false;
            }
            
        }
       
        private void lblNumberPercent_Click(object sender, EventArgs e)
        {

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            
                IntPtr hMenu = GetSystemMenu(this.Handle, false);
                int MenuCount = GetMenuItemCount(hMenu) - 1;
                RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            
        }
    }
}

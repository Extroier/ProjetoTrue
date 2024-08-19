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
    public partial class frmFuncionarios : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal open = new frmMenuPrincipal();
            open.Show();
            this.Hide();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            {
                IntPtr hMenu = GetSystemMenu(this.Handle, false);
                int MenuCount = GetMenuItemCount(hMenu) - 1;
                RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
          
        }

        //public void buscaCEP(string numCep)
        //try
        // {WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient(); }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
         
        }
    }
}

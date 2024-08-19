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
    public partial class frmMenuPrincipal : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmMenuPrincipal()
        {
            InitializeComponent();

        }
        public frmMenuPrincipal(string nome)
        {
            InitializeComponent();
            lblUser.Text = nome;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin open = new frmLogin();
            open.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmCalculadora open = new frmCalculadora();
            open.Show();
            this.Hide();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios open = new frmFuncionarios();
            open.Show();
            this.Hide();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            {
                IntPtr hMenu = GetSystemMenu(this.Handle, false);
                int MenuCount = GetMenuItemCount(hMenu) - 1;
                RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos open = new frmProdutos(lblUser.Text);
            open.Show();
            this.Hide();
        }
        public void frmLogin(string nome)
        {
            frmLogin user = new frmLogin(lblUser.Text);
            lblUser.Text = user.Text;

        }
        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}

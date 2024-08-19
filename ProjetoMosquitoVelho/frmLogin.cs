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
    public partial class frmLogin : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(string nome)
        {
            InitializeComponent();
            txtUser.Text = "User";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            /*
            this.Close();*/
            Application.Exit();                                           
        }
      
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("User") && txtSenha.Text.Equals("senha")) 
            {
                frmMenuPrincipal open = new frmMenuPrincipal(txtUser.Text); 
                open.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido");
                limparCampos();
            }
        }
        public void limparCampos()
        {
            txtUser.Clear();
            txtSenha.Clear();
            txtUser.Focus();

        }

        private void PctImagem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Self Destruction Mode Activated.");
        }
   
    private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
                    }
            if (e.KeyCode == Keys.Delete)
            {
                Application.Exit();
            }

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }

        private void PctImagem_Click(object sender, EventArgs e)
        
        {
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

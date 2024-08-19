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
    public partial class frmProdutos : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmProdutos(string user)
        {
            InitializeComponent();
            lblUser.Text = user;          

        }
            private void frmProdutos_Load(object sender, EventArgs e)
        {

            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
        public void LimparCampos()
        {
            txtProduto.Clear();
            ltbProduto.Items.Clear();
            txtProduto.Focus();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal open = new frmMenuPrincipal(lblUser.Text);
            open.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();

        }

        private void ltbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pegando o indice selecionado
            //lblEscolhido.Text = ltbProduto.SelectedIndex.ToString();

            //pegando o valor selecionador
            if (ltbProduto.SelectedItem != null)
            {
                lblEscolhido.Text = ltbProduto.SelectedItem.ToString();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //ltbProduto.Items.Clear();
            ltbProduto.Items.Add(txtProduto.Text);
            txtProduto.Clear();
            txtProduto.Focus();
        }


        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ltbProduto.Items.Add(txtProduto.Text);
                txtProduto.Clear();
                txtProduto.Focus();
            }
            if (e.KeyCode == Keys.L)
            {

                btnFalse.Visible = true;
            }

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            ltbProduto.Items.RemoveAt(ltbProduto.SelectedIndex);
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Relógio do fim ligado.");
                frmListarProdutos open = new frmListarProdutos();
                open.Show();
                this.Hide();
                //Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
    

        }
    }
}


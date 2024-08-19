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
    public partial class frmListarProdutos : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmListarProdutos()
        {

            InitializeComponent();
            //execultando o método para carregar combobox
            CarregaCombo();
        }
        //criando o método carrega
       public void CarregaCombo()
        {
            produtos[0] = "Saber";
            produtos[1] = "Archer";
            produtos[2] = "Lancer";
            produtos[3] = "Caster";
            produtos[4] = "Berserker";
            produtos[5] = "Rider";
            produtos[6] = "Assassin";
            produtos[7] = "Ruler";
            produtos[8] = "Avenger";
            produtos[9] = "Pretender";
            
            for (int i = 0; i < produtos.Length; i++)
            {
                cbbProdutos.Items.Add(produtos[i]);
            }
        }

    private void frmListarProdutos_Load(object sender, EventArgs e)
        {
            {
                IntPtr hMenu = GetSystemMenu(this.Handle, false);
                int MenuCount = GetMenuItemCount(hMenu) - 1;
                RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            }
        }
        string[] produtos = new string[10];
        private void btnCarregar_Click(object sender, EventArgs e)
        { //criar um vetor
          //int Valor não necessário.
          // int Valor = 10;
          // string[] produtos = new string[Valor];
          // produtos[0] = "Destino";
          //produtos[4] = "Futuro";
          //produtos[1+5] = "Aventura";
          // MessageBox.Show("Produto", produtos[6]);
          //MessageBox.Show("Produto", produtos[4]);
          //MessageBox.Show("Produto", produtos[0]);
            ltbListaProdutos.Items.Clear();
            produtos[0] = "Saber";
            produtos[1] = "Archer"; 
            produtos[2] = "Lancer"; 
            produtos[3] = "Caster";
            produtos[4] = "Berserker";
            produtos[5] = "Rider";
            produtos[6] = "Assassin";
            produtos[7] = "Ruler";
            produtos[8] = "Avenger";
            produtos[9] = "Pretender";
            //Percorrendo o vetor criado
            for (int i = 0; i <produtos.Length; i++)
            {
                ltbListaProdutos.Items.Add(produtos[i]);
            }
         
        }

        private void cbbNames_MouseHover(object sender, EventArgs e)
        {
            // MessageBox.Show("oq esta ocorrendo");
        }

        private void cbbNames_MouseClick(object sender, MouseEventArgs e)
              
        {
            cbbNames.Items.Clear();
            produtos[0] = "Saber";
            produtos[1] = "Archer";
            produtos[2] = "Lancer";
            produtos[3] = "Caster";
            produtos[4] = "Berserker";
            produtos[5] = "Rider";
            produtos[6] = "Assassin";
            produtos[7] = "Ruler";
            produtos[8] = "Avenger";
            produtos[9] = "Pretender";

            for (int i = 0; i < produtos.Length; i++)
            {
                cbbNames.Items.Add(produtos[i]);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin open = new frmLogin();
            open.Show();
            this.Hide();
        }

        private void btnTestarPessoa_Click(object sender, EventArgs e)
        {
            //instanceando o objeto pessoa
            Pessoa Truename = new Pessoa();
            Truename.Nome = "Artoria";
            lblTrueName.Text = Truename.Nome;
            //Pessoa E = new Pessoa();
            //E.Email = "Pendragon"();
            //lblTrueName.Text = E.Email;
            Pessoa Vivo = new Pessoa();
            Vivo.Alive = true;
            Pessoa Age = new Pessoa();
            Age.Idade = 23;

           }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Bilhete bilhete = new Bilhete();
            bilhete.Documento = txtDocumento.Text;
            bilhete.NumeroCartao = mtbNumerodoCartao.Text;
            
            lblDocumento.Text = bilhete.Documento;
            lblNumerodoCartao.Text = bilhete.NumeroCartao;
           // bilhete.reservar(psg "Star Rail");

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnTestaLogin_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin(txtTestaLogin.Text);
            abrir.Show();
            this.Hide();
        }

        private void txtTestaLogin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ltbReservas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //static bool flag = false;
        // class Conexao 


    }
}

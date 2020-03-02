using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftManager.Models;
using SoftManager.Repositories;

namespace SoftManager
{
    public partial class Caixa : Form
    {
        private Register Register
        {
            get
            {
                return new Register()
                {
                    //id = string.IsNullOrEmpty(textID.Text) ? 0 : int.Parse(textID.Text),
                    codigo = int.Parse(txtcodprod.Text),
                    desconto = int.Parse(txtdiscount.Text),
                    valorsaida = int.Parse(txtunityprice.Text),
                    qtd = int.Parse(txtprodavailable.Text)
                };
            }
        }

        private DadosCliente Read
        {
            get
            {
                return new DadosCliente()
                {
                    //id = string.IsNullOrEmpty(textID.Text) ? 0 : int.Parse(textID.Text),
                    codigo = int.Parse(txtcodprod.Text),
                    desconto = int.Parse(txtdiscount.Text),
                    valorsaida = int.Parse(txtunityprice.Text),
                    qtd = int.Parse(txtprodavailable.Text)
                };
            }
        }

        private List<TextBox> _textBoxes;

       
        private void ExibirDados()
        {
            try
            {

                List<DadosCliente> produto = ProductRepository.GetRegisterById(Convert.ToInt32(txtcodprod.Text));


                //txtcodprod.Text = dados
                txtdiscount.Text = produto[0].desconto.ToString();
                txtunityprice.Text = produto[0].valorsaida.ToString();
                txtprodavailable.Text = produto[0].qtd.ToString();

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }

        public Caixa()
        {
            InitializeComponent();

            _textBoxes = new List<TextBox>()
            {
                txtcodprod,
                txtdiscount,
                txtunityprice,
                txtprodavailable,
                //txtsenha,
                //txtobs
            };

            //ExibirDados();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txtgetcpf_Click(object sender, EventArgs e)
        {

        }

        private void entercpf_button_Click(object sender, EventArgs e)
        {
            txtgetcpf.Text = txtcpf.Text;
        }

        private void enter_Click(object sender, EventArgs e)
        {
            ExibirDados();
        }
    }
}

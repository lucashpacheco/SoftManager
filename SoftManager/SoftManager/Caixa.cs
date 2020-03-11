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
using System.Threading;


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

        private List<TextBox> _textBoxes;


        private void ExibirDados()
        {
            try
            {



                var registers = ProductRepository.GetRegisterById(int.Parse(txtcodprod.Text));

                txtdiscount.Text = registers[0].desconto.ToString();
                txtunityprice.Text = registers[0].valorsaida.ToString();
                txtprodavailable.Text = registers[0].qtd.ToString();



            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }

        public void ExibirDadosDeTodos()
        {
            try
            {
                VerTodosProd resultado = new VerTodosProd();

                int codigo = resultado.PassarDadosDeTodos();

                var registers = ProductRepository.GetRegisterById(codigo);

                txtdiscount.Text = registers[0].desconto.ToString();
                txtunityprice.Text = registers[0].valorsaida.ToString();
                txtprodavailable.Text = registers[0].qtd.ToString();



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
             
            };

        }
      
        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }
        private void AllPriceInsert()
        {
            double unityprice = Convert.ToDouble(txtunityprice.Text);
            int qtdinsert = Convert.ToInt32(txtqtdinsert.Text);

            var allprice = qtdinsert * unityprice;

            MessageBox.Show(Convert.ToString(allprice));

            txtallprice.Text = Convert.ToString(qtdinsert * unityprice);


        }
        private void txtgetcpf_Click(object sender, EventArgs e)
        {

        }

        private void entercpf_button_Click(object sender, EventArgs e)
        {
            txtgetcpf.Text = txtcpf.Text;
        }

        private void Caixa_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            AllPriceInsert();

        }

        private void go_allprod_btn_Click(object sender, EventArgs e)
        {
            Thread inallprod;

            inallprod = new Thread(in_allprod);
            inallprod.SetApartmentState(ApartmentState.STA);
            inallprod.Start();

        
        }
        private void in_allprod()
        {
            Application.Run(new VerTodosProd());

        }
    }
}

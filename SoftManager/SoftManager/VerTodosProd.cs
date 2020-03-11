using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftManager.Repositories;
using SoftManager;


namespace SoftManager
{
    public partial class VerTodosProd : Form
    {
        public VerTodosProd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerTodos();
        }

        public void VerTodos()
        {
            var registers = ProductRepository.GetAllRegisterFilter();

            dgvAllProdView.DataSource = registers;
        }


        public int PassarDadosDeTodos()
        {
            int selectedRowCount = dgvAllProdView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            int codigo = 0;

            if (selectedRowCount > 0)
            {

                try
                {



                    foreach (DataGridViewRow row in dgvAllProdView.SelectedRows)
                    {
                        if (row.IsNewRow) continue;
                        codigo = (int)row.Cells[0].Value;

                        

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
                
            }
            return codigo;

          

        }

        
        private void insertfromallview_btn_Click(object sender, EventArgs e)
        {
            
            Caixa resultado = new Caixa();
            
            resultado.ExibirDadosDeTodos();
            PassarDadosDeTodos();

        }



    }

    
}

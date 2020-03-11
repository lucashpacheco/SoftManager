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

        private void VerTodos()
        {
            var registers = ProductRepository.GetAllRegisterFilter();

            dgvAllProdView.DataSource = registers;
        }

    }
}

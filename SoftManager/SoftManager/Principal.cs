using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SoftManager
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void operation_button_Click(object sender, EventArgs e)
        {

            Thread inoperation;

            inoperation = new Thread(in_operation);
            inoperation.SetApartmentState(ApartmentState.STA);
            inoperation.Start();

            this.Close();

        }

        private void clients_button_Click(object sender, EventArgs e)
        {

            Thread inclients;

            inclients = new Thread(in_clients);
            inclients.SetApartmentState(ApartmentState.STA);
            inclients.Start();

            this.Close();
        }

        private void storage_button_Click(object sender, EventArgs e)
        {

            Thread instorage;

            instorage = new Thread(in_storaged);
            instorage.SetApartmentState(ApartmentState.STA);
            instorage.Start();

            this.Close();
        }

        private void employees_button_Click(object sender, EventArgs e)
        {

            Thread inemployees;

            inemployees = new Thread(in_empployees);
            inemployees.SetApartmentState(ApartmentState.STA);
            inemployees.Start();

            this.Close();

        }

        private void in_operation()
        {
            Application.Run(new Caixa());
            
        }

        private void in_storaged()
        {
            Application.Run(new Estoque());
            
        }

        private void in_clients()
        {
            Application.Run(new Clientes());
            
        }

        private void in_empployees()
        {
            Application.Run(new Operadores());
            
        }


    }
}

namespace SoftManager
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.clients_button = new System.Windows.Forms.Button();
            this.storage_button = new System.Windows.Forms.Button();
            this.buy_button = new System.Windows.Forms.Button();
            this.operation_button = new System.Windows.Forms.Button();
            this.r_operation_button = new System.Windows.Forms.Button();
            this.r_sell_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.employees_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clients_button
            // 
            this.clients_button.Location = new System.Drawing.Point(80, 106);
            this.clients_button.Name = "clients_button";
            this.clients_button.Size = new System.Drawing.Size(75, 23);
            this.clients_button.TabIndex = 0;
            this.clients_button.Text = "Clientes";
            this.clients_button.UseVisualStyleBackColor = true;
            this.clients_button.Click += new System.EventHandler(this.clients_button_Click);
            // 
            // storage_button
            // 
            this.storage_button.Location = new System.Drawing.Point(80, 149);
            this.storage_button.Name = "storage_button";
            this.storage_button.Size = new System.Drawing.Size(75, 23);
            this.storage_button.TabIndex = 1;
            this.storage_button.Text = "Estoque";
            this.storage_button.UseVisualStyleBackColor = true;
            this.storage_button.Click += new System.EventHandler(this.storage_button_Click);
            // 
            // buy_button
            // 
            this.buy_button.Location = new System.Drawing.Point(80, 190);
            this.buy_button.Name = "buy_button";
            this.buy_button.Size = new System.Drawing.Size(75, 23);
            this.buy_button.TabIndex = 2;
            this.buy_button.Text = "Compras";
            this.buy_button.UseVisualStyleBackColor = true;
            // 
            // operation_button
            // 
            this.operation_button.Location = new System.Drawing.Point(80, 68);
            this.operation_button.Name = "operation_button";
            this.operation_button.Size = new System.Drawing.Size(75, 23);
            this.operation_button.TabIndex = 3;
            this.operation_button.Text = "Caixa";
            this.operation_button.UseVisualStyleBackColor = true;
            this.operation_button.Click += new System.EventHandler(this.operation_button_Click);
            // 
            // r_operation_button
            // 
            this.r_operation_button.Location = new System.Drawing.Point(202, 131);
            this.r_operation_button.Name = "r_operation_button";
            this.r_operation_button.Size = new System.Drawing.Size(134, 23);
            this.r_operation_button.TabIndex = 4;
            this.r_operation_button.Text = "Fluxo de Caixa";
            this.r_operation_button.UseVisualStyleBackColor = true;
            // 
            // r_sell_button
            // 
            this.r_sell_button.Location = new System.Drawing.Point(202, 166);
            this.r_sell_button.Name = "r_sell_button";
            this.r_sell_button.Size = new System.Drawing.Size(134, 23);
            this.r_sell_button.TabIndex = 5;
            this.r_sell_button.Text = "Fluxo de Vendas";
            this.r_sell_button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Contas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // employees_button
            // 
            this.employees_button.Location = new System.Drawing.Point(202, 68);
            this.employees_button.Name = "employees_button";
            this.employees_button.Size = new System.Drawing.Size(88, 23);
            this.employees_button.TabIndex = 7;
            this.employees_button.Text = "Operadorees";
            this.employees_button.UseVisualStyleBackColor = true;
            this.employees_button.Click += new System.EventHandler(this.employees_button_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 322);
            this.Controls.Add(this.employees_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.r_sell_button);
            this.Controls.Add(this.r_operation_button);
            this.Controls.Add(this.operation_button);
            this.Controls.Add(this.buy_button);
            this.Controls.Add(this.storage_button);
            this.Controls.Add(this.clients_button);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clients_button;
        private System.Windows.Forms.Button storage_button;
        private System.Windows.Forms.Button buy_button;
        private System.Windows.Forms.Button operation_button;
        private System.Windows.Forms.Button r_operation_button;
        private System.Windows.Forms.Button r_sell_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button employees_button;
    }
}


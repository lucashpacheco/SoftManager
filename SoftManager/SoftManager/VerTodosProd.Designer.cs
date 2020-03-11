namespace SoftManager
{
    partial class VerTodosProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAllProdView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.insertfromallview_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProdView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllProdView
            // 
            this.dgvAllProdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProdView.Location = new System.Drawing.Point(12, 42);
            this.dgvAllProdView.Name = "dgvAllProdView";
            this.dgvAllProdView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllProdView.Size = new System.Drawing.Size(526, 253);
            this.dgvAllProdView.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "PESQUISAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // insertfromallview_btn
            // 
            this.insertfromallview_btn.Location = new System.Drawing.Point(405, 7);
            this.insertfromallview_btn.Name = "insertfromallview_btn";
            this.insertfromallview_btn.Size = new System.Drawing.Size(133, 23);
            this.insertfromallview_btn.TabIndex = 3;
            this.insertfromallview_btn.Text = "NSERIR";
            this.insertfromallview_btn.UseVisualStyleBackColor = true;
            this.insertfromallview_btn.Click += new System.EventHandler(this.insertfromallview_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PESQUISE POR NOME";
            // 
            // VerTodosProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertfromallview_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvAllProdView);
            this.Name = "VerTodosProd";
            this.Text = "TODOS OS PRODUTOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllProdView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button insertfromallview_btn;
        private System.Windows.Forms.Label label1;
    }
}
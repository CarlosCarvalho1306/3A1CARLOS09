namespace CARLOSEDUARDO3A1_09
{
    partial class Frm_EPA
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_mercadoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_custo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.datagrid_mercadorias = new System.Windows.Forms.DataGridView();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_mudatr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_mercadorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(74, 101);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(137, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_mercadoria
            // 
            this.txt_mercadoria.Location = new System.Drawing.Point(74, 147);
            this.txt_mercadoria.Name = "txt_mercadoria";
            this.txt_mercadoria.Size = new System.Drawing.Size(137, 20);
            this.txt_mercadoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mercadoria";
            // 
            // txt_custo
            // 
            this.txt_custo.Location = new System.Drawing.Point(74, 199);
            this.txt_custo.Name = "txt_custo";
            this.txt_custo.Size = new System.Drawing.Size(137, 20);
            this.txt_custo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preco unico";
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(74, 250);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(137, 20);
            this.txt_categoria.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria da mercadoria";
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(74, 289);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(137, 39);
            this.btn_inserir.TabIndex = 8;
            this.btn_inserir.Text = "INSERIR MERCADORIA";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // datagrid_mercadorias
            // 
            this.datagrid_mercadorias.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.datagrid_mercadorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_mercadorias.Location = new System.Drawing.Point(320, 85);
            this.datagrid_mercadorias.Name = "datagrid_mercadorias";
            this.datagrid_mercadorias.Size = new System.Drawing.Size(408, 162);
            this.datagrid_mercadorias.TabIndex = 9;
            this.datagrid_mercadorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_mercadorias_CellClick);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(320, 289);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(185, 39);
            this.btn_apagar.TabIndex = 10;
            this.btn_apagar.Text = "APAGAR REGISTRO";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_mudatr
            // 
            this.btn_mudatr.Location = new System.Drawing.Point(553, 289);
            this.btn_mudatr.Name = "btn_mudatr";
            this.btn_mudatr.Size = new System.Drawing.Size(175, 39);
            this.btn_mudatr.TabIndex = 11;
            this.btn_mudatr.Text = "ALTERAR REGISTRO";
            this.btn_mudatr.UseVisualStyleBackColor = true;
            this.btn_mudatr.Click += new System.EventHandler(this.btn_mudatr_Click);
            // 
            // Frm_EPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_mudatr);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.datagrid_mercadorias);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_custo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mercadoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "Frm_EPA";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_EPA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_mercadorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_mercadoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_custo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.DataGridView datagrid_mercadorias;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_mudatr;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CARLOSEDUARDO3A1_09.Codigo.BLL;
using CARLOSEDUARDO3A1_09.Codigo.DTO;


namespace CARLOSEDUARDO3A1_09
{
    public partial class Frm_EPA : Form
    {
        EpaBLL epaBLL = new EpaBLL();
        EpaDTO epaDTO = new EpaDTO();

        public Frm_EPA()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            epaDTO.Mercadoria = txt_mercadoria.Text;
            epaDTO.Custo = int.Parse(txt_custo.Text);
            epaDTO.Categoria = txt_categoria.Text;

            epaBLL.Inserir(epaDTO);

            MessageBox.Show("Cadastro feito!", "EPA");

            epaBLL.Listar();

        }

        private void btn_mudatr_Click(object sender, EventArgs e)
        {
            epaDTO.Id = int.Parse(txt_id.Text);
            epaDTO.Mercadoria = txt_mercadoria.Text;
            epaDTO.Custo = int.Parse(txt_custo.Text);
            epaDTO.Categoria = txt_categoria.Text;

            epaBLL.Editar(epaDTO);

            MessageBox.Show("Alteracao concluida!", "EPA");


            epaBLL.Listar();

        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            epaDTO.Id = int.Parse(txt_id.Text);

            epaBLL.Exclui(epaDTO);
            MessageBox.Show("Registro apagado!", "EPA");

            epaBLL.Listar();
        }

        private void Frm_EPA_Load(object sender, EventArgs e)
        {
            datagrid_mercadorias.DataSource = epaBLL.Listar();
        }

        private void datagrid_mercadorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = datagrid_mercadorias.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_mercadoria.Text = datagrid_mercadorias.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_custo.Text = datagrid_mercadorias.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_categoria.Text = datagrid_mercadorias.Rows[e.RowIndex].Cells[3].Value.ToString();

        }
    }
}

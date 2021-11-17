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

namespace CARLOSEDUARDO3A1_09.Forms
{
    public partial class Frm_Usuario : Form
    {

        UsuarioBLL usuarioBLL = new UsuarioBLL();
        UsuarioDTO usuarioDTO = new UsuarioDTO();

        public Frm_Usuario()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            usuarioDTO.Usuario = txt_usuario.Text;
            usuarioDTO.Senha = txt_password.Text;

            if (usuarioBLL.RealizarLogin(usuarioDTO) == true)
            {
                Frm_EPA form = new Frm_EPA();
                form.ShowDialog();
            }


        }
    }
}

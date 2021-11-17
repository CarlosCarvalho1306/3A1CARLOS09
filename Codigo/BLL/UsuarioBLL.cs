using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CARLOSEDUARDO3A1_09.Codigo.DAL;
using CARLOSEDUARDO3A1_09.Codigo.DTO;

namespace CARLOSEDUARDO3A1_09.Codigo.BLL
{
    class UsuarioBLL
    {

        BancoDAL conect = new BancoDAL();
        string tabela = "contas";

        public bool RealizarLogin(UsuarioDTO usuarioDTO)
        {
            string sql = $"select * from {tabela} where nome_conta = '{usuarioDTO.Usuario}' and senha_conta = '{usuarioDTO.Senha}'";
            DataTable dt = conect.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }




    }
}

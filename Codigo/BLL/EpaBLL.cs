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
    class EpaBLL
    {
        BancoDAL conect = new BancoDAL();
        string tabela = "mercadorias";
        public void Inserir(EpaDTO epaDTO)
        {
            string inserir = $"insert into {tabela} value (null, '{epaDTO.Mercadoria}', '{epaDTO.Custo}', '{epaDTO.Categoria}')";
            conect.ExecutarComando(inserir);
        }

        public void Editar(EpaDTO epaDTO)
        {
            string alterar = $"update {tabela} set mercadoria  = '{epaDTO.Mercadoria}', custo = '{epaDTO.Custo}'," +
                $" categoria = '{epaDTO.Categoria}'  where id = '{epaDTO.Id}'";
            conect.ExecutarComando(alterar);
        }

        public void Exclui(EpaDTO prodDTO)
        {
            string excluir = $"delete from {tabela} where id = '{prodDTO.Id}'";
            conect.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conect.ExecutarConsulta(sql);
        }


    }
}

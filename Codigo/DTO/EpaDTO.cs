using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARLOSEDUARDO3A1_09.Codigo.DTO
{
    class EpaDTO
    {
        private int _id;
        private string _mercadoria;
        private int _custo;
        private string _categoria;

        public int Id { get => _id; set => _id = value; }
        public string Mercadoria { get => _mercadoria; set => _mercadoria = value; }
        public int Custo { get => _custo; set => _custo = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
    }
}

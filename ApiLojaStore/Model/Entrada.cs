using System.ComponentModel.DataAnnotations.Schema;

namespace ApiLojaStore.Model
{
    public class Entrada
    {
        public int Id { get; set; }
        public string data_entrada{ get; set; }
        public string data_fabricacao { get; set; }
        public string data_validade { get; set; }
        public string observacao{ get; set; }
        public string titulo { get; set; }

        [ForeignKey("User")]
        public int idUser { get; set; }
        public int qtd { get; set; }


        [ForeignKey("Produto")]
        public int idProduto { get; set; }
    }
}

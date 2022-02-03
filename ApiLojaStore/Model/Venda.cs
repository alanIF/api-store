using System.ComponentModel.DataAnnotations.Schema;

namespace ApiLojaStore.Model
{
    public class Venda
    {
        public int Id { get; set; }
        public string data_venda { get; set; }
        public int qtd { get; set; }

        public string observacao { get; set; }

        [ForeignKey("User")]
        public int idComprador{ get; set; }

        [ForeignKey("Produto")]
        public int idProduto { get; set; }
    }
}

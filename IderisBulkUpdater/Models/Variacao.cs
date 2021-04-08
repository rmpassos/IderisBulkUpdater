using System;
using System.Collections.Generic;
using System.Text;

namespace IderisBulkUpdater.Models
{
    public class Variacao
    {
        public int VariacaoId { get; set; }
        public int QuantidadeVariacao { get; set; }
        public object QuantidadeVariacaoReserva { get; set; }
        public string SkuVariacao { get; set; }
        public string CaminhoImagemVariacao { get; set; }
        public List<Combinacao> Combinacao { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace IderisBulkUpdater.Models
{
    public class Combinacao
    {
        public int TipoVariacaoId { get; set; }
        public string TipoVariacao { get; set; }
        public string Descricao { get; set; }
        public int? TipoVariacaoValorId { get; set; }
        public string TipoVariacaoValor { get; set; }
    }
}

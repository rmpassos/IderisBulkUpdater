using System;
using System.Collections.Generic;
using System.Text;

namespace IderisBulkUpdater.Models
{
    public class Root
    {
        public Paging Paging { get; set; }
        public List<ProdutoIderis> Result { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace IderisBulkUpdater.Models
{
    public class Paging
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
    }
}

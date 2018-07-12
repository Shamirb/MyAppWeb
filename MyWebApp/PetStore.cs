using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp
{
    public class PetStore
    {
        public int Id { get; set; }
        public int PetStoreId { get; set; }
        public string Item { get; set; }
        public int Qty { get; set; }
        public DateTime LastupdatedDate { get; set; }

    }
}
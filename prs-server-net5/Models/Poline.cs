using System;
namespace prs_server_net5.Models {

    public class Poline {

        public string PartNbr { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Poline() {}
    }
}


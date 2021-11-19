using System;
using System.Collections.Generic;

namespace prs_server_net5.Models {

    public class Po {

        public Vendor Vendor { get; set; }
        public User User { get; set; }
        public List<Poline> Polines { get; set; }

        public string Description { get; set; }
        public decimal Total { get; set; }

        public Po() {}
    }
}


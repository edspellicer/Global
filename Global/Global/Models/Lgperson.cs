using System;
using System.Collections.Generic;
using System.Text;

namespace Global.Models
{//bhhhgh
    public class Lgperson
    {
        public string CodPer { get; set; }
        public string DesPer { get; set; }
        public string Prep { get; set; }
        public string Rev { get; set; }
        public string Trans { get; set; }
        public string Usuario { get; set; }
        public string UPass { get; set; }
        public int? UIdMobile { get; set; }
        public bool? Estado { get; set; }
        public string Transporte { get; set; }
        public PedidosAsignados PedidosAsignados { get; set; }
    }
}

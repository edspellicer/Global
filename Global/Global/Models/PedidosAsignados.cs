using System;
using System.Collections.Generic;
using System.Text;

namespace Global.Models
{
    public class PedidosAsignados
    {        
        public string CodPer { get; set; }

        public string Folio { get; set; }

        public double? Total { get; set; }

        public int? Líneas { get; set; }
   
        public string Status { get; set; }

        public string NumPed { get; set; }

        public string Area { get; set; }
    
        public DateTime? Fecha { get; set; }
      
        public string DesPer { get; set; }
   
        public string Bodega { get; set; }
       
        public DateTime? Fasign { get; set; }

        public Lgperson Lgperson { get; set; }
    }
}

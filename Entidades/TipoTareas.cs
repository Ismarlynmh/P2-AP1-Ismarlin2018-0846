using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_Ismarlin2018_0846.Entidades
{
    public class TipoTareas
    {
        [Key]
        public int TipoId { get; set; }
        public string TipoTarea { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int TiempoTarea { get; set; }

        public TipoTareas() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace P2_AP1_Ismarlin2018_0846.Entidades
{
    public class Proyectos
    {
        [Key]
        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Descripcion { get; set; }
        public int Tiempo { get; set; }

        [ForeignKey("ProyectoId")]
        public List<ProyectosDetalle> Detalle { get; set; } = new List<ProyectosDetalle>();
    }
}

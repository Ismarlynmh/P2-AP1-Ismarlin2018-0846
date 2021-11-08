using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_Ismarlin2018_0846.Entidades
{
    public class ProyectosDetalle
    {
        [Key]
        public int IdDetalle { get; set; }
        public int TipoId { get; set; }
        public int ProyectoId { get; set; }
        public string Requerimientos { get; set; }
        public int Tiempo { get; set; }

        public ProyectosDetalle(int tipo, int proyecto, string requerimientos, int tiempo)
        {
            this.TipoId = tipo;
            this.ProyectoId = proyecto;
            this.Requerimientos = requerimientos;
            this.Tiempo = tiempo;
        }
        public ProyectosDetalle(int TipoId, int ProyectoId)
        {
            this.TipoId = TipoId;
            this.ProyectoId = ProyectoId;
        }
    }
}

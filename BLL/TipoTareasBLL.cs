using P2_AP1_Ismarlin2018_0846.DAL;
using P2_AP1_Ismarlin2018_0846.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace P2_AP1_Ismarlin2018_0846.BLL
{
    public class TipoTareasBLL
    {
        public static List<TipoTareas> GetList(Expression<Func<TipoTareas, bool>> expression)
        {
            List<TipoTareas> tareas = new List<TipoTareas>();
            Contexto db = new Contexto();
            try
            {
                tareas = db.TipoTareas.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return tareas;
        }

        public static List<TipoTareas> GetList()
        {
            List<TipoTareas> lista = new List<TipoTareas>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TipoTareas.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}

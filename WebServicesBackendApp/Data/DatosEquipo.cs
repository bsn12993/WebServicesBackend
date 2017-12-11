using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DatosEquipo
    {
        FutbolEntities contexto;

        public DatosEquipo()
        {
            contexto = new FutbolEntities();
            contexto.Configuration.ProxyCreationEnabled = false;
        }

        public List<Equipo> allEquipos()
        {
            return contexto.Equipoes.ToList();
        }

        public Equipo equipoById(int id)
        {
            return contexto.Equipoes.Where(e => e.idequipo == id).SingleOrDefault();
        }
    }
}

using Data;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EquipoServices
    {
        DatosEquipo equipo = new DatosEquipo();

        public List<Equipo> GetEquipos()
        {
            return this.equipo.allEquipos();
        }

        public Equipo GetEquipoById(int id)
        {
            return this.equipo.equipoById(id);
        }
    }
}

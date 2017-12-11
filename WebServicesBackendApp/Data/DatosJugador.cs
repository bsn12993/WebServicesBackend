using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DatosJugador
    {
        FutbolEntities context;

        public DatosJugador()
        {
            context = new FutbolEntities();
            context.Configuration.ProxyCreationEnabled = false;
        }
   
        public List<Jugador> allJugadores()
        {
            return context.Jugadors.Include("Equipo").ToList();
        }

        public Jugador jugadorById(int id)
        {
            return context.Jugadors.Include("Equipo").Where(j => j.idjugador == id).SingleOrDefault();
        }

        public int crearJugador(Jugador jugador)
        {
            if (jugador.foto == null)
            {
                jugador.foto = "";
            }
            context.Jugadors.Add(jugador);
            context.SaveChanges();
            return jugador.idjugador;
        }

        public bool actualizarJugador(Jugador jugador)
        {
            Jugador jugadorModificar = context.Jugadors.Where(j => j.idjugador == jugador.idjugador).SingleOrDefault();
            if (jugadorModificar != null)
            {
                context.Entry(jugadorModificar).CurrentValues.SetValues(jugador);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminarJugador(int id)
        {
            Jugador jugadorEliminar = context.Jugadors.Where(j => j.idjugador == id).SingleOrDefault();
            if (jugadorEliminar != null)
            {
                context.Jugadors.Remove(jugadorEliminar);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

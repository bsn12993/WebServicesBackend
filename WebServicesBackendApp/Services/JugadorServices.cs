using Data;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class JugadorServices
    {
        DatosJugador jugador = new DatosJugador();

        public List<Jugador> GetJugadores()
        {
            return this.jugador.allJugadores();
        }

        public Jugador GetJugadorById(int id)
        {
            return this.jugador.jugadorById(id);
        }

        public int SetNuevoJugador(Jugador jugador)
        {
            return this.jugador.crearJugador(jugador);
        }

        public bool SetActualizarJugador(Jugador jugador)
        {
            return this.jugador.actualizarJugador(jugador);
        }

        public bool DeleteJugador(int id)
        {
            return this.jugador.eliminarJugador(id);
        }
    }
}

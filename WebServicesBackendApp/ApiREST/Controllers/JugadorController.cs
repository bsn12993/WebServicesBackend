using DataAccess;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiREST.Controllers
{
    public class JugadorController : ApiController
    {
        JugadorServices _jugadorService = new JugadorServices();

        // GET: api/Jugador
        public IEnumerable<Jugador> Get()
        {
            return this._jugadorService.GetJugadores();
        }

        // GET: api/Jugador/5
        public Jugador Get(int id)
        {
            return this._jugadorService.GetJugadorById(id);
        }

        // POST: api/Jugador
        public int Post([FromBody]Jugador jugador)
        {
            return this._jugadorService.SetNuevoJugador(jugador);
        }

        // PUT: api/Jugador/5
        public bool Put(int id, [FromBody]Jugador jugador)
        {
            jugador.idjugador = id;
            return this._jugadorService.SetActualizarJugador(jugador);
        }

        // DELETE: api/Jugador/5
        public bool Delete(int id)
        {
            return this._jugadorService.DeleteJugador(id);
        }
    }
}

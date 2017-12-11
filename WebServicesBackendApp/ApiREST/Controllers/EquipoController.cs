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
    public class EquipoController : ApiController
    {
        EquipoServices _equipoService = new EquipoServices();

        // GET: api/Equipo
        public IEnumerable<Equipo> Get()
        {
            return this._equipoService.GetEquipos();
        }

        // GET: api/Equipo/5
        public Equipo Get(int id)
        {
            return this._equipoService.GetEquipoById(id);
        }

        // POST: api/Equipo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Equipo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Equipo/5
        public void Delete(int id)
        {
        }
    }
}

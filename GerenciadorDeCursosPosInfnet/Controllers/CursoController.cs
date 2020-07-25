using Cursos.Application.Intefaces;
using Cursos.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cursos.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ICursoApplication _cursoApplication;
        public ClienteController(ICursoApplication cursoApplication)
        {
            _cursoApplication = cursoApplication;
        }
        // GET: api/<Cliente>
        [HttpGet]
        public IEnumerable<CursoViewModel> Get()
        {
            return _cursoApplication.List();
        }

        // GET api/<Cliente>/5
        [HttpGet("{id}")]
        public CursoViewModel Get(Guid id)
        {
            return _cursoApplication.Find(id);
        }

        // POST api/<Cliente>
        [HttpPost]
        public void Post([FromBody] CursoViewModel curso)
        {
            _cursoApplication.Add(curso);
        }

        // PUT api/<Cliente>
        [HttpPut]
        public void Put([FromBody] CursoViewModel curso)
        {
            _cursoApplication.Update(curso);
        }

        // DELETE api/<Cliente>
        [HttpDelete]
        public void Delete([FromBody] CursoViewModel curso)
        {
            _cursoApplication.Remove(curso);
        }
    }
}

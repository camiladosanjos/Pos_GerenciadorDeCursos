using Cursos.Application.Intefaces;
using Cursos.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cursos.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaApplication _disciplinaApplication;
        public DisciplinaController(IDisciplinaApplication disciplinaApplication)
        {
            _disciplinaApplication = disciplinaApplication;
        }
        // GET: api/<Cliente>
        [HttpGet]
        public IEnumerable<DisciplinaViewModel> Get()
        {
            return _disciplinaApplication.List();
        }

        // GET api/<Cliente>/5
        [HttpGet("{id}")]
        public DisciplinaViewModel Get(Guid id)
        {
            return _disciplinaApplication.Find(id);
        }

        // POST api/<Cliente>
        [HttpPost]
        public void Post([FromBody] DisciplinaViewModel disciplina)
        {
            _disciplinaApplication.Add(disciplina);
        }

        // PUT api/<Cliente>
        [HttpPut]
        public void Put([FromBody] DisciplinaViewModel disciplina)
        {
            _disciplinaApplication.Update(disciplina);
        }

        // DELETE api/<Cliente>
        [HttpDelete]
        public void Delete([FromBody] DisciplinaViewModel disciplina)
        {
            _disciplinaApplication.Remove(disciplina);
        }
    }
}

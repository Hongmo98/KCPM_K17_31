using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KCPM_DotCover.Models;
using KCPM_DotCover.Models.Notes;
using KCPM_DotCover.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KCPM_DotCover.Controllers
{
    [Route("api/Notes")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INotesRepositories _notesRepository;
        public  NotesController(INotesRepositories notes)
        {
            _notesRepository = notes;

        }
        // GET: api/Notes
        [HttpGet]
        public IEnumerable<Note> Get()
        {
            return _notesRepository.GetNotes();
        }

        [HttpGet("{id}", Name = "Get1")]
        public Note Get(int id)
        {
            return _notesRepository.GetNote(id);
        }

        // POST: api/Notes
             [HttpPost]
              public IActionResult Create([FromBody] Note value)
        {
            if (ModelState.IsValid)
            {
                _notesRepository.AddNotes(value);
            }
            else
            {
                return new BadRequestResult();
            }

            return Ok();

        }
        // PUT: api/Notes/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] Note value)
        {
            if (ModelState.IsValid)
            {

                _notesRepository.UpdateNotes(value,id);
            }

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {


            _notesRepository.DeleteNote(id);
            return Ok();

        }
    }
}

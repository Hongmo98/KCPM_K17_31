using KCPM_DotCover.Data;
using KCPM_DotCover.Models;
using KCPM_DotCover.Models.Notes;
using KCPM_DotCover.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCPM_DotCover.Repositories
{
    
    public class NotesRepositories : INotesRepositories
    {
        private readonly Datacontext _dbcontext;


        public NotesRepositories(Datacontext datacontext)
        {
            _dbcontext = datacontext;
          
        }

        public Note AddNotes(Note note)
        {
           
            _dbcontext.Add(note);
            _dbcontext.SaveChanges();

            return note;
        }

        public Note DeleteNote(int id)
        {
            {
                var Notes = _dbcontext.Notes.Find(id);

                if (Notes != null)
                {
                    _dbcontext.Notes.Remove(Notes);
                    _dbcontext.SaveChanges();

                }
                return Notes;
            }
        }

        public Note GetNote(int Id)
        {
            var notes = _dbcontext.Notes.Find(Id);
            return notes;


        }

        public IEnumerable<Note> GetNotes()
        {
            var storedData = _dbcontext.Notes;
           return storedData;
        }

        public Note UpdateNotes(Note Notes, int id)
        {
            var notes = _dbcontext.Notes.Find(id);
            notes.Description = notes.Description;
            notes.Title = notes.Title;
            _dbcontext.Update(notes);

            return notes;
        }
    }
}

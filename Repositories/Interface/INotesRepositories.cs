using KCPM_DotCover.Models;
using KCPM_DotCover.Models.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCPM_DotCover.Repositories.Interface
{
    public interface INotesRepositories 
    {
        Note GetNote(int Id);

        IEnumerable<Note> GetNotes();
        Note AddNotes(Note Note);
        Note UpdateNotes(Note Notechange, int id);
        Note DeleteNote(int id);
    }
}

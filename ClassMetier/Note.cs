using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetier
{
    public class Note
    {
        private int idNote;
        private int idCritere;
        private int idEvalutation;
        int note;
        List<Note> lesNotes = new List<Note>();

        public Note(int unIdNote, int unIdCritere, int unIdEvaluation, int uneNote)
        {
            this.idNote = unIdNote;
            this.idCritere = unIdCritere;
            this.idEvalutation = unIdEvaluation;
            this.note = uneNote;
        }

        public int GetIdNote { get { return this.idNote; } set { this.idNote = value; } }
        public int GetIdCritere { get { return this.idCritere; } set { this.idCritere = value; } }
        public int GetidEvalutaion { get { return this.idEvalutation; } set { this.idEvalutation = value; } }
        public int GetNote { get { return this.note; } set { this.note = value; } }
        public void AddNotes(Note note)
        {
            this.lesNotes.Add(note);
        }
        public List<Note> GetLesNotes()
        {
            return this.lesNotes;
        }
    }
}

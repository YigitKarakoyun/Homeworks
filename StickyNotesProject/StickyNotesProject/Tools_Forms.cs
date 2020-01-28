using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotesProject
{
    class Tools_Forms
    {
        public static Tools_Forms instance { get; private set; } = new Tools_Forms();

        public List<FormNote> forms = new List<FormNote>();
        public FormNote GetForm(Tbl_Note note)
        {
            return new FormNote(note);
        }

        public void AddForm(FormNote formNote)
        {
            forms.Add(formNote);
        }
        public FormNote AddForm(Tbl_Note note)
        {
            FormNote formNote = GetForm(note);
            AddForm(formNote);
            return formNote;
        }
        public bool RemoveForm(FormNote form_note)
        {
            return forms.Remove(form_note);
        }
        public void ShowForm(FormNote formNote)
        {
            formNote.Show();
        }
    }
}

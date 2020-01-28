using System;
using System.Collections.Generic;
using System.Linq;

namespace StickyNotesProject
{
    class Tools_CRUD
    {
        public static Tools_CRUD instance { get; } = new Tools_CRUD();
        private Tools_CRUD() { }
   
        public StickersEntities db { get; private set; } = new StickersEntities();
        public Tbl_Note Insert_Not(string temp = "")
        {
            try
            {
                Tbl_Note notum = new Tbl_Note();
                notum.Note = temp;
                notum.KonumX = 0;
                notum.KonumY = 0;
                notum.ColorID = 0;

                var rs = db.Tbl_Note.Add(notum);
                db.SaveChanges();
                return notum;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public bool Delete_Not(Tbl_Note temp)
        {
            try
            {
                db.Tbl_Note.Remove(temp);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool Update_Not(Tbl_Note temp)
        {
            try
            {
                var urun = db.Tbl_Note.First(x => x.ID == temp.ID);
                urun.Note = temp.Note;
                urun.KonumX = temp.KonumX;
                urun.KonumY = temp.KonumY;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool Update_Not2(Tbl_Note temp)
        {
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        public List<Tbl_Note> Select_Notums
        {
            get
            {
                return db.Tbl_Note.ToList();
            }
        }
    }
}

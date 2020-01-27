using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp2
{
    class Tools_CRUD
    {
        //public static Tools_CRUD instance { get; } = new Tools_CRUD();

        public static NotlarEntities db = new NotlarEntities();
        public tblNot Insert_Not(string temp = "")
        {
            try
            {
                tblNot notum = new tblNot();
                notum.Notum = temp;
                var rs = db.tblNots.Add(notum);
                db.SaveChanges();
                return notum;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public bool Delete_Not(tblNot temp)
        {
            try
            {
                db.tblNots.Remove(temp);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool Update_Not(tblNot temp)
        {
            try
            {
                var urun = db.tblNots.First(x => x.ID == temp.ID);
                urun.Notum = temp.Notum;

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        public static List<tblNot> Select_Notums
        {
            get
            {
                return db.tblNots.ToList();
            }
        }
    }

}

namespace ProjectPagedList.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
            var s =  this.TBL_MEYVELER.ToList().Count;
            if (s<=0)
            {
                string[] temp = { "ELMA", "ARMUT", "ÞEFTALÝ", "ÜZÜM", "AYVA", "MUZ", "AVOKADO", "CENNET ELMASI", "ALTIN ÇÝLEK", "ÇÝLEK", "ERÝK" };

                foreach (var item in temp)
                {
                    TBL_MEYVELER meyve = new TBL_MEYVELER();
                    meyve.MEYVE = item;

                    TBL_MEYVELER.Add(meyve);

                }
                SaveChanges();
            }

        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBL_MEYVELER> TBL_MEYVELER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_MEYVELER>()
                .Property(e => e.MEYVE)
                .IsUnicode(false);
        }
    }
}

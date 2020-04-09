namespace ProjectPagedList.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_MEYVELER
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string MEYVE { get; set; }
    }
}

namespace Permission_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Role_Info
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}

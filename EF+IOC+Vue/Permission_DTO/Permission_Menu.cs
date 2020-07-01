namespace Permission_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permission_Menu
    {
        public int ID { get; set; }

        public int? Permission_Id { get; set; }

        public int? Menu_Id { get; set; }
    }
}

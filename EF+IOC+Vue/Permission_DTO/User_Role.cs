namespace Permission_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Role
    {
        public int Id { get; set; }

        public int? User_Id { get; set; }

        public int? Role_Id { get; set; }
    }
}

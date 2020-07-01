namespace Permission_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Info
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string LoginName { get; set; }

        [StringLength(50)]
        public string PassWord { get; set; }

        [StringLength(20)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? UserType { get; set; }

        public bool? IsDel { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string Creater { get; set; }
    }
}

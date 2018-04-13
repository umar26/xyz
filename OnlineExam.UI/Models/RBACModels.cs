﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineExam.UI.Models
{
    [Table("PERMISSIONS")]
    public class PERMISSION
    {
        [Key]
        public int PermissionId { get; set; }

        [Required]
        [StringLength(50)]
        public string PermissionDescription { get; set; }

        public virtual List<ApplicationRole> ROLES { get; set; }
    }   
}
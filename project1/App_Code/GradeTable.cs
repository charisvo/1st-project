namespace GradesNamespace
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GradeTable")]
    public partial class GradeTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentFirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentLastName { get; set; }

        public int Grade { get; set; }
    }
}

namespace doan_htttdn.FF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ARTICLE")]
    public partial class ARTICLE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Article { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Summary { get; set; }

        [Required]
        public string Contents { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Day { get; set; }

        [Required]
        [StringLength(50)]
        public string IDAdmin { get; set; }

        public int? State { get; set; }

        public int ID_Menu { get; set; }

        public virtual Admin_Article Admin_Article { get; set; }

        public virtual Menu_Article Menu_Article { get; set; }
    }
}

namespace StudentAppDotNetCore.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class subjects
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? studid { get; set; }

        [StringLength(100)]
        public string subName { get; set; }

        public virtual student student { get; set; }
    }
}

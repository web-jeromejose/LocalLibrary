using LocalLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LocalLibrary.Entity
{
    public class CreateUpdateBookDto
    {
        [Required]
        [StringLength(128)]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }

        public Section Section { get; set; }


    }
}

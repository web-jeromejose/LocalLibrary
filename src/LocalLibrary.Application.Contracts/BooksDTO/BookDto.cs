using LocalLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
 
namespace LocalLibrary.Entity
{
    public class BookDto : AuditedEntityDto<Guid>
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public Section Section { get; set; }



    }
}

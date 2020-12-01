using System;
using System.Collections.Generic;
using System.Text;

namespace Fooddb.Domain.Model
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}

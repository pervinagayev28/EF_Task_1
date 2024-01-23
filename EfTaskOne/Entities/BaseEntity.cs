﻿using EfTaskOne.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTaskOne.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DataStatus Status{ get; set; }
        public DateTime CreatedDate{ get; set; }
        public DateTime ModifiedDate{ get; set; }
    }
}

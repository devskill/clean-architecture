﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Course : AggregateRoot<Guid>
    {
        public string Title { get; set; }
        public int Fees { get; set; }
        public DateTime ClassStartDateTime { get; set; }

    }
}

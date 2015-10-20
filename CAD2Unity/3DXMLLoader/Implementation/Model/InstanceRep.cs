﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreeDXMLLoader.Implementation.Model
{
    class InstanceRep
    {
        public int Id { get; }
        public string Name { get; }
        public int AggregatedBy { get; set; }
        public int InstanceOf { get; set; }

        public InstanceRep(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}

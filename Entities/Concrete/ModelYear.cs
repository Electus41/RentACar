﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ModelYear :IEntity
    {
        public int ModelYearId { get; set; }
        public int ModelYearName { get; set; }  

        
    }
}

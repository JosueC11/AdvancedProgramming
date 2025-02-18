﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedProgramming.Data;
using AdvancedProgramming.Repository.Interface;

namespace AdvancedProgramming.Repository.Implementation
{
    public class SupplierRepository : BaseRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository() : base() { }
    }
}

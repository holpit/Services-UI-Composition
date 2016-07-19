﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Finance.Data.Models;

namespace Finance.Data.Repositories
{
    public interface IFinanceRepository
    {
        Task<Price> Price(Guid productId);
        Task<List<Price>> Prices();
    }
}
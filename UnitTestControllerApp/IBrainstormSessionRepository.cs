﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestControllerApp.Models;
namespace UnitTestControllerApp
{
    public interface IBrainstormSessionRepository
    {
        Task<BrainstormSession> GetByIdAsync(int id);
        Task<List<BrainstormSession>> ListAsync();
        Task AddAsync(BrainstormSession session);
        Task UpdateAsync(BrainstormSession session);
    }
}

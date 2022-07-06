﻿using Data.EmployeeData.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Contract
{
    public interface IEmployeeSkillRepository : IRepositoryBase<EmployeeSkill>
    {
        Task UpdateSkillsAsync(IEnumerable<EmployeeSkill> skills);
    }
}

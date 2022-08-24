﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface ISubService
    {
        Task<List<SubService>> GetSubServices(int id);

    }
}

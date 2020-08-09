﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Services
{
    public interface ICountryService : IService<Country>
    {
        public void Active(int id);
    }
}

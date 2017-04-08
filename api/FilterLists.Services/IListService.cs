﻿using System.Collections.Generic;
using FilterLists.Models;

namespace FilterLists.Services
{
    public interface IListService
    {
        IEnumerable<List> GetAll();
    }
}
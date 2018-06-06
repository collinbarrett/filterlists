﻿using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList
{
    [UsedImplicitly]
    public class ListSummaryDto
    {
        public int Id { get; set; }
        public IEnumerable<ListLanguagesDto> Languages { get; set; }
        public string Name { get; set; }
        public string ViewUrl { get; set; }
    }
}
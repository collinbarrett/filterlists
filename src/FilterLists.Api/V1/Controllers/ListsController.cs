﻿using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.FilterList;
using FilterLists.Services.Seed;
using FilterLists.Services.Seed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class ListsController : BaseController
    {
        private readonly FilterListService filterListService;

        public ListsController(IMemoryCache memoryCache, SeedService seedService, FilterListService filterListService) :
            base(memoryCache, seedService) => this.filterListService = filterListService;

        [HttpGet]
        public async Task<IActionResult> Index() =>
            await Get(() => filterListService.GetAllAsync());

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id) =>
            await Get(() => filterListService.GetDetailsAsync(id), id);

        [HttpGet("seed")]
        public async Task<IActionResult> Seed() =>
            await Get(() => SeedService.GetAllAsync<FilterList, FilterListSeedDto>());
    }
}
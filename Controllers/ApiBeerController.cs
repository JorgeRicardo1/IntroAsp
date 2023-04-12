﻿using IntroAsp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroAsp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBeerController : ControllerBase
    {
        private readonly PubContext _context;

        public ApiBeerController(PubContext context)
        {
            _context = context;
        }

        public async Task<List<Beer>> Get()
        {
            return await _context.Beers.ToListAsync();
        }
    }
}

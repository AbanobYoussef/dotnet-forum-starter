﻿using Forum.Data;
using System;
using forum_app_demo.Models;
using System.Threading.Tasks;
using forum_app_demo.Data;

namespace Forum.Service
{
    public class ApplicationUserService : IApplicationUser
    {
        private ApplicationDbContext _context;

        public ApplicationUserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Add(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task Deactivate(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
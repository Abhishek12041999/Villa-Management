﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Application.Common.Interfaces;
using WhiteLagoon.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace WhiteLagoon.Infrastructure.Repository
{
    public class AmenityRepository : Repository<Amenity> , IAmenityRepository
    {
        private readonly ApplicationDbContext _db;

        public AmenityRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Amenity entity)
        {
            _db.Amenities.Update(entity);
        }
    }
}
﻿using System.Collections.Generic;
using System.Linq;
using SmartReference.Domain.Interfaces;
using SmartReference.Domain.Models;

namespace SmartReference.Infrastructure.Repositories
{
    public class ReferenceRepository : IReferenceRepository
    {
        private readonly ReferenceContext _context;

        public ReferenceRepository(ReferenceContext context)
        {
            _context = context;
        }

        public IEnumerable<Reference> List()
        {
            return _context.References;
        }

        public Reference Get(string name)
        {
            return _context.References.FirstOrDefault(r => r.Name.Equals(name));
        }

        public string Create(Reference reference)
        {
            _context.References.Add(reference);
            _context.SaveChanges();
            return reference.Name;
        }
    }
}
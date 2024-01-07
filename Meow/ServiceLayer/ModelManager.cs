﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ServiceLayer
{
    public class ModelManager
    {
        private readonly ModelContext modelContext;

        public ModelManager(ModelContext modelContext)
        {
            this.modelContext = modelContext;
        }

        public async Task CreateAsync(Model item)
        {
            await modelContext.CreateAsync(item);
        }

        public async Task<Model> ReadAsync(int key, bool useNavigationalProperties = false, bool isReadOnly = true)
        {
            return await modelContext.ReadAsync(key, useNavigationalProperties, isReadOnly);
        }

        public async Task<ICollection<Model>> ReadAllAsync(bool useNavigationalProperties = false, bool isReadOnly = true)
        {
            return await modelContext.ReadAllAsync(useNavigationalProperties, isReadOnly);
        }

        public async Task UpdateAsync(Model item, bool useNavigationalProperties = false)
        {
            await modelContext.UpdateAsync(item, useNavigationalProperties);
        }

        public async Task DeleteAsync(int key)
        {
            await modelContext.DeleteAsync(key);
        }
    }
}

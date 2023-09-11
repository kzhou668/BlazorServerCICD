using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resmed.MSP.LSR.WebApi.Models
{
    public class MspLookupRepo : IMspLookupRepo
    {
        private readonly DowntimeFormContext appDbContext;

        public MspLookupRepo(DowntimeFormContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Lookup> AddMspLookup(Lookup mspLookup)
        {
            var result = await appDbContext.Lookups.AddAsync(mspLookup);
            await appDbContext.SaveChangesAsync();

            return result.Entity;

        }

        public async void DeleteMspLookup(int AutoId)
        {
            var result = await appDbContext.Lookups
                .FirstOrDefaultAsync(m => m.AutoId == AutoId);
            if (result != null)
            {
                appDbContext.Lookups.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Lookup>> GetMspLookups(string appName)
        {
            return await appDbContext.Lookups.Where(m => m.AppName == appName).ToListAsync();
        }

        public async Task<IEnumerable<Lookup>> GetMspLookups(string appName, string fieldName)
        {
            return await appDbContext.Lookups.Where(m => m.AppName == appName & m.FieldName == fieldName).ToListAsync();
        }

        public async Task<Lookup> UpdateMspLookup(Lookup mspLookup)
        {
            var result = await appDbContext.Lookups
                .FirstOrDefaultAsync(m => m.AutoId == mspLookup.AutoId);
            if (result != null)
            {
                result.AppName = mspLookup.AppName;
                result.DisplayOrder = mspLookup.DisplayOrder;
                result.FieldName = mspLookup.FieldName;
                result.FieldValue = mspLookup.FieldValue;
                result.IsActive = mspLookup.IsActive;
                await appDbContext.SaveChangesAsync();

                await appDbContext.AddRangeAsync();

                return result;
            }

            return null;
        }
    }
}

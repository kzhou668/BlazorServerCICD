using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resmed.MSP.LSR.WebApi.Models
{
    public interface IMspLookupRepo
    {
        Task<IEnumerable<Lookup>> GetMspLookups(string appName);
        Task<IEnumerable<Lookup>> GetMspLookups(string appName, string fieldName);
        Task<Lookup> AddMspLookup(Lookup mspLookup);
        Task<Lookup> UpdateMspLookup(Lookup mspLookup);
        void DeleteMspLookup(int AutoId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resmed.MSP.LSR.WebApi.Models
{
    public interface IDowntimeFormRepo
    {
        Task<IEnumerable<DowntimeForm>> GetDowntimeForms();
        Task<DowntimeForm> GetDowntimeForm(int downtimeFormId);
        Task<DowntimeForm> AddDowntimeForm(DowntimeForm downtimeForm);
        Task<DowntimeForm> UpdateDowntimeForm(DowntimeForm downtimeForm);
        void DeleteDowntimeForm(int downtimeFormId);
    }
}

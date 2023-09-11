using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resmed.MSP.LSR.WebApi.Models
{
    public class DowntimeFormRepo : IDowntimeFormRepo
    {
        private readonly DowntimeFormContext appDbContext;

        public DowntimeFormRepo(DowntimeFormContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<DowntimeForm> AddDowntimeForm(DowntimeForm downtimeForm)
        {
            var result = await appDbContext.AddAsync(downtimeForm);
            await appDbContext.SaveChangesAsync();

            return result.Entity;
        }

        public async void DeleteDowntimeForm(int downtimeFormId)
        {
            var result = await appDbContext.DowntimeForms
                .FirstOrDefaultAsync(f => f.AutoId == downtimeFormId);
            if (result != null)
            {
                appDbContext.DowntimeForms.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }

        public async Task<DowntimeForm> GetDowntimeForm(int downtimeFormId)
        {
            return await appDbContext.DowntimeForms
                .FirstOrDefaultAsync(f => f.AutoId == downtimeFormId);
        }

        public async Task<IEnumerable<DowntimeForm>> GetDowntimeForms()
        {
            return await appDbContext.DowntimeForms.ToListAsync();
        }

        public async Task<DowntimeForm> UpdateDowntimeForm(DowntimeForm downtimeForm)
        {
            var result = await appDbContext.DowntimeForms
                .FirstOrDefaultAsync(f => f.AutoId == downtimeForm.AutoId);
            if (result != null)
            {
                result.ActionDetails = downtimeForm.ActionDetails;
                result.Cell = downtimeForm.Cell;
                result.CycleTime = downtimeForm.CycleTime;
                result.DownDuration = downtimeForm.DownDuration;
                result.DownReasons = downtimeForm.DownReasons;
                result.DownTime = downtimeForm.DownTime;
                result.DownTimeText = downtimeForm.DownTimeText;
                result.MachineNo = downtimeForm.MachineNo;
                result.OpsDate = downtimeForm.OpsDate;
                result.PartNo = downtimeForm.PartNo;
                result.Product = downtimeForm.Product;
                result.ToolNo = downtimeForm.ToolNo;
                result.UpdatedBy = downtimeForm.UpdatedBy;
                result.UpdatedDate = downtimeForm.UpdatedDate;
                result.UpTime = downtimeForm.UpTime;
                result.UpTimeText = downtimeForm.UpTimeText;
                result.WorkOrderNo = downtimeForm.WorkOrderNo;

                await appDbContext.AddRangeAsync();

                return result;
            }

            return null;

        }
    }
}

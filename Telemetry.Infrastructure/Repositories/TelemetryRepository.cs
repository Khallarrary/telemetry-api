using System.Security.Cryptography.Xml;
using Microsoft.EntityFrameworkCore;
using Telemetry.Domain.Entities;
using Telemetry.Domain.Interfaces;
using Telemetry.Infrastructure.Data;


namespace Telemetry.Infrastructure.Repositories

{

    public class TelemetryRepository : ITelemetryRepository
    {
        private readonly TelemetryDbContext _context;

        public TelemetryRepository(TelemetryDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TelemetryEvent telemetry)
        {
            await _context.TelemetryEvents.AddAsync(telemetry);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TelemetryEvent>> GetLatestAsync(int quantity)
        {
            return await _context.TelemetryEvents
                .OrderByDescending(x => x.TimeStamp)
                .Take(quantity)
                .ToListAsync();
        }
    }
}

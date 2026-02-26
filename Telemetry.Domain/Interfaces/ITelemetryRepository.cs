using Telemetry.Domain.Entities;

namespace Telemetry.Domain.Interfaces
{
    public interface ITelemetryRepository
    {
        Task AddAsync(TelemetryEvent telemetry);
        Task<List<TelemetryEvent>> GetLatestAsync(int quantity);
    }
}

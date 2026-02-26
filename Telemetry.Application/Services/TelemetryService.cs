using Telemetry.Application.DTOs;
using Telemetry.Domain.Entities;
using Telemetry.Domain.Interfaces;

namespace Telemetry.Application.Services
{
    public class TelemetryService
    {
        private readonly ITelemetryRepository _repository;

        public TelemetryService(ITelemetryRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(CreateTelemetryDto dto)
        {
            var telemetry = new TelemetryEvent(
                dto.Application,
                dto.Message,
                dto.Level
            );

            await _repository.AddAsync(telemetry);
        }

        public async Task<List<TelemetryEvent>> GetLatestAsync(int quantity)
        {
            return await _repository.GetLatestAsync(quantity);
        }
    }
}

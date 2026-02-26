using Telemetry.Domain.Enums;

namespace Telemetry.Application.DTOs
{
    public class CreateTelemetryDto
    {
        
        public string Application { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public LogLevel Level { get; set; }
        
    }
}

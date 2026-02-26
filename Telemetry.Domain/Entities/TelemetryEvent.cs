using Telemetry.Domain.Enums;

namespace Telemetry.Domain.Entities

{
    public class TelemetryEvent
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Application { get; private set; } = null!;
        public string Message { get; private set; } = null!;
        public LogLevel Level { get; private set; }
        public DateTime TimeStamp { get; private set; }

        public TelemetryEvent(string application, string message, LogLevel level)
        {
            Application = application;
            Message = message;
            Level = level;
            TimeStamp = DateTime.UtcNow;
        }

        private TelemetryEvent() { }
    }
}

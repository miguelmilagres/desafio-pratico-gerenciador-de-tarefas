using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Requests
{
    public class RequestTaskJson
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Priority Priority { get; set; }
        public DateTime Deadline { get; set; }

        public Status Status { get; set; }
    }
}

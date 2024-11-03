using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Responses
{
    public class ResponseShortTaskJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Status Status { get; set; }
    }
}

using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetById
{
    public class GetTaskByIdUseCase
    {
        public ResponseTaskJson Execute(int id)
        {
            return new ResponseTaskJson
            {
                Id = id,
                Name = "Test",
                Description = "Test",
                Priority = Communication.Enum.Priority.Low,
                Deadline = new DateTime(year: 2024, month: 11, day: 03),
                Status = Communication.Enum.Status.InProgress,
            };
        }
    }
}

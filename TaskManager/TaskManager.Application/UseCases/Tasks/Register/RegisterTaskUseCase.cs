using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.Register
{
    public class RegisterTaskUseCase
    {
        public ResponseRegisteredTaskJson Execute(RequestTaskJson request)
        {
            return new ResponseRegisteredTaskJson
            {
                Id = 0,
                Name = request.Name,
            };
        }
    }
}

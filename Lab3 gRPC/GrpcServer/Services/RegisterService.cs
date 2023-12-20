using Grpc.Core;

namespace GrpcServer.Services
{
    public class RegisterService : Register.RegisterBase
    {
        private readonly ILogger<RegisterService> _logger;

        public RegisterService(ILogger<RegisterService> logger)
        {
            _logger = logger;
        }

        public override Task<RegisterReply> ChangeRegister(RegisterRequest request, ServerCallContext context)
        {
            var RegisterOutput = new RegisterReply
            {
                ChangedUp = ChangeUp(request.TextToChange),
                ChangedDown = ChangeDown(request.TextToChange)
            };

            return Task.FromResult(RegisterOutput);
        }
        
        public string ChangeUp(string words)
        {
            var up = words.ToUpper();
            return up;
        }

        public string ChangeDown(string words)
        {
            var down = words.ToLower();
            return down;
        }
    }
}

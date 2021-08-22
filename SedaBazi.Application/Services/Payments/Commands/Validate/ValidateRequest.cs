using System;

namespace SedaBazi.Application.Services.Payments.Commands.Validate
{
    public class ValidateRequest
    {
        public Guid Guid { get; }

        public string Authority { get; }

        public string Username { get; }

        public ValidateRequest(Guid guid, string authority, string username)
        {
            Guid = guid;
            Authority = authority;
            Username = username;
        }
    }
}

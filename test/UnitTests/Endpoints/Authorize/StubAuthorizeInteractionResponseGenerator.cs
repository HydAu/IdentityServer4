﻿using IdentityServer4.Core.ResponseHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Core.Models;
using IdentityServer4.Core.Validation;
using System.Security.Claims;

namespace UnitTests.Endpoints.Authorize
{
    class StubAuthorizeInteractionResponseGenerator : IAuthorizeInteractionResponseGenerator
    {
        internal LoginInteractionResponse LoginResponse { get; set; } = new LoginInteractionResponse();
        internal LoginInteractionResponse ClientLoginResponse { get; set; } = new LoginInteractionResponse();

        public Task<LoginInteractionResponse> ProcessLoginAsync(ValidatedAuthorizeRequest request, ClaimsPrincipal user)
        {
            return Task.FromResult(LoginResponse);
        }

        public Task<LoginInteractionResponse> ProcessClientLoginAsync(ValidatedAuthorizeRequest request)
        {
            return Task.FromResult(ClientLoginResponse);
        }
    }
}

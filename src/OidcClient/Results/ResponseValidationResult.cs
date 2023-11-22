// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel.Client;
using System.Security.Claims;

namespace IdentityModel.OidcClient
{
    /// <summary>
    /// Response type returned by <see cref="ResponseProcessor"/> from validating an authorize response.
    /// </summary>
    public class ResponseValidationResult : Result
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ResponseValidationResult()
        {

        }

        /// <summary>
        /// Error constructor
        /// </summary>
        /// <param name="error"></param>
        public ResponseValidationResult(string error)
        {
            Error = error;
        }

        /// <summary>
        /// The original authorize response which was validated
        /// </summary>
        public virtual AuthorizeResponse AuthorizeResponse { get; set; }

        /// <summary>
        /// The response obtained when exchanging the authorization code for tokens
        /// </summary>
        public virtual TokenResponse TokenResponse { get; set; }

        /// <summary>
        /// A <see cref="ClaimsPrincipal"/> derived from the token response
        /// </summary>
        public virtual ClaimsPrincipal User { get; set; }
    }
}
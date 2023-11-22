// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


namespace IdentityModel.OidcClient.Results
{
    /// <summary>
    /// Response type returned by <see cref="ResponseProcessor"/> from validating a token response.
    /// </summary>
    public class TokenResponseValidationResult : Result
    {
        /// <summary>
        /// Error constructor
        /// </summary>
        /// <param name="error"></param>
        public TokenResponseValidationResult(string error)
        {
            Error = error;
        }

        /// <summary>
        /// Default constructor, providing a valid inner result
        /// </summary>
        /// <param name="result"></param>
        public TokenResponseValidationResult(IdentityTokenValidationResult result)
        {
            IdentityTokenValidationResult = result;
        }

        /// <summary>
        /// The inner result from validating the ID token
        /// </summary>
        public virtual IdentityTokenValidationResult IdentityTokenValidationResult { get; set; }
    }
}
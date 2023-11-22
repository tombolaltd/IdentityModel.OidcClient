// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System.Net.Http;

namespace IdentityModel.OidcClient.Infrastructure
{
    /// <summary>
    /// Extension methods over <see cref="OidcClientOptions"/>
    /// </summary>
    public static class OidcClientOptionsExtensions
    {
        /// <summary>
        /// Creates an <see cref="HttpClient"/> configured for backchannel requests to the authorization server
        /// </summary>
        /// <param name="options">Client options</param>
        /// <returns>A new <see cref="HttpClient"/></returns>
        public static HttpClient CreateBackchannelClient(this OidcClientOptions options)
        {
            if (options.HttpClientFactory != null)
            {
                return options.HttpClientFactory(options);
            }
            
            HttpClient client;

            if (options.BackchannelHandler != null)
            {
                client = new HttpClient(options.BackchannelHandler);
            }
            else
            {
                client = new HttpClient();
            }

            client.Timeout = options.BackchannelTimeout;
            return client;
        }
    }
}
﻿using System;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication;

namespace Yamool.AspNetCore.Authentication.Taobao
{
    public class BaiduMiddleware : OAuthMiddleware<BaiduOptions>
    {
        public BaiduMiddleware(
        RequestDelegate next,
        IDataProtectionProvider dataProtectionProvider,
        ILoggerFactory loggerFactory,
        UrlEncoder encoder,
        IOptions<SharedAuthenticationOptions> sharedOptions,
        IOptions<BaiduOptions> options)
             : base(next, dataProtectionProvider, loggerFactory, encoder, sharedOptions, options)
        {
            if (next == null)
            {
                throw new ArgumentNullException(nameof(next));
            }

            if (dataProtectionProvider == null)
            {
                throw new ArgumentNullException(nameof(dataProtectionProvider));
            }

            if (loggerFactory == null)
            {
                throw new ArgumentNullException(nameof(loggerFactory));
            }

            if (encoder == null)
            {
                throw new ArgumentNullException(nameof(encoder));
            }

            if (sharedOptions == null)
            {
                throw new ArgumentNullException(nameof(sharedOptions));
            }

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
        }

        protected override AuthenticationHandler<BaiduOptions> CreateHandler()
        {
            return new BaiduHandler(Backchannel);
        }
    }
}

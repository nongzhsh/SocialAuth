﻿namespace Yamool.AspNetCore.Authentication.Taobao
{
    public static class BaiduDefaults
    {
        public const string AuthenticationScheme = "Baidu";

        public const string CallbackPath = "/signin-baidu";

        public const string Issuer = "Baidu";

        public const string AuthorizationEndpoint = "http://openapi.baidu.com/oauth/2.0/authorize";

        public const string TokenEndpoint = "https://openapi.baidu.com/oauth/2.0/token";      

        public const string UserInformationEndpoint = "https://openapi.baidu.com/rest/2.0/passport/users/getLoggedInUser";
    }
}

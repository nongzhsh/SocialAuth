微博登录
===

安装
===

> Install-Package Yamool.AspNetCore.Authentication.Weibo

使用
===

### Startup.cs

```c#
public void Configure(IApplicationBuilder app){
    app.UseWeiboAuthentication(new WeiboOptions()
    {
        AppKey = "xxxxxx",
        AppSecret = "xxxxxx"
    });
}
```

|Claim Name                   |Descript|
|--------------------------|----------------|
|ClaimTypes.NameIdentifier |用户UID|
|ClaimTypes.Name |友好显示名称|
|ClaimTypes.Gender |性别，m：男、f：女、n：未知|
|urn:weibo:screen_name |用户昵称|
|urn:weibo:profile_image_url|用户头像地址,50x50|
|urn:weibo:avatar_large|用户头像地址（大图），180×180|
|urn:weibo:avatar_hd|用户头像地址（高清）|
|urn:weibo:cover_image_phone||
|urn:weibo:location|所在地|
|||




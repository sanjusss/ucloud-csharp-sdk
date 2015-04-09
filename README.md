[![Build status](https://ci.appveyor.com/api/projects/status/dcwmp3siioro05qy/branch/master?svg=true)](https://ci.appveyor.com/project/icyflash/ucloud-csharp-sdk/branch/master)

ucloud-csharp-sdk
===================
ucloud-csharp-sdk是使用C#开发，用于请求UCloud API的.Net SDK。现已覆盖：

>  1. 云主机 UHost
>  2. 网络 UNet
>  3. 负载均衡 ULB
>  4. 云数据库 UDB
>  5. 对象存储 UFile
>  6. 接入云 UCDN
>  7. 云监控 UMon
>  8. 云硬盘 UDisk
>  9. 短信包 SMS

### SDK文档

> 在线文档： http://icyflash.gitcafe.io/ucloud-csharp-sdk

SDK使用方法
-------------

### 1.添加类库
#### 1.1 将类库添加至项目

**NuGet**（简单方便，自动添加相关配置内容）

> PM> Install-Package UCloudSDK

#### 1.2引入命令空间

    using UCloudSDK;
    using UCloudSDK.Models;

### 2.配置
使用API前，需要对PublicKey（用户公钥）  PrivateKey（用户私钥） BaseUrl（API地址 ，可选，默认为https://api.ucloud.cn） 进行设置。设置方法有两种：一种是在config文件中；一种是在程序中初始化对象时进行设置。

#### 2.1 在config文件中设置

> 使用NuGet方式安装的，在项目中会自动添加以下内容，只需填写相关配置即可

    <configSections>
        <section name="UcloudSetting" type="System.Configuration.NameValueSectionHandler" />
    </configSections>
    <UcloudSetting>
        <!--用户公钥-->
        <add key="PublicKey" value="ucloudsomeone@example.com1296235120854146120" />
        <!--用户私钥-->
        <add key="PrivateKey" value="46f09bb9fab4f12dfc160dae12273d5332b5debe" />
        <!--API请求地址-->
        <add key="BaseUrl" value="https://api.ucloud.cn" />
    </UcloudSetting>  

#### 2.2 程序中初始化

构造函数：

    UCloud(string publicKey, string privateKey)
    UCloud(string publicKey, string privateKey, string baseUrl)

使用方法:

    var ucloud=new UCloud("xxx","yyy")
    var ucloud=new UCloud("xxx","yyy","https://api.ucloud.cn")
    //或实例化后对属性进行设置
    ucloud.PublicKey="xxx";
    ucloud.PrivateKey="yyy";
    ucloud.BaseUrl="https://api.ucloud.cn";
    

### 3.API请求
为便于区别和使用，SDK采用了以下约定：

>  1. 类名对应于产品名。比如云主机**UHost**产品对应的类名为`UHost`
>  2. API方法名与文档中方法名一致。具体方法名请参见：[http://docs.ucloud.cn/api/apilist.html](http://docs.ucloud.cn/api/apilist.html)
>  3. 请求的实体类型名称为**方法名+Request**。比如创建[UHost实例](http://docs.ucloud.cn/api/uhost/create_uhost_instance.html)，则参数类型为`CreateUHostInstanceRequest`
>  4. 返回值的类型名称为**方法名+Response**。比如创建[UHost实例](http://docs.ucloud.cn/api/uhost/create_uhost_instance.html)，则返回类型为`CreateUHostInstanceResponse`
>  5. 请求参数**Param.n**的类型为`NList`，继承于`List<string>` 。
>  6. 返回值的**Array**类型：**string**类型的为`List<string>`  ，**object**类型的为List<方法名+object名称>，如在[DescribeUHostInstance](http://docs.ucloud.cn/api/uhost/describe_uhost_instance.html) 中，返回值UHostSet为object集合，则其对应的C#类型为`List<DescribeUHostInstanceUHostSet>`
>  7. 请求实体类型的构造函数包含所有Required为Yes的参数。比如创建[UHost实例](http://docs.ucloud.cn/api/uhost/create_uhost_instance.html)方法的构造函数：
> `CreateUHostInstanceRequest(string region, string imageid, string
> loginmode)`

请求API有三种方法：

    //强类型请求及返回，对应于各个产品类
    T Execute<T>(IRestRequest request)
    //自定义请求参数，强类型返回，使用UCloud基类
    T Execute<T>(Dictionary<string, string> dictionary, Method method = Method.GET)
    //自定义请求参数，动态内容返回，使用UCloud基类 只支持.Net4及以上
    RestResponse<dynamic> Execute(Dictionary<string, string> dictionary, Method method = Method.GET)

> **注意：**
> 以下以云主机创建UHost实例[CreateUHostInstance](http://docs.ucloud.cn/api/uhost/create_uhost_instance.html)为例。
> 配置方式采用的config配置。
> 其它API类似，或参见`UCloudSDK.Test`中的测试方法。


#### 3.1 强类型请求及返回     （**推荐使用**）
请求参数及返回值都是强类型。
按照SDK设置约定，所有的方法都类似下形式： 

    public MethodResponse Method(MethodRequest requestParams)
    {
         var request = new RestRequest(Method.GET);
         request.AddUObject(requestParams);
         return Execute<MethodResponse>(request);
    }

使用方法如下：

    var uhost=new UHost(); 
    //该方法有三个必需(Required为Yes)的请求参数
    var entity=new CreateUHostInstanceRequest("cn-north-03","uimage-3wrk30","Password"); 
    //设置其它参数
    entity.CPU=2;
    entity.Memory=2048;
    entity.DiskSpace=10;
    //密码需要进行BASE64编码，SDK自动编码
    entity.Password="Password1";
    entity.Name="UCloudExample01";
    entity.ChargeType="Month";
    entity.Quantity=1;
    //请求API，返回类型为CreateUHostInstanceResponse
    var response=uhost.CreateUHostInstance(entity);
    //获取RetCode
    var retCode=response.RetCode;
    //若RetCode不为0，说明API请求失败错误，使用Message查看错误内容
    var error = response.RetCode!=0 ? response.Message : "";
    
#### 3.2 自定义请求参数，强类型返回
请求参数为字典，返回值为强类型

    var ucloud=new UCloud();
    var dict=new Dictionary<string, string>();
    //设置请求参数
    dict.Add("Action","CreateUHostInstance");
    dict.Add("Region","cn-north-03");
    dict.Add("ImageId","uimage-3wrk30");
    dict.Add("CPU","2");
    dict.Add("Memory","2048");
    dict.Add("DiskSpace","10");
    dict.Add("LoginMode","Password");
    //密码需要进行BASE64编码
    var password="Password1";
    //使用string.ToBase64()进行编码
    dict.Add("Password",password.ToBase64());
    dict.Add("Name","UCloudExample01");
    dict.Add("ChargeType","Month");
    dict.Add("Quantity","1");
    //请求API，返回类型为CreateUHostInstanceResponse
    var response=ucloud.Execute<CreateUHostInstanceResponse>(dict);
    //获取RetCode
    var retCode=response.RetCode;
    //若RetCode不为0，说明API请求失败错误，使用Message查看错误内容
    var error = response.RetCode!=0 ? response.Message : "";
    
#### 3.2 自定义请求参数，动态内容返回（**.Net4**及以上支持）
请求参数为字典，返回值为动态类型。适用于SDK未覆盖到的API。

    var ucloud=new UCloud(); 
    var dict=new Dictionary<string, string>();
    //设置请求参数
    dict.Add("Action","CreateUHostInstance");
    dict.Add("Region","cn-north-03");
    dict.Add("ImageId","uimage-3wrk30");
    dict.Add("CPU","2");
    dict.Add("Memory","2048");
    dict.Add("DiskSpace","10");
    dict.Add("LoginMode","Password");
    //密码需要进行BASE64编码
    var password="Password1";
    //使用string.ToBase64()进行编码
    dict.Add("Password",password.ToBase64());
    dict.Add("Name","UCloudExample01");
    dict.Add("ChargeType","Month");
    dict.Add("Quantity","1");
    //请求API，返回类型为RestResponse<dynamic>
    var response=ucloud.Execute(dict);
    //之后可用数组的形式获取数据
    var entity=response.Data;
    //获取RetCode
    var retCode=entity["RetCode"];

### 4. 对象存储UFile文件操作使用方法

> **注意**
> 这里Bucket已创建，名称为bucketName，未创建的话，请先创建Bucket [CreateBucket](http://docs.ucloud.cn/api/ufile/create_bucket.html)

    // 初始化UFile对象
    UFile ufile=new UFile(){Bucket="bucketName"};  
    // 小文件本地路径（小于4M）
    string filePath = @"";
    // 大文件本地路径（大于4M）
    private string bigfilePath = @"";  
    /// 下载文件保存路径
    private string savePath = @"";
    
    // 普通上传文件
    ufile.PutFile(filePath);
    
    // 表单上传文件
    uflie.PostFile(filePath);

    // 分片上传
    // 初始化分片上传
    var entity = ufile.InitiateMultipartUpload(bigfilePath);
    for (int i = 0; i < 100000; i++)
    {
        if (ufile.PartFile.IsLast)
        {
            break;
        }
        // 上传文件分片
        ufile.UploadPart(i);
    }
    // 完成分片上传
    var response = ufile.FinishMultipartUpload("newKey");
    //若RetCode不为0，说明API请求失败错误，使用ErrMsg查看错误内容
    var error = response.RetCode!=0 ? response.ErrMsg: "";    
    
    // 下载文件 key为文件在Bucket中的名称
    ufile.GetFile("key", savePath);
    
    
### 5. 发送短信

    SMSResponse SendSms(SMSRequest requestParams)

> **注意**
> 1. 发送短信前请先[在此](https://console.ucloud.cn/apps#message/list)设置短信签名，并购买短信包。
> 2. 该方法作为`UCloud`基类方法，在其子类如`UHost`, `UDB`等类中均可直接调用。

    UCloud ucloud = new UCloud();
    //号码以Phone.0=xxxx&Phone.1=xxxx的形式发送，所以使用NList
    var phone = new NList();
    phone.Add("138xxxxxxxx");
    phone.Add("189xxxxxxxx");
    var content = "你好，Ucloud";
    var entity = new SMSRequest(phone, content);
    var response = ucloud.SendSms(entity);

### 6. RestSharp
SDK的HTTP请求使用了[RestSharp](http://restsharp.org/)，需要对HTTP请求进行设置，比如代理、过期时间等，可对UCloud的**Client**属性进行设置。更多RestSharp使用方法请参见其[官方文档](https://github.com/restsharp/RestSharp/wiki)。

    var uhost=new UHost();
    //设置HTTP代理
    uhost.Client.Proxy=new WebProxy("http://proxy.com");

### 7. 其它特性

1. 根据官方API文档添加了详细的注释，配合Visual Studio使用更加方便。
2. 添加了大部分枚举值以便于使用。

> **注意：**
> 由于C#命名规则，枚举值不允许使用“-”，部分枚举值（比如Region）需要使用`string.ToHyphen()`来取值。在枚举的注释中有注明需要用此方法的。
> 由于C#命名规则，枚举值不允许使用数字，部分枚举值（比如Priority）需要使用`(int)Priority.High`来取值。在枚举的注释中有注明需要用此方法的。

3. 需要BASE64编码的请使用`string.ToBase64()`    扩展方法
4. NList类型转换后会自动在属性后添加.n，使用时无需再添加。使用方法如下：

> 以更新防火墙规则[UpdateSecurityGroup](http://docs.ucloud.cn/api/unet/update_security_group.html)为例

    NList rules=new NList();
    //添加规则
    rules.Add("TCP|3306|0.0.0.0/0|DROP|50");
    //该Rule是一个对象，SDK内置了此对象，方便使用
    var rule = new SecurityGroupRule()
    {
        Proto = "UDP",
        Dst_port = "53",
        Src_ip = "0.0.0.0/0",
        Action = "ACCEPT",
        //内置Priority枚举
        Priority = (int) Priority.Medium
    };
    //ToString() 直接生成“Proto|Dst_port|Src_ip|Action|Priority”
    rules.Add(rule.ToString());
    var entity = new UpdateSecurityGroupRequest("cn-north-03", "6583",rules);

### 8. 关于测试

> 1. 使用测试方法请先在UCloud.Test中Config.cs配置相关参数
> 2. UDisk的一些测试方法返回错误结果，因为没有相关权限，已在测试中注明。除此之外，其它方法都经过测试并返回了正确结果。
> 3. UCloud现在未提供沙箱环境，而一些测试需要进行支付，所以测试并非纯粹的单元测试，有的测试需要依赖其它测试的结果。
    
其它
-------------

### 相关链接
UCloud: http://www.ucloud.cn/
UCloud API: http://docs.ucloud.cn/api/index.html

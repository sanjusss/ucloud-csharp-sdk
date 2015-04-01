ucloud-csharp-sdk
===================
ucloud-csharp-sdk是用于请求UCloud API的C# .Net4.5 SDK。现已覆盖：

>  1. 云主机 UHost
>  2. 网络 UNet
>  3. 负载均衡 ULB
>  4. 云数据库 UDB
>  5. 接入云 UCDN
>  6. 云监控 UMon

SDK使用方法
-------------

### 1.添加类库
#### 1.1 将类库添加至项目

**NuGet**

> PM> Install-Package UCloudSDK

#### 1.2引入命令空间

    using UCloudSDK;
    using UCloudSDK.Models;

### 2.配置
使用API前，需要对PublicKey（用户公钥）  PrivateKey（用户私钥） BaseUrl（API地址 ，可选，默认为https://api.ucloud.cn） 进行设置。设置方法有两种：一种是在config文件中；一种是在程序中初始化对象时进行设置。

#### 2.1 在config文件中设置
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

>  1. 类名对应于产品名。比如云主机**UHost**产品对应的类名为`UHos`t
>  2. API方法名与文档中方法名一致。具体方法名请参见：[http://docs.ucloud.cn/api/apilist.html](http://docs.ucloud.cn/api/apilist.html)
>  3. 请求的参数类型名称为**方法名+Request**。比如创建[UHost实例](http://docs.ucloud.cn/api/uhost/create_uhost_instance.html)，则参数类型为`CreateUHostInstanceRequest`
>  4. 返回值的类型名称为**方法名+Response**。比如创建[UHost实例](http://docs.ucloud.cn/api/uhost/create_uhost_instance.html)，则返回类型为`CreateUHostInstanceResponse`
>  5. 请求参数**Param.n**的类型为`NList`，继承于`List<string>` 。
>  6. 返回值的**Array**类型，**string**类型的为`List<string>`  ，**object**类型的为List<方法名+object名称>，如在[DescribeUHostInstance](http://docs.ucloud.cn/api/uhost/describe_uhost_instance.html) 中，返回值UHostSet为object集合，则其对应的C#类型为`List<DescribeUHostInstanceUHostSet>`
>  7. 请求参数类型的构造函数包含所有Required为Yes的参数。比如创建[UHost实例](http://docs.ucloud.cn/api/uhost/create_uhost_instance.html)方法的构造函数：
> `CreateUHostInstanceRequest(string region, string imageid, string
> loginmode)`

API使用有三种方法：

    //强类型请求及返回，对应于各个产品类
    T Execute<T>(IRestRequest request)
    //强类型返回，使用UCloud基类
    T Execute<T>(Dictionary<string, string> dictionary, Method method = Method.GET)
    //动态内容返回，使用UCloud基类
    RestResponse<dynamic> Execute(Dictionary<string, string> dictionary, Method method = Method.GET)

> **注意：**以下以云主机创建UHost实例[CreateUHostInstance](http://docs.ucloud.cn/api/uhost/create_uhost_instance.html)为例，其它API类似。
> 配置方式采用的config配置。


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
    //密码需要进行BASE64编码
    var password="Password1";
    //使用string.ToBase64()进行编码
    entity.Password=password.ToBase64();
    entity.Name="UCloudExample01";
    entity.ChargeType="Month";
    entity.Quantity=1;
    //请求API，返回类型为CreateUHostInstanceResponse
    var response=uhost.CreateUHostInstance(entity);
    //获取RetCode
    var retCode=response.RetCode;
    //若RetCode不为0，说明API请求失败错误，使用Message查看错误内容
    var error = response.RetCode!=0 ? response.Message : "";
    
#### 3.2 强类型返回
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
    
#### 3.2 动态类型返回
请求参数为字典，返回值为动态类型。适用于未覆盖到的API方法。

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

### 4. RestSharp
SDK的HTTP请求使用了[RestSharp](http://restsharp.org/)，需要对HTTP请求进行设置，比如代理、过期时间等，可对UCloud的**Client**属性进行设置。更多RestSharp使用方法请参见其[官方文档](https://github.com/restsharp/RestSharp/wiki)。

    var uhost=new UHost();
    //设置HTTP代理
    uhost.Client.Proxy=new WebProxy("http://proxy.com");

### 5. 其它特性

1. 根据官方API文档添加了详细的注释，配合Visual Studio使用更加方便。
2. 添加了大部分枚举值以便于使用。

> **注意：**
> 由于C#命名规则，枚举值不允许使用“-”，部分枚举值（比如Region）需要使用`string.ToHyphen()`来取值。在枚举的注释中有注明需要用此方法的。
> 由于C#命名规则，枚举值不允许使用数字，部分枚举值（比如Priority）需要使用`(int)Priority.High`来取值。在枚举的注释中有注明需要用此方法的。

3.需要BASE64编码的请使用`string.ToBase64()` 扩展方法
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
    
其它
-------------

### 链接
UCloud: http://www.ucloud.cn/
UCloud API: http://docs.ucloud.cn/api/index.html
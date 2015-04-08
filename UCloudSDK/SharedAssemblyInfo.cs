using System;
using System.Reflection;
using UCloudSDK;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyDescription("UCloud API C# SDK")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("icyflash")]
[assembly: AssemblyProduct("UCloud API C# SDK")]
[assembly: AssemblyCopyright("Copyright © UCloudSDK Project")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(true)]
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(SharedAssemblyInfo.Version + ".0")]
[assembly: AssemblyInformationalVersion(SharedAssemblyInfo.Version)]
[assembly: AssemblyFileVersion(SharedAssemblyInfo.Version + ".0")]

namespace UCloudSDK
{
    class SharedAssemblyInfo
    {
        public const string Version = "1.0.9";
    }
}

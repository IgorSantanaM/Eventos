[1mdiff --git a/.vs/Eventos.IO/DesignTimeBuild/.dtbcache.v2 b/.vs/Eventos.IO/DesignTimeBuild/.dtbcache.v2[m
[1mindex 2a4d2c4..7a73506 100644[m
Binary files a/.vs/Eventos.IO/DesignTimeBuild/.dtbcache.v2 and b/.vs/Eventos.IO/DesignTimeBuild/.dtbcache.v2 differ
[1mdiff --git a/.vs/Eventos.IO/FileContentIndex/150bb181-bad8-4cbf-a664-cd3706af75c7.vsidx b/.vs/Eventos.IO/FileContentIndex/150bb181-bad8-4cbf-a664-cd3706af75c7.vsidx[m
[1mdeleted file mode 100644[m
[1mindex 70aef67..0000000[m
Binary files a/.vs/Eventos.IO/FileContentIndex/150bb181-bad8-4cbf-a664-cd3706af75c7.vsidx and /dev/null differ
[1mdiff --git a/.vs/Eventos.IO/FileContentIndex/4041e670-691c-40ff-854f-d9568be8e41c.vsidx b/.vs/Eventos.IO/FileContentIndex/4041e670-691c-40ff-854f-d9568be8e41c.vsidx[m
[1mdeleted file mode 100644[m
[1mindex bb7a168..0000000[m
Binary files a/.vs/Eventos.IO/FileContentIndex/4041e670-691c-40ff-854f-d9568be8e41c.vsidx and /dev/null differ
[1mdiff --git a/.vs/Eventos.IO/FileContentIndex/4a374ca6-fbd6-4396-a51e-27e91f92057c.vsidx b/.vs/Eventos.IO/FileContentIndex/4a374ca6-fbd6-4396-a51e-27e91f92057c.vsidx[m
[1mdeleted file mode 100644[m
[1mindex 70aef67..0000000[m
Binary files a/.vs/Eventos.IO/FileContentIndex/4a374ca6-fbd6-4396-a51e-27e91f92057c.vsidx and /dev/null differ
[1mdiff --git a/.vs/Eventos.IO/FileContentIndex/cfe87688-c359-4486-ab58-3500103df9bd.vsidx b/.vs/Eventos.IO/FileContentIndex/cfe87688-c359-4486-ab58-3500103df9bd.vsidx[m
[1mdeleted file mode 100644[m
[1mindex 70aef67..0000000[m
Binary files a/.vs/Eventos.IO/FileContentIndex/cfe87688-c359-4486-ab58-3500103df9bd.vsidx and /dev/null differ
[1mdiff --git a/.vs/Eventos.IO/FileContentIndex/ea969158-efdf-4907-b11a-2bc612f95311.vsidx b/.vs/Eventos.IO/FileContentIndex/ea969158-efdf-4907-b11a-2bc612f95311.vsidx[m
[1mdeleted file mode 100644[m
[1mindex 70aef67..0000000[m
Binary files a/.vs/Eventos.IO/FileContentIndex/ea969158-efdf-4907-b11a-2bc612f95311.vsidx and /dev/null differ
[1mdiff --git a/.vs/Eventos.IO/config/applicationhost.config b/.vs/Eventos.IO/config/applicationhost.config[m
[1mdeleted file mode 100644[m
[1mindex 0d88f0d..0000000[m
[1m--- a/.vs/Eventos.IO/config/applicationhost.config[m
[1m+++ /dev/null[m
[36m@@ -1,1016 +0,0 @@[m
[31m-<?xml version="1.0" encoding="UTF-8"?>[m
[31m-<!--[m
[31m-[m
[31m-    IIS configuration sections.[m
[31m-[m
[31m-    For schema documentation, see[m
[31m-    %IIS_BIN%\config\schema\IIS_schema.xml.[m
[31m-    [m
[31m-    Please make a backup of this file before making any changes to it.[m
[31m-[m
[31m-    NOTE: The following environment variables are available to be used[m
[31m-          within this file and are understood by the IIS Express.[m
[31m-[m
[31m-          %IIS_USER_HOME% - The IIS Express home directory for the user[m
[31m-          %IIS_SITES_HOME% - The default home directory for sites[m
[31m-          %IIS_BIN% - The location of the IIS Express binaries[m
[31m-          %SYSTEMDRIVE% - The drive letter of %IIS_BIN%[m
[31m-[m
[31m--->[m
[31m-<configuration>[m
[31m-[m
[31m-    <!--[m
[31m-[m
[31m-        The <configSections> section controls the registration of sections.[m
[31m-        Section is the basic unit of deployment, locking, searching and[m
[31m-        containment for configuration settings.[m
[31m-        [m
[31m-        Every section belongs to one section group.[m
[31m-        A section group is a container of logically-related sections.[m
[31m-        [m
[31m-        Sections cannot be nested.[m
[31m-        Section groups may be nested.[m
[31m-        [m
[31m-        <section[m
[31m-            name=""  [Required, Collection Key] [XML name of the section][m
[31m-            allowDefinition="Everywhere" [MachineOnly|MachineToApplication|AppHostOnly|Everywhere] [Level where it can be set][m
[31m-            overrideModeDefault="Allow"  [Allow|Deny] [Default delegation mode][m
[31m-            allowLocation="true"  [true|false] [Allowed in location tags][m
[31m-        />[m
[31m-        [m
[31m-        The recommended way to unlock sections is by using a location tag:[m
[31m-        <location path="Default Web Site" overrideMode="Allow">[m
[31m-            <system.webServer>[m
[31m-                <asp />[m
[31m-            </system.webServer>[m
[31m-        </location>[m
[31m-[m
[31m-    -->[m
[31m-    <configSections>[m
[31m-        <sectionGroup name="system.applicationHost">[m
[31m-            <section name="applicationPools" allowDefinition="AppHostOnly" overrideModeDefault="Deny" />[m
[31m-            <section name="configHistory" allowDefinition="AppHostOnly" overrideModeDefault="Deny" />[m
[31m-            <section name="customMetadata" allowDefinition="AppHostOnly" overrideModeDefault="Deny" />[m
[31m-            <section name="listenerAdapters" allowDefinition="AppHostOnly" overrideModeDefault="Deny" />[m
[31m-            <section name="log" allowDefinition="AppHostOnly" overrideModeDefault="Deny" />[m
[31m-            <section name="serviceAutoStartProviders" allowDefinition="AppHostOnly" overrideModeDefault="Deny" />[m
[31m-            <section name="sites" allowDefinition="AppHostOnly" overrideModeDefault="Deny" />[m
[31m-            <section name="webLimits" allowDefinition="AppHostOnly" overrideModeDefault="Deny" />[m
[31m-        </sectionGroup>[m
[31m-[m
[31m-        <sectionGroup name="system.webServer">[m
[31m-            <section name="asp" overrideModeDefault="Deny" />[m
[31m-            <section name="caching" overrideModeDefault="Allow" />[m
[31m-            <section name="cgi" overrideModeDefault="Deny" />[m
[31m-            <section name="defaultDocument" overrideModeDefault="Allow" />[m
[31m-            <section name="directoryBrowse" overrideModeDefault="Allow" />[m
[31m-            <section name="fastCgi" allowDefinition="AppHostOnly" overrideModeDefault="Deny" />[m
[31m-            <section name="globalModules" allowDefinition="AppHostOnly" overrideModeDefault="Deny" />[m
[31m-            <section name="handlers" overrideModeDefault="Deny" />[m
[31m-            <section name="httpCompression" overrideModeDefault="Allow" allowDefinition="Everywhere" />[m
[31m-            <section name="httpErrors" overrideModeDefault="Allow" />[m
[31m-            <section name="httpLogging" overrideModeDefault="Deny" />[m
[31m-            <section name="httpProtocol" overrideModeDefault="Allow" />[m
[31m-            <section name="httpRedirect" overrideModeDefault="Allow" />[m
[31m-            <section name="httpTracing" overrideModeDefault="Deny" />[m
[31m-            <section name="isapiFilters" allowDefinition="MachineToApplication" overrideModeDefault="Deny" />[m
[31m-            <section name="modules" allowDefinition="MachineToApplication" overrideModeDefault="Deny" />[m
[31m-            <section name="applicationInitialization" allowDefinition="MachineToApplication" overrideModeDefault="Allow" />[m
[31m-            <section name="odbcLogging" overrideModeDefault="Deny" />[m
[31m-            <sectionGroup name="security">[m
[31m-                <section name="access" overrideModeDefault="Deny" />[m
[31m-                <section name="applicationDependencies" overrideModeDefault="Deny" />[m
[31m-                <sectionGroup name="authentication">[m
[31m-                    <section name="anonymousAuthentication" overrideModeDefault="Deny" />[m
[31m-                    <section name="basicAuthentication" overrideModeDefault="Deny" />[m
[31m-                    <section name="clientCertificateMappingAuthentication" overrideModeDefault="Deny" />[m
[31m-                    <section name="digestAuthentication" overrideModeDefault="Deny" />[m
[31m-                    <section name="iisClientCertificateMappingAuthentication" overrideModeDefault="Deny" />[m
[31m-                    <section name="windowsAuthentication" overrideModeDefault="Deny" />[m
[31m-                </sectionGroup>[m
[31m-                <section name="authorization" overrideModeDefault="Allow" />[m
[31m-                <section name="ipSecurity" overrideModeDefault="Deny" />[m
[31m-                <section name="dynamicIpSecurity" overrideModeDefault="Deny" />[m
[31m-                <section name="isapiCgiRestriction" allowDefinition="AppHostOnly" overrideModeDefault="Deny" />[m
[31m-                <section name="requestFiltering" overrideModeDefault="Allow" />[m
[31m-            </sectionGroup>[m
[31m-            <section name="serverRuntime" overrideModeDefault="Deny" />[m
[31m-            <section name="serverSideInclude" overrideModeDefault="Deny" />[m
[31m-            <section name="staticContent" overrideModeDefault="Allow" />[m
[31m-            <sectionGroup name="tracing">[m
[31m-                <section name="traceFailedRequests" overrideModeDefault="Allow" />[m
[31m-                <section name="traceProviderDefinitions" overrideModeDefault="Deny" />[m
[31m-            </sectionGroup>[m
[31m-            <section name="urlCompression" overrideModeDefault="Allow" />[m
[31m-            <section name="validation" overrideModeDefault="Allow" />[m
[31m-            <sectionGroup name="webdav">[m
[31m-                <section name="globalSettings" overrideModeDefault="Deny" />[m
[31m-                <section name="authoring" overrideModeDefault="Deny" />[m
[31m-                <section name="authoringRules" overrideModeDefault="Deny" />[m
[31m-            </sectionGroup>[m
[31m-            <sectionGroup name="rewrite">[m
[31m-                <section name="allowedServerVariables" overrideModeDefault="Deny" />[m
[31m-                <section name="rules" overrideModeDefault="Allow" />[m
[31m-                <section name="outboundRules" overrideModeDefault="Allow" />[m
[31m-                <section name="globalRules" overrideModeDefault="Deny" allowDefinition="AppHostOnly" />[m
[31m-                <section name="providers" overrideModeDefault="Allow" />[m
[31m-                <section name="rewriteMaps" overrideModeDefault="Allow" />[m
[31m-            </sectionGroup>[m
[31m-            <section name="webSocket" overrideModeDefault="Deny" />[m
[31m-        <section name="aspNetCore" overrideModeDefault="Allow" /></sectionGroup>[m
[31m-    </configSections>[m
[31m-[m
[31m-    <configProtectedData>[m
[31m-        <providers>[m
[31m-            <add name="IISWASOnlyRsaProvider" type="" description="Uses RsaCryptoServiceProvider to encrypt and decrypt" keyContainerName="iisWasKey" cspProviderName="" useMachineContainer="true" useOAEP="false" />[m
[31m-            <add name="AesProvider" type="Microsoft.ApplicationHost.AesProtectedConfigurationProvider" description="Uses an AES session key to encrypt and decrypt" keyContainerName="iisConfigurationKey" cspProviderName="" useOAEP="false" useMachineContainer="true" sessionKey="AQIAAA5mAAAApAAA/HKxkz6alrlAPez0IUgujj/6k3WxCDriHp6jvpv3yEZmo7h6SMzGLxo4mTrIQVHSkB7tmElHKfUFTzE2BWF7nFWHY6Z6qmGBauFzwJMwESjril7Gjz69RBFH259HQ6aRDq9Xfx7U7H4HtdmnKNqGjgl/hwPQBGeIlWiDh+sYv3vKB0QU971tjX6H2B+9armlnC8UOuA6JYMDMI/VLLL16sng0fWAy5JYe0YVABVjiAWDW264RZW9Tr1Oax4qHZKg+SdjULxeOc2YmpX+d0yeITo1HkPF1hN1gHpIPIUDo05ilHUNfR3OkjVCIQK4cFKCq1s8NH+y+13MxUC4Fn1AlQ==" />[m
[31m-            <add name="IISWASOnlyAesProvider" type="Microsoft.ApplicationHost.AesProtectedConfigurationProvider" description="Uses an AES session key to encrypt and decrypt" keyContainerName="iisWasKey" cspProviderName="" useOAEP="false" useMachineContainer="true" sessionKey="AQIAAA5mAAAApAAALmU8lTC+v2qtfQiiiquvvLpUQqKLEXs+jSKoWCM/uPhyB++k4dwug19mGidNK5FYiWK2KYE1yhjVJcbp12E98Q0R2nT7eBiCMY2JairxQ591rqABK7keGaIjwH7PwGzSpILl3RJ4YFvJ/7ZXEJxeDZIjW8ZxWVXx+/VyHs9U3WguLEkgMUX3jrxJi8LouxaIVPJAv/YQ1ZCWs8zImitxX/C/7o7yaIxznfsN5nGQzQfpUDPeby99aw2zPVTtZI2LaWIBON8guABvZ6JtJVDWmfdK6sodbnwdZkr6/Z2rfvamT1dC1SpQrGG7ulR/f9/GXvCaW10ZVKxekBF/CYlNMg==" />[m
[31m-        </providers>[m
[31m-    </configProtectedData>[m
[31m-[m
[31m-    <system.applicationHost>[m
[31m-[m
[31m-        <applicationPools>[m
[31m-            <add name="Clr4IntegratedAppPool" managedRuntimeVersion="v4.0" managedPipelineMode="Integrated" CLRConfigFile="%IIS_USER_HOME%\config\aspnet.config" autoStart="true" />[m
[31m-            <add name="Clr4ClassicAppPool" managedRuntimeVersion="v4.0" managedPipelineMode="Classic" CLRConfigFile="%IIS_USER_HOME%\config\aspnet.config" autoStart="true" />[m
[31m-            <add name="Clr2IntegratedAppPool" managedRuntimeVersion="v2.0" managedPipelineMode="Integrated" CLRConfigFile="%IIS_USER_HOME%\config\aspnet.config" autoStart="true" />[m
[31m-            <add name="Clr2ClassicAppPool" managedRuntimeVersion="v2.0" managedPipelineMode="Classic" CLRConfigFile="%IIS_USER_HOME%\config\aspnet.config" autoStart="true" />[m
[31m-            <add name="UnmanagedClassicAppPool" managedRuntimeVersion="" managedPipelineMode="Classic" autoStart="true" />[m
[31m-            <applicationPoolDefaults managedRuntimeVersion="v4.0">[m
[31m-                <processModel loadUserProfile="true" setProfileEnvironment="false" />[m
[31m-            </applicationPoolDefaults>[m
[31m-        </applicationPools>[m
[31m-[m
[31m-        <!--[m
[31m-[m
[31m-          The <listenerAdapters> section defines the protocols with which the[m
[31m-          Windows Process Activation Service (WAS) binds.[m
[31m-[m
[31m-        -->[m
[31m-        <listenerAdapters>[m
[31m-            <add name="http" />[m
[31m-        </listenerAdapters>[m
[31m-[m
[31m-        <sites>[m
[31m-            <site name="WebSite1" id="1" serverAutoStart="true">[m
[31m-                <application path="/">[m
[31m-                    <virtualDirectory path="/" physicalPath="%IIS_SITES_HOME%\WebSite1" />[m
[31m-                </application>[m
[31m-                <bindings>[m
[31m-                    <binding protocol="http" bindingInformation=":8080:localhost" />[m
[31m-                </bindings>[m
[31m-            </site>[m
[31m-            <siteDefaults>[m
[31m-                <!-- To enable logging, please change the below attribute "enabled" to "true" -->[m
[31m-                <logFile logFormat="W3C" directory="%AppData%\Microsoft\IISExpressLogs" enabled="false" />[m
[31m-                <traceFailedRequestsLogging directory="%AppData%\Microsoft" enabled="false" maxLogFileSizeKB="1024" />[m
[31m-            </siteDefaults>[m
[31m-            <applicationDefaults applicationPool="Clr4IntegratedAppPool" />[m
[31m-            <virtualDirectoryDefaults allowSubDirConfig="true" />[m
[31m-        </sites>[m
[31m-[m
[31m-        <webLimits />[m
[31m-[m
[31m-    </system.applicationHost>[m
[31m-[m
[31m-    <system.webServer>[m
[31m-[m
[31m-        <serverRuntime />[m
[31m-[m
[31m-        <asp scriptErrorSentToBrowser="true">[m
[31m-            <cache diskTemplateCacheDirectory="%TEMP%\iisexpress\ASP Compiled Templates" />[m
[31m-            <limits />[m
[31m-        </asp>[m
[31m-[m
[31m-        <caching enabled="true" enableKernelCache="true">[m
[31m-        </caching>[m
[31m-[m
[31m-        <cgi />[m
[31m-[m
[31m-        <defaultDocument enabled="true">[m
[31m-            <files>[m
[31m-                <add value="Default.htm" />[m
[31m-                <add value="Default.asp" />[m
[31m-                <add value="index.htm" />[m
[31m-                <add value="index.html" />[m
[31m-                <add value="iisstart.htm" />[m
[31m-                <add value="default.aspx" />[m
[31m-            </files>[m
[31m-        </defaultDocument>[m
[31m-[m
[31m-        <directoryBrowse enabled="false" />[m
[31m-[m
[31m-        <fastCgi />[m
[31m-[m
[31m-        <!--[m
[31m-[m
[31m-          The <globalModules> section defines all native-code modules.[m
[31m-          To enable a module, specify it in the <modules> section.[m
[31m-[m
[31m-        -->[m
[31m-        <globalModules>[m
[31m-            <add name="HttpLoggingModule" image="%IIS_BIN%\loghttp.dll" />[m
[31m-            <add name="UriCacheModule" image="%IIS_BIN%\cachuri.dll" />[m
[31m-            <add name="TokenCacheModule" image="%IIS_BIN%\cachtokn.dll" />[m
[31m-            <add name="DynamicCompressionModule" image="%IIS_BIN%\compdyn.dll" />[m
[31m-            <add name="StaticCompressionModule" image="%IIS_BIN%\compstat.dll" />[m
[31m-            <add name="DefaultDocumentModule" image="%IIS_BIN%\defdoc.dll" />[m
[31m-            <add name="DirectoryListingModule" image="%IIS_BIN%\dirlist.dll" />[m
[31m-            <add name="ProtocolSupportModule" image="%IIS_BIN%\protsup.dll" />[m
[31m-            <add name="HttpRedirectionModule" image="%IIS_BIN%\redirect.dll" />[m
[31m-            <add name="ServerSideIncludeModule" image="%IIS_BIN%\iis_ssi.dll" />[m
[31m-            <add name="StaticFileModule" image="%IIS_BIN%\static.dll" />[m
[31m-            <add name="AnonymousAuthenticationModule" image="%IIS_BIN%\authanon.dll" />[m
[31m-            <add name="CertificateMappingAuthenticationModule" image="%IIS_BIN%\authcert.dll" />[m
[31m-            <add name="UrlAuthorizationModule" image="%IIS_BIN%\urlauthz.dll" />[m
[31m-            <add name="BasicAuthenticationModule" image="%IIS_BIN%\authbas.dll" />[m
[31m-            <add name="WindowsAuthenticationModule" image="%IIS_BIN%\authsspi.dll" />[m
[31m-            <add name="IISCertificateMappingAuthenticationModule" image="%IIS_BIN%\authmap.dll" />[m
[31m-            <add name="IpRestrictionModule" image="%IIS_BIN%\iprestr.dll" />[m
[31m-            <add name="DynamicIpRestrictionModule" image="%IIS_BIN%\diprestr.dll" />[m
[31m-            <add name="RequestFilteringModule" image="%IIS_BIN%\modrqflt.dll" />[m
[31m-            <add name="CustomLoggingModule" image="%IIS_BIN%\logcust.dll" />[m
[31m-            <add name="CustomErrorModule" image="%IIS_BIN%\custerr.dll" />[m
[31m-            <add name="FailedRequestsTracingModule" image="%IIS_BIN%\iisfreb.dll" />[m
[31m-            <add name="RequestMonitorModule" image="%IIS_BIN%\iisreqs.dll" />[m
[31m-            <add name="IsapiModule" image="%IIS_BIN%\isapi.dll" />[m
[31m-            <add name="IsapiFilterModule" image="%IIS_BIN%\filter.dll" />[m
[31m-            <add name="CgiModule" image="%IIS_BIN%\cgi.dll" />[m
[31m-            <add name="FastCgiModule" image="%IIS_BIN%\iisfcgi.dll" />[m
[31m-<!--            <add name="WebDAVModule" image="%IIS_BIN%\webdav.dll" /> -->[m
[31m-            <add name="RewriteModule" image="%IIS_BIN%\rewrite.dll" />[m
[31m-            <add name="ConfigurationValidationModule" image="%IIS_BIN%\validcfg.dll" />[m
[31m-            <add name="WebSocketModule" image="%IIS_BIN%\iiswsock.dll" />[m
[31m-            <add name="WebMatrixSupportModule" image="%IIS_BIN%\webmatrixsup.dll" />[m
[31m-            <add name="ManagedEngine" image="%windir%\Microsoft.NET\Framework\v2.0.50727\webengine.dll" preCondition="integratedMode,runtimeVersionv2.0,bitness32" />[m
[31m-            <add name="ManagedEngine64" image="%windir%\Microsoft.NET\Framework64\v2.0.50727\webengine.dll" preCondition="integratedMode,runtimeVersionv2.0,bitness64" />[m
[31m-            <add name="ManagedEngineV4.0_32bit" image="%windir%\Microsoft.NET\Framework\v4.0.30319\webengine4.dll" preCondition="integratedMode,runtimeVersionv4.0,bitness32" />[m
[31m-            <add name="ManagedEngineV4.0_64bit" image="%windir%\Microsoft.NET\Framework64\v4.0.30319\webengine4.dll" preCondition="integratedMode,runtimeVersionv4.0,bitness64" />[m
[31m-            <add name="ApplicationInitializationModule" image="%IIS_BIN%\warmup.dll" />[m
[31m-            <add name="AspNetCoreModule" image="%IIS_BIN%\aspnetcore.dll" />[m
[31m-            <add name="AspNetCoreModuleV2" image="%IIS_BIN%\Asp.Net Core Module\V2\aspnetcorev2.dll" />[m
[31m-        </globalModules>[m
[31m-[m
[31m-        <httpCompression directory="%TEMP%">[m
[31m-            <scheme name="gzip" dll="%IIS_BIN%\gzip.dll" />[m
[31m-            <dynamicTypes>[m
[31m-                <add mimeType="text/*" enabled="true" />[m
[31m-                <add mimeType="message/*" enabled="true" />[m
[31m-                <add mimeType="application/x-javascript" enabled="true" />[m
[31m-                <add mimeType="application/javascript" enabled="true" />[m
[31m-                <add mimeType="*/*" enabled="false" />[m
[31m-                <add mimeType="text/event-stream" enabled="false" />[m
[31m-            </dynamicTypes>[m
[31m-            <staticTypes>[m
[31m-                <add mimeType="text/*" enabled="true" />[m
[31m-                <add mimeType="message/*" enabled="true" />[m
[31m-                <add mimeType="application/javascript" enabled="true" />[m
[31m-                <add mimeType="application/atom+xml" enabled="true" />[m
[31m-                <add mimeType="application/xaml+xml" enabled="true" />[m
[31m-                <add mimeType="image/svg+xml" enabled="true" />[m
[31m-                <add mimeType="*/*" enabled="false" />[m
[31m-            </staticTypes>[m
[31m-        </httpCompression>[m
[31m-[m
[31m-        <httpErrors lockAttributes="allowAbsolutePathsWhenDelegated,defaultPath">[m
[31m-            <error statusCode="401" prefixLanguageFilePath="%IIS_BIN%\custerr" path="401.htm" />[m
[31m-            <error statusCode="403" prefixLanguageFilePath="%IIS_BIN%\custerr" path="403.htm" />[m
[31m-            <error statusCode="404" prefixLanguageFilePath="%IIS_BIN%\custerr" path="404.htm" />[m
[31m-            <error statusCode="405" prefixLanguageFilePath="%IIS_BIN%\custerr" path="405.htm" />[m
[31m-            <error statusCode="406" prefixLanguageFilePath="%IIS_BIN%\custerr" path="406.htm" />[m
[31m-            <error statusCode="412" prefixLanguageFilePath="%IIS_BIN%\custerr" path="412.htm" />[m
[31m-            <error statusCode="500" prefixLanguageFilePath="%IIS_BIN%\custerr" path="500.htm" />[m
[31m-            <error statusCode="501" prefixLanguageFilePath="%IIS_BIN%\custerr" path="501.htm" />[m
[31m-            <error statusCode="502" prefixLanguageFilePath="%IIS_BIN%\custerr" path="502.htm" />[m
[31m-        </httpErrors>[m
[31m-[m
[31m-        <httpLogging dontLog="false" />[m
[31m-[m
[31m-        <httpProtocol>[m
[31m-            <customHeaders>[m
[31m-                <clear />[m
[31m-                <add name="X-Powered-By" value="ASP.NET" />[m
[31m-            </customHeaders>[m
[31m-            <redirectHeaders>[m
[31m-                <clear />[m
[31m-            </redirectHeaders>[m
[31m-        </httpProtocol>[m
[31m-[m
[31m-        <httpRedirect enabled="false" />[m
[31m-[m
[31m-        <httpTracing />[m
[31m-[m
[31m-        <isapiFilters>[m
[31m-            <filter name="ASP.Net_2.0.50727-64" path="%windir%\Microsoft.NET\Framework64\v2.0.50727\aspnet_filter.dll" enableCache="true" preCondition="bitness64,runtimeVersionv2.0" />[m
[31m-            <filter name="ASP.Net_2.0.50727.0" path="%windir%\Microsoft.NET\Framework\v2.0.50727\aspnet_filter.dll" enableCache="true" preCondition="bitness32,runtimeVersionv2.0" />[m
[31m-            <filter name="ASP.Net_2.0_for_v1.1" path="%windir%\Microsoft.NET\Framework\v2.0.50727\aspnet_filter.dll" enableCache="true" preCondition="runtimeVersionv1.1" />[m
[31m-            <filter name="ASP.Net_4.0_32bit" path="%windir%\Microsoft.NET\Framework\v4.0.30319\aspnet_filter.dll" enableCache="true" preCondition="bitness32,runtimeVersionv4.0" />[m
[31m-            <filter name="ASP.Net_4.0_64bit" path="%windir%\Microsoft.NET\Framework64\v4.0.30319\aspnet_filter.dll" enableCache="true" preCondition="bitness64,runtimeVersionv4.0" />[m
[31m-        </isapiFilters>[m
[31m-[m
[31m-        <odbcLogging />[m
[31m-[m
[31m-        <security>[m
[31m-[m
[31m-            <access sslFlags="None" />[m
[31m-[m
[31m-            <applicationDependencies>[m
[31m-                <application name="Active Server Pages" groupId="ASP" />[m
[31m-            </applicationDependencies>[m
[31m-[m
[31m-            <authentication>[m
[31m-[m
[31m-                <anonymousAuthentication enabled="true" userName="" />[m
[31m-[m
[31m-                <basicAuthentication enabled="false" />[m
[31m-[m
[31m-                <clientCertificateMappingAuthentication enabled="false" />[m
[31m-[m
[31m-                <digestAuthentication enabled="false" />[m
[31m-[m
[31m-                <iisClientCertificateMappingAuthentication enabled="false">[m
[31m-                </iisClientCertificateMappingAuthentication>[m
[31m-[m
[31m-                <windowsAuthentication enabled="false">[m
[31m-                    <providers>[m
[31m-                        <add value="Negotiate" />[m
[31m-                        <add value="NTLM" />[m
[31m-                    </providers>[m
[31m-                </windowsAuthentication>[m
[31m-[m
[31m-            </authentication>[m
[31m-[m
[31m-            <authorization>[m
[31m-                <add accessType="Allow" users="*" />[m
[31m-            </authorization>[m
[31m-[m
[31m-            <ipSecurity allowUnlisted="true" />[m
[31m-[m
[31m-            <isapiCgiRestriction notListedIsapisAllowed="true" notListedCgisAllowed="true">[m
[31m-                <add path="%windir%\Microsoft.NET\Framework64\v4.0.30319\webengine4.dll" allowed="true" groupId="ASP.NET_v4.0" description="ASP.NET_v4.0" />[m
[31m-                <add path="%windir%\Microsoft.NET\Framework\v4.0.30319\webengine4.dll" allowed="true" groupId="ASP.NET_v4.0" description="ASP.NET_v4.0" />[m
[31m-                <add path="%windir%\Microsoft.NET\Framework64\v2.0.50727\aspnet_isapi.dll" allowed="true" groupId="ASP.NET v2.0.50727" description="ASP.NET v2.0.50727" />[m
[31m-                <add path="%windir%\Microsoft.NET\Framework\v2.0.50727\aspnet_isapi.dll" allowed="true" groupId="ASP.NET v2.0.50727" description="ASP.NET v2.0.50727" />[m
[31m-            </isapiCgiRestriction>[m
[31m-[m
[31m-            <requestFiltering>[m
[31m-                <fileExtensions allowUnlisted="true" applyToWebDAV="true">[m
[31m-                    <add fileExtension=".asa" allowed="false" />[m
[31m-                    <add fileExtension=".asax" allowed="false" />[m
[31m-                    <add fileExtension=".ascx" allowed="false" />[m
[31m-                    <add fileExtension=".master" allowed="false" />[m
[31m-                    <add fileExtension=".skin" allowed="false" />[m
[31m-                    <add fileExtension=".browser" allowed="false" />[m
[31m-                    <add fileExtension=".sitemap" allowed="false" />[m
[31m-                    <add fileExtension=".config" allowed="false" />[m
[31m-                    <add fileExtension=".cs" allowed="false" />[m
[31m-                    <add fileExtension=".csproj" allowed="false" />[m
[31m-                    <add fileExtension=".vb" allowed="false" />[m
[31m-                    <add fileExtension=".vbproj" allowed="false" />[m
[31m-                    <add fileExtension=".webinfo" allowed="false" />[m
[31m-                    <add fileExtension=".licx" allowed="false" />[m
[31m-                    <add fileExtension=".resx" allowed="false" />[m
[31m-                    <add fileExtension=".resources" allowed="false" />[m
[31m-                    <add fileExtension=".mdb" allowed="false" />[m
[31m-                    <add fileExtension=".vjsproj" allowed="false" />[m
[31m-                    <add fileExtension=".java" allowed="false" />[m
[31m-                    <add fileExtension=".jsl" allowed="false" />[m
[31m-                    <add fileExtension=".ldb" allowed="false" />[m
[31m-                    <add fileExtension=".dsdgm" allowed="false" />[m
[31m-                    <add fileExtension=".ssdgm" allowed="false" />[m
[31m-                    <add fileExtension=".lsad" allowed="false" />[m
[31m-                    <add fileExtension=".ssmap" allowed="false" />[m
[31m-                    <add fileExtension=".cd" allowed="false" />[m
[31m-                    <add fileExtension=".dsprototype" allowed="false" />[m
[31m-                    <add fileExtension=".lsaprototype" allowed="false" />[m
[31m-                    <add fileExtension=".sdm" allowed="false" />[m
[31m-                    <add fileExtension=".sdmDocument" allowed="false" />[m
[31m-                    <add fileExtension=".mdf" allowed="false" />[m
[31m-                    <add fileExtension=".ldf" allowed="false" />[m
[31m-                    <add fileExtension=".ad" allowed="false" />[m
[31m-                    <add fileExtension=".dd" allowed="false" />[m
[31m-                    <add fileExtension=".ldd" allowed="false" />[m
[31m-                    <add fileExtension=".sd" allowed="false" />[m
[31m-                    <add fileExtension=".adprototype" allowed="false" />[m
[31m-                    <add fileExtension=".lddprototype" allowed="false" />[m
[31m-                    <add fileExtension=".exclude" allowed="false" />[m
[31m-                    <add fileExtension=".refresh" allowed="false" />[m
[31m-                    <add fileExtension=".compiled" allowed="false" />[m
[31m-                    <add fileExtension=".msgx" allowed="false" />[m
[31m-                    <add fileExtension=".vsdisco" allowed="false" />[m
[31m-                    <add fileExtension=".rules" allowed="false" />[m
[31m-                </fileExtensions>[m
[31m-                <verbs allowUnlisted="true" applyToWebDAV="true" />[m
[31m-                <hiddenSegments applyToWebDAV="true">[m
[31m-                    <add segment="web.config" />[m
[31m-                    <add segment="bin" />[m
[31m-                    <add segment="App_code" />[m
[31m-                    <add segment="App_GlobalResources" />[m
[31m-                    <add segment="App_LocalResources" />[m
[31m-                    <add segment="App_WebReferences" />[m
[31m-                    <add segment="App_Data" />[m
[31m-                    <add segment="App_Browsers" />[m
[31m-                </hiddenSegments>[m
[31m-            </requestFiltering>[m
[31m-[m
[31m-        </security>[m
[31m-[m
[31m-        <serverSideInclude ssiExecDisable="false" />[m
[31m-[m
[31m-        <staticContent lockAttributes="isDocFooterFileName">[m
[31m-            <mimeMap fileExtension=".323" mimeType="text/h323" />[m
[31m-            <mimeMap fileExtension=".3g2" mimeType="video/3gpp2" />[m
[31m-            <mimeMap fileExtension=".3gp2" mimeType="video/3gpp2" />[m
[31m-            <mimeMap fileExtension=".3gp" mimeType="video/3gpp" />[m
[31m-            <mimeMap fileExtension=".3gpp" mimeType="video/3gpp" />[m
[31m-            <mimeMap fileExtension=".aac" mimeType="audio/aac" />[m
[31m-            <mimeMap fileExtension=".aaf" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".aca" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".accdb" mimeType="application/msaccess" />[m
[31m-            <mimeMap fileExtension=".accde" mimeType="application/msaccess" />[m
[31m-            <mimeMap fileExtension=".accdt" mimeType="application/msaccess" />[m
[31m-            <mimeMap fileExtension=".acx" mimeType="application/internet-property-stream" />[m
[31m-            <mimeMap fileExtension=".adt" mimeType="audio/vnd.dlna.adts" />[m
[31m-            <mimeMap fileExtension=".adts" mimeType="audio/vnd.dlna.adts" />[m
[31m-            <mimeMap fileExtension=".afm" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".ai" mimeType="application/postscript" />[m
[31m-            <mimeMap fileExtension=".aif" mimeType="audio/x-aiff" />[m
[31m-            <mimeMap fileExtension=".aifc" mimeType="audio/aiff" />[m
[31m-            <mimeMap fileExtension=".aiff" mimeType="audio/aiff" />[m
[31m-            <mimeMap fileExtension=".appcache" mimeType="text/cache-manifest" />[m
[31m-            <mimeMap fileExtension=".application" mimeType="application/x-ms-application" />[m
[31m-            <mimeMap fileExtension=".art" mimeType="image/x-jg" />[m
[31m-            <mimeMap fileExtension=".asd" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".asf" mimeType="video/x-ms-asf" />[m
[31m-            <mimeMap fileExtension=".asi" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".asm" mimeType="text/plain" />[m
[31m-            <mimeMap fileExtension=".asr" mimeType="video/x-ms-asf" />[m
[31m-            <mimeMap fileExtension=".asx" mimeType="video/x-ms-asf" />[m
[31m-            <mimeMap fileExtension=".atom" mimeType="application/atom+xml" />[m
[31m-            <mimeMap fileExtension=".au" mimeType="audio/basic" />[m
[31m-            <mimeMap fileExtension=".avi" mimeType="video/avi" />[m
[31m-            <mimeMap fileExtension=".axs" mimeType="application/olescript" />[m
[31m-            <mimeMap fileExtension=".bas" mimeType="text/plain" />[m
[31m-            <mimeMap fileExtension=".bcpio" mimeType="application/x-bcpio" />[m
[31m-            <mimeMap fileExtension=".bin" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".bmp" mimeType="image/bmp" />[m
[31m-            <mimeMap fileExtension=".c" mimeType="text/plain" />[m
[31m-            <mimeMap fileExtension=".cab" mimeType="application/vnd.ms-cab-compressed" />[m
[31m-            <mimeMap fileExtension=".calx" mimeType="application/vnd.ms-office.calx" />[m
[31m-            <mimeMap fileExtension=".cat" mimeType="application/vnd.ms-pki.seccat" />[m
[31m-            <mimeMap fileExtension=".cdf" mimeType="application/x-cdf" />[m
[31m-            <mimeMap fileExtension=".chm" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".class" mimeType="application/x-java-applet" />[m
[31m-            <mimeMap fileExtension=".clp" mimeType="application/x-msclip" />[m
[31m-            <mimeMap fileExtension=".cmx" mimeType="image/x-cmx" />[m
[31m-            <mimeMap fileExtension=".cnf" mimeType="text/plain" />[m
[31m-            <mimeMap fileExtension=".cod" mimeType="image/cis-cod" />[m
[31m-            <mimeMap fileExtension=".cpio" mimeType="application/x-cpio" />[m
[31m-            <mimeMap fileExtension=".cpp" mimeType="text/plain" />[m
[31m-            <mimeMap fileExtension=".crd" mimeType="application/x-mscardfile" />[m
[31m-            <mimeMap fileExtension=".crl" mimeType="application/pkix-crl" />[m
[31m-            <mimeMap fileExtension=".crt" mimeType="application/x-x509-ca-cert" />[m
[31m-            <mimeMap fileExtension=".csh" mimeType="application/x-csh" />[m
[31m-            <mimeMap fileExtension=".css" mimeType="text/css" />[m
[31m-            <mimeMap fileExtension=".csv" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".cur" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".dcr" mimeType="application/x-director" />[m
[31m-            <mimeMap fileExtension=".deploy" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".der" mimeType="application/x-x509-ca-cert" />[m
[31m-            <mimeMap fileExtension=".dib" mimeType="image/bmp" />[m
[31m-            <mimeMap fileExtension=".dir" mimeType="application/x-director" />[m
[31m-            <mimeMap fileExtension=".disco" mimeType="text/xml" />[m
[31m-            <mimeMap fileExtension=".dll" mimeType="application/x-msdownload" />[m
[31m-            <mimeMap fileExtension=".dll.config" mimeType="text/xml" />[m
[31m-            <mimeMap fileExtension=".dlm" mimeType="text/dlm" />[m
[31m-            <mimeMap fileExtension=".doc" mimeType="application/msword" />[m
[31m-            <mimeMap fileExtension=".docm" mimeType="application/vnd.ms-word.document.macroEnabled.12" />[m
[31m-            <mimeMap fileExtension=".docx" mimeType="application/vnd.openxmlformats-officedocument.wordprocessingml.document" />[m
[31m-            <mimeMap fileExtension=".dot" mimeType="application/msword" />[m
[31m-            <mimeMap fileExtension=".dotm" mimeType="application/vnd.ms-word.template.macroEnabled.12" />[m
[31m-            <mimeMap fileExtension=".dotx" mimeType="application/vnd.openxmlformats-officedocument.wordprocessingml.template" />[m
[31m-            <mimeMap fileExtension=".dsp" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".dtd" mimeType="text/xml" />[m
[31m-            <mimeMap fileExtension=".dvi" mimeType="application/x-dvi" />[m
[31m-            <mimeMap fileExtension=".dvr-ms" mimeType="video/x-ms-dvr" />[m
[31m-            <mimeMap fileExtension=".dwf" mimeType="drawing/x-dwf" />[m
[31m-            <mimeMap fileExtension=".dwp" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".dxr" mimeType="application/x-director" />[m
[31m-            <mimeMap fileExtension=".eml" mimeType="message/rfc822" />[m
[31m-            <mimeMap fileExtension=".emz" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".eot" mimeType="application/vnd.ms-fontobject" />[m
[31m-            <mimeMap fileExtension=".eps" mimeType="application/postscript" />[m
[31m-            <mimeMap fileExtension=".esd" mimeType="application/vnd.ms-cab-compressed" />[m
[31m-            <mimeMap fileExtension=".etx" mimeType="text/x-setext" />[m
[31m-            <mimeMap fileExtension=".evy" mimeType="application/envoy" />[m
[31m-            <mimeMap fileExtension=".exe" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".exe.config" mimeType="text/xml" />[m
[31m-            <mimeMap fileExtension=".fdf" mimeType="application/vnd.fdf" />[m
[31m-            <mimeMap fileExtension=".fif" mimeType="application/fractals" />[m
[31m-            <mimeMap fileExtension=".fla" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".flr" mimeType="x-world/x-vrml" />[m
[31m-            <mimeMap fileExtension=".flv" mimeType="video/x-flv" />[m
[31m-            <mimeMap fileExtension=".gif" mimeType="image/gif" />[m
[31m-            <mimeMap fileExtension=".glb" mimeType="model/gltf-binary" />[m
[31m-            <mimeMap fileExtension=".gtar" mimeType="application/x-gtar" />[m
[31m-            <mimeMap fileExtension=".gz" mimeType="application/x-gzip" />[m
[31m-            <mimeMap fileExtension=".h" mimeType="text/plain" />[m
[31m-            <mimeMap fileExtension=".hdf" mimeType="application/x-hdf" />[m
[31m-            <mimeMap fileExtension=".hdml" mimeType="text/x-hdml" />[m
[31m-            <mimeMap fileExtension=".hhc" mimeType="application/x-oleobject" />[m
[31m-            <mimeMap fileExtension=".hhk" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".hhp" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".hlp" mimeType="application/winhlp" />[m
[31m-            <mimeMap fileExtension=".hqx" mimeType="application/mac-binhex40" />[m
[31m-            <mimeMap fileExtension=".hta" mimeType="application/hta" />[m
[31m-            <mimeMap fileExtension=".htc" mimeType="text/x-component" />[m
[31m-            <mimeMap fileExtension=".htm" mimeType="text/html" />[m
[31m-            <mimeMap fileExtension=".html" mimeType="text/html" />[m
[31m-            <mimeMap fileExtension=".htt" mimeType="text/webviewhtml" />[m
[31m-            <mimeMap fileExtension=".hxt" mimeType="text/html" />[m
[31m-            <mimeMap fileExtension=".ico" mimeType="image/x-icon" />[m
[31m-            <mimeMap fileExtension=".ics" mimeType="text/calendar" />[m
[31m-            <mimeMap fileExtension=".ief" mimeType="image/ief" />[m
[31m-            <mimeMap fileExtension=".iii" mimeType="application/x-iphone" />[m
[31m-            <mimeMap fileExtension=".inf" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".ins" mimeType="application/x-internet-signup" />[m
[31m-            <mimeMap fileExtension=".isp" mimeType="application/x-internet-signup" />[m
[31m-            <mimeMap fileExtension=".IVF" mimeType="video/x-ivf" />[m
[31m-            <mimeMap fileExtension=".jar" mimeType="application/java-archive" />[m
[31m-            <mimeMap fileExtension=".java" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".jck" mimeType="application/liquidmotion" />[m
[31m-            <mimeMap fileExtension=".jcz" mimeType="application/liquidmotion" />[m
[31m-            <mimeMap fileExtension=".jfif" mimeType="image/pjpeg" />[m
[31m-            <mimeMap fileExtension=".jpb" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".jpe" mimeType="image/jpeg" />[m
[31m-            <mimeMap fileExtension=".jpeg" mimeType="image/jpeg" />[m
[31m-            <mimeMap fileExtension=".jpg" mimeType="image/jpeg" />[m
[31m-            <mimeMap fileExtension=".js" mimeType="application/javascript" />[m
[31m-            <mimeMap fileExtension=".json" mimeType="application/json" />[m
[31m-            <mimeMap fileExtension=".jsonld" mimeType="application/ld+json" />[m
[31m-            <mimeMap fileExtension=".jsx" mimeType="text/jscript" />[m
[31m-            <mimeMap fileExtension=".latex" mimeType="application/x-latex" />[m
[31m-            <mimeMap fileExtension=".less" mimeType="text/css" />[m
[31m-            <mimeMap fileExtension=".lit" mimeType="application/x-ms-reader" />[m
[31m-            <mimeMap fileExtension=".lpk" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".lsf" mimeType="video/x-la-asf" />[m
[31m-            <mimeMap fileExtension=".lsx" mimeType="video/x-la-asf" />[m
[31m-            <mimeMap fileExtension=".lzh" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".m13" mimeType="application/x-msmediaview" />[m
[31m-            <mimeMap fileExtension=".m14" mimeType="application/x-msmediaview" />[m
[31m-            <mimeMap fileExtension=".m1v" mimeType="video/mpeg" />[m
[31m-            <mimeMap fileExtension=".m2ts" mimeType="video/vnd.dlna.mpeg-tts" />[m
[31m-            <mimeMap fileExtension=".m3u" mimeType="audio/x-mpegurl" />[m
[31m-            <mimeMap fileExtension=".m4a" mimeType="audio/mp4" />[m
[31m-            <mimeMap fileExtension=".m4v" mimeType="video/mp4" />[m
[31m-            <mimeMap fileExtension=".man" mimeType="application/x-troff-man" />[m
[31m-            <mimeMap fileExtension=".manifest" mimeType="application/x-ms-manifest" />[m
[31m-            <mimeMap fileExtension=".map" mimeType="text/plain" />[m
[31m-            <mimeMap fileExtension=".mdb" mimeType="application/x-msaccess" />[m
[31m-            <mimeMap fileExtension=".mdp" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".me" mimeType="application/x-troff-me" />[m
[31m-            <mimeMap fileExtension=".mht" mimeType="message/rfc822" />[m
[31m-            <mimeMap fileExtension=".mhtml" mimeType="message/rfc822" />[m
[31m-            <mimeMap fileExtension=".mid" mimeType="audio/mid" />[m
[31m-            <mimeMap fileExtension=".midi" mimeType="audio/mid" />[m
[31m-            <mimeMap fileExtension=".mix" mimeType="application/octet-stream" />[m
[31m-            <mimeMap fileExtension=".mmf" mimeType="application/x-smaf" />[m
[31m-            <mimeMap fileExtension=".mno" mimeType="text/xml" />[m
[31m-            <mimeMap fileExtension=".mny" mimeType="application/x-msmoney" />[m
[31m-            <mimeMap fileExtension=".mov" mimeType="video/quicktime" />[m
[31m-            <mimeMap fileExtension=".movie" mimeType="video/x-sgi-movie" />[m
[31m-            <mimeMap fileExtension=".mp2" mimeType="video/mpeg" />[m
[31m-            <mimeMap fileExtension=".mp3" mimeType="audio/mpeg" />[m
[31m-            <mimeMap fileExtension=".mp4" mimeType="video/mp4" />[m
[31m-            <mimeMap fileExtension=".mp4v" mimeType="video/mp4" />[m
[31m-            <mimeMap fileExtension=".mpa" mimeType="video/mpeg" />[m
[31m-            <mimeMap fileExtension=".mpe" mimeType="video/mpeg" />[m
[31m-            <mimeMap fileExtension=".mpeg" mimeType="video/mpeg" />[m
[31m-            <mimeMap fileExtension=".mpg" mimeType="video/mpeg" 
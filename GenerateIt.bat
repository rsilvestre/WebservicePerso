C:
cd C:\Program Files (x86)\Microsoft Visual Studio 12.0\VC
call vcvarsall.bat
cd c:\Tmp
svcutil C:\VS2013\WebservicePerso\IFAC\bin\Debug\WebsIFAC.dll /d:C:\Tmp
svcutil C:\Tmp\WebsIFAC.ClientIFAC.wsdl c:\Tmp\*xsd /out:C:\Tmp\ClientIFAC.cs /async /ct:System.Collections.Generic.List`1 /r:C:\VS2013\WebservicePerso\IFAC\bin\Debug\WebsBO.dll /n:*,WCF.Proxies /noConfig

svcutil C:\Tmp\WebsIFAC.EmpruntIFAC.wsdl c:\Tmp\*xsd /out:C:\Tmp\EmpruntIFAC.cs /async /ct:System.Collections.Generic.List`1 /r:C:\VS2013\WebservicePerso\IFAC\bin\Debug\WebsBO.dll /n:*,WCF.Proxies /noConfig

svcutil C:\Tmp\WebsIFAC.PersonneIFAC.wsdl c:\Tmp\*xsd /out:C:\Tmp\PersonneIFAC.cs /async /ct:System.Collections.Generic.List`1 /r:C:\VS2013\WebservicePerso\IFAC\bin\Debug\WebsBO.dll /n:*,WCF.Proxies /noConfig

Pause
del C:\Tmp\*.wsdl
del C:\Tmp\*.xsd
cd..
Pause


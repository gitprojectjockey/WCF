
makecert.exe  -sr LocalMachine -ss Root -pe -sky exchange -n "CN=Eric-PC" Eric-PC.cer

rem makecert.exe  -sr LocalMachine -ss My -pe -sky exchange -n "CN=EWNDevelopmentCert" EWNDevelopmentCert.cer

rem -sr = Registry location of the subject's certificate store.  	SubjectCertStoreLocation must be either LocalMachine (registry key HKEY_LOCAL_MACHINE) or CurrentUser (registry key HKEY_CURRENT_USER). CurrentUser is the default.

rem	-ss = Name of the subject's certificate store where the generated certificate will be stored.

rem -pe = Marks the private key as exportable. So you can export the certificate in base64 string to be used as the public key in the client application's config file.

rem -sky = Subject's key specification.

rem -n "Name"	Name for the publisher's certificate. This name must conform to the  X.500 standard. The simplest method is to use the "CN=MyName" format

rem NOTE: NOTE: NOTE: Certification File Output Path 'C:\Windows\SysWOW64'
pause

https://csharp.christiannagel.com/2018/07/10/azurestoragestaticwebsite/

Publish to Folder in Visual Studio

In VS Code, pick Release, netstandard2.0, publish, BlazorAzFunc, dist

Set Azure Function CORS to: (NO trailing slash)
https://rjlpdiblazorsatest.z21.web.core.windows.net
http://rjlpdiblazorsatest.z21.web.core.windows.net

https://github.com/aspnet/Blazor/issues/261
If you have both a debug and a release folder, you can't launch, clean doesn't help.
Remove the release folder in bin

Test
https://rjlpdiblazorapi.azurewebsites.net/api/BooksFunction

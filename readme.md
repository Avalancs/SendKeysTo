# SendKeysTo

This is a C# WinForms application for windows that lets you type into a text area, and send the content of it to another window like if you typed it there (or at least close to that, [see SendKeys documentation](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=windowsdesktop-6.0)).

Very useful when you need to work through Remote Desktop, but for security reasons the clipboard is disabled, so you previously had to type out ip addresses, encrypted password, SQL queries etc...

![Screenshot of the application](https://github.com/Avalancs/SendKeysTo/raw/main/screenshot.jpg)

##### How to compile

You can open the project as a Visual Studio 2019 solution. Hopefully no extra configuration is required.

##### Distribution

After compiling the project, go into the `SendKeysTo/bin/Debug` or `SendKeysTo/bin/Release` folder depending on your configuration, and copy the contents of the folder to the intended destination.

##### License

This project is under the MIT license. See `license.txt` for more details.



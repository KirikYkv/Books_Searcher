# Book search application

 An application designed to search for programming textbooks. The mechanism is as follows: specify the parameters of the book you need, indicate the number of pages to search, and click on the "Search book" button. You can also scroll through the pages. Example of setting parameters: enter the number of pages in the empty line (there are 20 books on each page), and select the book with the desired programming language from the drop-down list. You can also sort the results by title, author, rating, publication date, and price.

## System requirements

**Important:** This project is developed based on **.NET Framework 4.7.2** and uses the **Windows Forms** library. 
> 
> ⚠️ **The project only works in Windows environments.** Running on Linux or macOS is not supported due to architectural limitations of the graphical interface.

*   **OS:** Windows 7 / 10 / 11
*   **Platform:** .NET Framework 4.7.2 or higher
*   **Browser:** Google Chrome (for Selenium to work)
 ## Dependencies

 The following main packages and tools are used for the project:

 1. .NET Framework 4.7.2
 2. Selenium WebDriver
 3. .NET SDK (Recommended version 8.0 or higher)
 4. NuGet CLI, install it [here](https://www.nuget.org/downloads)
 
    [.NET](https://dotnet.microsoft.com/ru-ru/download/dotnet)


 

 
 > Click [here](https://www.nuget.org/packages/Selenium.WebDriver) to read more about Selenium WebDriver

 ## How to launch:

 Clone it:
 ```
 git clone https://github.com
 cd Book_Manager
 ```
 Restore dependencies (NuGet):
 ```
 nuget restore MyParser.sln
 ```
 Build the project:
 ```
 msbuild MyParser.sln /p:Configuration=Release
 ```

 Run the binary (executable) file:
 ```
 .\MyParser\bin\Release\MyParser.exe
 ```




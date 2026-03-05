# Book search application

 An application designed to search for programming textbooks. The mechanism is as follows: specify the parameters of the book you need, indicate the number of pages to search, and click on the "Search book" button. You can also scroll through the pages. Example of setting parameters: enter the number of pages in the empty line (there are 20 books on each page), and select the book with the desired programming language from the drop-down list. You can also sort the results by title, author, rating, publication date, and price.

## System requirements

**Important:** This project is developed based on **.NET Framework 4.7.2** and uses the **Windows Forms** library. 
> 
> ⚠️ **The project only works in Windows environments.** Running on Linux or macOS is not supported due to architectural limitations of the graphical interface.

*   **OS:** Windows 10 / 11
*   **Runtime:** .NET Framework 4.7.2 or higher
* * **SDK:** [.NET](https://dotnet.microsoft.com/ru-ru/download/dotnet) SDK 8.0 or newer 
*   **Browser:** Google Chrome (for Selenium to work)

 ## How to launch:

 Clone it:
 ```
 git clone https://github.com/KirikYkv/Books_Searcher
 cd Books_Searcher
 ```
 Restore dependencies and build project:
 ```
 dotnet restore

 dotnet build 
 ```
 Run the binary (executable) file:
 ```
 dotnet run

 ```




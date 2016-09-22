![](https://camo.githubusercontent.com/b83dac05ace44c8c5c14589709f1016f34adf331/687474703a2f2f737461746963312e73717561726573706163652e636f6d2f7374617469632f3533386633666364653462303563356665636337613430652f742f3533386634386134653462303064393465386332353362332f313435333339363633323537362f3f666f726d61743d34303077)
# C# Workbook

## Setup Your Workbook
1. Fork this workbook to your account by clicking the "Fork" button.
2. On your fork, click the "Clone or download" button and copy the link
3. Clone the repository to your local machine `git clone "enter url here"`
4. Navigate into the directory `cd directory-name`
5. Open folder in text editor, make a change to `00Setup.cs` by setting `"Hello!"` to `"Hello World!"`, and save the file
6. In your terminal, stage the file `git add 00Setup.cs`
7. Now commit the file `git commit -m "Setting up workbook"`
8. Push your changes up to your fork `git push origin master`
9. Navigate to your fork on Github.com and click "Pull requests", then "New pull request"
10. Enter your First and Last name as the title and click "Create pull request"

## Compile and Run a File
1. Install [Mono](http://www.mono-project.com/download/)
2. To run the program, you must first compile using `mcs`
  ```
  mcs 00Setup.cs
  ```
3. This will create a `.exe` file. Run it using `mono`
  ```
  mono 00Setup.exe
  ```

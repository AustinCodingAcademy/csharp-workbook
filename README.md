![](http://en.gravatar.com/userimage/107370100/a08594145564536138dfaaf072c7b241.png)
# Austin Coding Academy

## C# Workbook

### Download Workbook files
1. Fork this workbook to your account by clicking the "Fork" button
1. On your forked repository, click the "Clone or download" button and copy the url
1. On your computer create a folder that will contain your repository
1. Open Git Bash and navigate to the folder created above
1. Use git clone command to download the repository into your computer, **replace** `"url"` with the url from step 2.
    ```
    git clone "url"
    ```
1. Navigate into the directory and leave the Git Bash open, we will use it later
    ```
    cd git-workbook
    ```

### Open Workbook in Visual Studio Code
1. `cd` into your `csharp-workbook`
1. Open your workbook in VSCode `code .`
1. Open your integrated terminal by clicking `View` -> `Integrated Terminal` or pressing `control` + `\``

### Run and modify a project
1. Navigate into your first project `cd ./01Week/HelloWorld`
1. Run the project in the integrated terminal `dotnet run`
1. You should see `Hello World!`
1. Go to the file in the file in the Explorer and change the text to say `Hello <Your Name>!`
1. You should see `Hello <Your Name>!`

### Create a Pull Request
This steps setup needs to be done only once. For future projects all you need to do is push you changes to the branch.

1. Get back on Git Bash and check the status of your repository - You should see the file(s) you changed appear in red
    ```
    git status
    ```
1. Stage the file(s) using:
    ```
    git add -A
    ```
1. Commit that staged file
    ```
    git commit -m "Saying hello to myself"
    ```
1. Push your changes up to your remote repository
    ```
    git push
    ```
1. Head to your remote repository in GitHub
1. Click on `new pull request` button and name it using your full name

If you are having some trouble with the steps watch this [video here](https://www.youtube.com/watch?v=pMuEKpaYwec)

# C# Workbook

## Download Workbook files
1. Fork this workbook to your account by clicking the "Fork" button
2. On your forked repository, click the "Clone or download" button and copy the url
3. On your computer create a folder that will contain your repository
4. Open Git Bash and navigate to the folder created above
5. Use git clone command to download the repository into your computer, **replace** `"url"` with the url from step 2.

```
git clone "url"
```
6. Navigate into the directory and leave the Git Bash open, we will use it later

```
cd git-workbook
```

## Visual Studio Project 

1. Open Visual Studio Community
2. On the top menu select `File -> New -> Project` or use the keyboard shortcut `Control + Shift + N`
3. From the left menu select `Visual C# -> Windows Classic Desktop` then on the right select `Console App (.NET Framework)`. Set the project name as `CSharpProject`, the location can be anywhere in your computer, just make sure it is **outside your recent cloned repository folder**
4. Visual Studio will create a initial `Program.cs` file. You can delete it, we wont need it
5. To add a file to the project, right-click on top of CSharpProject `Add  -> Existing Item...` or use the keyboard shortcut `Shift + Alt + A`
6. Navigate to the `/git-workbook/01Week/` repository/folder and select the file `HelloWorld.cs`
7. The Add button has a small arrow pointing down. Click on that and select `Add As Link`. If you just add it, it will copy the file and you won't be able to track it in your repository.
8. Open the file you just added as a link
9. Change th text inside `Console.WriteLine` method to `"Hello Word"` and save it


## Create a Pull Request
1. Get back on Git Bash and check the status of your repository - You should see the file HelloWorld.cs appear in red
```
git status
```
2. Stage the file using:
```
git add -A
```
3. Commit that staged file
```
git commit -m "Hello World"
```
4. Push your changes up to your remote repository
```
git push
```
5. Head to your remote repository in [GitHub](www.github.com)
6. Click on `new pull request` button and name it using your name
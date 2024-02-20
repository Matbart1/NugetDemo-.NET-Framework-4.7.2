using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetExamplePackage
{
    // Comment and research by Mathieu Barrette
    // https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio-net-framework

    // Step 1, make a class library ENSURING IT IS A .NET FRAMEWORK

    // Step 2, download the NuGet.exe CLI function and add it to a folder
    //within the user directory or higher (for permissions)
    //THEN go to advance system settings -> environment variables -> add new + edit
    //and link the folder containing nuget.exe

    // Step 3, build the solution to form a .dll

    // Step 4, configure properties for the package by right clicking Project -> Properties and selecting Assembly Information

    // Step 4.1, create this as a github repository, this will be used in project url
    //within the package properties

    // Step 5, this library needs to be converted into a release version, to do this, right click the SOLUTION
    //select CONFIGURATION MANAGER and change the solution from debug to release.

    // Step 5.2, you'll need to create a nuget manifest, open the command line under Tools -> Command Line -> Developer Console
    //and enter: nuget spec <projectName>.csproj
    //if an error occurs, ensure the directory is accurate to the file

    // Step 6, edit the manifest, ensuring that licenseURL, projectURL, releaseNotes, and tags are all filled in with relevant information
    //to edit the manifest: find the folder containing the project, and open <fileName>.nuspec in notepad, save when finished

    // Step 7, you'll need to package the nuget manifest, open the command line under Tools -> Command Line -> Developer Console
    //enter: nuget pack <fileName>.csproj
    //if an error occurs, ensure the directory is accurate to the file
    //this will create the <fileName><versionNumber>.nupkg file

    // Step 8, visit nuget.org and sign up, then navigate to your profile in the top right corner and
    //select API Keys, create a key with a unique name, and a glob pattern of *, copy the key code and
    //save this somewhere private

    // Step 9, open cmd.exe, enter "cd " and then drag+drog the folder containing the <fileName><versionNumber>.nupkg file
    //this will navigate to the specific directory you want to be in, 
    //type: nuget push <package filename> <api key value> -Source https://api.nuget.org/v3/index.json
    //package filename will be the nupkg file, api key from nuget.org

    // If all goes well, the console will say "Your package has been pushed"

    // You can view your published packages on your account on nuget.org, these will appear as unlisted for 
    //an hour or so upon creation, and then may be indexable on the website for download.
    public class MathFunctions
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}

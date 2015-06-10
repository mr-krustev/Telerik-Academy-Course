/*
Problem 3. Read file contents

Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class HandleFileReading
{
    static void Main()
    {
        string filePath = Console.ReadLine();
        ReadFileContent(filePath);
    }

    private static void ReadFileContent(string filePath)
    {
        try
        {
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine(fileContent);
        }
        catch (System.AccessViolationException)
        {
            Console.WriteLine("You do not have access.");
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("The found you want to be read couldn't be found.");
        }
        
    }
}


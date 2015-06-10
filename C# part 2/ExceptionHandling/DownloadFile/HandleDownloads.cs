/*
Problem 4. Download file

Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


class HandleDownloads
{
    static void DownloadFile(string fileLink, string fileName)
    {
        using (WebClient Client = new WebClient())
        {
            Client.DownloadFile("http://www.abc.com/file/song/a.mpeg", "a.mpeg");
        }
    }

    static void Main()
    {
        string fileLink = Console.ReadLine();
        string fileName = Console.ReadLine();

        try
        {
            DownloadFile(fileLink, fileName);
            Console.WriteLine("Image was downloaded successfully in 'bin' directory of the project!");
        }
        catch (ArgumentException AE)
        {
            Console.WriteLine(AE.Message);
        }
        catch (WebException WE)
        {
            Console.WriteLine(WE.Message);
        }
        catch (NotSupportedException NSE)
        {
            Console.WriteLine(NSE.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
        
    }
}


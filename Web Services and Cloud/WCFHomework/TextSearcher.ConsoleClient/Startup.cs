namespace TextSearcher.Service.Models
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    public class Startup
    {
        public static void Main()
        {
            // Note: To test this you should have the service running in the background on the same port ( in this case 1234 );

            var service = new TextSearcherClient();
            var text = "This is a test case";
            var searchedText = "is";
            var result = service.GetNumberOfOccurence(text, searchedText);
            Console.WriteLine("The string \"{0}\" occured {1} times in the text : \n\"{2}\".", searchedText, result, text);
        }
    }
}

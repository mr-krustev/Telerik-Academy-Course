namespace TextSearcher.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;

    public class TextSearcher : ITextSearcher
    {
        public int GetNumberOfOccurence(string text, string searchedText)
        {
            var result = 0;

            for (int i = 0; i < text.Length - (searchedText.Length + 1); i++)
            {
                if (text.Substring(i,searchedText.Length) == searchedText)
                {
                    result++;
                }
            }

            return result;
        }
    }
}

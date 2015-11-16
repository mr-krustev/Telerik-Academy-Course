namespace TextSearcher.Service.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;

    [ServiceContract]
    public interface ITextSearcher
    {
        [OperationContract]
        int GetNumberOfOccurence(string text, string searchedText);
    }
}

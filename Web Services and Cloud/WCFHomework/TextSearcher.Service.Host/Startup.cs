namespace TextSearcher.Service.Models
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    public class Startup
    {
        public static void Main()
        {
            var serviceAdress = new Uri("http://localhost:1234/textSearcher");
            var selfHost = new ServiceHost(typeof(TextSearcher), serviceAdress);

            var smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);

            selfHost.Open();

            Console.WriteLine("Service started on {0}!", serviceAdress);

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}

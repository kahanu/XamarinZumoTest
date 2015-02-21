using System;
using System.Linq;
using System.Net.Http;
using Microsoft.WindowsAzure.MobileServices;

namespace XamarinZumoTest.Client
{
    /// <summary>
    /// This is the Azure Mobile Service client class that can 
    /// be referenced from any service.
    /// </summary>
    public class AzureClient
    {
        static AzureClient()
        {
            InitializeClient();
        }

        public static MobileServiceClient MobileService;

        public static void InitializeClient(params DelegatingHandler[] handlers)
        {
            try
            {
                MobileService = new MobileServiceClient(
                                @"http://localhost:63878/",
                                null,
                                handlers
                            );
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

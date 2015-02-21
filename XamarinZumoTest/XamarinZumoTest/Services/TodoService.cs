using System;
using System.Linq;
using Microsoft.WindowsAzure.MobileServices;
using XamarinZumoTest.Client;
using XamarinZumoTest.Models;

namespace XamarinZumoTest.Services
{
    /// <summary>
    /// This service class will be called from the various ViewModel classes
    /// to bind the viewModel to the UI elements.
    /// </summary>
    public class TodoService
    {
        public static IMobileServiceTable<TodoItem> GetTodoTable()
        {
            var table = AzureClient.MobileService.GetTable<TodoItem>();

            return table;
        }
    }
}

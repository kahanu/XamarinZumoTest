using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.MobileServices;
using XamarinZumoTest.Models;
using XamarinZumoTest.Services;

namespace XamarinZumoTest.ViewModels
{
    public class RootPageViewModel
    {
        public RootPageViewModel()
        {
            Items = new List<TodoItem>();
        }
        public List<TodoItem> Items { get; set; }

        public void LoadItems()
        {
            var table = TodoService.GetTodoTable();
            var result = table.Where(t => t.Complete == false).ToListAsync();
            Items = result.Result;
        }
    }
}

using AOPDemo.Aspects;
using AOPDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo.Services
{
    public class ItemService
    {
        [ConsoleLoggingAspect]
        public void Save(Item item)
        {
            Console.WriteLine("Item is being saved.");
        }
    }
}

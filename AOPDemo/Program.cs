using AOPDemo.Models;
using AOPDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            ItemService itemService = new ItemService();
            itemService.Save(new Item());
        }
    }
}

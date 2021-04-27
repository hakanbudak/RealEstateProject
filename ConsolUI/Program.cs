using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseManager houseManager = new HouseManager(new EfHouseDal());

            foreach (var manager in houseManager.GetByPrice(1000,5000))
            {
                Console.WriteLine(manager.Description);
            }
        }
    }
}

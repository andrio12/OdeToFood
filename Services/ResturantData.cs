using System;
using System.Collections.Generic;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();
    }

    public class InMemoryResturantData : IResturantData
    {
        public InMemoryResturantData()
        {
            _resturants = new List<Resturant>
            {
                new Resturant { Id = 1, Name = "Jurbangle" },
                new Resturant { Id = 2, Name = "Cat burgers" },
                new Resturant { Id = 3, Name = "What is a hat?" }
            };

        }
        public IEnumerable<Resturant> GetAll()
        {
            return _resturants;
        }

        List<Resturant> _resturants;
    }
}
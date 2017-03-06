using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Entities;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);

    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _resturants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Jurbangle" },
                new Restaurant { Id = 2, Name = "Cat burgers" },
                new Restaurant { Id = 3, Name = "What is a hat?" }
            };

        }

        public Restaurant Get(int id)
        {
            return _resturants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _resturants;
        }

        List<Restaurant> _resturants;
    }
}
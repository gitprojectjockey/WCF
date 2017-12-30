using System;
using System.Collections.Generic;
using System.Threading;

namespace PizzaService
{

    public class PizzaService : IPizzaService
    {
        const string CacheKey = "availablePizzas";
        SlowRepository repository;
         
        public PizzaService()
        {
            this.repository = new SlowRepository();
        }

        IEnumerable<string> IPizzaService.GetAvailablePizzas()
        {
            System.Runtime.Caching.ObjectCache cache = System.Runtime.Caching.MemoryCache.Default;
            if (cache.Contains(CacheKey))
            {
                return (IEnumerable<string>)cache.Get(CacheKey);
            }
            else
            {
                IEnumerable<string> availablePizzas = repository.GetPizzas();
                System.Runtime.Caching.CacheItemPolicy cacheItemPolicy = new System.Runtime.Caching.CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddHours(1.0);
                cache.Add(CacheKey, availablePizzas, cacheItemPolicy);
                return availablePizzas;
            }
        }
    }

    class SlowRepository
    {
        public IEnumerable<string> GetPizzas()
        {
            Thread.Sleep(10000);
            return new List<string> { "Hawaii", "Pepperoni", "Bolognaise", "Cheese","Anchovy" };
        }
    }

}

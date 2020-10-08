using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;


namespace BlazorApp.Data
{
   public class SoupService
    {
      private static List<int> list = new List<int>();
        private static List<Soup> Soups = new List<Soup>() {
          new Soup("Chicken Noodle", "Hot"),
          new Soup("Tomato", "hot"),
          new Soup("Cheddar Brocolli", "hot")
        };
        public Task<List<Soup>> GetSoupAsync() {
          return Task.FromResult(Soups);
        }

        public void SaveSoup(Soup soup) {

        }
    }
}
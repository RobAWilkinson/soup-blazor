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
        private static List<string> Soups = new List<string>() {
          "Chicken Noodle",
          "Tomato",
          "Cheedar Brocolli"
        };
        public Task<List<string>> GetSoupAsync() {
          return Task.FromResult(Soups);
        }

        public void SaveSoup(Soup soup) {

        }
    }
}
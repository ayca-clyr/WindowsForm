using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___IndexedProperty
{
    class Team
    {
        public Team()
        {
            _players = new List<string>();
        }

        public string Name { get; set; }
        public int FounderYear { get; set; }
        private List<string> _players;// { get; set; } //Dışarda kullanılmayacağı için field yaptık

        public void AddPlayer(string player)
        {
            _players.Add(player);
        }

        public void RemovePlayer(string player)
        {
            _players.Remove(player);
        }

        public string GetPlayer(int index)
        {
            return _players[index];
        }

        //Indexed Property
        // this in anlamı bu sınıf demek 
        public string this[int index] { get { return _players[index]; } }

        public string this[string Position , int index] { get { return "Forvet"; } }

        public List<string> this[int index, int index1] { get { return null; } }

        public List<string> this[params int[]indexes] { get { return null; } }
    }
}

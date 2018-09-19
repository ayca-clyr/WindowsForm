using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexedProperty
{
    class Team
    {
        public Team()
        {
            _players = new List<string>();
        }
        public string Name { get; set; }
        public int FoundedYear { get; set; }

        // Koleksiyon varsa List gibi bunun ctor'da instance al.
        private List<string> _players;// { get; set; }

        public string GetPlayer(int index)
        {
            return _players[index];
        }


        public void AddPlayer(string player)
        {
            _players.Add(player);
        }

        public void RemovePlayer(string player)
        {
            _players.Remove(player);
        }

        // Indexed Property

        // Kolleksiyonmuş gibi davranan bir sınıf elde etmiş olduk. Birden fazla parametre'de alabilir.
        public string this[int index]
        {
            get { return _players[index]; }

        }

        public string this[string position, int index]
        {
            get { return ""; }
        }

        public List<string> this[int index1, int index2]
        {
            get { return null; }
        }

        public List<string> this[params int[] indexes]
        {
            get { return null; }
        }
    }
}

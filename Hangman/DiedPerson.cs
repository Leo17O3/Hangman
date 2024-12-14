using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class DiedPerson
    {
        private GameObject _head;
        private GameObject _body;
        private GameObject _hands;
        private GameObject _legs;
        private GameObject[] _hangerParts;

        public DiedPerson()
        {
            _head = new GameObject("(*-*)", new Vector2(2, 1));
            _hands = new GameObject(@"/ \", new Vector2(3, 2));
            _body = new GameObject("|", new Vector2(4, 3));
            _legs = new GameObject("| |", new Vector2(3, 4));
            _hangerParts = new GameObject[] { new GameObject("|", new Vector2(0, 0)), new GameObject("|", new Vector2(0, 1)),
                new GameObject("|", new Vector2(0, 2)), new GameObject("|", new Vector2(0, 3)), new GameObject("|", new Vector2(0, 4)),
            new GameObject("|", new Vector2(0, 5)), new GameObject("---", new Vector2(1, 0)), new GameObject("|", new Vector2(2, 0))};
        }

        public List<GameObject> GetDiedPersonParts()
        {
            List<GameObject> diedPersonParts = new List<GameObject>(11);
            diedPersonParts.Add(_head);
            diedPersonParts.Add(_body);
            diedPersonParts.Add(_hands);
            diedPersonParts.Add(_legs);
            diedPersonParts.AddRange(_hangerParts);

            return diedPersonParts;
        }
    }
}

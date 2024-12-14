using System.Collections.Generic;

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
            _head = new GameObject("(*-*)", new Vector2(2, 3));
            _hands = new GameObject(@"/ \", new Vector2(3, 4));
            _body = new GameObject("|", new Vector2(4, 5));
            _legs = new GameObject("| |", new Vector2(3, 6));
            _hangerParts = new GameObject[] { new GameObject("|", new Vector2(0, 2)), new GameObject("|", new Vector2(0, 3)),
                new GameObject("|", new Vector2(0, 4)), new GameObject("|", new Vector2(0, 5)), new GameObject("|", new Vector2(0, 6)),
            new GameObject("|", new Vector2(0, 7)), new GameObject("---", new Vector2(1, 2)), new GameObject("|", new Vector2(2, 2))};
        }

        public List<GameObject> GetDiedPersonParts()
        {
            List<GameObject> diedPersonParts = new List<GameObject>(11);
            diedPersonParts.AddRange(_hangerParts);
            diedPersonParts.Add(_head);
            diedPersonParts.Add(_hands);
            diedPersonParts.Add(_body);
            diedPersonParts.Add(_legs);

            return diedPersonParts;
        }
    }
}

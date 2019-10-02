using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sequences.Library
{
    public class StringSequence
    {
        private readonly List<string> _list = new List<string>();

        public void Add(string item)
        {
            _list.Add(item);
        }

        public void remove(string item)
        {
            _list.Remove(item);
        }
        public string Get(int index)
        {
            return _list[index];
        }

        public string this[int index]
        {
            get => _list[index];
            set => _list[index] = value;
        }

        public string LongestString()
        {
            var maxLength = _list.Max(s => s.Length);
            return _list.First(s => s.Length == maxLength);
        }
    }
}

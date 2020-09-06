using System.Collections.Generic;

namespace ComposableCollections.Crdt
{
    public class Summation : ICrdt<int>
    {
        private object _lock = new object();
        private int _state;

        public Summation(int initialState)
        {
            _state = initialState;
        }

        public void Write(IEnumerable<int> writes)
        {
            lock (_lock)
            {
                foreach (var write in writes)
                {
                    _state = _state + write;
                }
            }
        }
    }
}
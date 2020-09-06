using System.Collections.Generic;

namespace ComposableCollections.Crdt
{
    public interface ICrdt<in TWrite>
    {
        void Write(IEnumerable<TWrite> writes);
    }
}
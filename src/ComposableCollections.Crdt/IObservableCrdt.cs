using System;

namespace ComposableCollections.Crdt
{
    public interface IObservableCrdt<TWrite> : ICrdt<TWrite>, IObservable<TWrite>
    {
    }
}
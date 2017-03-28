﻿using System.Collections.Generic;

namespace Stave
{
    public interface IComposite<TAbstract, TParent, TComponent> : IParent<TAbstract, TParent, TComponent>
        where TAbstract : class, IComponent<TAbstract, TParent>
        where TParent : class, TAbstract, IParent<TAbstract, TParent>
        where TComponent : class, TAbstract
    {
        new IReadOnlyCollection<TComponent> Components { get; }
        void Add(TComponent item);
        bool Remove(TComponent item);
        void Clear();
        bool Contains(TComponent item);
    }
}
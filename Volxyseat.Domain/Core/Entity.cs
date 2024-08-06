using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volxyseat.Domain.Core
{
    public interface IEntity
    {
    }

    public abstract class Entity<TKey> : IEntity
    {
        public TKey Id { get; protected set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity<TKey>;

            if(ReferenceEquals(this, compareTo)) return true;
            if(ReferenceEquals(null, compareTo)) return false;
            return Id.Equals(compareTo.Id);
        }
    }
}
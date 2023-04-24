using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Entities.Interfaces
{
    public interface IBuilder
    {
        void Reset();
        IEntity GetProduct();
    }
}
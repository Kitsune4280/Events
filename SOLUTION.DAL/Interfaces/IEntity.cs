using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.Interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FunctionalVisitor.Impl
{
    internal interface IVisitable
    {
        IEnumerable<T> Accept<T>(IVisitor<T> visitor);
    }
}
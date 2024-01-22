using Checkers_Library.Enumerations;
using System;

namespace Checkers_Library.Interfaces
{
    public interface IPawn
    {
        event EventHandler Promote;

        event EventHandler Gloups;

        event EventHandler Gloupsed;
        
        GameColor Color { get; set; }
     
        bool IsQueen { get; }
    }
}

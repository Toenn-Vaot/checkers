using System;
using Checkers_Library;

namespace Checkers_Controls
{
    /// <summary>
    /// This class represents the event arguments use when a <see cref="GameMode"/> change triggered
    /// </summary>
    /// <seealso cref="GameRule"/>
    public class GameModeEventArgs : EventArgs
    {
        /// <summary>
        /// The previous <see cref="GameRule"/> changed
        /// </summary>
        public GameMode Previous { get; private set; }

        /// <summary>
        /// The new and current <see cref="GameRule"/> applies
        /// </summary>
        public GameMode Current { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="previous">The <see cref="GameMode"/> changed</param>
        /// <param name="current">The new <see cref="GameMode"/> applies</param>
        public GameModeEventArgs(GameMode previous, GameMode current)
        {
            Previous = previous;
            Current = current;
        }
    }
}
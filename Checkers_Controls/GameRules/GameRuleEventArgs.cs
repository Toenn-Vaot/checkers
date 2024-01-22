using System;

namespace Checkers_Controls
{
    /// <summary>
    /// This class represents the event arguments use when a <see cref="GameRule"/> change triggered
    /// </summary>
    /// <seealso cref="GameRule"/>
    public class GameRuleEventArgs : EventArgs
    {
        /// <summary>
        /// The previous <see cref="GameRule"/> changed
        /// </summary>
        public GameRule Previous { get; private set; }

        /// <summary>
        /// The new and current <see cref="GameRule"/> applies
        /// </summary>
        public GameRule Current { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="previous">The <see cref="GameRule"/> changed</param>
        /// <param name="current">The new <see cref="GameRule"/> applies</param>
        public GameRuleEventArgs(GameRule previous, GameRule current)
        {
            Previous = previous;
            Current = current;
        }
    }
}

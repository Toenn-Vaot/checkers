using Checkers_Library.Enumerations;
using Checkers_Library.Interfaces;
using System.Collections.Generic;

namespace Checkers_Library
{
    /// <summary>
    /// A Player is a person is playing and have a list of pawns who can move on the Game board
    /// </summary>
    public class Player
    {
        /// <summary>
        /// The name of the player displayed during the game
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The color of their pawns that the player can move
        /// </summary>
        public GameColor Color { get; set; }

        /// <summary>
        /// The collection of pawns that the player can move
        /// </summary>
        public List<IPawn> Pawns { get; set; }

        /// <summary>
        /// The current score of the player
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Player()
        {
            Pawns = new List<IPawn>();
            Score = 0;
        }
    }

    public class PlayerEventArgs
    {
        /// <summary>
        /// Gets the current player concerned by the event
        /// </summary>
        public Player Current { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="player">The player concerned</param>
        public PlayerEventArgs(Player player)
        {
            Current = player;
        }
    }
}

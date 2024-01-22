using Checkers_Library.Interfaces;
using System.Collections.Generic;

namespace Checkers_Library
{
    public class GameMove
    {
        /// <summary>
        /// Get the list of <see cref="IPawn"/> caught during the <see cref="GameMove"/>
        /// </summary>
        public List<IPawn> PawnsCaught { get; set; }

        /// <summary>
        /// Get the list of positions passed during the <see cref="GameMove"/>
        /// </summary>
        public List<int> Positions { get; set; }

        /// <summary>
        /// Get the beginning of the <see cref="GameMove"/>, the first position of the <see cref="GameMove"/>
        /// </summary>
        public int PositionFrom => Positions[0];

        /// <summary>
        /// Get the end of the <see cref="GameMove"/>, the last position of the <see cref="GameMove"/>
        /// </summary>
        public int PositionTo => Positions[Positions.Count-1];

        /// <summary>
        /// Constructor
        /// </summary>
        public GameMove()
        {
            Positions = new List<int>();
            PawnsCaught = new List<IPawn>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="positionFrom">The beginning of the move</param>
        /// <param name="positionTo">The first position passed</param>
        public GameMove(int positionFrom, int positionTo) : this()
        {
            Positions.Add(positionFrom);
            Positions.Add(positionTo);
        }

        /// <summary>
        /// Adds an <see cref="IPawn"/>to the list of <see cref="IPawn"/> caught
        /// </summary>
        /// <param name="pawnCaught">The control to add to the list</param>
        public void AddCatch(IPawn pawnCaught)
        {
            PawnsCaught.Add(pawnCaught);
        }

        /// <summary>
        /// Adds a position passed during the <see cref="GameMove"/>
        /// </summary>
        /// <param name="positionTo">The position passed to add to the list</param>
        public void AddPosition(int positionTo)
        {
            Positions.Add(positionTo);
        }
    }

    public enum MoveDirection
    {
        /// <summary>
        /// Left direction
        /// </summary>
        Left,
        /// <summary>
        /// Right direction
        /// </summary>
        Right,
        /// <summary>
        /// Left backward direction
        /// </summary>
        LeftBackward,
        /// <summary>
        /// Right backward direction
        /// </summary>
        RightBackward,
        /// <summary>
        /// Not used
        /// </summary>
        None
    }
}

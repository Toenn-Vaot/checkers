using Checkers_Library;
using Checkers_Library.Enumerations;
using System;

namespace Checkers_Controls
{
    /// <summary>
    /// This class represent the base of rules set of Checkers's game
    /// </summary>
    /// <seealso cref="International"/>
    public abstract class GameRule
    {
        /// <summary>
        /// Event triggered when the <see cref="GameMode"/> changed
        /// </summary>
        public event EventHandler GameModeChanged;

        /// <summary>
        /// The first <see cref="GameColor"/> positionned at right of the <see cref="Player"/>
        /// </summary>
        public GameColor FirstRightCaseColor { get; set; }

        /// <summary>
        /// The <see cref="GameColor"/> of <see cref="CaseControl"/> where the <see cref="PawnControl"/> can be moved
        /// </summary>
        public GameColor ActiveCaseColor { get; set; }

        /// <summary>
        /// The <see cref="GameColor"/> of <see cref="Player"/> begins the game
        /// </summary>
        public GameColor FirstPlayColor { get; set; }

        private GameMode _mode = GameMode.None;
        /// <summary>
        /// The <see cref="GameMode"/> of the game determined the size of the <see cref="Gameboard"/> and the number of <see cref="PawnControl"/>
        /// </summary>
        /// <remarks>The event <see cref="GameModeChanged"/> is triggered when property is set</remarks>
        public GameMode Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                GameModeChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Indicates if the <see cref="PawnControl"/> can catch an opponent <see cref="PawnControl"/> with a backward move
        /// </summary>
        public bool PawnCanGloupsBehind { get; set; }

        /// <summary>
        /// Indicates if the <see cref="PawnControl"/> in state of Queen can move more than one <see cref="CaseControl"/>
        /// </summary>
        public bool QueenCanMoveMulti { get; set; }

        /// <summary>
        /// Indicates if the <see cref="PawnControl"/> can catch an opponent <see cref="PawnControl"/> in state of Queen
        /// </summary>
        public bool PawnCanGloupsQueen { get; set; }

        /// <summary>
        /// Indicates if the <see cref="PawnControl"/> can become a Queen during catching opponent <see cref="PawnControl"/>
        /// </summary>
        public bool PassingQueen { get; set; }

        /// <summary>
        /// Indicates if the <see cref="Player"/> must catch the maximum of <see cref="PawnControl"/> as possible
        /// </summary>
        /// <remarks>In this case, a <see cref="PawnControl"/> in state of Queen count like one, like a standard <see cref="PawnControl"/></remarks>
        public bool MaximumGloups { get; set; }

        /// <summary>
        /// Indicates if a <see cref="PawnControl"/> in state of Queen has priority when can catch opponent <see cref="PawnControl"/> in front of a <see cref="PawnControl"/>
        /// </summary>
        public bool QueenMustGlouspBefore { get; set; }

        /// <summary>
        /// <para>Indicates if a <see cref="PawnControl"/> can be lost by the <see cref="Player"/> in case of it could have the possibility to catch an opponent.</para>
        /// <para>The <see cref="PawnControl"/> lost is not its played. If this rule is false, the catch of an opponent <see cref="PawnControl"/> becomes mandatory.</para>
        /// </summary>
        public bool BreatheIsNotPlay { get; set; }

        /// <summary>
        /// <para>Indicates if the opponent <see cref="Player"/> can force the other <see cref="Player"/> to realize a move when the opponent can catch for example.</para>
        /// <para>Even if this rule is set to True, the <see cref="Player"/> has choice to let their opponent play and not force a move.</para>
        /// </summary>
        public bool ForceToPlay { get; set; }

        //public GameNotation Notation { get; set; }
    }
}

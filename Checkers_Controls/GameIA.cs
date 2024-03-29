﻿using Checkers_Library;
using Checkers_Library.Enumerations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using Checkers_Library.Events;

namespace Checkers_Controls
{
    public class GameIA
    {
        #region Events

        public event EventHandler Initialized;

        public event EventHandler<GameRuleEventArgs> RulesChanged;

        public event EventHandler<GameModeEventArgs> GameModeChanged;

        public event EventHandler NextPlayerChanged;

        #endregion

        #region Singleton

        private static GameIA _instance;

        public static GameIA Instance => _instance ?? (_instance = new GameIA());

        #endregion

        #region Privates fields

        private Player _currentPlayer;

        private GameRule _rules;

        #endregion

        #region Properties

        /// <summary>
        /// The number of active <see cref="CaseControl"/> on the board per line
        /// </summary>
        public int CountActiveCases => (int)Rules.Mode / 2;

        /// <summary>
        /// The <see cref="Player"/> who plays the white <see cref="PawnControl"/>
        /// </summary>
        public Player Whites { get; set; }

        /// <summary>
        /// The <see cref="Player"/> who plays the black <see cref="PawnControl"/>
        /// </summary>
        public Player Blacks { get; set; }

        /// <summary>
        /// The future <see cref="Player"/> will play
        /// </summary>
        /// <remarks>Trigger the event <see cref="NextPlayerChanged"/> when the property is set</remarks>
        public Player CurrentPlayer
        {
            get => _currentPlayer;
            private set
            {
                _currentPlayer = value;
                NextPlayerChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// The <see cref="Rules"/> of the game used
        /// </summary>
        /// <remarks>Trigger the event <see cref="RulesChanged"/> when the property is set</remarks>
        public GameRule Rules
        {
            get => _rules;
            set
            {
                RulesChanged?.Invoke(this, new GameRuleEventArgs(_rules, value));
                GameModeChanged?.Invoke(this, new GameModeEventArgs(_rules?.Mode ?? default, value.Mode));
                _rules = value;
            }
        }

        /// <summary>
        /// The <see cref="Gameboard"/> where the game takes place
        /// </summary>
        public Gameboard Board { get; set; }

        /// <summary>
        /// The actual <see cref="GameMove"/> is playing
        /// </summary>
        public GameMove CurrentMove { get; set; }

        /// <summary>
        /// The history of <see cref="GameMove"/> played during the game
        /// </summary>
        public Queue<GameMove> Moves { get; set; }

        /// <summary>
        /// Indicates if <see cref="CaseControl"/> coordinates are displayed
        /// </summary>
        public bool DisplayCaseInformation => bool.TryParse(ConfigurationManager.AppSettings["DisplayCaseInformation"], out var result) && result;

        /// <summary>
        /// Indicates if <see cref="PawnControl"/> infos are displayed
        /// </summary>
        public bool DisplayPawnInfo => bool.TryParse(ConfigurationManager.AppSettings["DisplayPawnInformation"], out var result) && result;

        #endregion

        /// <summary>
        /// Private constructor according to the design pattern singleton
        /// </summary>
        private GameIA()
        {
            Moves = new Queue<GameMove>();
        }

        /// <summary>
        /// <para>Get the position of the <see cref="CaseControl"/> on the game board</para>
        /// <para>according to the current <see cref="Player"/> is playing</para>
        /// </summary>
        /// <param name="control">Control to return their position index on the game board</param>
        /// <returns>
        /// <para>The position according to the point of view of the current player who is playing</para>
        /// <para>Returns default(int) in case of :</para>
        /// <list type="number">
        /// <item>The color of the <see cref="CaseControl"/> is not the color of gaming <see cref="CaseControl"/></item>
        /// <item>The <see cref="CaseControl"/> is not put on a <see cref="Gameboard"/></item>
        /// <item>The <see cref="CaseControl"/> is put on a <see cref="Gameboard"/> but it is not the <see cref="Gameboard"/> used by the <see cref="GameIA"/></item>
        /// </list>
        /// </returns>
        public int GetPosition(CaseControl control)
        {
            if (control.Color != Rules.ActiveCaseColor) return default;
            if (!(control.Parent is Gameboard)) return default;

            if (Board != null)
            {
                if (control.Parent == Board)
                {
                    if (CurrentPlayer == Blacks) return Board.Controls.IndexOf(control) / 2 + 1;
                    if (CurrentPlayer == Whites) return (int)Math.Ceiling((int)Rules.Mode / 2 * (int)Rules.Mode - Board.Controls.IndexOf(control) / 2d);
                }
            }
            return default;
        }

        public CaseControl GetCase(int position)
        {
            if (position == default) return null;
            if (Board != null)
            {
                var lineIndex = position / CountActiveCases + (position % CountActiveCases == 0 ? 0 : 1);
                var isPairIndex = lineIndex % 2 == 0;

                if (CurrentPlayer == Blacks) return Board.Controls[position * 2 - 1 - (isPairIndex ? 1 : 0)] as CaseControl;
                if (CurrentPlayer == Whites) return Board.Controls[Board.Controls.Count - position * 2 + (isPairIndex ? 1 : 0)] as CaseControl;
            }
            return null;
        }

        public int GetPosition(CaseControl caseControl, CaseDirection direction)
        {
            //Determines if a case control can exists in the direction specified
            var position = GetPosition(caseControl);
            var lineIndex = position / CountActiveCases + (position % CountActiveCases == 0 ? 0 : 1);
            var isPairIndex = lineIndex % 2 == 0;

            int moveDelta;
            switch (direction)
            {
                case CaseDirection.Left:
                    if (lineIndex == (int)Rules.Mode) break;
                    if (CurrentPlayer == Whites && lineIndex * CountActiveCases == position && !isPairIndex) break;
                    if (CurrentPlayer == Blacks && (lineIndex - 1) * CountActiveCases + 1 == position && isPairIndex) break;

                    moveDelta = isPairIndex ? 5 : 6;
                    return position + moveDelta;

                case CaseDirection.LeftBackward:
                    if (lineIndex == 1) break;
                    if (lineIndex * CountActiveCases == position && !isPairIndex) break;

                    moveDelta = isPairIndex ? 5 : 4;
                    return position - moveDelta;

                case CaseDirection.Right:
                    if (lineIndex == (int)Rules.Mode) break;
                    if (CurrentPlayer == Whites && (lineIndex - 1) * CountActiveCases + 1 == position && isPairIndex) break;
                    if (CurrentPlayer == Blacks && lineIndex * CountActiveCases == position && !isPairIndex) break;

                    moveDelta = isPairIndex ? 4 : 5;
                    return position + moveDelta;

                case CaseDirection.RightBackward:
                    if (lineIndex == 1) break;
                    if ((lineIndex - 1) * CountActiveCases + 1 == position && isPairIndex) break;

                    moveDelta = isPairIndex ? 6 : 5;
                    return position - moveDelta;
            }

            return default;
        }

        /// <summary>
        /// <para>Get the coordinates of the <see cref="CaseControl"/> on the Game board</para>
        /// <para>according to the current <see cref="Player"/> is playing</para>
        /// </summary>
        /// <param name="control">Control to return their coordinates on the game board</param>
        /// <returns>The <see cref="Point"/> corresponds to the column (X) and line (Y)</returns>
        public Point GetCoordinates(CaseControl control)
        {
            var line = GetPosition(control) / ((int)Rules.Mode / 2);
            var column = GetPosition(control) % ((int)Rules.Mode / 2);

            return new Point(column, line);
        }

        public bool CanMoveTo(CaseControl caseControlFrom, CaseControl caseControlTo, PawnControl pawn)
        {
            if (caseControlFrom == null) throw new ArgumentNullException(nameof(caseControlFrom), "The pawn seems to provide from another way that the gameboard because there is no reference to their case");

            return caseControlTo.CanAcceptPawn(pawn);
        }

        /// <summary>
        /// Initializes the <see cref="Gameboard"/> and the two <see cref="Player"/>
        /// </summary>
        public void InitializeGame()
        {
            if (Rules == null) throw new NullReferenceException("The rule set to use is not defined !");
            if (Board == null) throw new NullReferenceException("The game board to play is not defined !");

            Board.Controls.Clear();

            //Initialize the players
            Blacks = new Player { Color = GameColor.Black, Score = 0 };
            Whites = new Player { Color = GameColor.White, Score = 0 };

            //Initialize the current player
            CurrentPlayer = Rules.FirstPlayColor == GameColor.White ? Whites : Blacks;

            //Initialize the cases
            InitializeCaseControls();
            //Initialize the pawns
            InitializePawnControls(GameColor.Black);
            InitializePawnControls(GameColor.White);

            InitializeDiagonals();

            Initialized?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Initializes the <see cref="CaseControl"/> of the <see cref="Gameboard"/>
        /// </summary>
        private void InitializeCaseControls()
        {
            var firstColor = Rules.FirstRightCaseColor;

            //Y axis
            for (var i = 0; i < (int)Rules.Mode; i++)
            {
                //X axis
                for (var j = 0; j < (int)Rules.Mode; j++)
                {
                    Board.Controls.Add(new CaseControl { Color = firstColor, Location = new Point(j * 50, i * 50) }); //Add the case to the gameboard
                    firstColor = firstColor == GameColor.Black ? GameColor.White : GameColor.Black; //Alternate the color on columns
                }
                firstColor = firstColor == GameColor.Black ? GameColor.White : GameColor.Black; //Alternate another time the color to have alternate color on rows
            }
        }

        /// <summary>
        /// Initializes the <see cref="PawnControl"/> of the <see cref="Gameboard"/> according to the <paramref name="color"/>.
        /// </summary>
        /// <param name="color">The <see cref="GameColor"/> of <see cref="PawnControl"/> to initialize</param>
        private void InitializePawnControls(GameColor color)
        {
            var countPawns = (int)Rules.Mode / 2 * ((int)Rules.Mode - 2) / 2;

            var bottomPadLine = color == GameColor.White ? (int)Rules.Mode / 2 + 1 : 0; //Calculate the bottom pad to apply on line number calculation
            var leftPadFirstColumn = Rules.ActiveCaseColor == GameColor.White ? 0 : 1;
            if (Rules.FirstRightCaseColor == GameColor.Black)
            {
                leftPadFirstColumn = Rules.ActiveCaseColor == GameColor.White ? 1 : 0;
            }

            for (var i = 0; i < countPawns; i++)
            {
                //Calculate the correct column and line index to position the pawn on the game board
                var lineIndex = i / ((int)Rules.Mode / 2) + bottomPadLine;
                //Calculate the column index
                //A:(leftPadFirstColumn + i)  => if the first case if white, add 1 to the index
                //B:(i % (int)Rules.Mode)     => add the remainder to shift X on pair value of i
                //C:(A + B) % (int)Rules.Mode => restrict the number of column between 0 to (int)Rules.Mode
                //D:C - correction * (lineIndex % 2)  => remove or add the correction when the line number is a odd value according to active color
                var correction = Rules.ActiveCaseColor == GameColor.White ? -1 : 1;
                if (Rules.FirstRightCaseColor == GameColor.Black)
                {
                    correction = Rules.ActiveCaseColor == GameColor.White ? 1 : -1;
                }
                var columnIndex = (leftPadFirstColumn + i + i % (int)Rules.Mode) % (int)Rules.Mode - correction * (lineIndex % 2);

                Console.WriteLine($"line={lineIndex}, column={columnIndex}");

                var pawn = new PawnControl { Color = color }; //Create a new pawn of the color passed in parameter
                var caseControl = Board.GetCaseControl(new Point(columnIndex, lineIndex)); //Get the case at the corresponding location point

                //Add the pawn to the player collection according to the pawn color
                if (color == GameColor.Black)
                    Blacks.Pawns.Add(pawn);
                else
                    Whites.Pawns.Add(pawn);

                pawn.Gloups += PawnOnGloups;
                pawn.Gloupsed += PawnOnGloupsed;
                pawn.Promote += PawnOnPromote;

                caseControl.Controls.Add(pawn);
            }
        }

        private void PawnOnGloups(object sender, EventArgs e)
        {
            CurrentPlayer.AddPoint();
        }

        private void PawnOnGloupsed(object sender, PawnGloupsedEventArgs e)
        {
            e.Parent.Controls.Remove(e.PawnGloupsed);
            CurrentMove.AddCatch(e.PawnGloupsed);
        }

        private void PawnOnPromote(object sender, EventArgs e)
        {
            CurrentPlayer.AddPromotionPoint();
        }

        private void InitializeDiagonals()
        {
            #region Diagonal Left

            var diagonalLeft = 0;
            for (var i = 1; i <= CountActiveCases; i++)
            {
                var j = 1;
                var position = i;
                diagonalLeft = i;
                do
                {
                    var caseControl = GetCase(position);
                    caseControl.DiagonalLeft = diagonalLeft;
                    position += CountActiveCases + j;

                    j = j == 0 ? 1 : 0;
                } while (i != (int)Rules.Mode && i != CountActiveCases && position <= ((int)Rules.Mode - (i + (i - 1))) * CountActiveCases);
            }

            for (var i = CountActiveCases + 1; i <= (int)Rules.Mode * CountActiveCases - CountActiveCases + 1; i = i + (int)Rules.Mode)
            {
                var j = 0;
                var position = i;
                diagonalLeft++;
                do
                {
                    var caseControl = GetCase(position);
                    caseControl.DiagonalLeft = diagonalLeft;
                    position += CountActiveCases + j;

                    j = j == 0 ? 1 : 0;
                } while (position <= CountActiveCases * (int)Rules.Mode - (diagonalLeft - CountActiveCases - 1));
            }

            #endregion

            #region Diagonal Right

            var diagonalRight = 0;
            for (var i = 1; i <= CountActiveCases; i++)
            {
                var j = 0;
                var position = i;
                diagonalRight = i;
                do
                {
                    var caseControl = GetCase(position);
                    caseControl.DiagonalRight = diagonalRight;
                    position += CountActiveCases + j;

                    j = j == 0 ? -1 : 0;
                } while (position <= (i + (i - 1)) * CountActiveCases + 1);
            }

            for (var i = CountActiveCases * 3; i <= (int)Rules.Mode * CountActiveCases - CountActiveCases + 1; i = i + (int)Rules.Mode)
            {
                var j = 0;
                var position = i;
                diagonalRight++;
                do
                {
                    var caseControl = GetCase(position);
                    caseControl.DiagonalRight = diagonalRight;
                    position += CountActiveCases + j;

                    j = j == 0 ? -1 : 0;
                } while (position <= CountActiveCases * (int)Rules.Mode - ((int)Rules.Mode - diagonalRight - 1));
            }

            #endregion
        }

        public void SetNextPlayer()
        {
            CurrentPlayer = CurrentPlayer == Whites ? Blacks : Whites;

            InitializeDiagonals();

            CurrentMove = new GameMove(); //Init a new move
        }
    }
}

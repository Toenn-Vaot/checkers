using Checkers_Library;
using Checkers_Library.Enumerations;

namespace Checkers_Controls.GameRules
{
    public class Dutch : GameRule
    {
        public Dutch()
        {
            FirstRightCaseColor = GameColor.White;
            ActiveCaseColor = GameColor.Black;
            FirstPlayColor = GameColor.White;
            Mode = GameMode.Mode10X10;
            PawnCanGloupsBehind = true;
            QueenCanMoveMulti = true;
            PawnCanGloupsQueen = true;
            PassingQueen = false;
            MaximumGloups = true;
            QueenMustGlouspBefore = false;
            BreatheIsNotPlay = false;
            ForceToPlay = true;
            //Notation = null;
        }
    }
}
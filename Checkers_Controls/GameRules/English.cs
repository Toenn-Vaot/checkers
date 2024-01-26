using Checkers_Library;
using Checkers_Library.Enumerations;

namespace Checkers_Controls.GameRules
{
    public class English : GameRule
    {
        public English()
        {
            FirstRightCaseColor = GameColor.White;
            ActiveCaseColor = GameColor.Black;
            FirstPlayColor = GameColor.White;
            Mode = GameMode.Mode8X8;
            PawnCanGloupsBehind = false;
            QueenCanMoveMulti = true;
            PawnCanGloupsQueen = true;
            PassingQueen = false;
            MaximumGloups = false;
            QueenMustGlouspBefore = false;
            BreatheIsNotPlay = false;
            ForceToPlay = true;
            //Notation = null;
        }
    }
}
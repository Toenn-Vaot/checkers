using Checkers_Library;
using Checkers_Library.Enumerations;

namespace Checkers_Controls.GameRules
{
    public class Italian : GameRule
    {
        public Italian()
        {
            FirstRightCaseColor = GameColor.Black;
            ActiveCaseColor = GameColor.Black;
            FirstPlayColor = GameColor.White;
            Mode = GameMode.Mode8X8;
            PawnCanGloupsBehind = false;
            QueenCanMoveMulti = true;
            PawnCanGloupsQueen = true;
            PassingQueen = false;
            MaximumGloups = true;
            QueenMustGlouspBefore = true;
            BreatheIsNotPlay = true;
            ForceToPlay = true;
            //Notation = null;
        }
    }
}
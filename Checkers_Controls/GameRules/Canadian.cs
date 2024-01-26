using Checkers_Library;
using Checkers_Library.Enumerations;

namespace Checkers_Controls.GameRules
{
    public class Canadian : GameRule
    {
        public Canadian()
        {
            FirstRightCaseColor = GameColor.White;
            ActiveCaseColor = GameColor.Black;
            FirstPlayColor = GameColor.White;
            Mode = GameMode.Mode12X12;
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
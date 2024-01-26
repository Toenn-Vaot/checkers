using Checkers_Library;
using Checkers_Library.Enumerations;

namespace Checkers_Controls.GameRules
{
    public class Spanish : GameRule
    {
        public Spanish()
        {
            FirstRightCaseColor = GameColor.White;
            ActiveCaseColor = GameColor.White;
            FirstPlayColor = GameColor.White;
            Mode = GameMode.Mode8X8;
            PawnCanGloupsBehind = false;
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
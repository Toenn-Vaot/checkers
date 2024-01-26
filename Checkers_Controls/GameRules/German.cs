using Checkers_Library;
using Checkers_Library.Enumerations;

namespace Checkers_Controls.GameRules
{
    public class German : GameRule
    {
        public German()
        {
            FirstRightCaseColor = GameColor.White;
            ActiveCaseColor = GameColor.White;
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
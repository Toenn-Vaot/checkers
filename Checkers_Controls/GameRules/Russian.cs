using Checkers_Library;
using Checkers_Library.Enumerations;

namespace Checkers_Controls.GameRules
{
    public class Russian : GameRule
    {
        public Russian()
        {
            FirstRightCaseColor = GameColor.White;
            ActiveCaseColor = GameColor.Black;
            FirstPlayColor = GameColor.White;
            Mode = GameMode.Mode8X8;
            PawnCanGloupsBehind = true;
            QueenCanMoveMulti = true;
            PawnCanGloupsQueen = true;
            PassingQueen = true;
            MaximumGloups = false;
            QueenMustGlouspBefore = false;
            BreatheIsNotPlay = false;
            ForceToPlay = true;
            //Notation = null;
        }
    }
}
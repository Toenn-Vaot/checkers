using Checkers_Library.Enumerations;
using System;
using Checkers_Library.Events;
using System.Windows.Forms;

namespace Checkers_Library.Interfaces
{
    public abstract class PawnBase : UserControl
    {
        public delegate void GloupsedEventHandler(object sender, PawnGloupsedEventArgs e);

        public abstract event EventHandler Promote;

        public abstract event EventHandler Gloups;

        public abstract event GloupsedEventHandler Gloupsed;

        public GameColor Color
        {
            get => BackColor == System.Drawing.Color.Black ? GameColor.Black : GameColor.White;
            set
            {
                switch (value)
                {
                    case GameColor.Black:
                        BackColor = System.Drawing.Color.Black;
                        break;
                    case GameColor.White:
                    case GameColor.CustomBlack:
                    case GameColor.CustomWhite:
                    default:
                        BackColor = System.Drawing.Color.White;
                        break;
                }
                Invalidate();
            }
        }

        protected bool IsQueenValue = false;

        protected bool IsGloupsedValue = false;

        protected bool HasGloupsValue = false;
        
        /// <summary>
        /// Indicates if the <see cref="PawnBase"/> is a Queen
        /// </summary>
        public abstract bool IsQueen { get; set; }
        /// <summary>
        /// Indicates if the <see cref="PawnBase"/> has been gloupsed or not
        /// </summary>
        public abstract bool IsGloupsed { get; set; }

        /// <summary>
        /// Indicates if the <see cref="PawnBase"/> has gloups or not
        /// </summary>
        public abstract bool HasGloups { get; set; }
    }
}

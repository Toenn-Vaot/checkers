using System.Windows.Forms;
using Checkers_Library.Interfaces;

namespace Checkers_Library.Events
{
    public class PawnGloupsedEventArgs
    {
        public PawnBase PawnGloupsed { get; set; }

        public Control Parent { get; set; }
    }
}

using Checkers_Library.Enumerations;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Checkers_Library;

namespace Checkers_Controls
{
	public sealed partial class CaseControl : UserControl
	{
		/// <summary>
		/// The fixed size of each side of the control
		/// </summary>
		public const int FixedSize = 50;

		/// <summary>
		/// The private instance of the color of the control
		/// </summary>
		/// <seealso cref="GameColor"/>
		private GameColor _color = GameColor.Black;

		/// <summary>
		/// The color of the control
		/// </summary>
		public GameColor Color
		{
			get => _color;
			set
			{
				_color = value;
				BackColor = _color == GameColor.Black ? System.Drawing.Color.DimGray : System.Drawing.Color.White;
			}
		}

		/// <summary>
		/// Get the <see cref="PawnControl"/> present on the <see cref="CaseControl"/>. Otherwise, null.
		/// </summary>
		public PawnControl Pawn => Controls.OfType<PawnControl>().FirstOrDefault();

		/// <summary>
		/// Get the current position on the <see cref="Gameboard"/> according to the <see cref="Player"/> is playing.
		/// </summary>
		public int Position => GameIA.Instance.GetPosition(this);

		/// <summary>
		/// Get the current line index on the <see cref="Gameboard"/> according to the <see cref="Player"/> is playing.
		/// </summary>
		public int Line => Position / GameIA.Instance.CountActiveCases + (Position % GameIA.Instance.CountActiveCases == 0 ? 0 : 1);

		public int DiagonalLeft { get; set; }

		public int DiagonalRight { get; set; }

		public int FrontLeft => GameIA.Instance.GetPosition(this, CaseDirection.Left);

		public int FrontRight => GameIA.Instance.GetPosition(this, CaseDirection.Right);

		public int BackLeft => GameIA.Instance.GetPosition(this, CaseDirection.LeftBackward);

		public int BackRight => GameIA.Instance.GetPosition(this, CaseDirection.RightBackward);

		public CaseControl FrontLeftCase => GameIA.Instance.GetCase(FrontLeft);

		public CaseControl FrontRightCase => GameIA.Instance.GetCase(FrontRight);

		public CaseControl BackLeftCase => GameIA.Instance.GetCase(BackLeft);

		public CaseControl BackRightCase => GameIA.Instance.GetCase(BackRight);

		public Gameboard Gameboard => Parent as Gameboard;

		/// <summary>
		/// Get the coordinates on the <see cref="Gameboard"/> according to the <see cref="Player"/> is playing.
		/// </summary>
		public Point Coordinates => GameIA.Instance.GetCoordinates(this);

		/// <summary>
		/// Constructor
		/// </summary>
		public CaseControl()
		{
			InitializeComponent();

			AllowDrop = true;

			Size = new Size(FixedSize, FixedSize);
			MinimumSize = new Size(FixedSize, FixedSize);
			MaximumSize = new Size(FixedSize, FixedSize);

			GameIA.Instance.NextPlayerChanged += GameIA_NextPlayerChanged;
		}

		protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
		{
			base.OnGiveFeedback(gfbevent);
			gfbevent.UseDefaultCursors = false;
		}

		protected override void OnDragEnter(DragEventArgs drgevent)
		{
			if (Color == GameColor.White || Color == GameColor.CustomWhite) return;
			if (Pawn != null) return;

			if (drgevent.AllowedEffect == DragDropEffects.Move)
			{
				if (drgevent.Data.GetData(typeof(PawnControl)) is PawnControl controlEnter && controlEnter.Parent is CaseControl caseControlEnter)
				{
					if (GameIA.Instance.CanMoveTo(caseControlEnter, this, controlEnter))
					{
						Cursor = Cursors.Hand;
						drgevent.Effect = DragDropEffects.Move;
					}
					else
					{
						Cursor = Cursors.No;
						drgevent.Effect = DragDropEffects.None;
					}
				}
			}
		}

		protected override void OnDragDrop(DragEventArgs drgevent)
		{
			if (drgevent.Effect == DragDropEffects.Move)
			{
				base.OnDragDrop(drgevent);

				if (drgevent.Data.GetData(typeof(PawnControl)) is PawnControl pawnMoved && pawnMoved.Parent is CaseControl caseFrom)
				{
					var gloupsDone = false;
					var currentLineNumber = Line;
					var currentLineNumberFrom = caseFrom.Line;

					//NOTICE: Move forward
					if (currentLineNumber - currentLineNumberFrom >= 2)
					{
						if (pawnMoved.IsQueen)
						{
							if (caseFrom.DiagonalLeft == DiagonalLeft)
							{
								if (BackRightCase.Pawn != null)
								{
                                    pawnMoved.HasGloups = true;
                                    BackRightCase.Pawn.IsGloupsed = true; //QUEEN LEFT gloups
									gloupsDone = true;
								}
							}
							else
							{
								if (BackLeftCase.Pawn != null)
								{
                                    pawnMoved.HasGloups = true;
                                    BackLeftCase.Pawn.IsGloupsed = true; //QUEEN RIGHT gloups
									gloupsDone = true;
								}
							}
						}
						else
						{
							if (caseFrom.DiagonalLeft == DiagonalLeft && caseFrom.FrontLeftCase.Pawn != null)
                            {
                                pawnMoved.HasGloups = true;
                                caseFrom.FrontLeftCase.Pawn.IsGloupsed = true; //LEFT gloups
								gloupsDone = true;
							}

							if (caseFrom.DiagonalRight == DiagonalRight && caseFrom.FrontRightCase.Pawn != null)
							{
                                pawnMoved.HasGloups = true;
                                caseFrom.FrontRightCase.Pawn.IsGloupsed = true; //RIGHT gloups
								gloupsDone = true;
							}
						}
					}
					else if(currentLineNumber - currentLineNumberFrom <= -2)
					{
						if (pawnMoved.IsQueen || GameIA.Instance.Rules.PawnCanGloupsBehind)
						{
							if (caseFrom.DiagonalLeft == DiagonalLeft)
							{
								if (FrontLeftCase.Pawn != null)
								{
                                    pawnMoved.HasGloups = true;
                                    FrontLeftCase.Pawn.IsGloupsed = true; //QUEEN BACKWARD LEFT gloups or Rules allowed the gloups behind
									gloupsDone = true;
								}
							}
							else
							{
								if (FrontRightCase.Pawn != null)
								{
                                    pawnMoved.HasGloups = true;
                                    FrontRightCase.Pawn.IsGloupsed = true; //QUEEN BACKWARD RIGHT gloups or Rules allowed the gloups behind
									gloupsDone = true;
								}
							}
						}
					}

					Controls.Add(pawnMoved);
					
					if (gloupsDone)
					{
						if (pawnMoved.CanGloups(this))
						{
							//NOTICE: Let's the current player continue to move
							return;
						}
					}
					
					GameIA.Instance.SetNextPlayer();
				}
			}
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);

			if (Position != 0)
			{
				if (GameIA.Instance.DisplayCaseInformation)
                {
                    //Display the position number according to current player point of view
                    if (GameIA.Instance.CurrentPlayer.Color == GameColor.Black || GameIA.Instance.CurrentPlayer.Color == GameColor.CustomBlack)
					{
						e.Graphics.DrawString(Position.ToString(), Font, Brushes.Red, new PointF(0, 0));
					}
					else
					{
						e.Graphics.DrawString(Position.ToString(), Font, Brushes.Green, new PointF(0, 0));
					}

					//Display the position of their neighbors
					e.Graphics.DrawString(FrontLeft.ToString(), Font, Brushes.Orange, new PointF(12, 12));
					e.Graphics.DrawString(FrontRight.ToString(), Font, Brushes.Orange, new PointF(26, 12));
					e.Graphics.DrawString(BackLeft.ToString(), Font, Brushes.Orange, new PointF(12, 22));
					e.Graphics.DrawString(BackRight.ToString(), Font, Brushes.Orange, new PointF(26, 22));

					//Display the diagonals
					e.Graphics.DrawString(DiagonalLeft.ToString(), Font, Brushes.Violet, new PointF(0, 35));
					e.Graphics.DrawString(DiagonalRight.ToString(), Font, Brushes.Violet, new PointF(35, 35));

					e.Graphics.DrawString(Line.ToString(), Font, Brushes.Cyan, new PointF(35, 0));
				}
			}
		}

		public void GameIA_NextPlayerChanged(object sender, EventArgs e)
		{
			Invalidate();
			foreach (Control ctl in Controls)
			{
				ctl.Invalidate();
			}
		}

		public bool CanAcceptPawn(PawnControl controlMoving)
		{
			if (Pawn != null) return false; //If there is a pawn on the case, return false
			if (Color != GameIA.Instance.Rules.ActiveCaseColor) return false; //If the case is not a "game" case, return false

			var caseFrom = controlMoving.Parent as CaseControl;
			var currentLineNumber = Line;
			var currentLineNumberFrom = caseFrom.Line;

			if (currentLineNumberFrom == currentLineNumber) return false;
			if (currentLineNumber - currentLineNumberFrom == 2 && (caseFrom.DiagonalLeft == DiagonalLeft && caseFrom.FrontLeftCase?.Pawn != null && caseFrom.FrontLeftCase.Pawn.Color != controlMoving.Color)) return true; //LEFT gloups
			if (currentLineNumber - currentLineNumberFrom == 2 && (caseFrom.DiagonalRight == DiagonalRight && caseFrom.FrontRightCase?.Pawn != null && caseFrom.FrontRightCase.Pawn.Color != controlMoving.Color)) return true; //RIGHT gloups

			if (!controlMoving.IsQueen && currentLineNumber - currentLineNumberFrom > 1) return false; //Move more than one line is forbidden for pawn, not for Queen
			if (!controlMoving.IsQueen && currentLineNumberFrom > currentLineNumber) return false; //Move backward is forbidden for pawn, not for Queen

			if (controlMoving.IsQueen)
			{
				if(caseFrom.DiagonalLeft != DiagonalLeft && caseFrom.DiagonalRight != DiagonalRight) return false; // Forbidden vertical move
				if (caseFrom.DiagonalLeft == DiagonalLeft)
				{
					var currentCase = caseFrom.FrontLeftCase;
					while (currentCase != null && currentCase != this)
					{
						if (currentCase.Pawn != null && currentCase.FrontLeftCase != this && !controlMoving.IsQueen) return false;
						currentCase = currentCase.FrontLeftCase;
					}

					if (currentCase == null)
					{
						currentCase = caseFrom.BackRightCase;
						while (currentCase != null && currentCase != this)
						{
							if (currentCase.Pawn != null && currentCase.BackRightCase != this) return false;
							currentCase = currentCase.BackRightCase;
						}
					}
				}
				if (caseFrom.DiagonalRight == DiagonalRight)
				{
					var currentCase = caseFrom.FrontRightCase;
					while (currentCase != null && currentCase != this)
					{
						if (currentCase.Pawn != null && currentCase.FrontRightCase != this && !controlMoving.IsQueen) return false;
						currentCase = currentCase.FrontRightCase;
					}

					if (currentCase == null)
					{
						currentCase = caseFrom.BackLeftCase;
						while (currentCase != null && currentCase != this)
						{
							if (currentCase.Pawn != null && currentCase.BackLeftCase != this) return false;
							currentCase = currentCase.BackLeftCase;
						}
					}
				}
			}

			return true;
		}

		public override string ToString()
		{
			return "Case " + Position + " : " + (Pawn != null ? "with" : "without") + " pawn";
		}
	}

	public enum CaseDirection
	{
		Left,
		Right,
		LeftBackward,
		RightBackward
	}
}

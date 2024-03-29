﻿using Checkers_Library.Enumerations;
using Checkers_Library.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;
using Checkers_Library.Events;

namespace Checkers_Controls
{
    public sealed partial class PawnControl : PawnBase
    {
        #region Events

        /// <inheritdoc />
        public override event EventHandler Promote;

        /// <inheritdoc />
        public override event EventHandler Gloups;

        /// <inheritdoc />
        public override event GloupsedEventHandler Gloupsed;

        #endregion

        /// <summary>
        /// The fixed size of each side of the control
        /// </summary>
        private const int FixedSize = 50;

        #region Properties
        
        /// <inheritdoc />
        public override bool IsQueen
        {
            get => IsQueenValue;
            set
            {
                IsQueenValue = value;
            }
        }
        
        /// <inheritdoc />
        public override bool IsGloupsed
        {
            get => IsGloupsedValue;
            set
            {
                IsGloupsedValue = value;
                Gloupsed?.Invoke(this, new PawnGloupsedEventArgs { Parent = Parent, PawnGloupsed = this });
                Invalidate();
            }
        }

        /// <inheritdoc />
        public override bool HasGloups
        {
            get => HasGloupsValue;
            set
            {
                HasGloupsValue = value;
                Gloups?.Invoke(this, EventArgs.Empty);
                Invalidate();
            }
        }

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public PawnControl()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true); //Activate the support of transparent back color
            BackColor = System.Drawing.Color.Transparent; //Set the back color to transparent

            Size = new Size(FixedSize, FixedSize);
            MinimumSize = new Size(FixedSize, FixedSize);
            MaximumSize = new Size(FixedSize, FixedSize);
        }

        /// <summary>
        /// Overrides the base control method to define a new style parameter rendering the control transparent
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; //Add Transparent Parameter
                return cp;
            }
        }

        /// <summary>
        /// Overrides the base control method to avoid the paint of control background
        /// </summary>
        /// <param name="e">Paint event arguments</param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Do nothing
        }

        /// <summary>
        /// Overrides the base control method to redefines how the control must be painted according to <see cref="Color"/>
        /// </summary>
        /// <param name="e">Paint event arguments</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Draw the image of the corresponding pawn

            if (Color == GameColor.Black)
                e.Graphics.FillEllipse(
                    IsQueen
                        ? new TextureBrush(Properties.Resources.Checker_Queen_Icon_Black, System.Drawing.Drawing2D.WrapMode.Clamp)
                        : new TextureBrush(Properties.Resources.Checker_Black, System.Drawing.Drawing2D.WrapMode.Clamp),
                    0, 0, 50, 50);
            else
                e.Graphics.FillEllipse(
                    IsQueen
                        ? new TextureBrush(Properties.Resources.Checker_Queen_Icon_White, System.Drawing.Drawing2D.WrapMode.Clamp)
                        : new TextureBrush(Properties.Resources.Checker_White, System.Drawing.Drawing2D.WrapMode.Clamp),
                    0, 0, 50, 50);

            if (!GameIA.Instance.DisplayPawnInfo) return;
            if (Color == GameColor.Black || Color == GameColor.CustomBlack)
            {
                e.Graphics.DrawString(Color.ToString(), Font, Brushes.White, new PointF(10, 15));
            }
            else
            {
                e.Graphics.DrawString(Color.ToString(), Font, Brushes.Black, new PointF(10, 15));
            }
        }

        /// <summary>
        /// Overrides the base control method to redefines how the control reacts when mouse moved.
        /// </summary>
        /// <param name="e">Mouse event arguments</param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(this, GameIA.Instance.CurrentPlayer.Color == Color ? DragDropEffects.Move : DragDropEffects.None);
            }
        }

        protected override void OnMouseHover(EventArgs e)
        {
            Cursor = Cursors.Hand;
            if (GameIA.Instance.CurrentPlayer.Color != Color)
                Cursor = Cursors.No;

            base.OnMouseHover(e);
        }

        /// <inheritdoc />
        protected override void OnParentChanged(EventArgs e)
        {
            if (Parent is CaseControl caseCtrl && !IsQueen)
            {
                if (caseCtrl.Line == (int)GameIA.Instance.Rules.Mode && GameIA.Instance.CurrentPlayer.Color == Color)
                {
                    IsQueen = true;
                    Promote?.Invoke(this, EventArgs.Empty);
                    Invalidate();
                }
            }

            base.OnParentChanged(e);
        }

        public bool CanGloups(CaseControl movedTo)
        {
            // NOTICE: Check FORWARD moves
            if (IsQueen)
            {
                var currentCase = movedTo;
                var previousHasPawn = false;

                // NOTICE: If move to left is possible
                if (currentCase.FrontLeftCase != null)
                {
                    do
                    {
                        var currentHasPawn = currentCase.FrontLeftCase.Pawn != null;
                        if (previousHasPawn)
                        {
                            //NOTICE: If the previous case has a pawn and the current one hasn't, gloups is possible
                            if (!currentHasPawn) return true;
                            //NOTICE: If the previous case has a pawn and the current one too, gloups is not possible on LEFT SIDE
                            break;
                        }

                        previousHasPawn = currentHasPawn;
                        currentCase = currentCase.FrontLeftCase;
                    } while (currentCase.FrontLeftCase != null);
                }

                previousHasPawn = false;
                currentCase = movedTo;
                // NOTICE: If move to right is possible
                if (currentCase.FrontRightCase != null)
                {
                    do
                    {
                        var currentHasPawn = currentCase.FrontRightCase.Pawn != null;
                        if (previousHasPawn)
                        {
                            //NOTICE: If the previous case has a pawn and the current one hasn't, gloups is possible
                            if (!currentHasPawn) return true;
                            //NOTICE: If the previous case has a pawn and the current one too, gloups is not possible on RIGHT SIDE
                            break;
                        }

                        previousHasPawn = currentHasPawn;
                        currentCase = currentCase.FrontRightCase;
                    } while (currentCase.FrontRightCase != null);
                }

                previousHasPawn = false;
                currentCase = movedTo;
                // NOTICE: If move to backward left is possible
                if (currentCase.BackLeftCase != null)
                {
                    do
                    {
                        var currentHasPawn = currentCase.BackLeftCase.Pawn != null;
                        if (previousHasPawn)
                        {
                            //NOTICE: If the previous case has a pawn and the current one hasn't, gloups is possible
                            if (!currentHasPawn) return true;
                            //NOTICE: If the previous case has a pawn and the current one too, gloups is not possible on BACKWARD LEFT SIDE
                            break;
                        }

                        previousHasPawn = currentHasPawn;
                        currentCase = currentCase.BackLeftCase;
                    } while (currentCase.BackLeftCase != null);
                }

                previousHasPawn = false;
                currentCase = movedTo;
                // NOTICE: If move to backward right is possible
                if (currentCase.BackRightCase != null)
                {
                    do
                    {
                        var currentHasPawn = currentCase.BackRightCase.Pawn != null;
                        if (previousHasPawn)
                        {
                            //NOTICE: If the previous case has a pawn and the current one hasn't, gloups is possible
                            if (!currentHasPawn) return true;
                            //NOTICE: If the previous case has a pawn and the current one too, gloups is not possible on BACKWARD RIGHT SIDE
                            break;
                        }

                        previousHasPawn = currentHasPawn;
                        currentCase = currentCase.BackRightCase;
                    } while (currentCase.BackRightCase != null);
                }
            }

            //NOTICE: If there is a pawn on neighbor and free case behind to gloups
            var gloupsForward = (movedTo.FrontLeftCase?.Pawn != null && movedTo.FrontLeftCase.FrontLeftCase != null && movedTo.FrontLeftCase.FrontLeftCase.Pawn == null)
                                || (movedTo.FrontRightCase?.Pawn != null && movedTo.FrontRightCase.FrontRightCase != null && movedTo.FrontRightCase.FrontRightCase.Pawn == null);

            var gloupsBackward = (movedTo.BackLeftCase?.Pawn != null && movedTo.BackLeftCase.BackLeftCase != null && movedTo.BackLeftCase.BackLeftCase.Pawn == null)
                                 || (movedTo.BackRightCase?.Pawn != null && movedTo.BackRightCase.BackRightCase != null && movedTo.BackRightCase.BackRightCase.Pawn == null);

            if (GameIA.Instance.Rules.PawnCanGloupsBehind)
                return gloupsForward || gloupsBackward;
            return gloupsForward;
        }
    }
}
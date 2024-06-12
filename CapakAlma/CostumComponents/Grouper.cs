/*
 [PLEASE DO NOT MODIFY THIS HEADER INFORMATION]---------------------
 Title: Grouper
 Description: A rounded groupbox with special painting features. 
 Date Created: December 17, 2005
 Author: Adam Smith
 Author Email: ibulwark@hotmail.com
 Websites: http://www.ebadgeman.com | http://www.codevendor.com
 
 Version History:
 1.0a - Beta Version - Release Date: December 17, 2005 
 -------------------------------------------------------------------
 */

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CapakAlma.CostumComponents
{
	/// <summary>A special custom rounding GroupBox with many painting features.</summary>
	[ToolboxBitmap(typeof(Grouper), "CodeVendor.Controls.Grouper.bmp")]
	[Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
	public class Grouper : System.Windows.Forms.UserControl
	{
		#region Enumerations

		/// <summary>A special gradient enumeration.</summary>
		public enum GroupBoxGradientMode
		{
			/// <summary>Specifies no gradient mode.</summary>
			None = 4,

			/// <summary>Specifies a gradient from upper right to lower left.</summary>
			BackwardDiagonal = 3,

			/// <summary>Specifies a gradient from upper left to lower right.</summary>
			ForwardDiagonal = 2,

			/// <summary>Specifies a gradient from left to right.</summary>
			Horizontal = 0,

			/// <summary>Specifies a gradient from top to bottom.</summary>
			Vertical = 1
		}

		
		#endregion

		#region Variables

		private System.ComponentModel.Container _components = null;
		private int _vRoundCorners = 10;
		private string _vGroupTitle = "The Grouper";
		private System.Drawing.Color _vBorderColor = Color.Black;
		private float _vBorderThickness = 1;
		private bool _vShadowControl = false;
		private System.Drawing.Color _vBackgroundColor = Color.White;
		private System.Drawing.Color _vBackgroundGradientColor = Color.White;
		private GroupBoxGradientMode _vBackgroundGradientMode = GroupBoxGradientMode.None;
		private System.Drawing.Color _vShadowColor = Color.DarkGray;
		private int _vShadowThickness = 3;
		private System.Drawing.Image _vGroupImage = null;
		private System.Drawing.Color _vCustomGroupBoxColor = Color.White;
		private bool _vPaintGroupBox = false;
		private System.Drawing.Color _vBackColor = Color.Transparent;

		#endregion

		#region Properties

		/// <summary>This feature will paint the background color of the control.</summary>
		[Category("Appearance"), Description("This feature will paint the background color of the control.")]
		public override System.Drawing.Color BackColor{get{return _vBackColor;} set{_vBackColor=value; this.Refresh();}}

		/// <summary>This feature will paint the group title background to the specified color if PaintGroupBox is set to true.</summary>
		[Category("Appearance"), Description("This feature will paint the group title background to the specified color if PaintGroupBox is set to true.")]
		public System.Drawing.Color CustomGroupBoxColor{get{return _vCustomGroupBoxColor;} set{_vCustomGroupBoxColor=value; this.Refresh();}}

		/// <summary>This feature will paint the group title background to the CustomGroupBoxColor.</summary>
		[Category("Appearance"), Description("This feature will paint the group title background to the CustomGroupBoxColor.")]
		public bool PaintGroupBox{get{return _vPaintGroupBox;} set{_vPaintGroupBox=value; this.Refresh();}}

		/// <summary>This feature can add a 16 x 16 image to the group title bar.</summary>
		[Category("Appearance"), Description("This feature can add a 16 x 16 image to the group title bar.")]
		public System.Drawing.Image GroupImage{get{return _vGroupImage;} set{_vGroupImage=value; this.Refresh();}}

		/// <summary>This feature will change the control's shadow color.</summary>
		[Category("Appearance"), Description("This feature will change the control's shadow color.")]
		public System.Drawing.Color ShadowColor{get{return _vShadowColor;} set{_vShadowColor=value; this.Refresh();}}

		/// <summary>This feature will change the size of the shadow border.</summary>
		[Category("Appearance"), Description("This feature will change the size of the shadow border.")]
		public int ShadowThickness
		{
			get{return _vShadowThickness;} 
			set
			{
				if(value>10)
				{
					_vShadowThickness=10;
				}
				else
				{
					if(value<1){_vShadowThickness=1;}
					else{_vShadowThickness=value; }
				}

				this.Refresh();
			}
		}

		
		/// <summary>This feature will change the group control color. This color can also be used in combination with BackgroundGradientColor for a gradient paint.</summary>
		[Category("Appearance"), Description("This feature will change the group control color. This color can also be used in combination with BackgroundGradientColor for a gradient paint.")]
		public System.Drawing.Color BackgroundColor{get{return _vBackgroundColor;} set{_vBackgroundColor=value; this.Refresh();}}

		/// <summary>This feature can be used in combination with BackgroundColor to create a gradient background.</summary>
		[Category("Appearance"), Description("This feature can be used in combination with BackgroundColor to create a gradient background.")]
		public System.Drawing.Color BackgroundGradientColor{get{return _vBackgroundGradientColor;} set{_vBackgroundGradientColor=value; this.Refresh();}}
		
		/// <summary>This feature turns on background gradient painting.</summary>
		[Category("Appearance"), Description("This feature turns on background gradient painting.")]
		public GroupBoxGradientMode BackgroundGradientMode{get{return _vBackgroundGradientMode;} set{_vBackgroundGradientMode=value; this.Refresh();}}

		/// <summary>This feature will round the corners of the control.</summary>
		[Category("Appearance"), Description("This feature will round the corners of the control.")]
		public int RoundCorners
		{
			get{return _vRoundCorners;} 
			set
			{
				if(value>25)
				{
					_vRoundCorners=25;
				}
				else
				{
					if(value<1){_vRoundCorners=1;}
					else{_vRoundCorners=value; }
				}
				
				this.Refresh();
			}
		}

		/// <summary>This feature will add a group title to the control.</summary>
		[Category("Appearance"), Description("This feature will add a group title to the control.")]
		public string GroupTitle{get{return _vGroupTitle;} set{_vGroupTitle=value; this.Refresh();}}

		/// <summary>This feature will allow you to change the color of the control's border.</summary>
		[Category("Appearance"), Description("This feature will allow you to change the color of the control's border.")]
		public System.Drawing.Color BorderColor{get{return _vBorderColor;} set{_vBorderColor=value; this.Refresh();}}

		/// <summary>This feature will allow you to set the control's border size.</summary>
		[Category("Appearance"), Description("This feature will allow you to set the control's border size.")]
		public float BorderThickness
		{
			get{return _vBorderThickness;} 
			set
			{
				if(value>3)
				{
					_vBorderThickness=3;
				}
				else
				{
					if(value<1){_vBorderThickness=1;}
					else{_vBorderThickness=value;}
				}
				this.Refresh();
			}
		}

		/// <summary>This feature will allow you to turn on control shadowing.</summary>
		[Category("Appearance"), Description("This feature will allow you to turn on control shadowing.")]
		public bool ShadowControl{get{return _vShadowControl;} set{_vShadowControl=value; this.Refresh();}}

		#endregion

		#region Constructor
		
		/// <summary>This method will construct a new GroupBox control.</summary>
		public Grouper()
		{
			InitializeStyles();
			InitializeGroupBox();
		}

	
		#endregion

		#region DeConstructor

		/// <summary>This method will dispose of the GroupBox control.</summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing){if(_components!=null){_components.Dispose();}}
			base.Dispose(disposing);
		}


		#endregion

		#region Initialization

		/// <summary>This method will initialize the controls custom styles.</summary>
		private void InitializeStyles()
		{
			//Set the control styles----------------------------------
			this.SetStyle(ControlStyles.DoubleBuffer, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.UserPaint, true);
			this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			//--------------------------------------------------------
		}


		/// <summary>This method will initialize the GroupBox control.</summary>
		private void InitializeGroupBox()
		{
			_components = new System.ComponentModel.Container();
			this.Resize+=new EventHandler(GroupBox_Resize);
			this.DockPadding.All = 20;
			this.Name = "GroupBox";
			this.Size = new System.Drawing.Size(368, 288);
		}

	
		#endregion

		#region Protected Methods
		
		/// <summary>Overrides the OnPaint method to paint control.</summary>
		/// <param name="e">The paint event arguments.</param>
		protected override void OnPaint(PaintEventArgs e)
		{
			PaintBack(e.Graphics);
			PaintGroupText(e.Graphics);
		}

		#endregion

		#region Private Methods

		/// <summary>This method will paint the group title.</summary>
		/// <param name="g">The paint event graphics object.</param>
		private void PaintGroupText(System.Drawing.Graphics g)
		{
			//Check if string has something-------------
			if(this.GroupTitle==string.Empty){return;}
			//------------------------------------------

			//Set Graphics smoothing mode to Anit-Alias-- 
			g.SmoothingMode = SmoothingMode.AntiAlias;
			//-------------------------------------------

			//Declare Variables------------------
			SizeF stringSize = g.MeasureString(this.GroupTitle, this.Font);
			Size stringSize2 = stringSize.ToSize();
			if(this.GroupImage!=null){stringSize2.Width+=18;}
			int arcWidth = this.RoundCorners;
			int arcHeight = this.RoundCorners;
			int arcX1 = 20;
			int arcX2 = (stringSize2.Width+34) - (arcWidth + 1);
			int arcY1 = 0;
			int arcY2 = 24 - (arcHeight + 1);
			System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
			System.Drawing.Brush borderBrush = new SolidBrush(this.BorderColor);
			System.Drawing.Pen borderPen = new Pen(borderBrush, this.BorderThickness);
			System.Drawing.Drawing2D.LinearGradientBrush backgroundGradientBrush = null;
			System.Drawing.Brush backgroundBrush = (this.PaintGroupBox) ? new SolidBrush(this.CustomGroupBoxColor) : new SolidBrush(this.BackgroundColor);
			System.Drawing.SolidBrush textColorBrush = new SolidBrush(this.ForeColor);
			System.Drawing.SolidBrush shadowBrush = null;
			System.Drawing.Drawing2D.GraphicsPath shadowPath  = null;
			//-----------------------------------

			//Check if shadow is needed----------
			if(this.ShadowControl)
			{
				shadowBrush = new SolidBrush(this.ShadowColor);
				shadowPath = new System.Drawing.Drawing2D.GraphicsPath();
				shadowPath.AddArc(arcX1+(this.ShadowThickness-1), arcY1+(this.ShadowThickness-1), arcWidth, arcHeight, 180, GroupBoxConstants.SweepAngle); // Top Left
				shadowPath.AddArc(arcX2+(this.ShadowThickness-1), arcY1+(this.ShadowThickness-1), arcWidth, arcHeight, 270, GroupBoxConstants.SweepAngle); //Top Right
				shadowPath.AddArc(arcX2+(this.ShadowThickness-1), arcY2+(this.ShadowThickness-1), arcWidth, arcHeight, 360, GroupBoxConstants.SweepAngle); //Bottom Right
				shadowPath.AddArc(arcX1+(this.ShadowThickness-1), arcY2+(this.ShadowThickness-1), arcWidth, arcHeight, 90, GroupBoxConstants.SweepAngle); //Bottom Left
				shadowPath.CloseAllFigures();

				//Paint Rounded Rectangle------------
				g.FillPath(shadowBrush, shadowPath);
				//-----------------------------------
			}
			//-----------------------------------

			//Create Rounded Rectangle Path------
			path.AddArc(arcX1, arcY1, arcWidth, arcHeight, 180, GroupBoxConstants.SweepAngle); // Top Left
			path.AddArc(arcX2, arcY1, arcWidth, arcHeight, 270, GroupBoxConstants.SweepAngle); //Top Right
			path.AddArc(arcX2, arcY2, arcWidth, arcHeight, 360, GroupBoxConstants.SweepAngle); //Bottom Right
			path.AddArc(arcX1, arcY2, arcWidth, arcHeight, 90, GroupBoxConstants.SweepAngle); //Bottom Left
			path.CloseAllFigures(); 
			//-----------------------------------

			//Check if Gradient Mode is enabled--
			if(this.PaintGroupBox)
			{
				//Paint Rounded Rectangle------------
				g.FillPath(backgroundBrush, path);
				//-----------------------------------
			}
			else
			{
				if(this.BackgroundGradientMode==GroupBoxGradientMode.None)
				{
					//Paint Rounded Rectangle------------
					g.FillPath(backgroundBrush, path);
					//-----------------------------------
				}
				else
				{
					backgroundGradientBrush = new LinearGradientBrush(new Rectangle(0,0,this.Width,this.Height), this.BackgroundColor, this.BackgroundGradientColor, (LinearGradientMode)this.BackgroundGradientMode);
				
					//Paint Rounded Rectangle------------
					g.FillPath(backgroundGradientBrush, path);
					//-----------------------------------
				}
			}
			//-----------------------------------

			//Paint Borded-----------------------
			g.DrawPath(borderPen, path);
			//-----------------------------------

			//Paint Text-------------------------
			int customStringWidth = (this.GroupImage!=null) ? 44 : 28;
			g.DrawString(this.GroupTitle, this.Font, textColorBrush, customStringWidth, 5);
			//-----------------------------------

			//Draw GroupImage if there is one----
			if(this.GroupImage!=null)
			{
				g.DrawImage(this.GroupImage, 28,4, 16, 16);
			}
			//-----------------------------------

			//Destroy Graphic Objects------------
			if(path!=null){path.Dispose();}
			if(borderBrush!=null){borderBrush.Dispose();}
			if(borderPen!=null){borderPen.Dispose();}
			if(backgroundGradientBrush!=null){backgroundGradientBrush.Dispose();}
			if(backgroundBrush!=null){backgroundBrush.Dispose();}
			if(textColorBrush!=null){textColorBrush .Dispose();}
			if(shadowBrush!=null){shadowBrush.Dispose();}
			if(shadowPath!=null){shadowPath.Dispose();}
			//-----------------------------------
		}

		
		/// <summary>This method will paint the control.</summary>
		/// <param name="g">The paint event graphics object.</param>
		private void PaintBack(System.Drawing.Graphics g)
		{
			//Set Graphics smoothing mode to Anit-Alias-- 
			g.SmoothingMode = SmoothingMode.AntiAlias;
			//-------------------------------------------

			//Declare Variables------------------
			int arcWidth = this.RoundCorners * 2;
			int arcHeight = this.RoundCorners * 2;
			int arcX1 = 0;
			int arcX2 = (this.ShadowControl) ? (this.Width - (arcWidth + 1))-this.ShadowThickness : this.Width - (arcWidth + 1);
			int arcY1 = 10;
			int arcY2 = (this.ShadowControl) ? (this.Height - (arcHeight + 1))-this.ShadowThickness : this.Height - (arcHeight + 1);
			System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
			System.Drawing.Brush borderBrush = new SolidBrush(this.BorderColor);
			System.Drawing.Pen borderPen = new Pen(borderBrush, this.BorderThickness);
			System.Drawing.Drawing2D.LinearGradientBrush backgroundGradientBrush = null;
			System.Drawing.Brush backgroundBrush = new SolidBrush(this.BackgroundColor);
			System.Drawing.SolidBrush shadowBrush = null;
			System.Drawing.Drawing2D.GraphicsPath shadowPath  = null;
			//-----------------------------------

			//Check if shadow is needed----------
			if(this.ShadowControl)
			{
				shadowBrush = new SolidBrush(this.ShadowColor);
				shadowPath = new System.Drawing.Drawing2D.GraphicsPath();
				shadowPath.AddArc(arcX1+this.ShadowThickness, arcY1+this.ShadowThickness, arcWidth, arcHeight, 180, GroupBoxConstants.SweepAngle); // Top Left
				shadowPath.AddArc(arcX2+this.ShadowThickness, arcY1+this.ShadowThickness, arcWidth, arcHeight, 270, GroupBoxConstants.SweepAngle); //Top Right
				shadowPath.AddArc(arcX2+this.ShadowThickness, arcY2+this.ShadowThickness, arcWidth, arcHeight, 360, GroupBoxConstants.SweepAngle); //Bottom Right
				shadowPath.AddArc(arcX1+this.ShadowThickness, arcY2+this.ShadowThickness, arcWidth, arcHeight, 90, GroupBoxConstants.SweepAngle); //Bottom Left
				shadowPath.CloseAllFigures();

				//Paint Rounded Rectangle------------
				g.FillPath(shadowBrush, shadowPath);
				//-----------------------------------
			}
			//-----------------------------------

			//Create Rounded Rectangle Path------
			path.AddArc(arcX1, arcY1, arcWidth, arcHeight, 180, GroupBoxConstants.SweepAngle); // Top Left
			path.AddArc(arcX2, arcY1, arcWidth, arcHeight, 270, GroupBoxConstants.SweepAngle); //Top Right
			path.AddArc(arcX2, arcY2, arcWidth, arcHeight, 360, GroupBoxConstants.SweepAngle); //Bottom Right
			path.AddArc(arcX1, arcY2, arcWidth, arcHeight, 90, GroupBoxConstants.SweepAngle); //Bottom Left
			path.CloseAllFigures(); 
			//-----------------------------------

			//Check if Gradient Mode is enabled--
			if(this.BackgroundGradientMode==GroupBoxGradientMode.None)
			{
				//Paint Rounded Rectangle------------
				g.FillPath(backgroundBrush, path);
				//-----------------------------------
			}
			else
			{
				backgroundGradientBrush = new LinearGradientBrush(new Rectangle(0,0,this.Width,this.Height), this.BackgroundColor, this.BackgroundGradientColor, (LinearGradientMode)this.BackgroundGradientMode);
				
				//Paint Rounded Rectangle------------
				g.FillPath(backgroundGradientBrush, path);
				//-----------------------------------
			}
			//-----------------------------------

			//Paint Borded-----------------------
			g.DrawPath(borderPen, path);
			//-----------------------------------

			//Destroy Graphic Objects------------
			if(path!=null){path.Dispose();}
			if(borderBrush!=null){borderBrush.Dispose();}
			if(borderPen!=null){borderPen.Dispose();}
			if(backgroundGradientBrush!=null){backgroundGradientBrush.Dispose();}
			if(backgroundBrush!=null){backgroundBrush.Dispose();}
			if(shadowBrush!=null){shadowBrush.Dispose();}
			if(shadowPath!=null){shadowPath.Dispose();}
			//-----------------------------------
		}

	
		/// <summary>This method fires when the GroupBox resize event occurs.</summary>
		/// <param name="sender">The object the sent the event.</param>
		/// <param name="e">The event arguments.</param>
		private void GroupBox_Resize(object sender, EventArgs e)
		{
			this.Refresh();
		}


		#endregion
	}
}

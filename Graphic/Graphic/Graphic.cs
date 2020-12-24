using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Graphic
{
	public partial class Graphic : Form
	{

		private Bitmap sprite, sprite2;
		private Bitmap backBuffer, backBuffer2;
		private Timer timer, timer2;
		public Graphics graphics, graphics2;
		private int index, index2;
		int limit = 5, limit2 = 3;
		List<string> Actions = new List<string>(), Actions2 = new List<string>();
		public Graphic()
		{
			InitializeComponent();
			
			graphics = this.CreateGraphics();
			graphics2 = this.CreateGraphics();
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			backBuffer = new Bitmap(150,150);
			backBuffer2 = new Bitmap(150, 150);
			sprite = new Bitmap("NewSprite.png");
			sprite2 = new Bitmap("Boss.png");
			index = 0;
			index2 = 0;
			timer = new Timer();
			timer.Enabled = true;
			timer.Interval = 100;
			timer.Tick += new EventHandler(timer_Tick);
			Actions = new List<string>{ "Idle","Walk","Attack","Dizzy","Die","Defend"};
			this.cbbAction.DataSource = Actions;
			cbbAction.SelectedIndex = 0;
			Actions2 = new List<string> { "Jump", "Attack", "Hurt","Die","Walk","Run","Sneer","Attack" };
			this.cbbAction2.DataSource = Actions2;
			cbbAction2.SelectedIndex = 0;
			timer2 = new Timer();
			timer2.Tick += new EventHandler(timer2_Tick);
			timer2.Enabled = true;
			timer2.Interval = 100;
		}
		private void Render()
		{
			Graphics g = Graphics.FromImage(backBuffer);
			g.Clear(Color.White);
			MultiChoice(g);
			g.Dispose();
			index++;
			if (index >= limit)
			{
				index = 0;
				//int k = cbbAction.SelectedIndex + 1;
				//if (k >= Actions.Count)
				//{
				//	cbbAction.SelectedIndex = 0;
				//}
				//else
				//	cbbAction.SelectedIndex = k;
			}
			else
			{
				index++;
			}

		}
		public void MultiChoice(Graphics g)
		{
			if(cbbAction.SelectedIndex==0)
			{
				g.DrawImage(sprite, 0, 0,
					new Rectangle(index * 68, 0, 68, 92), GraphicsUnit.Pixel);
				limit = 5;
				timer.Interval = 100;
			}	
			else if(cbbAction.SelectedIndex == 1)
			{
				g.DrawImage(sprite, 0, 0,
					new Rectangle(index * 71 , 94, 71, 92), GraphicsUnit.Pixel);
				limit = 5;
				timer.Interval = 100;
			}
			else if (cbbAction.SelectedIndex == 2)
			{
				g.DrawImage(sprite, 0, 0,
					new Rectangle(index * 135, 192, 135, 97), GraphicsUnit.Pixel);
				timer.Interval = 100;
				limit = 5;
			}
			else if (cbbAction.SelectedIndex == 3)
			{
				g.DrawImage(sprite, 0, 0,
					new Rectangle(index * 86, 300, 86, 86), GraphicsUnit.Pixel);
				timer.Interval = 100;
				limit = 2;
			}
			else if (cbbAction.SelectedIndex == 4)
			{
				g.DrawImage(sprite, 0, 0,
					new Rectangle(index * 100, 400, 96, 100), GraphicsUnit.Pixel);
				timer.Interval = 150;
				limit = 8;
			}
			else if(cbbAction.SelectedIndex==5)
			{
				g.DrawImage(sprite, 0, 0,
					new Rectangle(index * 150, 550, 130, 90), GraphicsUnit.Pixel);
				timer.Interval = 200;
				limit = 4;
			}	
		}
		public void MultiChoice2(Graphics g)
		{
			if (cbbAction2.SelectedIndex == 0)
			{
				g.DrawImage(sprite2, 0, 0,
					new Rectangle(index2 * 96, 0, 96, 96), GraphicsUnit.Pixel);
				limit2 = 3;
				timer2.Interval = 200;
			}
			else if (cbbAction2.SelectedIndex == 1)
			{
				g.DrawImage(sprite2, 0, 0,
					new Rectangle(index2 * 96, 103, 96, 96), GraphicsUnit.Pixel);
				limit2 = 3;
				timer2.Interval = 200;
			}
			else if (cbbAction2.SelectedIndex == 2)
			{
				g.DrawImage(sprite2, 0, 0,
					new Rectangle(index2 * 96, 206, 96, 96), GraphicsUnit.Pixel);
				limit2 = 3;
				timer2.Interval = 200;
			}
			else if (cbbAction2.SelectedIndex == 3)
			{
				g.DrawImage(sprite2, 0, 0,
					new Rectangle(index2 * 96, 308, 96, 96), GraphicsUnit.Pixel);
				limit2 = 5;
				timer2.Interval = 200;
			}
			else if (cbbAction2.SelectedIndex == 4)
			{
				g.DrawImage(sprite2, 0, 0,
					new Rectangle(index2 * 96, 404, 96, 96), GraphicsUnit.Pixel);
				limit2 = 5;
				timer2.Interval = 200;
			}
			else if (cbbAction2.SelectedIndex == 5)
			{
				g.DrawImage(sprite2, 0, 0,
					new Rectangle(index2 * 96, 500, 96, 96), GraphicsUnit.Pixel);
				limit2 = 5;
				timer2.Interval = 200;
			}
			else if (cbbAction2.SelectedIndex == 6)
			{
				g.DrawImage(sprite2, 0, 0,
					new Rectangle(index2 * 96, 597, 96, 96), GraphicsUnit.Pixel);
				limit2 = 5;
				timer2.Interval = 200;
			}
			else if (cbbAction2.SelectedIndex == 7)
			{
				g.DrawImage(sprite2, 0, 0,
					new Rectangle(index2 * 96, 690, 96, 96), GraphicsUnit.Pixel);
				limit2 = 5;
				timer2.Interval = 200;
			}
		}
		private void Render2()
		{
			Graphics g = Graphics.FromImage(backBuffer2);
			g.Clear(Color.White);
			MultiChoice2(g);
			g.Dispose();
			index2++;
			if (index2 >= limit2)
			{
				index2 = 0;
				//int k = cbbAction.SelectedIndex + 1;
				//if (k >= Actions.Count)
				//{
				//	cbbAction.SelectedIndex = 0;
				//}
				//else
				//	cbbAction.SelectedIndex = k;
			}
			else
			{
				index++;
			}

		}
		private void timer_Tick(object sender, EventArgs e)
		{
			Render();
			// Vẽ lên màn hình
			graphics.DrawImageUnscaled(backBuffer, 0, 0);
		}
		private void btPause_Click(object sender, EventArgs e)
		{
			if(btPause.Text=="Pause")
			{
				timer.Enabled = false;
				btPause.Text = "Play";
			}
			else
			{
				timer.Enabled = true;
				btPause.Text = "Pause";
			}	
		}
		private void btPause2_Click(object sender, EventArgs e)
		{
			if (btPause2.Text == "Pause")
			{
				timer2.Enabled = false;
				btPause2.Text = "Play";
			}
			else
			{
				timer2.Enabled = true;
				btPause2.Text = "Pause";
			}
		}
		private void timer2_Tick(object sender, EventArgs e)
		{
			Render2();
			// Vẽ lên màn hình
			graphics2.DrawImageUnscaled(backBuffer2, 200, 200);
		}
	}
}

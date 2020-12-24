namespace Graphic
{
	partial class Graphic
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbbAction = new System.Windows.Forms.ComboBox();
			this.btPause = new System.Windows.Forms.Button();
			this.cbbAction2 = new System.Windows.Forms.ComboBox();
			this.btPause2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbbAction
			// 
			this.cbbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbAction.Font = new System.Drawing.Font("SVN-Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbAction.FormattingEnabled = true;
			this.cbbAction.Location = new System.Drawing.Point(162, 12);
			this.cbbAction.Name = "cbbAction";
			this.cbbAction.Size = new System.Drawing.Size(173, 35);
			this.cbbAction.TabIndex = 0;
			// 
			// btPause
			// 
			this.btPause.Font = new System.Drawing.Font("SVN-Agency FB", 15.75F);
			this.btPause.Location = new System.Drawing.Point(354, 13);
			this.btPause.Name = "btPause";
			this.btPause.Size = new System.Drawing.Size(83, 34);
			this.btPause.TabIndex = 1;
			this.btPause.Text = "Pause";
			this.btPause.UseVisualStyleBackColor = true;
			this.btPause.Click += new System.EventHandler(this.btPause_Click);
			// 
			// cbbAction2
			// 
			this.cbbAction2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbAction2.Font = new System.Drawing.Font("SVN-Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbAction2.FormattingEnabled = true;
			this.cbbAction2.Location = new System.Drawing.Point(162, 138);
			this.cbbAction2.Name = "cbbAction2";
			this.cbbAction2.Size = new System.Drawing.Size(173, 35);
			this.cbbAction2.TabIndex = 0;
			// 
			// btPause2
			// 
			this.btPause2.Font = new System.Drawing.Font("SVN-Agency FB", 15.75F);
			this.btPause2.Location = new System.Drawing.Point(354, 137);
			this.btPause2.Name = "btPause2";
			this.btPause2.Size = new System.Drawing.Size(83, 36);
			this.btPause2.TabIndex = 1;
			this.btPause2.Text = "Pause";
			this.btPause2.UseVisualStyleBackColor = true;
			this.btPause2.Click += new System.EventHandler(this.btPause2_Click);
			// 
			// Graphic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 395);
			this.Controls.Add(this.btPause2);
			this.Controls.Add(this.btPause);
			this.Controls.Add(this.cbbAction2);
			this.Controls.Add(this.cbbAction);
			this.Name = "Graphic";
			this.Text = "Graphic";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbbAction;
		private System.Windows.Forms.Button btPause;
		private System.Windows.Forms.ComboBox cbbAction2;
		private System.Windows.Forms.Button btPause2;
	}
}
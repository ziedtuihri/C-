﻿/*
 * Created by SharpDevelop.
 * User: zied
 * Date: 27-May-19
 * Time: 17:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace window1
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(80, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "titre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(80, 192);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "annee";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Violet;
			this.textBox1.Location = new System.Drawing.Point(246, 74);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(148, 20);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.Yellow;
			this.textBox2.Location = new System.Drawing.Point(246, 139);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(148, 20);
			this.textBox2.TabIndex = 3;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.textBox3.Location = new System.Drawing.Point(246, 192);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(148, 20);
			this.textBox3.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(80, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "age";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Coral;
			this.button1.Location = new System.Drawing.Point(580, 270);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 43);
			this.button1.TabIndex = 6;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button2.Location = new System.Drawing.Point(438, 270);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(91, 42);
			this.button2.TabIndex = 7;
			this.button2.Text = "annuler";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Chartreuse;
			this.button3.Location = new System.Drawing.Point(63, 269);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(92, 43);
			this.button3.TabIndex = 8;
			this.button3.Text = "recherche";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Chocolate;
			this.button4.Location = new System.Drawing.Point(183, 269);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(91, 42);
			this.button4.TabIndex = 9;
			this.button4.Text = "modifier";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button5.Location = new System.Drawing.Point(297, 269);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(88, 42);
			this.button5.TabIndex = 10;
			this.button5.Text = "close";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 342);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

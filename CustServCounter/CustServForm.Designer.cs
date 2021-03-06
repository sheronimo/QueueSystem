﻿/*
 * Created by SharpDevelop.
 * User: waluigi
 * Date: 23-Mar-17
 * Time: 9:07 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
 
namespace CustServCounter
{
	partial class CustServForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileMenuButton;
		private System.Windows.Forms.ToolStripMenuItem csSelector;
		private System.Windows.Forms.ToolStripMenuItem cs01Option;
		private System.Windows.Forms.ToolStripMenuItem cs02Option;
		private System.Windows.Forms.ToolStripMenuItem cs03Option;
		private System.Windows.Forms.ToolStripMenuItem cs04Option;
		private System.Windows.Forms.ToolStripMenuItem cs05Option;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpMenuButton;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.Label csIDLabel;
		private System.Windows.Forms.TextBox csIDTextBox;
		private System.Windows.Forms.Button callButton;
		private System.Windows.Forms.Button recallButton;
		private System.Windows.Forms.Label currServLabel;
		private System.Windows.Forms.Label queueTotalLabel;
		private System.Windows.Forms.TextBox queueTotalTextBox;
		private System.Windows.Forms.TextBox currServTextBox;
		
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
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustServForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this.csSelector = new System.Windows.Forms.ToolStripMenuItem();
			this.cs01Option = new System.Windows.Forms.ToolStripMenuItem();
			this.cs02Option = new System.Windows.Forms.ToolStripMenuItem();
			this.cs03Option = new System.Windows.Forms.ToolStripMenuItem();
			this.cs04Option = new System.Windows.Forms.ToolStripMenuItem();
			this.cs05Option = new System.Windows.Forms.ToolStripMenuItem();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.csIDLabel = new System.Windows.Forms.Label();
			this.csIDTextBox = new System.Windows.Forms.TextBox();
			this.callButton = new System.Windows.Forms.Button();
			this.recallButton = new System.Windows.Forms.Button();
			this.currServLabel = new System.Windows.Forms.Label();
			this.queueTotalLabel = new System.Windows.Forms.Label();
			this.queueTotalTextBox = new System.Windows.Forms.TextBox();
			this.currServTextBox = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileMenuButton,
			this.helpMenuButton});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(764, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "mainMenuStrip";
			// 
			// fileMenuButton
			// 
			this.fileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.csSelector,
			this.exitMenuItem});
			this.fileMenuButton.Name = "fileMenuButton";
			this.fileMenuButton.Size = new System.Drawing.Size(37, 20);
			this.fileMenuButton.Text = "File";
			// 
			// csSelector
			// 
			this.csSelector.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cs01Option,
			this.cs02Option,
			this.cs03Option,
			this.cs04Option,
			this.cs05Option});
			this.csSelector.Name = "csSelector";
			this.csSelector.Size = new System.Drawing.Size(122, 22);
			this.csSelector.Text = "CS Select";
			// 
			// cs01Option
			// 
			this.cs01Option.Name = "cs01Option";
			this.cs01Option.Size = new System.Drawing.Size(105, 22);
			this.cs01Option.Text = "CS-01";
			this.cs01Option.Click += new System.EventHandler(this.CSIDOptionClick);
			// 
			// cs02Option
			// 
			this.cs02Option.Name = "cs02Option";
			this.cs02Option.Size = new System.Drawing.Size(105, 22);
			this.cs02Option.Text = "CS-02";
			this.cs02Option.Click += new System.EventHandler(this.CSIDOptionClick);
			// 
			// cs03Option
			// 
			this.cs03Option.Name = "cs03Option";
			this.cs03Option.Size = new System.Drawing.Size(105, 22);
			this.cs03Option.Text = "CS-03";
			this.cs03Option.Click += new System.EventHandler(this.CSIDOptionClick);
			// 
			// cs04Option
			// 
			this.cs04Option.Name = "cs04Option";
			this.cs04Option.Size = new System.Drawing.Size(105, 22);
			this.cs04Option.Text = "CS-04";
			this.cs04Option.Click += new System.EventHandler(this.CSIDOptionClick);
			// 
			// cs05Option
			// 
			this.cs05Option.Name = "cs05Option";
			this.cs05Option.Size = new System.Drawing.Size(105, 22);
			this.cs05Option.Text = "CS-05";
			this.cs05Option.Click += new System.EventHandler(this.CSIDOptionClick);
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(122, 22);
			this.exitMenuItem.Text = "Exit";
			this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItemClick);
			// 
			// helpMenuButton
			// 
			this.helpMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutMenuItem});
			this.helpMenuButton.Name = "helpMenuButton";
			this.helpMenuButton.Size = new System.Drawing.Size(44, 20);
			this.helpMenuButton.Text = "Help";
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutMenuItem.Text = "About";
			// 
			// csIDLabel
			// 
			this.csIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.csIDLabel.Location = new System.Drawing.Point(652, 27);
			this.csIDLabel.Name = "csIDLabel";
			this.csIDLabel.Size = new System.Drawing.Size(60, 30);
			this.csIDLabel.TabIndex = 1;
			this.csIDLabel.Text = "CS #";
			// 
			// csIDTextBox
			// 
			this.csIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.csIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.csIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.csIDTextBox.Location = new System.Drawing.Point(707, 27);
			this.csIDTextBox.Name = "csIDTextBox";
			this.csIDTextBox.ReadOnly = true;
			this.csIDTextBox.Size = new System.Drawing.Size(47, 23);
			this.csIDTextBox.TabIndex = 2;
			// 
			// callButton
			// 
			this.callButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.callButton.Image = ((System.Drawing.Image)(resources.GetObject("callButton.Image")));
			this.callButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.callButton.Location = new System.Drawing.Point(38, 90);
			this.callButton.Name = "callButton";
			this.callButton.Size = new System.Drawing.Size(230, 230);
			this.callButton.TabIndex = 3;
			this.callButton.Text = "Call Next";
			this.callButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.callButton.UseVisualStyleBackColor = true;
			this.callButton.Click += new System.EventHandler(this.CallButtonClick);
			// 
			// recallButton
			// 
			this.recallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.recallButton.Image = ((System.Drawing.Image)(resources.GetObject("recallButton.Image")));
			this.recallButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.recallButton.Location = new System.Drawing.Point(306, 90);
			this.recallButton.Name = "recallButton";
			this.recallButton.Size = new System.Drawing.Size(230, 230);
			this.recallButton.TabIndex = 4;
			this.recallButton.Text = "Call Again";
			this.recallButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.recallButton.UseVisualStyleBackColor = true;
			// 
			// currServLabel
			// 
			this.currServLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currServLabel.Location = new System.Drawing.Point(38, 360);
			this.currServLabel.Name = "currServLabel";
			this.currServLabel.Size = new System.Drawing.Size(345, 48);
			this.currServLabel.TabIndex = 5;
			this.currServLabel.Text = "Currently Serving: ";
			// 
			// queueTotalLabel
			// 
			this.queueTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.queueTotalLabel.Location = new System.Drawing.Point(38, 448);
			this.queueTotalLabel.Name = "queueTotalLabel";
			this.queueTotalLabel.Size = new System.Drawing.Size(257, 43);
			this.queueTotalLabel.TabIndex = 6;
			this.queueTotalLabel.Text = "Queue Total: ";
			// 
			// queueTotalTextBox
			// 
			this.queueTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.queueTotalTextBox.Location = new System.Drawing.Point(301, 445);
			this.queueTotalTextBox.Name = "queueTotalTextBox";
			this.queueTotalTextBox.ReadOnly = true;
			this.queueTotalTextBox.Size = new System.Drawing.Size(133, 53);
			this.queueTotalTextBox.TabIndex = 7;
			// 
			// currServTextBox
			// 
			this.currServTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currServTextBox.Location = new System.Drawing.Point(389, 355);
			this.currServTextBox.Name = "currServTextBox";
			this.currServTextBox.ReadOnly = true;
			this.currServTextBox.Size = new System.Drawing.Size(133, 53);
			this.currServTextBox.TabIndex = 8;
			// 
			// CustServForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 541);
			this.Controls.Add(this.currServTextBox);
			this.Controls.Add(this.queueTotalTextBox);
			this.Controls.Add(this.queueTotalLabel);
			this.Controls.Add(this.currServLabel);
			this.Controls.Add(this.recallButton);
			this.Controls.Add(this.callButton);
			this.Controls.Add(this.csIDTextBox);
			this.Controls.Add(this.csIDLabel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "CustServForm";
			this.Text = "Qbe - CS Counter";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustServFormFormClosing);
			this.Load += new System.EventHandler(this.CustServFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

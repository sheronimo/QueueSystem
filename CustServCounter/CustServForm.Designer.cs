/*
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
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.Label csIDLabel;
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
            this.csSelectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csIDLabel = new System.Windows.Forms.Label();
            this.csIDTextBox = new System.Windows.Forms.TextBox();
            this.callButton = new System.Windows.Forms.Button();
            this.recallButton = new System.Windows.Forms.Button();
            this.currServLabel = new System.Windows.Forms.Label();
            this.queueTotalLabel = new System.Windows.Forms.Label();
            this.queueTotalTextBox = new System.Windows.Forms.TextBox();
            this.currServTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyboardShortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuButton,
            this.viewToolStripMenuItem,
            this.helpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mainMenuStrip";
            // 
            // fileMenuButton
            // 
            this.fileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csSelectMenuItem,
            this.exitMenuItem});
            this.fileMenuButton.Name = "fileMenuButton";
            this.fileMenuButton.Size = new System.Drawing.Size(37, 20);
            this.fileMenuButton.Text = "File";
            // 
            // csSelectMenuItem
            // 
            this.csSelectMenuItem.Name = "csSelectMenuItem";
            this.csSelectMenuItem.Size = new System.Drawing.Size(128, 22);
            this.csSelectMenuItem.Text = "CS Select..";
            this.csSelectMenuItem.Click += new System.EventHandler(this.CSSelectMenuItemClick);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItemClick);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // csIDLabel
            // 
            this.csIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.csIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csIDLabel.Location = new System.Drawing.Point(675, 27);
            this.csIDLabel.Name = "csIDLabel";
            this.csIDLabel.Size = new System.Drawing.Size(57, 30);
            this.csIDLabel.TabIndex = 1;
            this.csIDLabel.Text = "CS #";
            // 
            // csIDTextBox
            // 
            this.csIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.csIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.csIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.csIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csIDTextBox.Location = new System.Drawing.Point(729, 27);
            this.csIDTextBox.Name = "csIDTextBox";
            this.csIDTextBox.ReadOnly = true;
            this.csIDTextBox.Size = new System.Drawing.Size(25, 23);
            this.csIDTextBox.TabIndex = 2;
            this.csIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.recallButton.Click += new System.EventHandler(this.RecallButtonClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "© Trisensa Diagnostic Centre";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(608, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 95);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Shift + C - Call Next";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Shift + R - Call Again";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Shift + S - CS Select";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "F2 - Show/Hide Shortcut List";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyboardShortcutsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // keyboardShortcutsToolStripMenuItem
            // 
            this.keyboardShortcutsToolStripMenuItem.Name = "keyboardShortcutsToolStripMenuItem";
            this.keyboardShortcutsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.keyboardShortcutsToolStripMenuItem.Text = "Keyboard Shortcuts";
            this.keyboardShortcutsToolStripMenuItem.Click += new System.EventHandler(this.keyboardShortcutsToolStripMenuItem_Click);
            // 
            // CustServForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.csIDTextBox);
            this.Controls.Add(this.csIDLabel);
            this.Controls.Add(this.currServTextBox);
            this.Controls.Add(this.queueTotalTextBox);
            this.Controls.Add(this.queueTotalLabel);
            this.Controls.Add(this.currServLabel);
            this.Controls.Add(this.recallButton);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustServForm";
            this.Text = "Qbe - CS Counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustServFormClosing);
            this.Load += new System.EventHandler(this.CustServFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustServForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.TextBox csIDTextBox;
        private System.Windows.Forms.ToolStripMenuItem csSelectMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyboardShortcutsToolStripMenuItem;
    }
}

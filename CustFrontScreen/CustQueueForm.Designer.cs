/*
 * Created by SharpDevelop.
 * User: waluigi
 * Date: 23-Mar-17
 * Time: 3:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CustReceptionArea
{
	partial class CustQueueForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button takeNumButton;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustQueueForm));
            this.takeNumButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.queueNumTextBox = new System.Windows.Forms.TextBox();
            this.totalQueueLabel = new System.Windows.Forms.Label();
            this.totalQueueTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // takeNumButton
            // 
            this.takeNumButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.takeNumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeNumButton.Location = new System.Drawing.Point(99, 55);
            this.takeNumButton.Name = "takeNumButton";
            this.takeNumButton.Size = new System.Drawing.Size(250, 250);
            this.takeNumButton.TabIndex = 0;
            this.takeNumButton.Text = "Take Number";
            this.takeNumButton.UseVisualStyleBackColor = true;
            this.takeNumButton.Click += new System.EventHandler(this.TakeNumButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(827, 534);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 55);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // queueNumTextBox
            // 
            this.queueNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.queueNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueNumTextBox.Location = new System.Drawing.Point(603, 133);
            this.queueNumTextBox.Name = "queueNumTextBox";
            this.queueNumTextBox.ReadOnly = true;
            this.queueNumTextBox.Size = new System.Drawing.Size(155, 68);
            this.queueNumTextBox.TabIndex = 2;
            this.queueNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalQueueLabel
            // 
            this.totalQueueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.totalQueueLabel.AutoSize = true;
            this.totalQueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQueueLabel.Location = new System.Drawing.Point(95, 381);
            this.totalQueueLabel.Name = "totalQueueLabel";
            this.totalQueueLabel.Size = new System.Drawing.Size(462, 54);
            this.totalQueueLabel.TabIndex = 4;
            this.totalQueueLabel.Text = "Current Total Queue:";
            // 
            // totalQueueTextBox
            // 
            this.totalQueueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.totalQueueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQueueTextBox.Location = new System.Drawing.Point(603, 374);
            this.totalQueueTextBox.Name = "totalQueueTextBox";
            this.totalQueueTextBox.ReadOnly = true;
            this.totalQueueTextBox.Size = new System.Drawing.Size(155, 68);
            this.totalQueueTextBox.TabIndex = 5;
            this.totalQueueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 64);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "© Trisensa Diagnostic Centre";
            // 
            // CustQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.totalQueueTextBox);
            this.Controls.Add(this.totalQueueLabel);
            this.Controls.Add(this.queueNumTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.takeNumButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustQueueForm";
            this.Text = "Qbe - Reception Area";
            this.Load += new System.EventHandler(this.CustQueueFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustQueueFormKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox queueNumTextBox;
        private System.Windows.Forms.Label totalQueueLabel;
        private System.Windows.Forms.TextBox totalQueueTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

/*
 * Created by SharpDevelop.
 * User: waluigi
 * Date: 23-Mar-17
 * Time: 3:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CustFrontScreen
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button takeQueueNumButton;
		
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
			this.takeQueueNumButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// takeQueueNumButton
			// 
			this.takeQueueNumButton.Location = new System.Drawing.Point(75, 33);
			this.takeQueueNumButton.Name = "takeQueueNumButton";
			this.takeQueueNumButton.Size = new System.Drawing.Size(128, 128);
			this.takeQueueNumButton.TabIndex = 0;
			this.takeQueueNumButton.Text = "button1";
			this.takeQueueNumButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 311);
			this.ControlBox = false;
			this.Controls.Add(this.takeQueueNumButton);
			this.Name = "MainForm";
			this.Text = "CustFrontScreen";
			this.ResumeLayout(false);

		}
	}
}

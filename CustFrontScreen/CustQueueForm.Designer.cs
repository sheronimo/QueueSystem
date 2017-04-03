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
            this.arrowLabel = new System.Windows.Forms.Label();
            this.totalQueueLabel = new System.Windows.Forms.Label();
            this.totalQueueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // takeNumButton
            // 
            this.takeNumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeNumButton.Location = new System.Drawing.Point(93, 60);
            this.takeNumButton.Name = "takeNumButton";
            this.takeNumButton.Size = new System.Drawing.Size(180, 180);
            this.takeNumButton.TabIndex = 0;
            this.takeNumButton.Text = "Take Number";
            this.takeNumButton.UseVisualStyleBackColor = true;
            this.takeNumButton.Click += new System.EventHandler(this.TakeNumButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(607, 384);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 45);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // queueNumTextBox
            // 
            this.queueNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueNumTextBox.Location = new System.Drawing.Point(425, 124);
            this.queueNumTextBox.Name = "queueNumTextBox";
            this.queueNumTextBox.ReadOnly = true;
            this.queueNumTextBox.Size = new System.Drawing.Size(130, 53);
            this.queueNumTextBox.TabIndex = 2;
            this.queueNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // arrowLabel
            // 
            this.arrowLabel.AutoSize = true;
            this.arrowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowLabel.Location = new System.Drawing.Point(314, 127);
            this.arrowLabel.Name = "arrowLabel";
            this.arrowLabel.Size = new System.Drawing.Size(66, 46);
            this.arrowLabel.TabIndex = 3;
            this.arrowLabel.Text = "⟶";
            // 
            // totalQueueLabel
            // 
            this.totalQueueLabel.AutoSize = true;
            this.totalQueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQueueLabel.Location = new System.Drawing.Point(87, 302);
            this.totalQueueLabel.Name = "totalQueueLabel";
            this.totalQueueLabel.Size = new System.Drawing.Size(269, 31);
            this.totalQueueLabel.TabIndex = 4;
            this.totalQueueLabel.Text = "Current Total Queue:";
            // 
            // totalQueueTextBox
            // 
            this.totalQueueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQueueTextBox.Location = new System.Drawing.Point(425, 288);
            this.totalQueueTextBox.Name = "totalQueueTextBox";
            this.totalQueueTextBox.ReadOnly = true;
            this.totalQueueTextBox.Size = new System.Drawing.Size(130, 53);
            this.totalQueueTextBox.TabIndex = 5;
            this.totalQueueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CustQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.ControlBox = false;
            this.Controls.Add(this.totalQueueTextBox);
            this.Controls.Add(this.totalQueueLabel);
            this.Controls.Add(this.arrowLabel);
            this.Controls.Add(this.queueNumTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.takeNumButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustQueueForm";
            this.Text = "Qbe - Reception Area";
            this.Load += new System.EventHandler(this.CustQueueFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustQueueFormKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox queueNumTextBox;
        private System.Windows.Forms.Label arrowLabel;
        private System.Windows.Forms.Label totalQueueLabel;
        private System.Windows.Forms.TextBox totalQueueTextBox;
    }
}

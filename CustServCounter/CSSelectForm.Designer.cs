namespace CustServCounter
{
    partial class CSSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSSelectForm));
            this.csOptionGroupBox = new System.Windows.Forms.GroupBox();
            this.cs05Option = new System.Windows.Forms.RadioButton();
            this.cs04Option = new System.Windows.Forms.RadioButton();
            this.cs03Option = new System.Windows.Forms.RadioButton();
            this.cs02Option = new System.Windows.Forms.RadioButton();
            this.cs01Option = new System.Windows.Forms.RadioButton();
            this.enterButton = new System.Windows.Forms.Button();
            this.csOptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // csOptionGroupBox
            // 
            this.csOptionGroupBox.Controls.Add(this.cs05Option);
            this.csOptionGroupBox.Controls.Add(this.cs04Option);
            this.csOptionGroupBox.Controls.Add(this.cs03Option);
            this.csOptionGroupBox.Controls.Add(this.cs02Option);
            this.csOptionGroupBox.Controls.Add(this.cs01Option);
            this.csOptionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.csOptionGroupBox.Name = "csOptionGroupBox";
            this.csOptionGroupBox.Size = new System.Drawing.Size(260, 200);
            this.csOptionGroupBox.TabIndex = 0;
            this.csOptionGroupBox.TabStop = false;
            // 
            // cs05Option
            // 
            this.cs05Option.AutoSize = true;
            this.cs05Option.Location = new System.Drawing.Point(7, 167);
            this.cs05Option.Name = "cs05Option";
            this.cs05Option.Size = new System.Drawing.Size(54, 17);
            this.cs05Option.TabIndex = 4;
            this.cs05Option.TabStop = true;
            this.cs05Option.Text = "CS-05";
            this.cs05Option.UseVisualStyleBackColor = true;
            // 
            // cs04Option
            // 
            this.cs04Option.AutoSize = true;
            this.cs04Option.Location = new System.Drawing.Point(6, 130);
            this.cs04Option.Name = "cs04Option";
            this.cs04Option.Size = new System.Drawing.Size(54, 17);
            this.cs04Option.TabIndex = 3;
            this.cs04Option.TabStop = true;
            this.cs04Option.Text = "CS-04";
            this.cs04Option.UseVisualStyleBackColor = true;
            // 
            // cs03Option
            // 
            this.cs03Option.AutoSize = true;
            this.cs03Option.Location = new System.Drawing.Point(6, 93);
            this.cs03Option.Name = "cs03Option";
            this.cs03Option.Size = new System.Drawing.Size(54, 17);
            this.cs03Option.TabIndex = 2;
            this.cs03Option.TabStop = true;
            this.cs03Option.Text = "CS-03";
            this.cs03Option.UseVisualStyleBackColor = true;
            // 
            // cs02Option
            // 
            this.cs02Option.AutoSize = true;
            this.cs02Option.Location = new System.Drawing.Point(6, 56);
            this.cs02Option.Name = "cs02Option";
            this.cs02Option.Size = new System.Drawing.Size(54, 17);
            this.cs02Option.TabIndex = 1;
            this.cs02Option.TabStop = true;
            this.cs02Option.Text = "CS-02";
            this.cs02Option.UseVisualStyleBackColor = true;
            // 
            // cs01Option
            // 
            this.cs01Option.AutoSize = true;
            this.cs01Option.Location = new System.Drawing.Point(6, 19);
            this.cs01Option.Name = "cs01Option";
            this.cs01Option.Size = new System.Drawing.Size(54, 17);
            this.cs01Option.TabIndex = 0;
            this.cs01Option.TabStop = true;
            this.cs01Option.Text = "CS-01";
            this.cs01Option.UseVisualStyleBackColor = true;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(105, 224);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.EnterButtonClick);
            // 
            // CSSelectForm
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.csOptionGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CSSelectForm";
            this.Text = "Qbe - CS Selector";
            this.csOptionGroupBox.ResumeLayout(false);
            this.csOptionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox csOptionGroupBox;
        private System.Windows.Forms.RadioButton cs05Option;
        private System.Windows.Forms.RadioButton cs04Option;
        private System.Windows.Forms.RadioButton cs03Option;
        private System.Windows.Forms.RadioButton cs02Option;
        private System.Windows.Forms.RadioButton cs01Option;
        private System.Windows.Forms.Button enterButton;
    }
}
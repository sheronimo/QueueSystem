namespace CustReceptionArea
{
    partial class PassVerifForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassVerifForm));
            this.warningLabel = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.passVerifButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(7, 11);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(301, 17);
            this.warningLabel.TabIndex = 0;
            this.warningLabel.Text = "Please enter the password to exit the program!";
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(10, 46);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '•';
            this.passTextBox.Size = new System.Drawing.Size(212, 26);
            this.passTextBox.TabIndex = 1;
            // 
            // passVerifButton
            // 
            this.passVerifButton.Location = new System.Drawing.Point(229, 46);
            this.passVerifButton.Name = "passVerifButton";
            this.passVerifButton.Size = new System.Drawing.Size(75, 26);
            this.passVerifButton.TabIndex = 2;
            this.passVerifButton.Text = "Enter!";
            this.passVerifButton.UseVisualStyleBackColor = true;
            this.passVerifButton.Click += new System.EventHandler(this.PassVerifButtonClick);
            // 
            // PassVerifForm
            // 
            this.AcceptButton = this.passVerifButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 99);
            this.Controls.Add(this.passVerifButton);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.warningLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PassVerifForm";
            this.Text = "Qbe - Password Verification";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassVerifFormKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button passVerifButton;
    }
}
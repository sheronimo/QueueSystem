namespace TVScreenDisplay
{
    partial class TVScreenForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TVScreenForm));
            this.cs01Label = new System.Windows.Forms.Label();
            this.cs02Label = new System.Windows.Forms.Label();
            this.cs03Label = new System.Windows.Forms.Label();
            this.cs04Label = new System.Windows.Forms.Label();
            this.cs05Label = new System.Windows.Forms.Label();
            this.cs01TextBox = new System.Windows.Forms.TextBox();
            this.cs04TextBox = new System.Windows.Forms.TextBox();
            this.cs02TextBox = new System.Windows.Forms.TextBox();
            this.cs03TextBox = new System.Windows.Forms.TextBox();
            this.cs05TextBox = new System.Windows.Forms.TextBox();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cs01Label
            // 
            this.cs01Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cs01Label.AutoSize = true;
            this.cs01Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs01Label.Location = new System.Drawing.Point(93, 94);
            this.cs01Label.Name = "cs01Label";
            this.cs01Label.Size = new System.Drawing.Size(180, 63);
            this.cs01Label.TabIndex = 0;
            this.cs01Label.Text = "CS-01";
            // 
            // cs02Label
            // 
            this.cs02Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cs02Label.AutoSize = true;
            this.cs02Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs02Label.Location = new System.Drawing.Point(380, 94);
            this.cs02Label.Name = "cs02Label";
            this.cs02Label.Size = new System.Drawing.Size(180, 63);
            this.cs02Label.TabIndex = 1;
            this.cs02Label.Text = "CS-02";
            // 
            // cs03Label
            // 
            this.cs03Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cs03Label.AutoSize = true;
            this.cs03Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs03Label.Location = new System.Drawing.Point(667, 94);
            this.cs03Label.Name = "cs03Label";
            this.cs03Label.Size = new System.Drawing.Size(180, 63);
            this.cs03Label.TabIndex = 2;
            this.cs03Label.Text = "CS-03";
            // 
            // cs04Label
            // 
            this.cs04Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cs04Label.AutoSize = true;
            this.cs04Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs04Label.Location = new System.Drawing.Point(93, 347);
            this.cs04Label.Name = "cs04Label";
            this.cs04Label.Size = new System.Drawing.Size(180, 63);
            this.cs04Label.TabIndex = 3;
            this.cs04Label.Text = "CS-04";
            // 
            // cs05Label
            // 
            this.cs05Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cs05Label.AutoSize = true;
            this.cs05Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs05Label.Location = new System.Drawing.Point(380, 347);
            this.cs05Label.Name = "cs05Label";
            this.cs05Label.Size = new System.Drawing.Size(180, 63);
            this.cs05Label.TabIndex = 4;
            this.cs05Label.Text = "CS-05";
            // 
            // cs01TextBox
            // 
            this.cs01TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cs01TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cs01TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs01TextBox.Location = new System.Drawing.Point(128, 182);
            this.cs01TextBox.Name = "cs01TextBox";
            this.cs01TextBox.ReadOnly = true;
            this.cs01TextBox.Size = new System.Drawing.Size(110, 53);
            this.cs01TextBox.TabIndex = 5;
            this.cs01TextBox.Text = "0";
            this.cs01TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cs01TextBox.TextChanged += new System.EventHandler(this.CS01TextBoxTextChanged);
            // 
            // cs04TextBox
            // 
            this.cs04TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cs04TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cs04TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs04TextBox.Location = new System.Drawing.Point(128, 435);
            this.cs04TextBox.Name = "cs04TextBox";
            this.cs04TextBox.ReadOnly = true;
            this.cs04TextBox.Size = new System.Drawing.Size(110, 53);
            this.cs04TextBox.TabIndex = 6;
            this.cs04TextBox.Text = "0";
            this.cs04TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cs04TextBox.TextChanged += new System.EventHandler(this.CS04TextBoxTextChanged);
            // 
            // cs02TextBox
            // 
            this.cs02TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cs02TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cs02TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs02TextBox.Location = new System.Drawing.Point(415, 182);
            this.cs02TextBox.Name = "cs02TextBox";
            this.cs02TextBox.ReadOnly = true;
            this.cs02TextBox.Size = new System.Drawing.Size(110, 53);
            this.cs02TextBox.TabIndex = 7;
            this.cs02TextBox.Text = "0";
            this.cs02TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cs02TextBox.TextChanged += new System.EventHandler(this.CS02TextBoxTextChanged);
            // 
            // cs03TextBox
            // 
            this.cs03TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cs03TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cs03TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs03TextBox.Location = new System.Drawing.Point(702, 182);
            this.cs03TextBox.Name = "cs03TextBox";
            this.cs03TextBox.ReadOnly = true;
            this.cs03TextBox.Size = new System.Drawing.Size(110, 53);
            this.cs03TextBox.TabIndex = 8;
            this.cs03TextBox.Text = "0";
            this.cs03TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cs03TextBox.TextChanged += new System.EventHandler(this.CS03TextBoxTextChanged);
            // 
            // cs05TextBox
            // 
            this.cs05TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cs05TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cs05TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs05TextBox.Location = new System.Drawing.Point(415, 435);
            this.cs05TextBox.Name = "cs05TextBox";
            this.cs05TextBox.ReadOnly = true;
            this.cs05TextBox.Size = new System.Drawing.Size(110, 53);
            this.cs05TextBox.TabIndex = 9;
            this.cs05TextBox.Text = "0";
            this.cs05TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cs05TextBox.TextChanged += new System.EventHandler(this.CS05TextBoxTextChanged);
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(752, 573);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(0, 22);
            this.dateTimeLabel.TabIndex = 15;
            this.dateTimeLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // dateTime
            // 
            this.dateTime.Enabled = true;
            this.dateTime.Interval = 1000;
            this.dateTime.Tick += new System.EventHandler(this.DateTimeTick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "© Trisensa Diagnostic Centre";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(40, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(860, 2);
            this.label2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(327, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 520);
            this.label3.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(614, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 520);
            this.label4.TabIndex = 24;
            // 
            // TVScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.cs05TextBox);
            this.Controls.Add(this.cs03TextBox);
            this.Controls.Add(this.cs02TextBox);
            this.Controls.Add(this.cs04TextBox);
            this.Controls.Add(this.cs01TextBox);
            this.Controls.Add(this.cs05Label);
            this.Controls.Add(this.cs04Label);
            this.Controls.Add(this.cs03Label);
            this.Controls.Add(this.cs02Label);
            this.Controls.Add(this.cs01Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TVScreenForm";
            this.Text = "Qbe - TV Screen Display";
            this.Load += new System.EventHandler(this.TVScreenFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cs01Label;
        private System.Windows.Forms.Label cs02Label;
        private System.Windows.Forms.Label cs03Label;
        private System.Windows.Forms.Label cs04Label;
        private System.Windows.Forms.Label cs05Label;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Timer dateTime;
        public System.Windows.Forms.TextBox cs01TextBox;
        public System.Windows.Forms.TextBox cs04TextBox;
        public System.Windows.Forms.TextBox cs02TextBox;
        public System.Windows.Forms.TextBox cs03TextBox;
        public System.Windows.Forms.TextBox cs05TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


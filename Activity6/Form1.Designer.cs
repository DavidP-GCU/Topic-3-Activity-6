namespace Activity6
{
    partial class activity6PoundsToOuncesConversion
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
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.userInputPounds = new System.Windows.Forms.TextBox();
            this.poundsLabel = new System.Windows.Forms.Label();
            this.ouncesLabel = new System.Windows.Forms.Label();
            this.userOuncesTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.AutoSize = true;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(25, 256);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(116, 63);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(205, 256);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 63);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userInputPounds
            // 
            this.userInputPounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputPounds.Location = new System.Drawing.Point(221, 54);
            this.userInputPounds.Name = "userInputPounds";
            this.userInputPounds.Size = new System.Drawing.Size(100, 31);
            this.userInputPounds.TabIndex = 2;
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poundsLabel.Location = new System.Drawing.Point(20, 54);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(151, 25);
            this.poundsLabel.TabIndex = 3;
            this.poundsLabel.Text = "Total Pounds";
            // 
            // ouncesLabel
            // 
            this.ouncesLabel.AutoSize = true;
            this.ouncesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouncesLabel.Location = new System.Drawing.Point(20, 162);
            this.ouncesLabel.Name = "ouncesLabel";
            this.ouncesLabel.Size = new System.Drawing.Size(152, 25);
            this.ouncesLabel.TabIndex = 4;
            this.ouncesLabel.Text = "Total Ounces";
            // 
            // userOuncesTotal
            // 
            this.userOuncesTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userOuncesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userOuncesTotal.Location = new System.Drawing.Point(221, 162);
            this.userOuncesTotal.Name = "userOuncesTotal";
            this.userOuncesTotal.Size = new System.Drawing.Size(100, 32);
            this.userOuncesTotal.TabIndex = 5;
            // 
            // activity6PoundsToOuncesConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 393);
            this.Controls.Add(this.userOuncesTotal);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.poundsLabel);
            this.Controls.Add(this.userInputPounds);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Name = "activity6PoundsToOuncesConversion";
            this.Text = "Pounds to Ounces Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox userInputPounds;
        private System.Windows.Forms.Label poundsLabel;
        private System.Windows.Forms.Label ouncesLabel;
        private System.Windows.Forms.Label userOuncesTotal;
    }
}


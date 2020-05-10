namespace TixTaxToe
{
    partial class GridSize
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
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.winBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(65, 22);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(55, 13);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "gridWidth:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(65, 46);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(58, 13);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "gridHeight:";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Location = new System.Drawing.Point(65, 69);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(80, 13);
            this.winLabel.TabIndex = 2;
            this.winLabel.Text = "Symbols to win:";
            // 
            // winBox
            // 
            this.winBox.Location = new System.Drawing.Point(161, 71);
            this.winBox.MaxLength = 2;
            this.winBox.Name = "winBox";
            this.winBox.Size = new System.Drawing.Size(27, 20);
            this.winBox.TabIndex = 4;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(161, 19);
            this.widthBox.MaxLength = 2;
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(27, 20);
            this.widthBox.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(126, 102);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(62, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(68, 102);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(52, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(161, 45);
            this.heightBox.MaxLength = 2;
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(27, 20);
            this.heightBox.TabIndex = 3;
            // 
            // GridSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 145);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.winBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "GridSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GridSize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.TextBox winBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox heightBox;
    }
}
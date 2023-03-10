namespace lab5
{
    partial class CreateCar
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceField = new System.Windows.Forms.TextBox();
            this.speedField = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.manufacturingYearField = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(40, 25);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(56, 25);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Price";
            // 
            // priceField
            // 
            this.priceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceField.Location = new System.Drawing.Point(12, 53);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(112, 27);
            this.priceField.TabIndex = 1;
            // 
            // speedField
            // 
            this.speedField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedField.Location = new System.Drawing.Point(145, 53);
            this.speedField.Name = "speedField";
            this.speedField.Size = new System.Drawing.Size(112, 27);
            this.speedField.TabIndex = 3;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.Location = new System.Drawing.Point(165, 25);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(70, 25);
            this.speedLabel.TabIndex = 2;
            this.speedLabel.Text = "Speed";
            // 
            // manufacturingYearField
            // 
            this.manufacturingYearField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturingYearField.Location = new System.Drawing.Point(285, 53);
            this.manufacturingYearField.Name = "manufacturingYearField";
            this.manufacturingYearField.Size = new System.Drawing.Size(177, 27);
            this.manufacturingYearField.TabIndex = 5;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(280, 25);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(182, 25);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Manufacturing Year";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(78, 115);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(112, 37);
            this.create.TabIndex = 6;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(264, 115);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(111, 37);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // CreateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 170);
            this.ControlBox = false;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.create);
            this.Controls.Add(this.manufacturingYearField);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.speedField);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.priceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.TextBox speedField;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox manufacturingYearField;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button cancel;
    }
}
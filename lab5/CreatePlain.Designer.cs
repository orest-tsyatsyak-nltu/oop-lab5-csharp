namespace lab5
{
    partial class CreatePlain
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.manufacturingYearField = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.speedField = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.priceField = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.numOfPassfield = new System.Windows.Forms.TextBox();
            this.numOfPassLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightfield = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(257, 182);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(111, 37);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(65, 182);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(112, 37);
            this.create.TabIndex = 14;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // manufacturingYearField
            // 
            this.manufacturingYearField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturingYearField.Location = new System.Drawing.Point(292, 58);
            this.manufacturingYearField.Name = "manufacturingYearField";
            this.manufacturingYearField.Size = new System.Drawing.Size(177, 27);
            this.manufacturingYearField.TabIndex = 13;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(287, 30);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(182, 25);
            this.yearLabel.TabIndex = 12;
            this.yearLabel.Text = "Manufacturing Year";
            // 
            // speedField
            // 
            this.speedField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedField.Location = new System.Drawing.Point(152, 58);
            this.speedField.Name = "speedField";
            this.speedField.Size = new System.Drawing.Size(112, 27);
            this.speedField.TabIndex = 11;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.Location = new System.Drawing.Point(172, 30);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(70, 25);
            this.speedLabel.TabIndex = 10;
            this.speedLabel.Text = "Speed";
            // 
            // priceField
            // 
            this.priceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceField.Location = new System.Drawing.Point(19, 58);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(112, 27);
            this.priceField.TabIndex = 9;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(47, 30);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(56, 25);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price";
            // 
            // numOfPassfield
            // 
            this.numOfPassfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numOfPassfield.Location = new System.Drawing.Point(19, 130);
            this.numOfPassfield.Name = "numOfPassfield";
            this.numOfPassfield.Size = new System.Drawing.Size(204, 27);
            this.numOfPassfield.TabIndex = 17;
            // 
            // numOfPassLabel
            // 
            this.numOfPassLabel.AutoSize = true;
            this.numOfPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numOfPassLabel.Location = new System.Drawing.Point(14, 102);
            this.numOfPassLabel.Name = "numOfPassLabel";
            this.numOfPassLabel.Size = new System.Drawing.Size(209, 25);
            this.numOfPassLabel.TabIndex = 16;
            this.numOfPassLabel.Text = "Number of passangers";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.Location = new System.Drawing.Point(324, 102);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(68, 25);
            this.heightLabel.TabIndex = 18;
            this.heightLabel.Text = "Height";
            // 
            // heightfield
            // 
            this.heightfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightfield.Location = new System.Drawing.Point(292, 130);
            this.heightfield.Name = "heightfield";
            this.heightfield.Size = new System.Drawing.Size(128, 27);
            this.heightfield.TabIndex = 19;
            // 
            // CreatePlain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 239);
            this.ControlBox = false;
            this.Controls.Add(this.heightfield);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.numOfPassfield);
            this.Controls.Add(this.numOfPassLabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.create);
            this.Controls.Add(this.manufacturingYearField);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.speedField);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.priceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreatePlain";
            this.Text = "CreatePlain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox manufacturingYearField;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox speedField;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.Label priceLabel;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.Windows.Forms.TextBox numOfPassfield;
        private System.Windows.Forms.Label numOfPassLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightfield;
    }
}
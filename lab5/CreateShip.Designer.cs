namespace lab5
{
    partial class CreateShip
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
            this.homePortField = new System.Windows.Forms.TextBox();
            this.homePortLabel = new System.Windows.Forms.Label();
            this.numOfPassfield = new System.Windows.Forms.TextBox();
            this.numOfPassLabel = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.manufacturingYearField = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.speedField = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.priceField = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homePortField
            // 
            this.homePortField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homePortField.Location = new System.Drawing.Point(298, 123);
            this.homePortField.Name = "homePortField";
            this.homePortField.Size = new System.Drawing.Size(128, 27);
            this.homePortField.TabIndex = 31;
            // 
            // homePortLabel
            // 
            this.homePortLabel.AutoSize = true;
            this.homePortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homePortLabel.Location = new System.Drawing.Point(313, 95);
            this.homePortLabel.Name = "homePortLabel";
            this.homePortLabel.Size = new System.Drawing.Size(102, 25);
            this.homePortLabel.TabIndex = 30;
            this.homePortLabel.Text = "Home port";
            // 
            // numOfPassfield
            // 
            this.numOfPassfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numOfPassfield.Location = new System.Drawing.Point(25, 123);
            this.numOfPassfield.Name = "numOfPassfield";
            this.numOfPassfield.Size = new System.Drawing.Size(204, 27);
            this.numOfPassfield.TabIndex = 29;
            // 
            // numOfPassLabel
            // 
            this.numOfPassLabel.AutoSize = true;
            this.numOfPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numOfPassLabel.Location = new System.Drawing.Point(20, 95);
            this.numOfPassLabel.Name = "numOfPassLabel";
            this.numOfPassLabel.Size = new System.Drawing.Size(209, 25);
            this.numOfPassLabel.TabIndex = 28;
            this.numOfPassLabel.Text = "Number of passangers";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(263, 175);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(111, 37);
            this.cancel.TabIndex = 27;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(71, 175);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(112, 37);
            this.create.TabIndex = 26;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // manufacturingYearField
            // 
            this.manufacturingYearField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturingYearField.Location = new System.Drawing.Point(298, 51);
            this.manufacturingYearField.Name = "manufacturingYearField";
            this.manufacturingYearField.Size = new System.Drawing.Size(177, 27);
            this.manufacturingYearField.TabIndex = 25;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(293, 23);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(182, 25);
            this.yearLabel.TabIndex = 24;
            this.yearLabel.Text = "Manufacturing Year";
            // 
            // speedField
            // 
            this.speedField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedField.Location = new System.Drawing.Point(158, 51);
            this.speedField.Name = "speedField";
            this.speedField.Size = new System.Drawing.Size(112, 27);
            this.speedField.TabIndex = 23;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.Location = new System.Drawing.Point(178, 23);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(70, 25);
            this.speedLabel.TabIndex = 22;
            this.speedLabel.Text = "Speed";
            // 
            // priceField
            // 
            this.priceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceField.Location = new System.Drawing.Point(25, 51);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(112, 27);
            this.priceField.TabIndex = 21;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(53, 23);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(56, 25);
            this.priceLabel.TabIndex = 20;
            this.priceLabel.Text = "Price";
            // 
            // CreateShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 235);
            this.ControlBox = false;
            this.Controls.Add(this.homePortField);
            this.Controls.Add(this.homePortLabel);
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
            this.Name = "CreateShip";
            this.Text = "AddShip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox homePortField;
        private System.Windows.Forms.Label homePortLabel;
        private System.Windows.Forms.TextBox numOfPassfield;
        private System.Windows.Forms.Label numOfPassLabel;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox manufacturingYearField;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox speedField;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.Label priceLabel;
    }
}
namespace lab5
{
    partial class Lab5MainWindow
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
            this.vehicles = new System.Windows.Forms.ListBox();
            this.addCar = new System.Windows.Forms.Button();
            this.addPlain = new System.Windows.Forms.Button();
            this.addShip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vehicles
            // 
            this.vehicles.FormattingEnabled = true;
            this.vehicles.Location = new System.Drawing.Point(43, 53);
            this.vehicles.Name = "vehicles";
            this.vehicles.Size = new System.Drawing.Size(448, 316);
            this.vehicles.TabIndex = 0;
            this.vehicles.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.vehicles_Format);
            // 
            // addCar
            // 
            this.addCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCar.Location = new System.Drawing.Point(526, 53);
            this.addCar.Name = "addCar";
            this.addCar.Size = new System.Drawing.Size(243, 52);
            this.addCar.TabIndex = 1;
            this.addCar.Text = "Add Car";
            this.addCar.UseVisualStyleBackColor = true;
            this.addCar.Click += new System.EventHandler(this.addCar_Click);
            // 
            // addPlain
            // 
            this.addPlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPlain.Location = new System.Drawing.Point(526, 135);
            this.addPlain.Name = "addPlain";
            this.addPlain.Size = new System.Drawing.Size(243, 52);
            this.addPlain.TabIndex = 2;
            this.addPlain.Text = "Add Plain";
            this.addPlain.UseVisualStyleBackColor = true;
            this.addPlain.Click += new System.EventHandler(this.addPlain_Click);
            // 
            // addShip
            // 
            this.addShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addShip.Location = new System.Drawing.Point(526, 212);
            this.addShip.Name = "addShip";
            this.addShip.Size = new System.Drawing.Size(243, 52);
            this.addShip.TabIndex = 3;
            this.addShip.Text = "Add Ship";
            this.addShip.UseVisualStyleBackColor = true;
            this.addShip.Click += new System.EventHandler(this.addShip_Click);
            // 
            // Lab5MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addShip);
            this.Controls.Add(this.addPlain);
            this.Controls.Add(this.addCar);
            this.Controls.Add(this.vehicles);
            this.Name = "Lab5MainWindow";
            this.Text = "Vehicle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox vehicles;
        private System.Windows.Forms.Button addCar;
        private System.Windows.Forms.Button addPlain;
        private System.Windows.Forms.Button addShip;
    }
}


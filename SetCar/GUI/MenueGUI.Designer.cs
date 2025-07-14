
namespace SetCar.GUI
{
    partial class MenueGUI
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCars = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMananger = new System.Windows.Forms.Button();
            this.btnFeedbeck = new System.Windows.Forms.Button();
            this.btnRents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCustomer.Location = new System.Drawing.Point(6, 231);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(180, 82);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEmployee.Location = new System.Drawing.Point(273, 231);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(202, 82);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "employees";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCars
            // 
            this.btnCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCars.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCars.Location = new System.Drawing.Point(545, 231);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(151, 82);
            this.btnCars.TabIndex = 2;
            this.btnCars.Text = "cars";
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SetCar.Properties.Resources.new1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.menu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menu.Location = new System.Drawing.Point(326, 35);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(104, 39);
            this.menu.TabIndex = 4;
            this.menu.Text = "menu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMananger);
            this.groupBox1.Controls.Add(this.btnFeedbeck);
            this.groupBox1.Controls.Add(this.btnRents);
            this.groupBox1.Controls.Add(this.btnCustomer);
            this.groupBox1.Controls.Add(this.menu);
            this.groupBox1.Controls.Add(this.btnEmployee);
            this.groupBox1.Controls.Add(this.btnCars);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 318);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "manager menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnMananger
            // 
            this.btnMananger.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMananger.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMananger.Location = new System.Drawing.Point(273, 109);
            this.btnMananger.Name = "btnMananger";
            this.btnMananger.Size = new System.Drawing.Size(202, 82);
            this.btnMananger.TabIndex = 7;
            this.btnMananger.Text = "mananger";
            this.btnMananger.UseVisualStyleBackColor = true;
            this.btnMananger.Click += new System.EventHandler(this.btnMananger_Click);
            // 
            // btnFeedbeck
            // 
            this.btnFeedbeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnFeedbeck.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFeedbeck.Location = new System.Drawing.Point(6, 109);
            this.btnFeedbeck.Name = "btnFeedbeck";
            this.btnFeedbeck.Size = new System.Drawing.Size(180, 82);
            this.btnFeedbeck.TabIndex = 6;
            this.btnFeedbeck.Text = "feedbeck";
            this.btnFeedbeck.UseVisualStyleBackColor = true;
            this.btnFeedbeck.Click += new System.EventHandler(this.feedbeck_Click);
            // 
            // btnRents
            // 
            this.btnRents.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRents.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRents.Location = new System.Drawing.Point(545, 109);
            this.btnRents.Name = "btnRents";
            this.btnRents.Size = new System.Drawing.Size(151, 82);
            this.btnRents.TabIndex = 5;
            this.btnRents.Text = "rents";
            this.btnRents.UseVisualStyleBackColor = true;
            this.btnRents.Click += new System.EventHandler(this.rents_Click);
            // 
            // MenueGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenueGUI";
            this.Text = "MangerMenueGUI";
            this.Load += new System.EventHandler(this.MenueGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRents;
        private System.Windows.Forms.Button btnFeedbeck;
        private System.Windows.Forms.Button btnMananger;
    }
}
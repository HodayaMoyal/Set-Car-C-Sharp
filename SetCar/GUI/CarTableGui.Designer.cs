
namespace SetCar.GUI
{
    partial class CarTableGui
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
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.addCar = new System.Windows.Forms.Button();
            this.deletear = new System.Windows.Forms.Button();
            this.updateCar = new System.Windows.Forms.Button();
            this.detailsCarClick = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCar
            // 
            this.dgvCar.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Location = new System.Drawing.Point(88, 55);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.RowHeadersWidth = 62;
            this.dgvCar.RowTemplate.Height = 28;
            this.dgvCar.Size = new System.Drawing.Size(602, 262);
            this.dgvCar.TabIndex = 0;
            this.dgvCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCar_CellContentClick);
            this.dgvCar.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.chooseCar);
            // 
            // addCar
            // 
            this.addCar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addCar.Location = new System.Drawing.Point(88, 355);
            this.addCar.Name = "addCar";
            this.addCar.Size = new System.Drawing.Size(110, 52);
            this.addCar.TabIndex = 1;
            this.addCar.Text = "add car";
            this.addCar.UseVisualStyleBackColor = false;
            this.addCar.Click += new System.EventHandler(this.addCar_Click);
            // 
            // deletear
            // 
            this.deletear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deletear.Location = new System.Drawing.Point(256, 355);
            this.deletear.Name = "deletear";
            this.deletear.Size = new System.Drawing.Size(111, 52);
            this.deletear.TabIndex = 2;
            this.deletear.Text = "delete car";
            this.deletear.UseVisualStyleBackColor = false;
            this.deletear.Click += new System.EventHandler(this.delete_Click);
            // 
            // updateCar
            // 
            this.updateCar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateCar.Location = new System.Drawing.Point(430, 355);
            this.updateCar.Name = "updateCar";
            this.updateCar.Size = new System.Drawing.Size(111, 52);
            this.updateCar.TabIndex = 4;
            this.updateCar.Text = "update car";
            this.updateCar.UseVisualStyleBackColor = false;
            this.updateCar.Click += new System.EventHandler(this.updateCar_Click);
            // 
            // detailsCarClick
            // 
            this.detailsCarClick.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.detailsCarClick.Location = new System.Drawing.Point(580, 355);
            this.detailsCarClick.Name = "detailsCarClick";
            this.detailsCarClick.Size = new System.Drawing.Size(111, 52);
            this.detailsCarClick.TabIndex = 5;
            this.detailsCarClick.Text = "details";
            this.detailsCarClick.UseVisualStyleBackColor = false;
            this.detailsCarClick.Click += new System.EventHandler(this.detailsCarClick_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(267, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(456, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "find by car name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CarTableGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.detailsCarClick);
            this.Controls.Add(this.updateCar);
            this.Controls.Add(this.deletear);
            this.Controls.Add(this.addCar);
            this.Controls.Add(this.dgvCar);
            this.Name = "CarTableGui";
            this.Text = "CarTableGui";
            this.Load += new System.EventHandler(this.CarTableGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCar;
        private System.Windows.Forms.Button addCar;
        private System.Windows.Forms.Button deletear;
      //  private System.Windows.Forms.Button detailsCar_click;
        private System.Windows.Forms.Button updateCar;
        private System.Windows.Forms.Button detailsCarClick;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
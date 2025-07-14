
namespace SetCar.GUI
{
    partial class RentsTableGui
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
            this.dgvRents = new System.Windows.Forms.DataGridView();
            this.addRents = new System.Windows.Forms.Button();
            this.detailsRents = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRents
            // 
            this.dgvRents.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRents.Location = new System.Drawing.Point(92, 97);
            this.dgvRents.Name = "dgvRents";
            this.dgvRents.RowHeadersWidth = 62;
            this.dgvRents.RowTemplate.Height = 28;
            this.dgvRents.Size = new System.Drawing.Size(613, 254);
            this.dgvRents.TabIndex = 0;
            this.dgvRents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRents_CellContentClick_1);
            this.dgvRents.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.chooseRents);
            // 
            // addRents
            // 
            this.addRents.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addRents.Location = new System.Drawing.Point(149, 380);
            this.addRents.Name = "addRents";
            this.addRents.Size = new System.Drawing.Size(203, 78);
            this.addRents.TabIndex = 1;
            this.addRents.Text = "add a rent";
            this.addRents.UseVisualStyleBackColor = false;
            this.addRents.Click += new System.EventHandler(this.addRents_Click);
            // 
            // detailsRents
            // 
            this.detailsRents.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.detailsRents.Location = new System.Drawing.Point(445, 380);
            this.detailsRents.Name = "detailsRents";
            this.detailsRents.Size = new System.Drawing.Size(188, 78);
            this.detailsRents.TabIndex = 2;
            this.detailsRents.Text = "details of rents";
            this.detailsRents.UseVisualStyleBackColor = false;
            this.detailsRents.Click += new System.EventHandler(this.detailsRents_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(421, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "find by rent id";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(243, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RentsTableGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.detailsRents);
            this.Controls.Add(this.addRents);
            this.Controls.Add(this.dgvRents);
            this.Name = "RentsTableGui";
            this.Text = "rentsTableGui";
            this.Load += new System.EventHandler(this.RentsTableGui_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRents;
        private System.Windows.Forms.Button addRents;
        private System.Windows.Forms.Button detailsRents;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
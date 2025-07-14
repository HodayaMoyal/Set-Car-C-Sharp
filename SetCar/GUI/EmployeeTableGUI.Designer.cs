
namespace SetCar.GUI
{
    partial class EmployeeTableGUI
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
            this.dvgEmployee = new System.Windows.Forms.DataGridView();
            this.addEmployee = new System.Windows.Forms.Button();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Button();
            this.updateEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgEmployee
            // 
            this.dvgEmployee.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dvgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEmployee.Location = new System.Drawing.Point(90, 101);
            this.dvgEmployee.Name = "dvgEmployee";
            this.dvgEmployee.RowHeadersWidth = 62;
            this.dvgEmployee.RowTemplate.Height = 28;
            this.dvgEmployee.Size = new System.Drawing.Size(626, 284);
            this.dvgEmployee.TabIndex = 0;
            this.dvgEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEmployee_CellContentClick);
            this.dvgEmployee.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.chooseEmployee);
            // 
            // addEmployee
            // 
            this.addEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addEmployee.Location = new System.Drawing.Point(90, 421);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(117, 53);
            this.addEmployee.TabIndex = 1;
            this.addEmployee.Text = "add employee";
            this.addEmployee.UseVisualStyleBackColor = false;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteEmployee.Location = new System.Drawing.Point(250, 421);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(125, 53);
            this.deleteEmployee.TabIndex = 2;
            this.deleteEmployee.Text = "delete employee";
            this.deleteEmployee.UseVisualStyleBackColor = false;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.details.Location = new System.Drawing.Point(595, 421);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(121, 53);
            this.details.TabIndex = 3;
            this.details.Text = "details";
            this.details.UseVisualStyleBackColor = false;
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // updateEmployee
            // 
            this.updateEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateEmployee.Location = new System.Drawing.Point(426, 421);
            this.updateEmployee.Name = "updateEmployee";
            this.updateEmployee.Size = new System.Drawing.Size(125, 53);
            this.updateEmployee.TabIndex = 4;
            this.updateEmployee.Text = "update employee";
            this.updateEmployee.UseVisualStyleBackColor = false;
            this.updateEmployee.Click += new System.EventHandler(this.updateEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(434, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "find by employee id";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(245, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmployeeTableGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updateEmployee);
            this.Controls.Add(this.details);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.dvgEmployee);
            this.Name = "EmployeeTableGUI";
            this.Text = "EmployeeTableGUI";
            this.Load += new System.EventHandler(this.EmployeeTableGUI_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgEmployee;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.Button updateEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
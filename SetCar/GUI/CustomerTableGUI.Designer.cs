
namespace SetCar.GUI
{
    partial class CustomerTableGUI
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
            this.dvgCustomer = new System.Windows.Forms.DataGridView();
            this.addCustomer = new System.Windows.Forms.Button();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCustomer
            // 
            this.dvgCustomer.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dvgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCustomer.Location = new System.Drawing.Point(69, 80);
            this.dvgCustomer.Name = "dvgCustomer";
            this.dvgCustomer.RowHeadersWidth = 62;
            this.dvgCustomer.RowTemplate.Height = 28;
            this.dvgCustomer.Size = new System.Drawing.Size(652, 263);
            this.dvgCustomer.TabIndex = 0;
            this.dvgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCustomer_CellContentClick);
            this.dvgCustomer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.chooseCustomer);
            // 
            // addCustomer
            // 
            this.addCustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addCustomer.Location = new System.Drawing.Point(69, 377);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(161, 75);
            this.addCustomer.TabIndex = 1;
            this.addCustomer.Text = "add customer";
            this.addCustomer.UseVisualStyleBackColor = false;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteCustomer.Location = new System.Drawing.Point(261, 377);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(146, 75);
            this.deleteCustomer.TabIndex = 2;
            this.deleteCustomer.Text = "delete customer";
            this.deleteCustomer.UseVisualStyleBackColor = false;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.details.Location = new System.Drawing.Point(601, 377);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(120, 75);
            this.details.TabIndex = 3;
            this.details.Text = "details";
            this.details.UseVisualStyleBackColor = false;
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateCustomer.Location = new System.Drawing.Point(439, 377);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(138, 75);
            this.updateCustomer.TabIndex = 4;
            this.updateCustomer.Text = "update customer";
            this.updateCustomer.UseVisualStyleBackColor = false;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(423, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "find by customer id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(234, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CustomerTableGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.details);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.dvgCustomer);
            this.Name = "CustomerTableGUI";
            this.Text = "CustomerTable";
            this.Load += new System.EventHandler(this.CustomerTableGUI_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCustomer;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
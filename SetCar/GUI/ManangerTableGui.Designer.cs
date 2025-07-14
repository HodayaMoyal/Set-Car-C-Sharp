
namespace SetCar.GUI
{
    partial class ManangerTableGui
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
            this.dgvTableMananger = new System.Windows.Forms.DataGridView();
            this.addMananger = new System.Windows.Forms.Button();
            this.deleteMananger = new System.Windows.Forms.Button();
            this.detailsMananger = new System.Windows.Forms.Button();
            this.updateMananger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableMananger)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTableMananger
            // 
            this.dgvTableMananger.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvTableMananger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableMananger.Location = new System.Drawing.Point(117, 105);
            this.dgvTableMananger.Name = "dgvTableMananger";
            this.dgvTableMananger.RowHeadersWidth = 62;
            this.dgvTableMananger.RowTemplate.Height = 28;
            this.dgvTableMananger.Size = new System.Drawing.Size(562, 264);
            this.dgvTableMananger.TabIndex = 0;
            this.dgvTableMananger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableMananger_CellContentClick);
            this.dgvTableMananger.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.chooseMananger);
            // 
            // addMananger
            // 
            this.addMananger.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addMananger.Location = new System.Drawing.Point(126, 409);
            this.addMananger.Name = "addMananger";
            this.addMananger.Size = new System.Drawing.Size(112, 55);
            this.addMananger.TabIndex = 1;
            this.addMananger.Text = "add mananger";
            this.addMananger.UseVisualStyleBackColor = false;
            this.addMananger.Click += new System.EventHandler(this.addMananger_Click);
            // 
            // deleteMananger
            // 
            this.deleteMananger.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteMananger.Location = new System.Drawing.Point(279, 415);
            this.deleteMananger.Name = "deleteMananger";
            this.deleteMananger.Size = new System.Drawing.Size(102, 49);
            this.deleteMananger.TabIndex = 2;
            this.deleteMananger.Text = "delete mananger";
            this.deleteMananger.UseVisualStyleBackColor = false;
            this.deleteMananger.Click += new System.EventHandler(this.deleteMananger_Click);
            // 
            // detailsMananger
            // 
            this.detailsMananger.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.detailsMananger.Location = new System.Drawing.Point(586, 412);
            this.detailsMananger.Name = "detailsMananger";
            this.detailsMananger.Size = new System.Drawing.Size(102, 49);
            this.detailsMananger.TabIndex = 3;
            this.detailsMananger.Text = "details";
            this.detailsMananger.UseVisualStyleBackColor = false;
            this.detailsMananger.Click += new System.EventHandler(this.detailsMananger_Click);
            // 
            // updateMananger
            // 
            this.updateMananger.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateMananger.Location = new System.Drawing.Point(431, 412);
            this.updateMananger.Name = "updateMananger";
            this.updateMananger.Size = new System.Drawing.Size(102, 49);
            this.updateMananger.TabIndex = 4;
            this.updateMananger.Text = "update mananger";
            this.updateMananger.UseVisualStyleBackColor = false;
            this.updateMananger.Click += new System.EventHandler(this.updateMananger_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(443, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "find by mananger id";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(265, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ManangerTableGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updateMananger);
            this.Controls.Add(this.detailsMananger);
            this.Controls.Add(this.deleteMananger);
            this.Controls.Add(this.addMananger);
            this.Controls.Add(this.dgvTableMananger);
            this.Name = "ManangerTableGui";
            this.Text = "ManangerTableGui";
            this.Load += new System.EventHandler(this.ManangerTableGui_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableMananger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTableMananger;
        private System.Windows.Forms.Button addMananger;
        private System.Windows.Forms.Button deleteMananger;
        private System.Windows.Forms.Button detailsMananger;
        private System.Windows.Forms.Button updateMananger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
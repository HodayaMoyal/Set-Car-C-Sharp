
namespace SetCar.GUI
{
    partial class FeedbeckTableGui
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
            this.dgvFeedbeck = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_details = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbeck)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFeedbeck
            // 
            this.dgvFeedbeck.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvFeedbeck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedbeck.Location = new System.Drawing.Point(70, 99);
            this.dgvFeedbeck.Name = "dgvFeedbeck";
            this.dgvFeedbeck.RowHeadersWidth = 62;
            this.dgvFeedbeck.RowTemplate.Height = 28;
            this.dgvFeedbeck.Size = new System.Drawing.Size(652, 265);
            this.dgvFeedbeck.TabIndex = 0;
            this.dgvFeedbeck.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedbeck_CellContentClick);
            this.dgvFeedbeck.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.chooseFeedbeck);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btndelete.Location = new System.Drawing.Point(70, 408);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(174, 65);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_add.Location = new System.Drawing.Point(312, 408);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(171, 65);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_details
            // 
            this.btn_details.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_details.Location = new System.Drawing.Point(550, 408);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(160, 65);
            this.btn_details.TabIndex = 3;
            this.btn_details.Text = "details";
            this.btn_details.UseVisualStyleBackColor = false;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(429, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "find by feedback id";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(240, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FeedbeckTableGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_details);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dgvFeedbeck);
            this.Name = "FeedbeckTableGui";
            this.Text = "FeedbeckTableGui";
            this.Load += new System.EventHandler(this.FeedbeckTableGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbeck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFeedbeck;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
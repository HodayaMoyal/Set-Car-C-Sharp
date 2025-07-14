
namespace SetCar.GUI
{
    partial class FeedbeckGui
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
            this.dgvFeedbeck = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sendClick = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtGrading = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.txtNameEmloyee = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrading)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFeedbeck
            // 
            this.dgvFeedbeck.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvFeedbeck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedbeck.Location = new System.Drawing.Point(40, 30);
            this.dgvFeedbeck.Name = "dgvFeedbeck";
            this.dgvFeedbeck.RowHeadersWidth = 62;
            this.dgvFeedbeck.RowTemplate.Height = 28;
            this.dgvFeedbeck.Size = new System.Drawing.Size(570, 408);
            this.dgvFeedbeck.TabIndex = 0;
            this.dgvFeedbeck.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedbeck_CellContentClick);
            this.dgvFeedbeck.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.choose);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(854, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtDescribe
            // 
            this.txtDescribe.Location = new System.Drawing.Point(854, 170);
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(100, 26);
            this.txtDescribe.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(689, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "name customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(689, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "describe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(689, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "grading";
            // 
            // sendClick
            // 
            this.sendClick.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sendClick.Location = new System.Drawing.Point(740, 282);
            this.sendClick.Name = "sendClick";
            this.sendClick.Size = new System.Drawing.Size(105, 47);
            this.sendClick.TabIndex = 18;
            this.sendClick.Text = "send";
            this.sendClick.UseVisualStyleBackColor = true;
            this.sendClick.Click += new System.EventHandler(this.sendClick_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtGrading
            // 
            this.txtGrading.Location = new System.Drawing.Point(839, 107);
            this.txtGrading.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtGrading.Name = "txtGrading";
            this.txtGrading.Size = new System.Drawing.Size(120, 26);
            this.txtGrading.TabIndex = 19;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label.Location = new System.Drawing.Point(694, 243);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(121, 20);
            this.label.TabIndex = 21;
            this.label.Text = "name employee";
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNameEmloyee
            // 
            this.txtNameEmloyee.Location = new System.Drawing.Point(859, 238);
            this.txtNameEmloyee.Name = "txtNameEmloyee";
            this.txtNameEmloyee.Size = new System.Drawing.Size(100, 26);
            this.txtNameEmloyee.TabIndex = 20;
            this.txtNameEmloyee.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FeedbeckGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 559);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtNameEmloyee);
            this.Controls.Add(this.txtGrading);
            this.Controls.Add(this.sendClick);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvFeedbeck);
            this.Name = "FeedbeckGui";
            this.Text = "grading";
            this.Load += new System.EventHandler(this.FeedbeckGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFeedbeck;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sendClick;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown txtGrading;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtNameEmloyee;
    }
}
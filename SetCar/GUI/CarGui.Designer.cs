
namespace SetCar.GUI
{
    partial class CarGui
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
            this.carName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.kind = new System.Windows.Forms.Label();
            this.txtKind = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFree = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.free = new System.Windows.Forms.Label();
            this.numSeats = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // carName
            // 
            this.carName.AutoSize = true;
            this.carName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.carName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.carName.Location = new System.Drawing.Point(40, 95);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(70, 18);
            this.carName.TabIndex = 1;
            this.carName.Text = "car name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 4;
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.send.ForeColor = System.Drawing.SystemColors.Highlight;
            this.send.Location = new System.Drawing.Point(411, 310);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(122, 55);
            this.send.TabIndex = 5;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // kind
            // 
            this.kind.AutoSize = true;
            this.kind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.kind.ForeColor = System.Drawing.SystemColors.Highlight;
            this.kind.Location = new System.Drawing.Point(40, 148);
            this.kind.Name = "kind";
            this.kind.Size = new System.Drawing.Size(35, 18);
            this.kind.TabIndex = 7;
            this.kind.Text = "kind";
            // 
            // txtKind
            // 
            this.txtKind.Location = new System.Drawing.Point(197, 144);
            this.txtKind.Name = "txtKind";
            this.txtKind.Size = new System.Drawing.Size(100, 26);
            this.txtKind.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SetCar.Properties.Resources.new1;
            this.pictureBox1.Location = new System.Drawing.Point(639, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 95);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFree);
            this.groupBox1.Controls.Add(this.txtSeats);
            this.groupBox1.Controls.Add(this.free);
            this.groupBox1.Controls.Add(this.numSeats);
            this.groupBox1.Controls.Add(this.carName);
            this.groupBox1.Controls.Add(this.send);
            this.groupBox1.Controls.Add(this.txtKind);
            this.groupBox1.Controls.Add(this.kind);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(44, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 392);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "new car";
            // 
            // txtFree
            // 
            this.txtFree.Location = new System.Drawing.Point(197, 264);
            this.txtFree.Name = "txtFree";
            this.txtFree.Size = new System.Drawing.Size(100, 26);
            this.txtFree.TabIndex = 12;
            this.txtFree.TextChanged += new System.EventHandler(this.txtFree_TextChanged);
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(197, 202);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(100, 26);
            this.txtSeats.TabIndex = 11;
            // 
            // free
            // 
            this.free.AutoSize = true;
            this.free.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.free.ForeColor = System.Drawing.SystemColors.Highlight;
            this.free.Location = new System.Drawing.Point(40, 268);
            this.free.Name = "free";
            this.free.Size = new System.Drawing.Size(33, 18);
            this.free.TabIndex = 10;
            this.free.Text = "free";
            // 
            // numSeats
            // 
            this.numSeats.AutoSize = true;
            this.numSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.numSeats.ForeColor = System.Drawing.SystemColors.Highlight;
            this.numSeats.Location = new System.Drawing.Point(40, 206);
            this.numSeats.Name = "numSeats";
            this.numSeats.Size = new System.Drawing.Size(94, 18);
            this.numSeats.TabIndex = 9;
            this.numSeats.Text = "num of seats";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CarGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CarGui";
            this.Text = "CarGui";
            this.Load += new System.EventHandler(this.CarGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label carName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label kind;
        private System.Windows.Forms.TextBox txtKind;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtFree;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.Label free;
        private System.Windows.Forms.Label numSeats;
    }
}
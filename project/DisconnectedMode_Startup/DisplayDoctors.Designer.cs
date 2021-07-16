namespace DisconnectedMode_Startup
{
    partial class DisplayDoctors
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spec = new System.Windows.Forms.TextBox();
            this.Dis = new System.Windows.Forms.Button();
            this.disback_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 206);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(956, 299);
            this.dataGridView1.TabIndex = 2;
            
            // 
            // spec
            // 
            this.spec.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spec.Location = new System.Drawing.Point(403, 91);
            this.spec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(337, 30);
            this.spec.TabIndex = 3;
            this.spec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dis
            // 
            this.Dis.BackColor = System.Drawing.SystemColors.Highlight;
            this.Dis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dis.ForeColor = System.Drawing.Color.White;
            this.Dis.Location = new System.Drawing.Point(446, 148);
            this.Dis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dis.Name = "Dis";
            this.Dis.Size = new System.Drawing.Size(232, 50);
            this.Dis.TabIndex = 5;
            this.Dis.Text = "Display Doctors";
            this.Dis.UseVisualStyleBackColor = false;
            this.Dis.Click += new System.EventHandler(this.Dis_Click);
            // 
            // disback_btn
            // 
            this.disback_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.disback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disback_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disback_btn.ForeColor = System.Drawing.Color.White;
            this.disback_btn.Location = new System.Drawing.Point(27, 542);
            this.disback_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disback_btn.Name = "disback_btn";
            this.disback_btn.Size = new System.Drawing.Size(139, 41);
            this.disback_btn.TabIndex = 14;
            this.disback_btn.Text = "< Back";
            this.disback_btn.UseVisualStyleBackColor = false;
            this.disback_btn.Click += new System.EventHandler(this.disback_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(69, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = " Enter Doctor Specialization";
            // 
            // DisplayDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DisconnectedMode_Startup.Properties.Resources.Capture3;
            this.ClientSize = new System.Drawing.Size(1039, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disback_btn);
            this.Controls.Add(this.Dis);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DisplayDoctors";
            this.Text = "Manage_Data_DataAdapter";
            this.Load += new System.EventHandler(this.Manage_Data_DataAdapter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox spec;
        private System.Windows.Forms.Button Dis;
        private System.Windows.Forms.Button disback_btn;
        private System.Windows.Forms.Label label1;
    }
}
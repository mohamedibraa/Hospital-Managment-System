namespace DisconnectedMode_Startup
{
    partial class Form1
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
            this.SalaryTxtBox = new System.Windows.Forms.TextBox();
            this.Load_Btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SalaryTxtBox
            // 
            this.SalaryTxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryTxtBox.ForeColor = System.Drawing.Color.Navy;
            this.SalaryTxtBox.Location = new System.Drawing.Point(363, 79);
            this.SalaryTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.SalaryTxtBox.Name = "SalaryTxtBox";
            this.SalaryTxtBox.Size = new System.Drawing.Size(337, 30);
            this.SalaryTxtBox.TabIndex = 0;
            this.SalaryTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Load_Btn
            // 
            this.Load_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Load_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Load_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_Btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Load_Btn.Location = new System.Drawing.Point(419, 148);
            this.Load_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Load_Btn.Name = "Load_Btn";
            this.Load_Btn.Size = new System.Drawing.Size(232, 50);
            this.Load_Btn.TabIndex = 1;
            this.Load_Btn.Text = "Load Information";
            this.Load_Btn.UseVisualStyleBackColor = false;
            this.Load_Btn.Click += new System.EventHandler(this.Load_Btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 206);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(956, 299);
            this.dataGridView1.TabIndex = 2;
            // 
            // Save_Btn
            // 
            this.Save_Btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Save_Btn.Location = new System.Drawing.Point(889, 544);
            this.Save_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(133, 41);
            this.Save_Btn.TabIndex = 3;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = false;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.back_btn.Location = new System.Drawing.Point(15, 545);
            this.back_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(133, 39);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "< Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(262, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Salary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DisconnectedMode_Startup.Properties.Resources.Capture3;
            this.ClientSize = new System.Drawing.Size(1039, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Load_Btn);
            this.Controls.Add(this.SalaryTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SalaryTxtBox;
        private System.Windows.Forms.Button Load_Btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label1;
    }
}


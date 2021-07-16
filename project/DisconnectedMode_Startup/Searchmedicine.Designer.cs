namespace DisconnectedMode_Startup
{
    partial class Searchmedicine
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
            this.Med_name = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.med_info = new System.Windows.Forms.DataGridView();
            this.searchback_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.med_info)).BeginInit();
            this.SuspendLayout();
            // 
            // Med_name
            // 
            this.Med_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Med_name.ForeColor = System.Drawing.Color.Navy;
            this.Med_name.Location = new System.Drawing.Point(341, 94);
            this.Med_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Med_name.Name = "Med_name";
            this.Med_name.Size = new System.Drawing.Size(337, 30);
            this.Med_name.TabIndex = 1;
            this.Med_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Highlight;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.search.Location = new System.Drawing.Point(419, 148);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(201, 50);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // med_info
            // 
            this.med_info.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.med_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.med_info.Location = new System.Drawing.Point(40, 206);
            this.med_info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.med_info.Name = "med_info";
            this.med_info.Size = new System.Drawing.Size(956, 299);
            this.med_info.TabIndex = 5;
            this.med_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.med_info_CellContentClick);
            // 
            // searchback_btn
            // 
            this.searchback_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchback_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchback_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchback_btn.Location = new System.Drawing.Point(15, 546);
            this.searchback_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchback_btn.Name = "searchback_btn";
            this.searchback_btn.Size = new System.Drawing.Size(141, 39);
            this.searchback_btn.TabIndex = 13;
            this.searchback_btn.Text = "< Back";
            this.searchback_btn.UseVisualStyleBackColor = false;
            this.searchback_btn.Click += new System.EventHandler(this.searchback_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(82, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = " Enter Medicine name";
            // 
            // Searchmedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DisconnectedMode_Startup.Properties.Resources.Capture3;
            this.ClientSize = new System.Drawing.Size(1039, 615);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchback_btn);
            this.Controls.Add(this.med_info);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Med_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Searchmedicine";
            this.Text = "SearchFilms";
            this.Load += new System.EventHandler(this.SearchFilms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.med_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Med_name;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView med_info;
        private System.Windows.Forms.Button searchback_btn;
        private System.Windows.Forms.Label label2;
    }
}
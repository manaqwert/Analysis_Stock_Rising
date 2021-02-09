
namespace _122_Analysis_StockRise
{
    partial class 騰落率分析
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Compute_Button = new System.Windows.Forms.Button();
            this.Quit_Button = new System.Windows.Forms.Button();
            this.File1_Sel_Box = new System.Windows.Forms.TextBox();
            this.File1_Sel_Button = new System.Windows.Forms.Button();
            this.File1_label = new System.Windows.Forms.Label();
            this.File2_label = new System.Windows.Forms.Label();
            this.File2_Sel_Button = new System.Windows.Forms.Button();
            this.File2_Sel_Box = new System.Windows.Forms.TextBox();
            this.File3_Sel_button = new System.Windows.Forms.Button();
            this.File3_Sel_Box = new System.Windows.Forms.TextBox();
            this.File3_label = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.Rise_and_Fall_Rate_label = new System.Windows.Forms.Label();
            this.Rise_and_Fall_Rate_Box = new System.Windows.Forms.TextBox();
            this.Ave_frames_label = new System.Windows.Forms.Label();
            this.Ave_frames_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Compute_Button
            // 
            this.Compute_Button.Location = new System.Drawing.Point(595, 363);
            this.Compute_Button.Name = "Compute_Button";
            this.Compute_Button.Size = new System.Drawing.Size(85, 27);
            this.Compute_Button.TabIndex = 0;
            this.Compute_Button.Text = "計算";
            this.Compute_Button.UseVisualStyleBackColor = true;
            this.Compute_Button.Click += new System.EventHandler(this.Compute_Button_Click);
            // 
            // Quit_Button
            // 
            this.Quit_Button.Location = new System.Drawing.Point(697, 363);
            this.Quit_Button.Name = "Quit_Button";
            this.Quit_Button.Size = new System.Drawing.Size(87, 26);
            this.Quit_Button.TabIndex = 1;
            this.Quit_Button.Text = "終了";
            this.Quit_Button.UseVisualStyleBackColor = true;
            this.Quit_Button.Click += new System.EventHandler(this.Quit_Button_Click);
            // 
            // File1_Sel_Box
            // 
            this.File1_Sel_Box.Location = new System.Drawing.Point(61, 19);
            this.File1_Sel_Box.Name = "File1_Sel_Box";
            this.File1_Sel_Box.Size = new System.Drawing.Size(638, 23);
            this.File1_Sel_Box.TabIndex = 2;
            this.File1_Sel_Box.Text = "File1";
            this.File1_Sel_Box.TextChanged += new System.EventHandler(this.File1_Sel_Box_TextChanged);
            // 
            // File1_Sel_Button
            // 
            this.File1_Sel_Button.Location = new System.Drawing.Point(710, 19);
            this.File1_Sel_Button.Name = "File1_Sel_Button";
            this.File1_Sel_Button.Size = new System.Drawing.Size(75, 22);
            this.File1_Sel_Button.TabIndex = 3;
            this.File1_Sel_Button.Text = "Select";
            this.File1_Sel_Button.UseVisualStyleBackColor = true;
            this.File1_Sel_Button.Click += new System.EventHandler(this.File1_Sel_Button_Click);
            // 
            // File1_label
            // 
            this.File1_label.AutoSize = true;
            this.File1_label.Location = new System.Drawing.Point(12, 23);
            this.File1_label.Name = "File1_label";
            this.File1_label.Size = new System.Drawing.Size(43, 15);
            this.File1_label.TabIndex = 4;
            this.File1_label.Text = "File1：";
            this.File1_label.Click += new System.EventHandler(this.File1_label_Click);
            // 
            // File2_label
            // 
            this.File2_label.AutoSize = true;
            this.File2_label.Location = new System.Drawing.Point(12, 60);
            this.File2_label.Name = "File2_label";
            this.File2_label.Size = new System.Drawing.Size(43, 15);
            this.File2_label.TabIndex = 7;
            this.File2_label.Text = "File2：";
            this.File2_label.Click += new System.EventHandler(this.File2_label_Click);
            // 
            // File2_Sel_Button
            // 
            this.File2_Sel_Button.Location = new System.Drawing.Point(710, 58);
            this.File2_Sel_Button.Name = "File2_Sel_Button";
            this.File2_Sel_Button.Size = new System.Drawing.Size(75, 22);
            this.File2_Sel_Button.TabIndex = 6;
            this.File2_Sel_Button.Text = "Select";
            this.File2_Sel_Button.UseVisualStyleBackColor = true;
            this.File2_Sel_Button.Click += new System.EventHandler(this.File2_Sel_Button_Click);
            // 
            // File2_Sel_Box
            // 
            this.File2_Sel_Box.Location = new System.Drawing.Point(61, 57);
            this.File2_Sel_Box.Name = "File2_Sel_Box";
            this.File2_Sel_Box.Size = new System.Drawing.Size(638, 23);
            this.File2_Sel_Box.TabIndex = 5;
            this.File2_Sel_Box.Text = "File2";
            this.File2_Sel_Box.TextChanged += new System.EventHandler(this.File2_Sel_Box_TextChanged);
            // 
            // File3_Sel_button
            // 
            this.File3_Sel_button.Location = new System.Drawing.Point(710, 94);
            this.File3_Sel_button.Name = "File3_Sel_button";
            this.File3_Sel_button.Size = new System.Drawing.Size(75, 22);
            this.File3_Sel_button.TabIndex = 9;
            this.File3_Sel_button.Text = "Select";
            this.File3_Sel_button.UseVisualStyleBackColor = true;
            this.File3_Sel_button.Click += new System.EventHandler(this.File3_Sel_button_Click);
            // 
            // File3_Sel_Box
            // 
            this.File3_Sel_Box.Location = new System.Drawing.Point(61, 95);
            this.File3_Sel_Box.Name = "File3_Sel_Box";
            this.File3_Sel_Box.Size = new System.Drawing.Size(638, 23);
            this.File3_Sel_Box.TabIndex = 8;
            this.File3_Sel_Box.Text = "File3";
            this.File3_Sel_Box.TextChanged += new System.EventHandler(this.File3_Sel_Box_TextChanged);
            // 
            // File3_label
            // 
            this.File3_label.AutoSize = true;
            this.File3_label.Location = new System.Drawing.Point(12, 98);
            this.File3_label.Name = "File3_label";
            this.File3_label.Size = new System.Drawing.Size(43, 15);
            this.File3_label.TabIndex = 11;
            this.File3_label.Text = "File3：";
            this.File3_label.Click += new System.EventHandler(this.File3_label_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 15;
            this.ListBox.Location = new System.Drawing.Point(14, 141);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(770, 169);
            this.ListBox.TabIndex = 12;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // Rise_and_Fall_Rate_label
            // 
            this.Rise_and_Fall_Rate_label.AutoSize = true;
            this.Rise_and_Fall_Rate_label.Location = new System.Drawing.Point(14, 327);
            this.Rise_and_Fall_Rate_label.Name = "Rise_and_Fall_Rate_label";
            this.Rise_and_Fall_Rate_label.Size = new System.Drawing.Size(91, 15);
            this.Rise_and_Fall_Rate_label.TabIndex = 13;
            this.Rise_and_Fall_Rate_label.Text = "騰落率（％）：";
            this.Rise_and_Fall_Rate_label.Click += new System.EventHandler(this.Rise_and_Fall_Rate_label_Click);
            // 
            // Rise_and_Fall_Rate_Box
            // 
            this.Rise_and_Fall_Rate_Box.Location = new System.Drawing.Point(129, 324);
            this.Rise_and_Fall_Rate_Box.Name = "Rise_and_Fall_Rate_Box";
            this.Rise_and_Fall_Rate_Box.Size = new System.Drawing.Size(92, 23);
            this.Rise_and_Fall_Rate_Box.TabIndex = 14;
            this.Rise_and_Fall_Rate_Box.Text = "騰落率（%）";
            // 
            // Ave_frames_label
            // 
            this.Ave_frames_label.AutoSize = true;
            this.Ave_frames_label.Location = new System.Drawing.Point(14, 353);
            this.Ave_frames_label.Name = "Ave_frames_label";
            this.Ave_frames_label.Size = new System.Drawing.Size(103, 15);
            this.Ave_frames_label.TabIndex = 15;
            this.Ave_frames_label.Text = "平均区間（日）：";
            this.Ave_frames_label.Click += new System.EventHandler(this.Ave_frames_label_Click);
            // 
            // Ave_frames_Box
            // 
            this.Ave_frames_Box.Location = new System.Drawing.Point(129, 350);
            this.Ave_frames_Box.Name = "Ave_frames_Box";
            this.Ave_frames_Box.Size = new System.Drawing.Size(92, 23);
            this.Ave_frames_Box.TabIndex = 16;
            this.Ave_frames_Box.Text = "平均区間（日）";
            this.Ave_frames_Box.TextChanged += new System.EventHandler(this.Ave_frames_Box_TextChanged);
            // 
            // 騰落率分析
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.Ave_frames_Box);
            this.Controls.Add(this.Ave_frames_label);
            this.Controls.Add(this.Rise_and_Fall_Rate_Box);
            this.Controls.Add(this.Rise_and_Fall_Rate_label);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.File3_label);
            this.Controls.Add(this.File3_Sel_button);
            this.Controls.Add(this.File3_Sel_Box);
            this.Controls.Add(this.File2_label);
            this.Controls.Add(this.File2_Sel_Button);
            this.Controls.Add(this.File2_Sel_Box);
            this.Controls.Add(this.File1_label);
            this.Controls.Add(this.File1_Sel_Button);
            this.Controls.Add(this.File1_Sel_Box);
            this.Controls.Add(this.Quit_Button);
            this.Controls.Add(this.Compute_Button);
            this.Name = "騰落率分析";
            this.Text = "騰落率分析";
            this.Load += new System.EventHandler(this.騰落率分析_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Compute_Button;
        private System.Windows.Forms.Button Quit_Button;
        private System.Windows.Forms.TextBox File1_Sel_Box;
        private System.Windows.Forms.Button File1_Sel_Button;
        private System.Windows.Forms.Label File1_label;
        private System.Windows.Forms.Label File2_label;
        private System.Windows.Forms.Button File2_Sel_Button;
        private System.Windows.Forms.TextBox File2_Sel_Box;
        private System.Windows.Forms.Label File3_Sel_label;
        private System.Windows.Forms.Button File3_Sel_button;
        private System.Windows.Forms.TextBox File3_Sel_Box;
        private System.Windows.Forms.Label File3_label;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label Rise_and_Fall_Rate_label;
        private System.Windows.Forms.TextBox Rise_and_Fall_Rate_Box;
        private System.Windows.Forms.Label Ave_frames_label;
        private System.Windows.Forms.TextBox Ave_frames_Box;
    }
}


namespace ICA07
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_UnsortedName_Lbx = new System.Windows.Forms.ListBox();
            this.UI_SortedName_Lbx = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_value_tbx = new System.Windows.Forms.TextBox();
            this.UI_AddName_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Names (Order of Entry)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "List of Names (Sorted)";
            // 
            // UI_UnsortedName_Lbx
            // 
            this.UI_UnsortedName_Lbx.FormattingEnabled = true;
            this.UI_UnsortedName_Lbx.ItemHeight = 16;
            this.UI_UnsortedName_Lbx.Location = new System.Drawing.Point(46, 76);
            this.UI_UnsortedName_Lbx.Name = "UI_UnsortedName_Lbx";
            this.UI_UnsortedName_Lbx.Size = new System.Drawing.Size(177, 244);
            this.UI_UnsortedName_Lbx.TabIndex = 2;
            // 
            // UI_SortedName_Lbx
            // 
            this.UI_SortedName_Lbx.FormattingEnabled = true;
            this.UI_SortedName_Lbx.ItemHeight = 16;
            this.UI_SortedName_Lbx.Location = new System.Drawing.Point(585, 76);
            this.UI_SortedName_Lbx.Name = "UI_SortedName_Lbx";
            this.UI_SortedName_Lbx.Size = new System.Drawing.Size(177, 244);
            this.UI_SortedName_Lbx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name: ";
            // 
            // UI_value_tbx
            // 
            this.UI_value_tbx.Location = new System.Drawing.Point(330, 73);
            this.UI_value_tbx.Name = "UI_value_tbx";
            this.UI_value_tbx.Size = new System.Drawing.Size(185, 22);
            this.UI_value_tbx.TabIndex = 5;
            // 
            // UI_AddName_btn
            // 
            this.UI_AddName_btn.Location = new System.Drawing.Point(330, 135);
            this.UI_AddName_btn.Name = "UI_AddName_btn";
            this.UI_AddName_btn.Size = new System.Drawing.Size(185, 34);
            this.UI_AddName_btn.TabIndex = 6;
            this.UI_AddName_btn.Text = "Add Name";
            this.UI_AddName_btn.UseVisualStyleBackColor = true;
            this.UI_AddName_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UI_AddName_btn);
            this.Controls.Add(this.UI_value_tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UI_SortedName_Lbx);
            this.Controls.Add(this.UI_UnsortedName_Lbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox UI_UnsortedName_Lbx;
        private System.Windows.Forms.ListBox UI_SortedName_Lbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UI_value_tbx;
        private System.Windows.Forms.Button UI_AddName_btn;
        private System.Windows.Forms.Button button2;
    }
}


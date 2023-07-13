namespace Reflection
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
            this.gb_ = new System.Windows.Forms.GroupBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.gb_ctor = new System.Windows.Forms.GroupBox();
            this.lb_ctors = new System.Windows.Forms.ListBox();
            this.gb_props = new System.Windows.Forms.GroupBox();
            this.lb_props = new System.Windows.Forms.ListBox();
            this.gb_meths = new System.Windows.Forms.GroupBox();
            this.lb_meths = new System.Windows.Forms.ListBox();
            this.gb_.SuspendLayout();
            this.gb_ctor.SuspendLayout();
            this.gb_props.SuspendLayout();
            this.gb_meths.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_
            // 
            this.gb_.Controls.Add(this.bttnSearch);
            this.gb_.Controls.Add(this.tb_search);
            this.gb_.Location = new System.Drawing.Point(31, 29);
            this.gb_.Name = "gb_";
            this.gb_.Size = new System.Drawing.Size(1090, 52);
            this.gb_.TabIndex = 0;
            this.gb_.TabStop = false;
            this.gb_.Text = "Class Name";
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(990, 16);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(94, 24);
            this.bttnSearch.TabIndex = 1;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(15, 18);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(969, 22);
            this.tb_search.TabIndex = 0;
            // 
            // gb_ctor
            // 
            this.gb_ctor.Controls.Add(this.lb_ctors);
            this.gb_ctor.Location = new System.Drawing.Point(39, 100);
            this.gb_ctor.Name = "gb_ctor";
            this.gb_ctor.Size = new System.Drawing.Size(290, 333);
            this.gb_ctor.TabIndex = 1;
            this.gb_ctor.TabStop = false;
            this.gb_ctor.Text = "CTORS";
            // 
            // lb_ctors
            // 
            this.lb_ctors.FormattingEnabled = true;
            this.lb_ctors.ItemHeight = 16;
            this.lb_ctors.Location = new System.Drawing.Point(0, 19);
            this.lb_ctors.Name = "lb_ctors";
            this.lb_ctors.Size = new System.Drawing.Size(277, 308);
            this.lb_ctors.TabIndex = 0;
            // 
            // gb_props
            // 
            this.gb_props.Controls.Add(this.lb_props);
            this.gb_props.Location = new System.Drawing.Point(329, 100);
            this.gb_props.Name = "gb_props";
            this.gb_props.Size = new System.Drawing.Size(218, 333);
            this.gb_props.TabIndex = 1;
            this.gb_props.TabStop = false;
            this.gb_props.Text = "PROPS";
            // 
            // lb_props
            // 
            this.lb_props.FormattingEnabled = true;
            this.lb_props.ItemHeight = 16;
            this.lb_props.Location = new System.Drawing.Point(6, 22);
            this.lb_props.Name = "lb_props";
            this.lb_props.Size = new System.Drawing.Size(205, 308);
            this.lb_props.TabIndex = 0;
            // 
            // gb_meths
            // 
            this.gb_meths.Controls.Add(this.lb_meths);
            this.gb_meths.Location = new System.Drawing.Point(553, 100);
            this.gb_meths.Name = "gb_meths";
            this.gb_meths.Size = new System.Drawing.Size(573, 333);
            this.gb_meths.TabIndex = 1;
            this.gb_meths.TabStop = false;
            this.gb_meths.Text = "METHODS";
            // 
            // lb_meths
            // 
            this.lb_meths.FormattingEnabled = true;
            this.lb_meths.ItemHeight = 16;
            this.lb_meths.Location = new System.Drawing.Point(6, 19);
            this.lb_meths.Name = "lb_meths";
            this.lb_meths.Size = new System.Drawing.Size(562, 308);
            this.lb_meths.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 450);
            this.Controls.Add(this.gb_meths);
            this.Controls.Add(this.gb_props);
            this.Controls.Add(this.gb_ctor);
            this.Controls.Add(this.gb_);
            this.Name = "Form1";
            this.Text = "Reflection";
            this.gb_.ResumeLayout(false);
            this.gb_.PerformLayout();
            this.gb_ctor.ResumeLayout(false);
            this.gb_props.ResumeLayout(false);
            this.gb_meths.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.GroupBox gb_ctor;
        private System.Windows.Forms.GroupBox gb_props;
        private System.Windows.Forms.GroupBox gb_meths;
        private System.Windows.Forms.ListBox lb_ctors;
        private System.Windows.Forms.ListBox lb_props;
        private System.Windows.Forms.ListBox lb_meths;
    }
}


namespace Lab1._1
{
    partial class Form1
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
            this.abort_retry_ignor_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dialog_result_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize_button = new Lab1._1.RoundButton();
            this.exit_button = new Lab1._1.RoundButton();
            this.line_label = new System.Windows.Forms.Label();
            this.yes_no_cancel_button = new System.Windows.Forms.Button();
            this.file_open_button = new System.Windows.Forms.Button();
            this.custom_dialog_button = new System.Windows.Forms.Button();
            this.which_option_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // abort_retry_ignor_button
            // 
            this.abort_retry_ignor_button.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.abort_retry_ignor_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.abort_retry_ignor_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abort_retry_ignor_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.abort_retry_ignor_button.ForeColor = System.Drawing.Color.IndianRed;
            this.abort_retry_ignor_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.abort_retry_ignor_button.Location = new System.Drawing.Point(290, 82);
            this.abort_retry_ignor_button.Name = "abort_retry_ignor_button";
            this.abort_retry_ignor_button.Size = new System.Drawing.Size(159, 35);
            this.abort_retry_ignor_button.TabIndex = 0;
            this.abort_retry_ignor_button.Text = "Abort, Retry, Ignore";
            this.abort_retry_ignor_button.UseVisualStyleBackColor = false;
            this.abort_retry_ignor_button.Click += new System.EventHandler(this.abort_retry_ignor_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.textBox1.Location = new System.Drawing.Point(227, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 25);
            this.textBox1.TabIndex = 5;
            // 
            // dialog_result_label
            // 
            this.dialog_result_label.AutoSize = true;
            this.dialog_result_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dialog_result_label.ForeColor = System.Drawing.Color.IndianRed;
            this.dialog_result_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dialog_result_label.Location = new System.Drawing.Point(125, 225);
            this.dialog_result_label.Name = "dialog_result_label";
            this.dialog_result_label.Size = new System.Drawing.Size(97, 19);
            this.dialog_result_label.TabIndex = 7;
            this.dialog_result_label.Text = "Dialog Result";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.minimize_button);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 32);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.Yellow;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.ForeColor = System.Drawing.Color.Yellow;
            this.minimize_button.Location = new System.Drawing.Point(522, 8);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(16, 16);
            this.minimize_button.TabIndex = 17;
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.IndianRed;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.IndianRed;
            this.exit_button.Location = new System.Drawing.Point(548, 8);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(16, 16);
            this.exit_button.TabIndex = 16;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // line_label
            // 
            this.line_label.BackColor = System.Drawing.Color.IndianRed;
            this.line_label.Location = new System.Drawing.Point(0, 32);
            this.line_label.Name = "line_label";
            this.line_label.Size = new System.Drawing.Size(574, 1);
            this.line_label.TabIndex = 15;
            // 
            // yes_no_cancel_button
            // 
            this.yes_no_cancel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.yes_no_cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yes_no_cancel_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yes_no_cancel_button.ForeColor = System.Drawing.Color.IndianRed;
            this.yes_no_cancel_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.yes_no_cancel_button.Location = new System.Drawing.Point(125, 82);
            this.yes_no_cancel_button.Name = "yes_no_cancel_button";
            this.yes_no_cancel_button.Size = new System.Drawing.Size(159, 35);
            this.yes_no_cancel_button.TabIndex = 16;
            this.yes_no_cancel_button.Text = "Yes, No, Cancel";
            this.yes_no_cancel_button.UseVisualStyleBackColor = false;
            this.yes_no_cancel_button.Click += new System.EventHandler(this.yes_no_cancel_button_Click);
            // 
            // file_open_button
            // 
            this.file_open_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.file_open_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.file_open_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.file_open_button.ForeColor = System.Drawing.Color.IndianRed;
            this.file_open_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.file_open_button.Location = new System.Drawing.Point(125, 123);
            this.file_open_button.Name = "file_open_button";
            this.file_open_button.Size = new System.Drawing.Size(159, 35);
            this.file_open_button.TabIndex = 17;
            this.file_open_button.Text = "File Open";
            this.file_open_button.UseVisualStyleBackColor = false;
            this.file_open_button.Click += new System.EventHandler(this.file_open_button_Click);
            // 
            // custom_dialog_button
            // 
            this.custom_dialog_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.custom_dialog_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_dialog_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.custom_dialog_button.ForeColor = System.Drawing.Color.IndianRed;
            this.custom_dialog_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.custom_dialog_button.Location = new System.Drawing.Point(290, 123);
            this.custom_dialog_button.Name = "custom_dialog_button";
            this.custom_dialog_button.Size = new System.Drawing.Size(159, 35);
            this.custom_dialog_button.TabIndex = 18;
            this.custom_dialog_button.Text = "Custom Dialog";
            this.custom_dialog_button.UseVisualStyleBackColor = false;
            this.custom_dialog_button.Click += new System.EventHandler(this.custom_dialog_button_Click);
            // 
            // which_option_button
            // 
            this.which_option_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.which_option_button.Enabled = false;
            this.which_option_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.which_option_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.which_option_button.ForeColor = System.Drawing.Color.IndianRed;
            this.which_option_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.which_option_button.Location = new System.Drawing.Point(207, 164);
            this.which_option_button.Name = "which_option_button";
            this.which_option_button.Size = new System.Drawing.Size(159, 35);
            this.which_option_button.TabIndex = 19;
            this.which_option_button.Text = "Which Option";
            this.which_option_button.UseVisualStyleBackColor = false;
            this.which_option_button.Click += new System.EventHandler(this.which_option_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(574, 297);
            this.Controls.Add(this.which_option_button);
            this.Controls.Add(this.custom_dialog_button);
            this.Controls.Add(this.file_open_button);
            this.Controls.Add(this.yes_no_cancel_button);
            this.Controls.Add(this.line_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dialog_result_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.abort_retry_ignor_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab work 1.1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button abort_retry_ignor_button;
        private RoundButton exit_button;
        private RoundButton minimize_button;
        private Label dialog_result_label;
        private Label line_label;

        private Panel panel1;
        private Button yes_no_cancel_button;
        private Button file_open_button;
        private Button custom_dialog_button;
        internal TextBox textBox1;
        internal Button which_option_button;
    }
}
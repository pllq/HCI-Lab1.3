namespace Lab3
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize_button = new Lab1._1.RoundButton();
            this.exit_button = new Lab1._1.RoundButton();
            this.message_and_option_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.message_enter_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.line_label = new System.Windows.Forms.Label();
            this.option4_checkBox = new System.Windows.Forms.CheckBox();
            this.option3_checkBox = new System.Windows.Forms.CheckBox();
            this.option2_checkBox = new System.Windows.Forms.CheckBox();
            this.option1_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.variant3_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.minimize_button);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.message_and_option_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 32);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.Yellow;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.ForeColor = System.Drawing.Color.Yellow;
            this.minimize_button.Location = new System.Drawing.Point(354, 8);
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
            this.exit_button.Location = new System.Drawing.Point(380, 8);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(16, 16);
            this.exit_button.TabIndex = 16;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // message_and_option_label
            // 
            this.message_and_option_label.AutoSize = true;
            this.message_and_option_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.message_and_option_label.ForeColor = System.Drawing.Color.IndianRed;
            this.message_and_option_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.message_and_option_label.Location = new System.Drawing.Point(3, 7);
            this.message_and_option_label.Name = "message_and_option_label";
            this.message_and_option_label.Size = new System.Drawing.Size(146, 19);
            this.message_and_option_label.TabIndex = 33;
            this.message_and_option_label.Text = "Message and Option";
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ok_button.ForeColor = System.Drawing.Color.IndianRed;
            this.ok_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ok_button.Location = new System.Drawing.Point(155, 119);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(215, 29);
            this.ok_button.TabIndex = 22;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // message_enter_label
            // 
            this.message_enter_label.AutoSize = true;
            this.message_enter_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.message_enter_label.ForeColor = System.Drawing.Color.IndianRed;
            this.message_enter_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.message_enter_label.Location = new System.Drawing.Point(36, 65);
            this.message_enter_label.Name = "message_enter_label";
            this.message_enter_label.Size = new System.Drawing.Size(106, 19);
            this.message_enter_label.TabIndex = 21;
            this.message_enter_label.Text = "Message enter";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.textBox1.Location = new System.Drawing.Point(149, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 25);
            this.textBox1.TabIndex = 20;
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel_button.ForeColor = System.Drawing.Color.IndianRed;
            this.cancel_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancel_button.Location = new System.Drawing.Point(155, 154);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(215, 29);
            this.cancel_button.TabIndex = 23;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // line_label
            // 
            this.line_label.BackColor = System.Drawing.Color.IndianRed;
            this.line_label.Location = new System.Drawing.Point(0, 32);
            this.line_label.Name = "line_label";
            this.line_label.Size = new System.Drawing.Size(406, 1);
            this.line_label.TabIndex = 18;
            // 
            // option4_checkBox
            // 
            this.option4_checkBox.AutoSize = true;
            this.option4_checkBox.Checked = true;
            this.option4_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.option4_checkBox.ForeColor = System.Drawing.Color.IndianRed;
            this.option4_checkBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.option4_checkBox.Location = new System.Drawing.Point(43, 198);
            this.option4_checkBox.Name = "option4_checkBox";
            this.option4_checkBox.Size = new System.Drawing.Size(74, 19);
            this.option4_checkBox.TabIndex = 27;
            this.option4_checkBox.Text = "Option 4";
            this.option4_checkBox.UseVisualStyleBackColor = true;
            // 
            // option3_checkBox
            // 
            this.option3_checkBox.AutoSize = true;
            this.option3_checkBox.Checked = true;
            this.option3_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.option3_checkBox.ForeColor = System.Drawing.Color.IndianRed;
            this.option3_checkBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.option3_checkBox.Location = new System.Drawing.Point(43, 173);
            this.option3_checkBox.Name = "option3_checkBox";
            this.option3_checkBox.Size = new System.Drawing.Size(74, 19);
            this.option3_checkBox.TabIndex = 26;
            this.option3_checkBox.Text = "Option 3";
            this.option3_checkBox.UseVisualStyleBackColor = true;
            // 
            // option2_checkBox
            // 
            this.option2_checkBox.AutoSize = true;
            this.option2_checkBox.Checked = true;
            this.option2_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.option2_checkBox.ForeColor = System.Drawing.Color.IndianRed;
            this.option2_checkBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.option2_checkBox.Location = new System.Drawing.Point(43, 148);
            this.option2_checkBox.Name = "option2_checkBox";
            this.option2_checkBox.Size = new System.Drawing.Size(74, 19);
            this.option2_checkBox.TabIndex = 25;
            this.option2_checkBox.Text = "Option 2";
            this.option2_checkBox.UseVisualStyleBackColor = true;
            // 
            // option1_checkBox
            // 
            this.option1_checkBox.AutoSize = true;
            this.option1_checkBox.Checked = true;
            this.option1_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.option1_checkBox.ForeColor = System.Drawing.Color.IndianRed;
            this.option1_checkBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.option1_checkBox.Location = new System.Drawing.Point(43, 123);
            this.option1_checkBox.Name = "option1_checkBox";
            this.option1_checkBox.Size = new System.Drawing.Size(74, 19);
            this.option1_checkBox.TabIndex = 24;
            this.option1_checkBox.Text = "Option 1";
            this.option1_checkBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(36, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 1);
            this.label1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(36, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 1);
            this.label2.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(148, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 102);
            this.label3.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(36, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 102);
            this.label4.TabIndex = 31;
            // 
            // variant3_button
            // 
            this.variant3_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.variant3_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.variant3_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.variant3_button.ForeColor = System.Drawing.Color.IndianRed;
            this.variant3_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.variant3_button.Location = new System.Drawing.Point(155, 189);
            this.variant3_button.Name = "variant3_button";
            this.variant3_button.Size = new System.Drawing.Size(215, 29);
            this.variant3_button.TabIndex = 32;
            this.variant3_button.Text = "My variant button";
            this.variant3_button.UseVisualStyleBackColor = false;
            this.variant3_button.Click += new System.EventHandler(this.variant3_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(406, 241);
            this.Controls.Add(this.variant3_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.option4_checkBox);
            this.Controls.Add(this.option3_checkBox);
            this.Controls.Add(this.option2_checkBox);
            this.Controls.Add(this.option1_checkBox);
            this.Controls.Add(this.line_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.message_enter_label);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Lab1._1.RoundButton minimize_button;
        private Lab1._1.RoundButton exit_button;
        private Button ok_button;
        private Label message_enter_label;
        private TextBox textBox1;
        private Button cancel_button;
        private Label line_label;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button variant3_button;
        internal CheckBox option4_checkBox;
        internal CheckBox option3_checkBox;
        internal CheckBox option2_checkBox;
        internal CheckBox option1_checkBox;
        private Label message_and_option_label;
    }
}
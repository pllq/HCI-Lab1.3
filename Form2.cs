using Lab1._1;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        internal static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private Form1 my_form1;

        public Form2 Form2_get()
        {
            return this;
        }

        public Form2(Form1 arg_my_form1)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            my_form1 = arg_my_form1;
        }

        //Custom panel

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        //Buttons

        private void exit_button_Click(object sender, EventArgs e)
        {
            my_form1.which_option_button.Enabled = false;
            Form1.Is_already_opened = false;
            this.Close();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            my_form1.which_option_button.Enabled = true;
            my_form1.textBox1.Text = textBox1.Text;
            DialogResult dialog_result = MessageBox.Show("You unlocked \"Which Option\" button. Now you can check what checkboxes are checked.", 
                                                         "\"Which Option\" unlocked", MessageBoxButtons.OK);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            my_form1.which_option_button.Enabled = false;
        }

        private void variant3_button_Click(object sender, EventArgs e)
        {
            DialogResult dialog_result = MessageBox.Show("Ok or Cancel?", "Ok, Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            my_form1.textBox1.Text = dialog_result.ToString();
        }
    }
}

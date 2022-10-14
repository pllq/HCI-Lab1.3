using Lab3;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Button = System.Windows.Forms.Button;

namespace Lab1._1
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        //For custom panel (border) (functinality to move)

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

        //

        internal void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void yes_no_cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult dialog_result = MessageBox.Show("Yes, No, Cancel", "Yes, No or Cancel?", MessageBoxButtons.YesNoCancel);

            switch (dialog_result)
            {
                case DialogResult.Yes:
                    textBox1.Text = "Yes";
                    break;

                case DialogResult.No:
                    textBox1.Text = "No";
                    break;

                case DialogResult.Cancel:
                    textBox1.Text = "Cancel";
                    break;
            }
        }

        private void abort_retry_ignor_button_Click(object sender, EventArgs e)
        {
            DialogResult dialog_result = MessageBox.Show("Abort, Retry, Ignore", "Abort, Retry or Ignore?", MessageBoxButtons.AbortRetryIgnore);

            switch (dialog_result) 
            {
                case DialogResult.Abort:
                    textBox1.Text = "Abort";
                    break;

                case DialogResult.Retry:
                    textBox1.Text = "Retry";
                    break;

                case DialogResult.Ignore:
                    textBox1.Text = "Ignore";
                    break;
            }
        }

        private void file_open_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            textBox1.Text = openFileDialog.SafeFileName;
        }

        internal static bool Is_already_opened { get; set; } = false;
        private void custom_dialog_button_Click(object sender, EventArgs e)
        {
            switch (Is_already_opened) 
            {
                case true:
                    MessageBox.Show("Form is already opened.", "Error");
                    break;

                case false:
                    Is_already_opened = true;
                    var my_second_form = new Form2(this);
                    my_second_form.Show();
                    //my_second_form.ShowDialog();
                    break;

            }
        }

        private void which_option_button_Click(object sender, EventArgs e)
        {
            byte how_many_checkboxes_are_checked = 0;

            foreach (Form2 oForm1 in Application.OpenForms.OfType<Form2>())
            {
                switch (oForm1.option1_checkBox.Checked)
                {
                    case true:
                        how_many_checkboxes_are_checked++;
                        break;

                    case false:
                        break;
                }

                switch (oForm1.option2_checkBox.Checked)
                {
                    case true:
                        how_many_checkboxes_are_checked++;
                        break;

                    case false:
                        break;
                }

                switch (oForm1.option3_checkBox.Checked)
                {
                    case true:
                        how_many_checkboxes_are_checked++;
                        break;

                    case false:
                        break;
                }

                switch (oForm1.option4_checkBox.Checked)
                {
                    case true:
                        how_many_checkboxes_are_checked++;
                        break;

                    case false:
                        break;
                }
            }

            MessageBox.Show($"Number of the checked checkboxes are {how_many_checkboxes_are_checked}.", 
                             "Number of the checked checkboxes");
        }
    }
}
using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPModul3_KPL
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblOutput;

        public Form1()
        {
            InitializeComponent();

            // Mapping komponen default ke variabel baru
            txtInput = textBox2; 
            btnSubmit = button2;
            lblOutput = label2;

            // Mengatur properti komponen lewat kode
            txtInput.Text = "Masukkan Nama";
            txtInput.Font = new System.Drawing.Font("Arial", 12);
            txtInput.Width = 200;

            btnSubmit.Text = "Kirim";
            btnSubmit.BackColor = System.Drawing.Color.LightBlue;
            btnSubmit.ForeColor = System.Drawing.Color.DarkBlue;

            lblOutput.Text = "Output akan tampil di sini";
            lblOutput.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            lblOutput.ForeColor = System.Drawing.Color.Red;

            // event klik tombol
            btnSubmit.Click += new EventHandler(BtnSubmit_Click);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string nama = txtInput.Text;
            lblOutput.Text = "Halo " + nama;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

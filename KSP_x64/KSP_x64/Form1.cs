using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace KSP_x64
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        string caminhoJogo = "ksp.exe";

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            btn_cancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_cancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.ForeColor = BackColor;
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.FlatAppearance.BorderSize = 0;

            btn_jogar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_jogar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_jogar.FlatStyle = FlatStyle.Flat;
            btn_jogar.ForeColor = BackColor;
            btn_jogar.UseVisualStyleBackColor = true;
            btn_jogar.FlatAppearance.BorderSize = 0;

            btnFechar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = BackColor;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.FlatAppearance.BorderSize = 0;

            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.ForeColor = BackColor;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.UseVisualStyleBackColor = true;

            rdbKSP.Checked = true;
            rdbKSP.ForeColor = ColorTranslator.FromHtml("#A8ACB3");
            rdbKSPRO.ForeColor = ColorTranslator.FromHtml("#A8ACB3");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {
        }

        private void rdbKSP_CheckedChanged(object sender, EventArgs e)
        {
            rdbKSP.ForeColor = ColorTranslator.FromHtml("#CED2CE");
            rdbKSPRO.ForeColor = ColorTranslator.FromHtml("#A8ACB3");
        }

        private void rdbKSPRO_CheckedChanged(object sender, EventArgs e)
        {
            rdbKSPRO.ForeColor = ColorTranslator.FromHtml("#CED2CE");
            rdbKSP.ForeColor = ColorTranslator.FromHtml("#A8ACB3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            try
            {
                var ksp = new Process();
                ksp.StartInfo = new ProcessStartInfo(@Directory.GetCurrentDirectory() + "\\" + caminhoJogo)
                {
                    UseShellExecute = true
                };
                ksp.Start();
                Thread.Sleep(1000);
                this.Visible = false;
                while (Process.GetProcessesByName("ksp").Length != 0)
                {
                    Thread.Sleep(500);
                }
                Close();
            }
            catch (Exception erro) { MessageBox.Show("Arquivos incorretos.\n Fechando");  Close(); }
        }

        private void rdbKSP_MouseClick(object sender, MouseEventArgs e)
        {
            caminhoJogo = "ksp.exe";
        }

        private void rdbKSPRO_MouseClick(object sender, MouseEventArgs e)
        {
            caminhoJogo = "kspRO.lnk";
        }
    }
}

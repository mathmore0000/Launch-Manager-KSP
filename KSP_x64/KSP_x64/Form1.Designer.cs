
namespace KSP_x64
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbKSP = new System.Windows.Forms.RadioButton();
            this.rdbKSPRO = new System.Windows.Forms.RadioButton();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Location = new System.Drawing.Point(272, 143);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(95, 23);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_jogar
            // 
            this.btn_jogar.BackColor = System.Drawing.Color.Transparent;
            this.btn_jogar.Location = new System.Drawing.Point(170, 143);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(96, 23);
            this.btn_jogar.TabIndex = 1;
            this.btn_jogar.UseVisualStyleBackColor = false;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrincipal.Controls.Add(this.btnMinimizar);
            this.pnlPrincipal.Controls.Add(this.btnFechar);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(373, 37);
            this.pnlPrincipal.TabIndex = 2;
            this.pnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrincipal_Paint);
            this.pnlPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPrincipal_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Location = new System.Drawing.Point(333, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 15);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFechar.Location = new System.Drawing.Point(351, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(16, 15);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iniciar KSP";
            // 
            // rdbKSP
            // 
            this.rdbKSP.AutoSize = true;
            this.rdbKSP.BackColor = System.Drawing.Color.Transparent;
            this.rdbKSP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbKSP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbKSP.Location = new System.Drawing.Point(28, 65);
            this.rdbKSP.Name = "rdbKSP";
            this.rdbKSP.Size = new System.Drawing.Size(84, 18);
            this.rdbKSP.TabIndex = 4;
            this.rdbKSP.TabStop = true;
            this.rdbKSP.Text = "Launch KSP";
            this.rdbKSP.UseVisualStyleBackColor = false;
            this.rdbKSP.CheckedChanged += new System.EventHandler(this.rdbKSP_CheckedChanged);
            this.rdbKSP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbKSP_MouseClick);
            // 
            // rdbKSPRO
            // 
            this.rdbKSPRO.AutoSize = true;
            this.rdbKSPRO.BackColor = System.Drawing.Color.Transparent;
            this.rdbKSPRO.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbKSPRO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbKSPRO.Location = new System.Drawing.Point(28, 95);
            this.rdbKSPRO.Name = "rdbKSPRO";
            this.rdbKSPRO.Size = new System.Drawing.Size(102, 18);
            this.rdbKSPRO.TabIndex = 5;
            this.rdbKSPRO.TabStop = true;
            this.rdbKSPRO.Text = "Launch KSP RO";
            this.rdbKSPRO.UseVisualStyleBackColor = false;
            this.rdbKSPRO.CheckedChanged += new System.EventHandler(this.rdbKSPRO_CheckedChanged);
            this.rdbKSPRO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbKSPRO_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(370, 176);
            this.Controls.Add(this.rdbKSPRO);
            this.Controls.Add(this.rdbKSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.btn_cancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbKSP;
        private System.Windows.Forms.RadioButton rdbKSPRO;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
    }
}


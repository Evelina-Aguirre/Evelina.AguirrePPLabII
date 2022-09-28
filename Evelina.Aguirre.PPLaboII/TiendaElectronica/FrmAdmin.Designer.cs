
namespace UITiendaElectronica
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.llbMinimizar = new System.Windows.Forms.LinkLabel();
            this.llbCerrar = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(12, -1);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 28);
            this.linkLabel1.TabIndex = 102;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "            ";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Transparent;
            // 
            // llbMinimizar
            // 
            this.llbMinimizar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.llbMinimizar.AutoSize = true;
            this.llbMinimizar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("llbMinimizar.Image")));
            this.llbMinimizar.LinkColor = System.Drawing.Color.Transparent;
            this.llbMinimizar.Location = new System.Drawing.Point(1096, -1);
            this.llbMinimizar.Name = "llbMinimizar";
            this.llbMinimizar.Size = new System.Drawing.Size(27, 28);
            this.llbMinimizar.TabIndex = 113;
            this.llbMinimizar.TabStop = true;
            this.llbMinimizar.Text = "   ";
            this.llbMinimizar.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.llbMinimizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbMinimizar_LinkClicked);
            // 
            // llbCerrar
            // 
            this.llbCerrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.llbCerrar.AutoSize = true;
            this.llbCerrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("llbCerrar.Image")));
            this.llbCerrar.LinkColor = System.Drawing.Color.Transparent;
            this.llbCerrar.Location = new System.Drawing.Point(1112, -1);
            this.llbCerrar.Name = "llbCerrar";
            this.llbCerrar.Size = new System.Drawing.Size(42, 28);
            this.llbCerrar.TabIndex = 114;
            this.llbCerrar.TabStop = true;
            this.llbCerrar.Text = "      ";
            this.llbCerrar.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.llbCerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCerrar_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(350, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 222);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(394, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 23);
            this.dateTimePicker1.TabIndex = 116;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(909, 102);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 117;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1155, 605);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.llbMinimizar);
            this.Controls.Add(this.llbCerrar);
            this.Controls.Add(this.linkLabel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAdmin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmAdmin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmAdmin_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel llbMinimizar;
        private System.Windows.Forms.LinkLabel llbCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
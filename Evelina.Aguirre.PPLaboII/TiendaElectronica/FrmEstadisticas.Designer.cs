
namespace UITiendaElectronica
{
    partial class FrmEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            this.btnVentasRealizadas = new System.Windows.Forms.Button();
            this.lblMontoInsuficiente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidadVentasRealizadas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlaquetas = new System.Windows.Forms.Button();
            this.btnLeds = new System.Windows.Forms.Button();
            this.btnBobinas = new System.Windows.Forms.Button();
            this.btnCapacitores = new System.Windows.Forms.Button();
            this.btnConectores = new System.Windows.Forms.Button();
            this.btnCircuitosIntegrados = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnControlTermico = new System.Windows.Forms.Button();
            this.btnLimpieza = new System.Windows.Forms.Button();
            this.btnSoldado = new System.Windows.Forms.Button();
            this.lblMasVendidoPorCategoria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPromedioGananciasCategoria = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVentasRealizadas
            // 
            this.btnVentasRealizadas.Location = new System.Drawing.Point(308, 12);
            this.btnVentasRealizadas.Name = "btnVentasRealizadas";
            this.btnVentasRealizadas.Size = new System.Drawing.Size(142, 23);
            this.btnVentasRealizadas.TabIndex = 0;
            this.btnVentasRealizadas.Text = "Detalle ventas";
            this.btnVentasRealizadas.UseVisualStyleBackColor = true;
            // 
            // lblMontoInsuficiente
            // 
            this.lblMontoInsuficiente.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoInsuficiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMontoInsuficiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblMontoInsuficiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMontoInsuficiente.Location = new System.Drawing.Point(-66, 208);
            this.lblMontoInsuficiente.Name = "lblMontoInsuficiente";
            this.lblMontoInsuficiente.Size = new System.Drawing.Size(488, 104);
            this.lblMontoInsuficiente.TabIndex = 134;
            this.lblMontoInsuficiente.Text = "                  ";
            this.lblMontoInsuficiente.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 135;
            this.label1.Text = "Cantidad de Ventas Total";
            // 
            // lblCantidadVentasRealizadas
            // 
            this.lblCantidadVentasRealizadas.AutoSize = true;
            this.lblCantidadVentasRealizadas.Location = new System.Drawing.Point(459, 58);
            this.lblCantidadVentasRealizadas.Name = "lblCantidadVentasRealizadas";
            this.lblCantidadVentasRealizadas.Size = new System.Drawing.Size(163, 15);
            this.lblCantidadVentasRealizadas.TabIndex = 136;
            this.lblCantidadVentasRealizadas.Text = "Cantidad de Ventas realizadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 15);
            this.label2.TabIndex = 137;
            this.label2.Text = "Producto Mas Vendido por categoría";
            // 
            // btnPlaquetas
            // 
            this.btnPlaquetas.Location = new System.Drawing.Point(11, 252);
            this.btnPlaquetas.Name = "btnPlaquetas";
            this.btnPlaquetas.Size = new System.Drawing.Size(180, 24);
            this.btnPlaquetas.TabIndex = 143;
            this.btnPlaquetas.Text = "Plaquetas";
            this.btnPlaquetas.UseVisualStyleBackColor = true;
            this.btnPlaquetas.Click += new System.EventHandler(this.btnPlaquetas_Click);
            // 
            // btnLeds
            // 
            this.btnLeds.Location = new System.Drawing.Point(12, 49);
            this.btnLeds.Name = "btnLeds";
            this.btnLeds.Size = new System.Drawing.Size(180, 24);
            this.btnLeds.TabIndex = 138;
            this.btnLeds.Text = "Leds";
            this.btnLeds.UseVisualStyleBackColor = true;
            this.btnLeds.Click += new System.EventHandler(this.btnLeds_Click);
            // 
            // btnBobinas
            // 
            this.btnBobinas.Location = new System.Drawing.Point(12, 87);
            this.btnBobinas.Name = "btnBobinas";
            this.btnBobinas.Size = new System.Drawing.Size(180, 24);
            this.btnBobinas.TabIndex = 139;
            this.btnBobinas.Text = "Bobinas";
            this.btnBobinas.UseVisualStyleBackColor = true;
            this.btnBobinas.Click += new System.EventHandler(this.btnBobinas_Click);
            // 
            // btnCapacitores
            // 
            this.btnCapacitores.Location = new System.Drawing.Point(12, 127);
            this.btnCapacitores.Name = "btnCapacitores";
            this.btnCapacitores.Size = new System.Drawing.Size(180, 24);
            this.btnCapacitores.TabIndex = 140;
            this.btnCapacitores.Text = "Capacitores";
            this.btnCapacitores.UseVisualStyleBackColor = true;
            // 
            // btnConectores
            // 
            this.btnConectores.Location = new System.Drawing.Point(11, 168);
            this.btnConectores.Name = "btnConectores";
            this.btnConectores.Size = new System.Drawing.Size(180, 24);
            this.btnConectores.TabIndex = 141;
            this.btnConectores.Text = "Conectores";
            this.btnConectores.UseVisualStyleBackColor = true;
            this.btnConectores.Click += new System.EventHandler(this.btnConectores_Click);
            // 
            // btnCircuitosIntegrados
            // 
            this.btnCircuitosIntegrados.Location = new System.Drawing.Point(12, 212);
            this.btnCircuitosIntegrados.Name = "btnCircuitosIntegrados";
            this.btnCircuitosIntegrados.Size = new System.Drawing.Size(180, 24);
            this.btnCircuitosIntegrados.TabIndex = 142;
            this.btnCircuitosIntegrados.Text = "Circuitos Integrados";
            this.btnCircuitosIntegrados.UseVisualStyleBackColor = true;
            this.btnCircuitosIntegrados.Click += new System.EventHandler(this.btnCircuitosIntegrados_Click);
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.Location = new System.Drawing.Point(12, 432);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(180, 24);
            this.btnHerramientas.TabIndex = 147;
            this.btnHerramientas.Text = "Herramientas";
            this.btnHerramientas.UseVisualStyleBackColor = true;
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // btnControlTermico
            // 
            this.btnControlTermico.Location = new System.Drawing.Point(12, 296);
            this.btnControlTermico.Name = "btnControlTermico";
            this.btnControlTermico.Size = new System.Drawing.Size(180, 24);
            this.btnControlTermico.TabIndex = 144;
            this.btnControlTermico.Text = "Control Térmico";
            this.btnControlTermico.UseVisualStyleBackColor = true;
            this.btnControlTermico.Click += new System.EventHandler(this.btnControlTermico_Click);
            // 
            // btnLimpieza
            // 
            this.btnLimpieza.Location = new System.Drawing.Point(12, 339);
            this.btnLimpieza.Name = "btnLimpieza";
            this.btnLimpieza.Size = new System.Drawing.Size(180, 24);
            this.btnLimpieza.TabIndex = 145;
            this.btnLimpieza.Text = "Limpieza";
            this.btnLimpieza.UseVisualStyleBackColor = true;
            this.btnLimpieza.Click += new System.EventHandler(this.btnLimpieza_Click);
            // 
            // btnSoldado
            // 
            this.btnSoldado.Location = new System.Drawing.Point(11, 387);
            this.btnSoldado.Name = "btnSoldado";
            this.btnSoldado.Size = new System.Drawing.Size(180, 24);
            this.btnSoldado.TabIndex = 146;
            this.btnSoldado.Text = "Soldado";
            this.btnSoldado.UseVisualStyleBackColor = true;
            this.btnSoldado.Click += new System.EventHandler(this.btnSoldado_Click);
            // 
            // lblMasVendidoPorCategoria
            // 
            this.lblMasVendidoPorCategoria.AutoSize = true;
            this.lblMasVendidoPorCategoria.Location = new System.Drawing.Point(459, 107);
            this.lblMasVendidoPorCategoria.Name = "lblMasVendidoPorCategoria";
            this.lblMasVendidoPorCategoria.Size = new System.Drawing.Size(201, 15);
            this.lblMasVendidoPorCategoria.TabIndex = 148;
            this.lblMasVendidoPorCategoria.Text = "Producto Mas Vendido por categoría";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 15);
            this.label3.TabIndex = 149;
            this.label3.Text = "Promedio Ganancias Categoría";
            // 
            // lblPromedioGananciasCategoria
            // 
            this.lblPromedioGananciasCategoria.AutoSize = true;
            this.lblPromedioGananciasCategoria.Location = new System.Drawing.Point(459, 157);
            this.lblPromedioGananciasCategoria.Name = "lblPromedioGananciasCategoria";
            this.lblPromedioGananciasCategoria.Size = new System.Drawing.Size(170, 15);
            this.lblPromedioGananciasCategoria.TabIndex = 150;
            this.lblPromedioGananciasCategoria.Text = "Promedio Ganancias Categoría";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 24);
            this.button1.TabIndex = 151;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPromedioGananciasCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMasVendidoPorCategoria);
            this.Controls.Add(this.btnHerramientas);
            this.Controls.Add(this.btnSoldado);
            this.Controls.Add(this.btnLimpieza);
            this.Controls.Add(this.btnControlTermico);
            this.Controls.Add(this.btnPlaquetas);
            this.Controls.Add(this.btnCircuitosIntegrados);
            this.Controls.Add(this.btnConectores);
            this.Controls.Add(this.btnCapacitores);
            this.Controls.Add(this.btnBobinas);
            this.Controls.Add(this.btnLeds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCantidadVentasRealizadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMontoInsuficiente);
            this.Controls.Add(this.btnVentasRealizadas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstadisticas";
            this.Text = "FrmEstadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVentasRealizadas;
        private System.Windows.Forms.Label lblMontoInsuficiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidadVentasRealizadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlaquetas;
        private System.Windows.Forms.Button btnLeds;
        private System.Windows.Forms.Button btnBobinas;
        private System.Windows.Forms.Button btnCapacitores;
        private System.Windows.Forms.Button btnConectores;
        private System.Windows.Forms.Button btnCircuitosIntegrados;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button btnControlTermico;
        private System.Windows.Forms.Button btnLimpieza;
        private System.Windows.Forms.Button btnSoldado;
        private System.Windows.Forms.Label lblMasVendidoPorCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPromedioGananciasCategoria;
        private System.Windows.Forms.Button button1;
    }
}
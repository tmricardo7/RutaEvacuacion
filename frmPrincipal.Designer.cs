namespace Ruta_de_evacuación_más_cercana
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCroquisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCroquisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarPlanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelEstadoP = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelExt = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.gbxDibujo = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.rdbAlto = new System.Windows.Forms.RadioButton();
            this.rdbMedio = new System.Windows.Forms.RadioButton();
            this.rdbBajo = new System.Windows.Forms.RadioButton();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.rdbSalida = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rdbPersona = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdbObstaculos = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSimulacion = new System.Windows.Forms.Button();
            this.gbxArea = new System.Windows.Forms.GroupBox();
            this.gbxRiesgos = new System.Windows.Forms.GroupBox();
            this.tbxAlto = new System.Windows.Forms.TextBox();
            this.tbxMedio = new System.Windows.Forms.TextBox();
            this.tbxBajo = new System.Windows.Forms.TextBox();
            this.lblAlto = new System.Windows.Forms.Label();
            this.lblMedio = new System.Windows.Forms.Label();
            this.lblBajo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelExt.SuspendLayout();
            this.gbxDibujo.SuspendLayout();
            this.gbxArea.SuspendLayout();
            this.gbxRiesgos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCroquisToolStripMenuItem,
            this.abrirCroquisToolStripMenuItem,
            this.guardarPlanoToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoCroquisToolStripMenuItem
            // 
            this.nuevoCroquisToolStripMenuItem.Name = "nuevoCroquisToolStripMenuItem";
            this.nuevoCroquisToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.nuevoCroquisToolStripMenuItem.Text = "Nuevo";
            this.nuevoCroquisToolStripMenuItem.Click += new System.EventHandler(this.nuevoCroquisToolStripMenuItem_Click);
            // 
            // abrirCroquisToolStripMenuItem
            // 
            this.abrirCroquisToolStripMenuItem.Name = "abrirCroquisToolStripMenuItem";
            this.abrirCroquisToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirCroquisToolStripMenuItem.Text = "Abrir";
            this.abrirCroquisToolStripMenuItem.Click += new System.EventHandler(this.abrirCroquisToolStripMenuItem_Click);
            // 
            // guardarPlanoToolStripMenuItem
            // 
            this.guardarPlanoToolStripMenuItem.Enabled = false;
            this.guardarPlanoToolStripMenuItem.Name = "guardarPlanoToolStripMenuItem";
            this.guardarPlanoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarPlanoToolStripMenuItem.Text = "Guardar";
            this.guardarPlanoToolStripMenuItem.Click += new System.EventHandler(this.guardarPlanoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelEstadoP});
            this.statusStrip.Location = new System.Drawing.Point(0, 509);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(628, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // labelEstadoP
            // 
            this.labelEstadoP.Name = "labelEstadoP";
            this.labelEstadoP.Size = new System.Drawing.Size(73, 17);
            this.labelEstadoP.Text = "Estado: Listo";
            // 
            // panelExt
            // 
            this.panelExt.BackColor = System.Drawing.Color.Gray;
            this.panelExt.Controls.Add(this.groupBox1);
            this.panelExt.Controls.Add(this.panel);
            this.panelExt.Location = new System.Drawing.Point(17, 32);
            this.panelExt.Name = "panelExt";
            this.panelExt.Size = new System.Drawing.Size(386, 386);
            this.panelExt.TabIndex = 2;
            this.panelExt.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(414, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(380, 380);
            this.panel.TabIndex = 1;
            this.panel.Visible = false;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // gbxDibujo
            // 
            this.gbxDibujo.Controls.Add(this.textBox7);
            this.gbxDibujo.Controls.Add(this.textBox6);
            this.gbxDibujo.Controls.Add(this.textBox5);
            this.gbxDibujo.Controls.Add(this.rdbAlto);
            this.gbxDibujo.Controls.Add(this.rdbMedio);
            this.gbxDibujo.Controls.Add(this.rdbBajo);
            this.gbxDibujo.Controls.Add(this.btnLimpiarTodo);
            this.gbxDibujo.Controls.Add(this.rdbSalida);
            this.gbxDibujo.Controls.Add(this.textBox3);
            this.gbxDibujo.Controls.Add(this.rdbPersona);
            this.gbxDibujo.Controls.Add(this.textBox2);
            this.gbxDibujo.Controls.Add(this.textBox1);
            this.gbxDibujo.Controls.Add(this.rdbObstaculos);
            this.gbxDibujo.Enabled = false;
            this.gbxDibujo.Location = new System.Drawing.Point(431, 35);
            this.gbxDibujo.Name = "gbxDibujo";
            this.gbxDibujo.Size = new System.Drawing.Size(166, 209);
            this.gbxDibujo.TabIndex = 3;
            this.gbxDibujo.TabStop = false;
            this.gbxDibujo.Text = "Área de dibujo";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Red;
            this.textBox7.Location = new System.Drawing.Point(144, 97);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(22, 20);
            this.textBox7.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Yellow;
            this.textBox6.Location = new System.Drawing.Point(144, 74);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(22, 20);
            this.textBox6.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LimeGreen;
            this.textBox5.Location = new System.Drawing.Point(144, 51);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(22, 20);
            this.textBox5.TabIndex = 7;
            // 
            // rdbAlto
            // 
            this.rdbAlto.AutoSize = true;
            this.rdbAlto.Enabled = false;
            this.rdbAlto.Location = new System.Drawing.Point(15, 97);
            this.rdbAlto.Name = "rdbAlto";
            this.rdbAlto.Size = new System.Drawing.Size(118, 17);
            this.rdbAlto.TabIndex = 6;
            this.rdbAlto.Text = "Dibujar Riesgo: Alto";
            this.rdbAlto.UseVisualStyleBackColor = true;
            // 
            // rdbMedio
            // 
            this.rdbMedio.AutoSize = true;
            this.rdbMedio.Enabled = false;
            this.rdbMedio.Location = new System.Drawing.Point(15, 74);
            this.rdbMedio.Name = "rdbMedio";
            this.rdbMedio.Size = new System.Drawing.Size(129, 17);
            this.rdbMedio.TabIndex = 5;
            this.rdbMedio.Text = "Dibujar Riesgo: Medio";
            this.rdbMedio.UseVisualStyleBackColor = true;
            // 
            // rdbBajo
            // 
            this.rdbBajo.AutoSize = true;
            this.rdbBajo.Enabled = false;
            this.rdbBajo.Location = new System.Drawing.Point(15, 51);
            this.rdbBajo.Name = "rdbBajo";
            this.rdbBajo.Size = new System.Drawing.Size(121, 17);
            this.rdbBajo.TabIndex = 4;
            this.rdbBajo.Text = "Dibujar Riesgo: Bajo";
            this.rdbBajo.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.Location = new System.Drawing.Point(46, 176);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(83, 23);
            this.btnLimpiarTodo.TabIndex = 3;
            this.btnLimpiarTodo.Text = "Limpiar Todo";
            this.btnLimpiarTodo.UseVisualStyleBackColor = true;
            this.btnLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
            // 
            // rdbSalida
            // 
            this.rdbSalida.AutoSize = true;
            this.rdbSalida.Enabled = false;
            this.rdbSalida.Location = new System.Drawing.Point(15, 143);
            this.rdbSalida.Name = "rdbSalida";
            this.rdbSalida.Size = new System.Drawing.Size(90, 17);
            this.rdbSalida.TabIndex = 3;
            this.rdbSalida.Text = "Dibujar Salida";
            this.rdbSalida.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox3.Location = new System.Drawing.Point(144, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(22, 20);
            this.textBox3.TabIndex = 2;
            // 
            // rdbPersona
            // 
            this.rdbPersona.AutoSize = true;
            this.rdbPersona.Enabled = false;
            this.rdbPersona.Location = new System.Drawing.Point(16, 120);
            this.rdbPersona.Name = "rdbPersona";
            this.rdbPersona.Size = new System.Drawing.Size(100, 17);
            this.rdbPersona.TabIndex = 2;
            this.rdbPersona.Text = "Dibujar Persona";
            this.rdbPersona.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Fuchsia;
            this.textBox2.Location = new System.Drawing.Point(144, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(22, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(144, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(22, 20);
            this.textBox1.TabIndex = 0;
            // 
            // rdbObstaculos
            // 
            this.rdbObstaculos.AutoSize = true;
            this.rdbObstaculos.Enabled = false;
            this.rdbObstaculos.Location = new System.Drawing.Point(15, 28);
            this.rdbObstaculos.Name = "rdbObstaculos";
            this.rdbObstaculos.Size = new System.Drawing.Size(114, 17);
            this.rdbObstaculos.TabIndex = 0;
            this.rdbObstaculos.Text = "Dibujar Obstáculos";
            this.rdbObstaculos.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(93, 433);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 24);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular ruta";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Visible = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSimulacion
            // 
            this.btnSimulacion.Location = new System.Drawing.Point(220, 433);
            this.btnSimulacion.Name = "btnSimulacion";
            this.btnSimulacion.Size = new System.Drawing.Size(110, 24);
            this.btnSimulacion.TabIndex = 10;
            this.btnSimulacion.Text = "Iniciar Simulación";
            this.btnSimulacion.UseVisualStyleBackColor = true;
            this.btnSimulacion.Visible = false;
            this.btnSimulacion.Click += new System.EventHandler(this.btnSimulacion_Click);
            // 
            // gbxArea
            // 
            this.gbxArea.BackColor = System.Drawing.Color.White;
            this.gbxArea.Controls.Add(this.gbxRiesgos);
            this.gbxArea.Controls.Add(this.btnSimulacion);
            this.gbxArea.Controls.Add(this.btnCalcular);
            this.gbxArea.Controls.Add(this.gbxDibujo);
            this.gbxArea.Controls.Add(this.panelExt);
            this.gbxArea.Location = new System.Drawing.Point(0, 12);
            this.gbxArea.Name = "gbxArea";
            this.gbxArea.Size = new System.Drawing.Size(628, 495);
            this.gbxArea.TabIndex = 5;
            this.gbxArea.TabStop = false;
            // 
            // gbxRiesgos
            // 
            this.gbxRiesgos.Controls.Add(this.tbxAlto);
            this.gbxRiesgos.Controls.Add(this.tbxMedio);
            this.gbxRiesgos.Controls.Add(this.tbxBajo);
            this.gbxRiesgos.Controls.Add(this.lblAlto);
            this.gbxRiesgos.Controls.Add(this.lblMedio);
            this.gbxRiesgos.Controls.Add(this.lblBajo);
            this.gbxRiesgos.Enabled = false;
            this.gbxRiesgos.Location = new System.Drawing.Point(431, 271);
            this.gbxRiesgos.Name = "gbxRiesgos";
            this.gbxRiesgos.Size = new System.Drawing.Size(93, 100);
            this.gbxRiesgos.TabIndex = 11;
            this.gbxRiesgos.TabStop = false;
            this.gbxRiesgos.Text = "Riesgos";
            // 
            // tbxAlto
            // 
            this.tbxAlto.Location = new System.Drawing.Point(50, 75);
            this.tbxAlto.Name = "tbxAlto";
            this.tbxAlto.Size = new System.Drawing.Size(34, 20);
            this.tbxAlto.TabIndex = 5;
            this.tbxAlto.Text = "3.0";
            // 
            // tbxMedio
            // 
            this.tbxMedio.Location = new System.Drawing.Point(50, 48);
            this.tbxMedio.Name = "tbxMedio";
            this.tbxMedio.Size = new System.Drawing.Size(34, 20);
            this.tbxMedio.TabIndex = 4;
            this.tbxMedio.Text = "2.0";
            // 
            // tbxBajo
            // 
            this.tbxBajo.Location = new System.Drawing.Point(50, 20);
            this.tbxBajo.Name = "tbxBajo";
            this.tbxBajo.Size = new System.Drawing.Size(34, 20);
            this.tbxBajo.TabIndex = 3;
            this.tbxBajo.Text = "1.0";
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Location = new System.Drawing.Point(15, 75);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(25, 13);
            this.lblAlto.TabIndex = 2;
            this.lblAlto.Text = "Alto";
            // 
            // lblMedio
            // 
            this.lblMedio.AutoSize = true;
            this.lblMedio.Location = new System.Drawing.Point(15, 48);
            this.lblMedio.Name = "lblMedio";
            this.lblMedio.Size = new System.Drawing.Size(36, 13);
            this.lblMedio.TabIndex = 1;
            this.lblMedio.Text = "Medio";
            // 
            // lblBajo
            // 
            this.lblBajo.AutoSize = true;
            this.lblBajo.Location = new System.Drawing.Point(15, 20);
            this.lblBajo.Name = "lblBajo";
            this.lblBajo.Size = new System.Drawing.Size(28, 13);
            this.lblBajo.TabIndex = 0;
            this.lblBajo.Text = "Bajo";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 531);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbxArea);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ruta de evacuación más cercana";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelExt.ResumeLayout(false);
            this.gbxDibujo.ResumeLayout(false);
            this.gbxDibujo.PerformLayout();
            this.gbxArea.ResumeLayout(false);
            this.gbxRiesgos.ResumeLayout(false);
            this.gbxRiesgos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCroquisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoCroquisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem guardarPlanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel labelEstadoP;
        private System.Windows.Forms.Panel panelExt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox gbxDibujo;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton rdbAlto;
        private System.Windows.Forms.RadioButton rdbMedio;
        private System.Windows.Forms.RadioButton rdbBajo;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.RadioButton rdbSalida;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton rdbPersona;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdbObstaculos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSimulacion;
        private System.Windows.Forms.GroupBox gbxArea;
        private System.Windows.Forms.GroupBox gbxRiesgos;
        private System.Windows.Forms.Label lblBajo;
        private System.Windows.Forms.TextBox tbxAlto;
        private System.Windows.Forms.TextBox tbxMedio;
        private System.Windows.Forms.TextBox tbxBajo;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.Label lblMedio;
    }
}



namespace WallANSI_v0._2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.gbColores = new System.Windows.Forms.GroupBox();
            this.cmdBlancoB = new System.Windows.Forms.Button();
            this.cmdCianB = new System.Windows.Forms.Button();
            this.cmdMagentaB = new System.Windows.Forms.Button();
            this.cmdAzulB = new System.Windows.Forms.Button();
            this.cmdAmarilloB = new System.Windows.Forms.Button();
            this.cmdVerdeB = new System.Windows.Forms.Button();
            this.cmdRojoB = new System.Windows.Forms.Button();
            this.cmdBlanco = new System.Windows.Forms.Button();
            this.cmdCian = new System.Windows.Forms.Button();
            this.cmdMagenta = new System.Windows.Forms.Button();
            this.cmdAzul = new System.Windows.Forms.Button();
            this.cmdAmarillo = new System.Windows.Forms.Button();
            this.cmdVerde = new System.Windows.Forms.Button();
            this.cmdRojo = new System.Windows.Forms.Button();
            this.cmdNegro = new System.Windows.Forms.Button();
            this.btnGuardarANSI = new System.Windows.Forms.Button();
            this.txtASCII = new System.Windows.Forms.TextBox();
            this.btnASCII = new System.Windows.Forms.Button();
            this.btnColores = new System.Windows.Forms.Button();
            this.lblSecuencia = new System.Windows.Forms.Label();
            this.rtfSecuencia = new System.Windows.Forms.RichTextBox();
            this.rtfTexto = new System.Windows.Forms.RichTextBox();
            this.gbBoveda = new System.Windows.Forms.GroupBox();
            this.cmdCerrarBoveda = new System.Windows.Forms.Button();
            this.rtfBoveda = new System.Windows.Forms.RichTextBox();
            this.cmdPegar = new System.Windows.Forms.Button();
            this.cmdGuardarBoveda = new System.Windows.Forms.Button();
            this.gbPrincipal.SuspendLayout();
            this.gbColores.SuspendLayout();
            this.gbBoveda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.gbBoveda);
            this.gbPrincipal.Controls.Add(this.gbColores);
            this.gbPrincipal.Controls.Add(this.btnGuardarANSI);
            this.gbPrincipal.Controls.Add(this.txtASCII);
            this.gbPrincipal.Controls.Add(this.btnASCII);
            this.gbPrincipal.Controls.Add(this.btnColores);
            this.gbPrincipal.Controls.Add(this.lblSecuencia);
            this.gbPrincipal.Controls.Add(this.rtfSecuencia);
            this.gbPrincipal.Controls.Add(this.rtfTexto);
            this.gbPrincipal.Location = new System.Drawing.Point(12, 61);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(825, 521);
            this.gbPrincipal.TabIndex = 0;
            this.gbPrincipal.TabStop = false;
            // 
            // gbColores
            // 
            this.gbColores.Controls.Add(this.cmdBlancoB);
            this.gbColores.Controls.Add(this.cmdCianB);
            this.gbColores.Controls.Add(this.cmdMagentaB);
            this.gbColores.Controls.Add(this.cmdAzulB);
            this.gbColores.Controls.Add(this.cmdAmarilloB);
            this.gbColores.Controls.Add(this.cmdVerdeB);
            this.gbColores.Controls.Add(this.cmdRojoB);
            this.gbColores.Controls.Add(this.cmdBlanco);
            this.gbColores.Controls.Add(this.cmdCian);
            this.gbColores.Controls.Add(this.cmdMagenta);
            this.gbColores.Controls.Add(this.cmdAzul);
            this.gbColores.Controls.Add(this.cmdAmarillo);
            this.gbColores.Controls.Add(this.cmdVerde);
            this.gbColores.Controls.Add(this.cmdRojo);
            this.gbColores.Controls.Add(this.cmdNegro);
            this.gbColores.Location = new System.Drawing.Point(387, 9);
            this.gbColores.Name = "gbColores";
            this.gbColores.Size = new System.Drawing.Size(163, 129);
            this.gbColores.TabIndex = 8;
            this.gbColores.TabStop = false;
            this.gbColores.Visible = false;
            // 
            // cmdBlancoB
            // 
            this.cmdBlancoB.BackColor = System.Drawing.Color.White;
            this.cmdBlancoB.Location = new System.Drawing.Point(120, 96);
            this.cmdBlancoB.Name = "cmdBlancoB";
            this.cmdBlancoB.Size = new System.Drawing.Size(32, 23);
            this.cmdBlancoB.TabIndex = 15;
            this.cmdBlancoB.UseVisualStyleBackColor = false;
            this.cmdBlancoB.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdCianB
            // 
            this.cmdCianB.BackColor = System.Drawing.Color.Cyan;
            this.cmdCianB.Location = new System.Drawing.Point(82, 96);
            this.cmdCianB.Name = "cmdCianB";
            this.cmdCianB.Size = new System.Drawing.Size(32, 23);
            this.cmdCianB.TabIndex = 14;
            this.cmdCianB.UseVisualStyleBackColor = false;
            this.cmdCianB.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdMagentaB
            // 
            this.cmdMagentaB.BackColor = System.Drawing.Color.Magenta;
            this.cmdMagentaB.Location = new System.Drawing.Point(44, 96);
            this.cmdMagentaB.Name = "cmdMagentaB";
            this.cmdMagentaB.Size = new System.Drawing.Size(32, 23);
            this.cmdMagentaB.TabIndex = 13;
            this.cmdMagentaB.UseVisualStyleBackColor = false;
            this.cmdMagentaB.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdAzulB
            // 
            this.cmdAzulB.BackColor = System.Drawing.Color.Blue;
            this.cmdAzulB.Location = new System.Drawing.Point(6, 96);
            this.cmdAzulB.Name = "cmdAzulB";
            this.cmdAzulB.Size = new System.Drawing.Size(32, 23);
            this.cmdAzulB.TabIndex = 12;
            this.cmdAzulB.UseVisualStyleBackColor = false;
            this.cmdAzulB.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdAmarilloB
            // 
            this.cmdAmarilloB.BackColor = System.Drawing.Color.Yellow;
            this.cmdAmarilloB.Location = new System.Drawing.Point(120, 67);
            this.cmdAmarilloB.Name = "cmdAmarilloB";
            this.cmdAmarilloB.Size = new System.Drawing.Size(32, 23);
            this.cmdAmarilloB.TabIndex = 11;
            this.cmdAmarilloB.UseVisualStyleBackColor = false;
            this.cmdAmarilloB.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdVerdeB
            // 
            this.cmdVerdeB.BackColor = System.Drawing.Color.Lime;
            this.cmdVerdeB.Location = new System.Drawing.Point(82, 67);
            this.cmdVerdeB.Name = "cmdVerdeB";
            this.cmdVerdeB.Size = new System.Drawing.Size(32, 23);
            this.cmdVerdeB.TabIndex = 10;
            this.cmdVerdeB.UseVisualStyleBackColor = false;
            this.cmdVerdeB.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdRojoB
            // 
            this.cmdRojoB.BackColor = System.Drawing.Color.Red;
            this.cmdRojoB.Location = new System.Drawing.Point(44, 67);
            this.cmdRojoB.Name = "cmdRojoB";
            this.cmdRojoB.Size = new System.Drawing.Size(32, 23);
            this.cmdRojoB.TabIndex = 9;
            this.cmdRojoB.UseVisualStyleBackColor = false;
            this.cmdRojoB.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdBlanco
            // 
            this.cmdBlanco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdBlanco.Location = new System.Drawing.Point(120, 38);
            this.cmdBlanco.Name = "cmdBlanco";
            this.cmdBlanco.Size = new System.Drawing.Size(32, 23);
            this.cmdBlanco.TabIndex = 7;
            this.cmdBlanco.UseVisualStyleBackColor = false;
            this.cmdBlanco.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdCian
            // 
            this.cmdCian.BackColor = System.Drawing.Color.DarkCyan;
            this.cmdCian.Location = new System.Drawing.Point(82, 38);
            this.cmdCian.Name = "cmdCian";
            this.cmdCian.Size = new System.Drawing.Size(32, 23);
            this.cmdCian.TabIndex = 6;
            this.cmdCian.UseVisualStyleBackColor = false;
            this.cmdCian.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdMagenta
            // 
            this.cmdMagenta.BackColor = System.Drawing.Color.DarkMagenta;
            this.cmdMagenta.Location = new System.Drawing.Point(44, 38);
            this.cmdMagenta.Name = "cmdMagenta";
            this.cmdMagenta.Size = new System.Drawing.Size(32, 23);
            this.cmdMagenta.TabIndex = 5;
            this.cmdMagenta.UseVisualStyleBackColor = false;
            this.cmdMagenta.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdAzul
            // 
            this.cmdAzul.BackColor = System.Drawing.Color.DarkBlue;
            this.cmdAzul.Location = new System.Drawing.Point(6, 38);
            this.cmdAzul.Name = "cmdAzul";
            this.cmdAzul.Size = new System.Drawing.Size(32, 23);
            this.cmdAzul.TabIndex = 4;
            this.cmdAzul.UseVisualStyleBackColor = false;
            this.cmdAzul.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdAmarillo
            // 
            this.cmdAmarillo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdAmarillo.Location = new System.Drawing.Point(120, 9);
            this.cmdAmarillo.Name = "cmdAmarillo";
            this.cmdAmarillo.Size = new System.Drawing.Size(32, 23);
            this.cmdAmarillo.TabIndex = 3;
            this.cmdAmarillo.UseVisualStyleBackColor = false;
            this.cmdAmarillo.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdVerde
            // 
            this.cmdVerde.BackColor = System.Drawing.Color.DarkGreen;
            this.cmdVerde.Location = new System.Drawing.Point(82, 9);
            this.cmdVerde.Name = "cmdVerde";
            this.cmdVerde.Size = new System.Drawing.Size(32, 23);
            this.cmdVerde.TabIndex = 2;
            this.cmdVerde.UseVisualStyleBackColor = false;
            this.cmdVerde.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdRojo
            // 
            this.cmdRojo.BackColor = System.Drawing.Color.DarkRed;
            this.cmdRojo.Location = new System.Drawing.Point(44, 9);
            this.cmdRojo.Name = "cmdRojo";
            this.cmdRojo.Size = new System.Drawing.Size(32, 23);
            this.cmdRojo.TabIndex = 1;
            this.cmdRojo.UseVisualStyleBackColor = false;
            this.cmdRojo.Click += new System.EventHandler(this.cambiarColor);
            // 
            // cmdNegro
            // 
            this.cmdNegro.BackColor = System.Drawing.Color.Black;
            this.cmdNegro.Location = new System.Drawing.Point(6, 9);
            this.cmdNegro.Name = "cmdNegro";
            this.cmdNegro.Size = new System.Drawing.Size(32, 23);
            this.cmdNegro.TabIndex = 0;
            this.cmdNegro.UseVisualStyleBackColor = false;
            this.cmdNegro.Click += new System.EventHandler(this.cambiarColor);
            // 
            // btnGuardarANSI
            // 
            this.btnGuardarANSI.Location = new System.Drawing.Point(387, 9);
            this.btnGuardarANSI.Name = "btnGuardarANSI";
            this.btnGuardarANSI.Size = new System.Drawing.Size(114, 44);
            this.btnGuardarANSI.TabIndex = 12;
            this.btnGuardarANSI.Text = "Guardar ANSI";
            this.btnGuardarANSI.UseVisualStyleBackColor = true;
            this.btnGuardarANSI.Click += new System.EventHandler(this.btnGuardarANSI_Click);
            // 
            // txtASCII
            // 
            this.txtASCII.BackColor = System.Drawing.Color.DarkCyan;
            this.txtASCII.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtASCII.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtASCII.ForeColor = System.Drawing.Color.Cyan;
            this.txtASCII.Location = new System.Drawing.Point(30, 82);
            this.txtASCII.Multiline = true;
            this.txtASCII.Name = "txtASCII";
            this.txtASCII.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtASCII.Size = new System.Drawing.Size(746, 403);
            this.txtASCII.TabIndex = 11;
            this.txtASCII.Text = resources.GetString("txtASCII.Text");
            this.txtASCII.Visible = false;
            this.txtASCII.WordWrap = false;
            this.txtASCII.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtASCII_MouseUp);
            // 
            // btnASCII
            // 
            this.btnASCII.Location = new System.Drawing.Point(354, 8);
            this.btnASCII.Name = "btnASCII";
            this.btnASCII.Size = new System.Drawing.Size(27, 24);
            this.btnASCII.TabIndex = 10;
            this.btnASCII.UseVisualStyleBackColor = true;
            this.btnASCII.Click += new System.EventHandler(this.btnASCII_Click);
            // 
            // btnColores
            // 
            this.btnColores.Location = new System.Drawing.Point(354, 29);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(27, 24);
            this.btnColores.TabIndex = 3;
            this.btnColores.UseVisualStyleBackColor = true;
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // lblSecuencia
            // 
            this.lblSecuencia.AutoSize = true;
            this.lblSecuencia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecuencia.Location = new System.Drawing.Point(7, 20);
            this.lblSecuencia.Name = "lblSecuencia";
            this.lblSecuencia.Size = new System.Drawing.Size(99, 19);
            this.lblSecuencia.TabIndex = 2;
            this.lblSecuencia.Text = "Secuencia:";
            // 
            // rtfSecuencia
            // 
            this.rtfSecuencia.BackColor = System.Drawing.Color.Black;
            this.rtfSecuencia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfSecuencia.ForeColor = System.Drawing.Color.White;
            this.rtfSecuencia.Location = new System.Drawing.Point(112, 7);
            this.rtfSecuencia.Name = "rtfSecuencia";
            this.rtfSecuencia.Size = new System.Drawing.Size(236, 46);
            this.rtfSecuencia.TabIndex = 1;
            this.rtfSecuencia.Text = "";
            this.rtfSecuencia.DoubleClick += new System.EventHandler(this.rtfSecuencia_DoubleClick);
            // 
            // rtfTexto
            // 
            this.rtfTexto.BackColor = System.Drawing.Color.Black;
            this.rtfTexto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfTexto.ForeColor = System.Drawing.Color.White;
            this.rtfTexto.Location = new System.Drawing.Point(6, 59);
            this.rtfTexto.Name = "rtfTexto";
            this.rtfTexto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtfTexto.Size = new System.Drawing.Size(807, 456);
            this.rtfTexto.TabIndex = 0;
            this.rtfTexto.Text = "";
            this.rtfTexto.WordWrap = false;
            // 
            // gbBoveda
            // 
            this.gbBoveda.Controls.Add(this.cmdPegar);
            this.gbBoveda.Controls.Add(this.cmdGuardarBoveda);
            this.gbBoveda.Controls.Add(this.cmdCerrarBoveda);
            this.gbBoveda.Controls.Add(this.rtfBoveda);
            this.gbBoveda.Location = new System.Drawing.Point(112, 47);
            this.gbBoveda.Name = "gbBoveda";
            this.gbBoveda.Size = new System.Drawing.Size(212, 265);
            this.gbBoveda.TabIndex = 13;
            this.gbBoveda.TabStop = false;
            this.gbBoveda.Visible = false;
            // 
            // cmdCerrarBoveda
            // 
            this.cmdCerrarBoveda.Location = new System.Drawing.Point(175, 4);
            this.cmdCerrarBoveda.Name = "cmdCerrarBoveda";
            this.cmdCerrarBoveda.Size = new System.Drawing.Size(31, 19);
            this.cmdCerrarBoveda.TabIndex = 1;
            this.cmdCerrarBoveda.Text = "X";
            this.cmdCerrarBoveda.UseVisualStyleBackColor = true;
            this.cmdCerrarBoveda.Click += new System.EventHandler(this.cmdCerrarBoveda_Click);
            // 
            // rtfBoveda
            // 
            this.rtfBoveda.BackColor = System.Drawing.Color.Black;
            this.rtfBoveda.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfBoveda.ForeColor = System.Drawing.Color.White;
            this.rtfBoveda.Location = new System.Drawing.Point(10, 49);
            this.rtfBoveda.Name = "rtfBoveda";
            this.rtfBoveda.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtfBoveda.Size = new System.Drawing.Size(196, 176);
            this.rtfBoveda.TabIndex = 0;
            this.rtfBoveda.Text = "";
            this.rtfBoveda.WordWrap = false;
            // 
            // cmdPegar
            // 
            this.cmdPegar.Image = global::WallANSI_v0._2.Properties.Resources.arrow_up_from_bracket_244d85;
            this.cmdPegar.Location = new System.Drawing.Point(10, 19);
            this.cmdPegar.Name = "cmdPegar";
            this.cmdPegar.Size = new System.Drawing.Size(31, 31);
            this.cmdPegar.TabIndex = 3;
            this.cmdPegar.UseVisualStyleBackColor = true;
            this.cmdPegar.Click += new System.EventHandler(this.cmdPegar_Click);
            // 
            // cmdGuardarBoveda
            // 
            this.cmdGuardarBoveda.Image = global::WallANSI_v0._2.Properties.Resources.save_solid_308e86;
            this.cmdGuardarBoveda.Location = new System.Drawing.Point(10, 230);
            this.cmdGuardarBoveda.Name = "cmdGuardarBoveda";
            this.cmdGuardarBoveda.Size = new System.Drawing.Size(31, 31);
            this.cmdGuardarBoveda.TabIndex = 2;
            this.cmdGuardarBoveda.UseVisualStyleBackColor = true;
            this.cmdGuardarBoveda.Click += new System.EventHandler(this.cmdGuardarBoveda_Click);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 594);
            this.Controls.Add(this.gbPrincipal);
            this.Name = "frmMain";
            this.Text = "WallANSI v0.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.gbColores.ResumeLayout(false);
            this.gbBoveda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.RichTextBox rtfTexto;
        private System.Windows.Forms.RichTextBox rtfSecuencia;
        private System.Windows.Forms.Button btnColores;
        private System.Windows.Forms.Label lblSecuencia;
        private System.Windows.Forms.GroupBox gbColores;
        private System.Windows.Forms.Button cmdBlancoB;
        private System.Windows.Forms.Button cmdCianB;
        private System.Windows.Forms.Button cmdMagentaB;
        private System.Windows.Forms.Button cmdAzulB;
        private System.Windows.Forms.Button cmdAmarilloB;
        private System.Windows.Forms.Button cmdVerdeB;
        private System.Windows.Forms.Button cmdRojoB;
        private System.Windows.Forms.Button cmdBlanco;
        private System.Windows.Forms.Button cmdCian;
        private System.Windows.Forms.Button cmdMagenta;
        private System.Windows.Forms.Button cmdAzul;
        private System.Windows.Forms.Button cmdAmarillo;
        private System.Windows.Forms.Button cmdVerde;
        private System.Windows.Forms.Button cmdRojo;
        private System.Windows.Forms.Button cmdNegro;
        private System.Windows.Forms.Button btnASCII;
        private System.Windows.Forms.TextBox txtASCII;
        private System.Windows.Forms.Button btnGuardarANSI;
        private System.Windows.Forms.GroupBox gbBoveda;
        private System.Windows.Forms.Button cmdPegar;
        private System.Windows.Forms.Button cmdGuardarBoveda;
        private System.Windows.Forms.Button cmdCerrarBoveda;
        private System.Windows.Forms.RichTextBox rtfBoveda;
    }
}


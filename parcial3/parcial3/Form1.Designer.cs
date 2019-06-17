namespace parcial3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInsert = new System.Windows.Forms.TabPage();
            this.tabmost = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textnroplaca = new System.Windows.Forms.TextBox();
            this.textmontocobra = new System.Windows.Forms.TextBox();
            this.textHRAINGRE = new System.Windows.Forms.TextBox();
            this.textHRASALIDA = new System.Windows.Forms.TextBox();
            this.CBTIPODEVEHI = new System.Windows.Forms.ComboBox();
            this.btbinsertar = new System.Windows.Forms.Button();
            this.mostrar = new System.Windows.Forms.ListBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.listadodemotos = new System.Windows.Forms.TabPage();
            this.Nrodevehiculos = new System.Windows.Forms.TabPage();
            this.mostrarlista = new System.Windows.Forms.ListBox();
            this.Btnmostrarlistado = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabInsert.SuspendLayout();
            this.tabmost.SuspendLayout();
            this.listadodemotos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInsert);
            this.tabControl1.Controls.Add(this.tabmost);
            this.tabControl1.Controls.Add(this.listadodemotos);
            this.tabControl1.Controls.Add(this.Nrodevehiculos);
            this.tabControl1.Location = new System.Drawing.Point(21, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 534);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInsert
            // 
            this.tabInsert.Controls.Add(this.btbinsertar);
            this.tabInsert.Controls.Add(this.CBTIPODEVEHI);
            this.tabInsert.Controls.Add(this.textHRASALIDA);
            this.tabInsert.Controls.Add(this.textHRAINGRE);
            this.tabInsert.Controls.Add(this.textmontocobra);
            this.tabInsert.Controls.Add(this.textnroplaca);
            this.tabInsert.Controls.Add(this.label5);
            this.tabInsert.Controls.Add(this.label4);
            this.tabInsert.Controls.Add(this.label3);
            this.tabInsert.Controls.Add(this.label2);
            this.tabInsert.Controls.Add(this.label1);
            this.tabInsert.Location = new System.Drawing.Point(4, 22);
            this.tabInsert.Name = "tabInsert";
            this.tabInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsert.Size = new System.Drawing.Size(739, 508);
            this.tabInsert.TabIndex = 0;
            this.tabInsert.Text = "InsertarDatos";
            this.tabInsert.UseVisualStyleBackColor = true;
            // 
            // tabmost
            // 
            this.tabmost.Controls.Add(this.btnmostrar);
            this.tabmost.Controls.Add(this.mostrar);
            this.tabmost.Location = new System.Drawing.Point(4, 22);
            this.tabmost.Name = "tabmost";
            this.tabmost.Padding = new System.Windows.Forms.Padding(3);
            this.tabmost.Size = new System.Drawing.Size(739, 508);
            this.tabmost.TabIndex = 1;
            this.tabmost.Text = "MostrarDatos";
            this.tabmost.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nroplaca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipodevehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "montoacobrar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "HradeIngreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Horadesalida";
            // 
            // textnroplaca
            // 
            this.textnroplaca.Location = new System.Drawing.Point(109, 52);
            this.textnroplaca.Name = "textnroplaca";
            this.textnroplaca.Size = new System.Drawing.Size(100, 20);
            this.textnroplaca.TabIndex = 5;
            this.textnroplaca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textmontocobra
            // 
            this.textmontocobra.Location = new System.Drawing.Point(109, 95);
            this.textmontocobra.Name = "textmontocobra";
            this.textmontocobra.Size = new System.Drawing.Size(100, 20);
            this.textmontocobra.TabIndex = 6;
            // 
            // textHRAINGRE
            // 
            this.textHRAINGRE.Location = new System.Drawing.Point(109, 122);
            this.textHRAINGRE.Name = "textHRAINGRE";
            this.textHRAINGRE.Size = new System.Drawing.Size(100, 20);
            this.textHRAINGRE.TabIndex = 7;
            // 
            // textHRASALIDA
            // 
            this.textHRASALIDA.Location = new System.Drawing.Point(109, 148);
            this.textHRASALIDA.Name = "textHRASALIDA";
            this.textHRASALIDA.Size = new System.Drawing.Size(100, 20);
            this.textHRASALIDA.TabIndex = 8;
            // 
            // CBTIPODEVEHI
            // 
            this.CBTIPODEVEHI.FormattingEnabled = true;
            this.CBTIPODEVEHI.Items.AddRange(new object[] {
            "AUTO",
            "VAGONETA",
            "CAMIÓN",
            "JEEP",
            "OTROTIPO",
            "MOTOS"});
            this.CBTIPODEVEHI.Location = new System.Drawing.Point(109, 186);
            this.CBTIPODEVEHI.Name = "CBTIPODEVEHI";
            this.CBTIPODEVEHI.Size = new System.Drawing.Size(121, 21);
            this.CBTIPODEVEHI.TabIndex = 9;
            // 
            // btbinsertar
            // 
            this.btbinsertar.Location = new System.Drawing.Point(277, 48);
            this.btbinsertar.Name = "btbinsertar";
            this.btbinsertar.Size = new System.Drawing.Size(98, 23);
            this.btbinsertar.TabIndex = 10;
            this.btbinsertar.Text = "InsertarDatos";
            this.btbinsertar.UseVisualStyleBackColor = true;
            this.btbinsertar.Click += new System.EventHandler(this.btbinsertar_Click);
            // 
            // mostrar
            // 
            this.mostrar.FormattingEnabled = true;
            this.mostrar.Location = new System.Drawing.Point(46, 50);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(292, 420);
            this.mostrar.TabIndex = 0;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(397, 50);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // listadodemotos
            // 
            this.listadodemotos.Controls.Add(this.Btnmostrarlistado);
            this.listadodemotos.Controls.Add(this.mostrarlista);
            this.listadodemotos.Location = new System.Drawing.Point(4, 22);
            this.listadodemotos.Name = "listadodemotos";
            this.listadodemotos.Size = new System.Drawing.Size(739, 508);
            this.listadodemotos.TabIndex = 2;
            this.listadodemotos.Text = "listadodemotos";
            this.listadodemotos.UseVisualStyleBackColor = true;
            // 
            // Nrodevehiculos
            // 
            this.Nrodevehiculos.BackColor = System.Drawing.Color.Transparent;
            this.Nrodevehiculos.Location = new System.Drawing.Point(4, 22);
            this.Nrodevehiculos.Name = "Nrodevehiculos";
            this.Nrodevehiculos.Size = new System.Drawing.Size(594, 306);
            this.Nrodevehiculos.TabIndex = 3;
            // 
            // mostrarlista
            // 
            this.mostrarlista.FormattingEnabled = true;
            this.mostrarlista.Location = new System.Drawing.Point(30, 33);
            this.mostrarlista.Name = "mostrarlista";
            this.mostrarlista.Size = new System.Drawing.Size(351, 355);
            this.mostrarlista.TabIndex = 0;
            // 
            // Btnmostrarlistado
            // 
            this.Btnmostrarlistado.Location = new System.Drawing.Point(482, 44);
            this.Btnmostrarlistado.Name = "Btnmostrarlistado";
            this.Btnmostrarlistado.Size = new System.Drawing.Size(75, 23);
            this.Btnmostrarlistado.TabIndex = 1;
            this.Btnmostrarlistado.Text = "mostrar";
            this.Btnmostrarlistado.UseVisualStyleBackColor = true;
            this.Btnmostrarlistado.Click += new System.EventHandler(this.Btnmostrarlistado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 558);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabInsert.ResumeLayout(false);
            this.tabInsert.PerformLayout();
            this.tabmost.ResumeLayout(false);
            this.listadodemotos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInsert;
        private System.Windows.Forms.TabPage tabmost;
        private System.Windows.Forms.TextBox textHRASALIDA;
        private System.Windows.Forms.TextBox textHRAINGRE;
        private System.Windows.Forms.TextBox textmontocobra;
        private System.Windows.Forms.TextBox textnroplaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBTIPODEVEHI;
        private System.Windows.Forms.Button btbinsertar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.ListBox mostrar;
        private System.Windows.Forms.TabPage listadodemotos;
        private System.Windows.Forms.Button Btnmostrarlistado;
        private System.Windows.Forms.ListBox mostrarlista;
        private System.Windows.Forms.TabPage Nrodevehiculos;
    }
}


namespace pregunta1segundoparcial
{
    partial class Form1
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
            this.bhtnobt = new System.Windows.Forms.Button();
            this.btncolocar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textvalor = new System.Windows.Forms.TextBox();
            this.valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bhtnobt
            // 
            this.bhtnobt.Location = new System.Drawing.Point(201, 215);
            this.bhtnobt.Name = "bhtnobt";
            this.bhtnobt.Size = new System.Drawing.Size(75, 23);
            this.bhtnobt.TabIndex = 0;
            this.bhtnobt.Text = "obtener";
            this.bhtnobt.UseVisualStyleBackColor = true;
            this.bhtnobt.Click += new System.EventHandler(this.bhtnobt_Click);
            // 
            // btncolocar
            // 
            this.btncolocar.Location = new System.Drawing.Point(460, 215);
            this.btncolocar.Name = "btncolocar";
            this.btncolocar.Size = new System.Drawing.Size(75, 23);
            this.btncolocar.TabIndex = 1;
            this.btncolocar.Text = "colocar";
            this.btncolocar.UseVisualStyleBackColor = true;
            this.btncolocar.Click += new System.EventHandler(this.btncolocar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textvalor
            // 
            this.textvalor.Location = new System.Drawing.Point(237, 151);
            this.textvalor.Name = "textvalor";
            this.textvalor.Size = new System.Drawing.Size(227, 20);
            this.textvalor.TabIndex = 3;
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(152, 151);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(30, 13);
            this.valor.TabIndex = 4;
            this.valor.Text = "valor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.textvalor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncolocar);
            this.Controls.Add(this.bhtnobt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bhtnobt;
        private System.Windows.Forms.Button btncolocar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textvalor;
        private System.Windows.Forms.Label valor;
    }
}
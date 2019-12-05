namespace AppVectorArreglado
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
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxVector = new System.Windows.Forms.ListBox();
            this.btnGenerarVector = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstVecctorOriginal = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(152, 21);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(100, 20);
            this.txtTamanio.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tamaño del vector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Vector Ordenado";
            // 
            // listBoxVector
            // 
            this.listBoxVector.FormattingEnabled = true;
            this.listBoxVector.Location = new System.Drawing.Point(184, 107);
            this.listBoxVector.Name = "listBoxVector";
            this.listBoxVector.Size = new System.Drawing.Size(158, 225);
            this.listBoxVector.TabIndex = 22;
            // 
            // btnGenerarVector
            // 
            this.btnGenerarVector.Location = new System.Drawing.Point(12, 54);
            this.btnGenerarVector.Name = "btnGenerarVector";
            this.btnGenerarVector.Size = new System.Drawing.Size(143, 23);
            this.btnGenerarVector.TabIndex = 23;
            this.btnGenerarVector.Text = "Generar vector";
            this.btnGenerarVector.UseVisualStyleBackColor = true;
            this.btnGenerarVector.Click += new System.EventHandler(this.btnGenerarVector_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(184, 54);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(143, 23);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lstVecctorOriginal
            // 
            this.lstVecctorOriginal.FormattingEnabled = true;
            this.lstVecctorOriginal.Location = new System.Drawing.Point(3, 107);
            this.lstVecctorOriginal.Name = "lstVecctorOriginal";
            this.lstVecctorOriginal.Size = new System.Drawing.Size(158, 225);
            this.lstVecctorOriginal.TabIndex = 27;
            this.lstVecctorOriginal.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Vector Original";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.lstVecctorOriginal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarVector);
            this.Controls.Add(this.listBoxVector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTamanio);
            this.Name = "Form1";
            this.Text = "frm Vector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxVector;
        private System.Windows.Forms.Button btnGenerarVector;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstVecctorOriginal;
        private System.Windows.Forms.Label label3;
    }
}


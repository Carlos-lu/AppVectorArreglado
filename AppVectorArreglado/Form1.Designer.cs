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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGenerarVector = new System.Windows.Forms.Button();
            this.btnOrdenarVector = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(49, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Elementos del vector";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 225);
            this.listBox1.TabIndex = 22;
            // 
            // btnGenerarVector
            // 
            this.btnGenerarVector.Location = new System.Drawing.Point(189, 56);
            this.btnGenerarVector.Name = "btnGenerarVector";
            this.btnGenerarVector.Size = new System.Drawing.Size(143, 23);
            this.btnGenerarVector.TabIndex = 23;
            this.btnGenerarVector.Text = "Generar vector";
            this.btnGenerarVector.UseVisualStyleBackColor = true;
            this.btnGenerarVector.Click += new System.EventHandler(this.btnGenerarVector_Click);
            // 
            // btnOrdenarVector
            // 
            this.btnOrdenarVector.Location = new System.Drawing.Point(189, 90);
            this.btnOrdenarVector.Name = "btnOrdenarVector";
            this.btnOrdenarVector.Size = new System.Drawing.Size(143, 23);
            this.btnOrdenarVector.TabIndex = 24;
            this.btnOrdenarVector.Text = "Ordenar Vector";
            this.btnOrdenarVector.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrdenarVector);
            this.Controls.Add(this.btnGenerarVector);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGenerarVector;
        private System.Windows.Forms.Button btnOrdenarVector;
    }
}


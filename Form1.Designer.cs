namespace WindowsFormsApp3
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
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.dgvAutosDatosS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.btnInsertarPush = new System.Windows.Forms.Button();
            this.btnSalidaPush = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosDatosS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlacas
            // 
            this.txtPlacas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacas.Location = new System.Drawing.Point(78, 23);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(215, 22);
            this.txtPlacas.TabIndex = 0;
            // 
            // dgvAutosDatosS
            // 
            this.dgvAutosDatosS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutosDatosS.Location = new System.Drawing.Point(12, 239);
            this.dgvAutosDatosS.Name = "dgvAutosDatosS";
            this.dgvAutosDatosS.Size = new System.Drawing.Size(491, 188);
            this.dgvAutosDatosS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Placas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(68, 101);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(113, 22);
            this.txtColor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Propietario";
            // 
            // txtProp
            // 
            this.txtProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProp.Location = new System.Drawing.Point(102, 61);
            this.txtProp.Name = "txtProp";
            this.txtProp.Size = new System.Drawing.Size(215, 22);
            this.txtProp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Top";
            // 
            // txtTop
            // 
            this.txtTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTop.Location = new System.Drawing.Point(61, 189);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(74, 22);
            this.txtTop.TabIndex = 7;
            // 
            // btnInsertarPush
            // 
            this.btnInsertarPush.Location = new System.Drawing.Point(394, 21);
            this.btnInsertarPush.Name = "btnInsertarPush";
            this.btnInsertarPush.Size = new System.Drawing.Size(109, 56);
            this.btnInsertarPush.TabIndex = 9;
            this.btnInsertarPush.Text = "Insertar Datos (Push)";
            this.btnInsertarPush.UseVisualStyleBackColor = true;
            this.btnInsertarPush.Click += new System.EventHandler(this.btnInsertarPush_Click);
            // 
            // btnSalidaPush
            // 
            this.btnSalidaPush.Location = new System.Drawing.Point(394, 84);
            this.btnSalidaPush.Name = "btnSalidaPush";
            this.btnSalidaPush.Size = new System.Drawing.Size(109, 56);
            this.btnSalidaPush.TabIndex = 10;
            this.btnSalidaPush.Text = "Salida de Datos (Pop)";
            this.btnSalidaPush.UseVisualStyleBackColor = true;
            this.btnSalidaPush.Click += new System.EventHandler(this.btnSalidaPush_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(394, 152);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 56);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSalidaPush);
            this.Controls.Add(this.btnInsertarPush);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAutosDatosS);
            this.Controls.Add(this.txtPlacas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosDatosS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.DataGridView dgvAutosDatosS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Button btnInsertarPush;
        private System.Windows.Forms.Button btnSalidaPush;
        private System.Windows.Forms.Button btnSalir;
    }
}


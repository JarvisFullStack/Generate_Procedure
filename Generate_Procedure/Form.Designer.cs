namespace Generate_Procedure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxSentenciaSQL = new System.Windows.Forms.TextBox();
            this.textBoxSqlResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.textBoxNombreTabla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSentenciaSQL
            // 
            this.textBoxSentenciaSQL.Location = new System.Drawing.Point(44, 57);
            this.textBoxSentenciaSQL.Multiline = true;
            this.textBoxSentenciaSQL.Name = "textBoxSentenciaSQL";
            this.textBoxSentenciaSQL.Size = new System.Drawing.Size(645, 264);
            this.textBoxSentenciaSQL.TabIndex = 1;
            // 
            // textBoxSqlResult
            // 
            this.textBoxSqlResult.Location = new System.Drawing.Point(44, 327);
            this.textBoxSqlResult.Multiline = true;
            this.textBoxSqlResult.Name = "textBoxSqlResult";
            this.textBoxSqlResult.Size = new System.Drawing.Size(645, 264);
            this.textBoxSqlResult.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(713, 514);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 61);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // textBoxNombreTabla
            // 
            this.textBoxNombreTabla.Location = new System.Drawing.Point(280, 31);
            this.textBoxNombreTabla.Name = "textBoxNombreTabla";
            this.textBoxNombreTabla.Size = new System.Drawing.Size(162, 20);
            this.textBoxNombreTabla.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de la Tabla";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombreTabla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSqlResult);
            this.Controls.Add(this.textBoxSentenciaSQL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREATE MERGE STORED PROCEDURE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSentenciaSQL;
        private System.Windows.Forms.TextBox textBoxSqlResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox textBoxNombreTabla;
        private System.Windows.Forms.Label label1;
    }
}


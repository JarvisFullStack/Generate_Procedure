namespace Generate_Procedure
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.storeProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeInsertUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxNota = new System.Windows.Forms.TextBox();
            this.LabelNota = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeProceduresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // storeProceduresToolStripMenuItem
            // 
            this.storeProceduresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergeInsertUpdateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.storeProceduresToolStripMenuItem.Name = "storeProceduresToolStripMenuItem";
            this.storeProceduresToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.storeProceduresToolStripMenuItem.Text = "Stored Procedures";
            // 
            // mergeInsertUpdateToolStripMenuItem
            // 
            this.mergeInsertUpdateToolStripMenuItem.Name = "mergeInsertUpdateToolStripMenuItem";
            this.mergeInsertUpdateToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.mergeInsertUpdateToolStripMenuItem.Text = "Merge (Insert-Update)";
            this.mergeInsertUpdateToolStripMenuItem.Click += new System.EventHandler(this.mergeInsertUpdateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // textBoxNota
            // 
            this.textBoxNota.Location = new System.Drawing.Point(12, 45);
            this.textBoxNota.Multiline = true;
            this.textBoxNota.Name = "textBoxNota";
            this.textBoxNota.Size = new System.Drawing.Size(414, 125);
            this.textBoxNota.TabIndex = 1;
            // 
            // LabelNota
            // 
            this.LabelNota.AutoSize = true;
            this.LabelNota.Location = new System.Drawing.Point(186, 26);
            this.LabelNota.Name = "LabelNota";
            this.LabelNota.Size = new System.Drawing.Size(37, 13);
            this.LabelNota.TabIndex = 2;
            this.LabelNota.Text = "NOTA";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(351, 176);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 201);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.LabelNota);
            this.Controls.Add(this.textBoxNota);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROCEDURE MANAGMENT (PS)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem storeProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeInsertUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxNota;
        private System.Windows.Forms.Label LabelNota;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
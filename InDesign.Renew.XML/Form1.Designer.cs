namespace InDesign.Renew.XML
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaListaCodiciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostraCodiciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pulisciCodiciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostraXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aiutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbStep1 = new System.Windows.Forms.GroupBox();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.pgbLoadCurrentCode = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGetCurrentCode = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gpbStep1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizzaListaCodiciToolStripMenuItem,
            this.puToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // visualizzaListaCodiciToolStripMenuItem
            // 
            this.visualizzaListaCodiciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostraCodiciToolStripMenuItem,
            this.pulisciCodiciToolStripMenuItem});
            this.visualizzaListaCodiciToolStripMenuItem.Name = "visualizzaListaCodiciToolStripMenuItem";
            this.visualizzaListaCodiciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visualizzaListaCodiciToolStripMenuItem.Text = "Codici";
            // 
            // mostraCodiciToolStripMenuItem
            // 
            this.mostraCodiciToolStripMenuItem.Name = "mostraCodiciToolStripMenuItem";
            this.mostraCodiciToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.mostraCodiciToolStripMenuItem.Text = "Mostra codici";
            // 
            // pulisciCodiciToolStripMenuItem
            // 
            this.pulisciCodiciToolStripMenuItem.Name = "pulisciCodiciToolStripMenuItem";
            this.pulisciCodiciToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.pulisciCodiciToolStripMenuItem.Text = "Pulisci codici";
            // 
            // puToolStripMenuItem
            // 
            this.puToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostraXMLToolStripMenuItem});
            this.puToolStripMenuItem.Name = "puToolStripMenuItem";
            this.puToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.puToolStripMenuItem.Text = "XML";
            // 
            // mostraXMLToolStripMenuItem
            // 
            this.mostraXMLToolStripMenuItem.Name = "mostraXMLToolStripMenuItem";
            this.mostraXMLToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.mostraXMLToolStripMenuItem.Text = "Mostra XML";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.aiutoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // aiutoToolStripMenuItem
            // 
            this.aiutoToolStripMenuItem.Name = "aiutoToolStripMenuItem";
            this.aiutoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aiutoToolStripMenuItem.Text = "Aiuto";
            this.aiutoToolStripMenuItem.Click += new System.EventHandler(this.aiutoToolStripMenuItem_Click);
            // 
            // gpbStep1
            // 
            this.gpbStep1.Controls.Add(this.lblStep1);
            this.gpbStep1.Controls.Add(this.pgbLoadCurrentCode);
            this.gpbStep1.Controls.Add(this.textBox1);
            this.gpbStep1.Controls.Add(this.btnGetCurrentCode);
            this.gpbStep1.Location = new System.Drawing.Point(12, 27);
            this.gpbStep1.Name = "gpbStep1";
            this.gpbStep1.Size = new System.Drawing.Size(257, 130);
            this.gpbStep1.TabIndex = 1;
            this.gpbStep1.TabStop = false;
            this.gpbStep1.Text = "Step 1 - Get current code";
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Location = new System.Drawing.Point(6, 77);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(130, 13);
            this.lblStep1.TabIndex = 3;
            this.lblStep1.Text = "Current activation code is:";
            // 
            // pgbLoadCurrentCode
            // 
            this.pgbLoadCurrentCode.Location = new System.Drawing.Point(113, 34);
            this.pgbLoadCurrentCode.Name = "pgbLoadCurrentCode";
            this.pgbLoadCurrentCode.Size = new System.Drawing.Size(138, 23);
            this.pgbLoadCurrentCode.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(7, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnGetCurrentCode
            // 
            this.btnGetCurrentCode.Location = new System.Drawing.Point(6, 19);
            this.btnGetCurrentCode.Name = "btnGetCurrentCode";
            this.btnGetCurrentCode.Size = new System.Drawing.Size(101, 52);
            this.btnGetCurrentCode.TabIndex = 0;
            this.btnGetCurrentCode.Text = "Get\r\ncurrent\r\ncode";
            this.btnGetCurrentCode.UseVisualStyleBackColor = true;
            this.btnGetCurrentCode.Click += new System.EventHandler(this.btnGetCurrentCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 330);
            this.Controls.Add(this.gpbStep1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbStep1.ResumeLayout(false);
            this.gpbStep1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaListaCodiciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostraCodiciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pulisciCodiciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostraXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aiutoToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbStep1;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.ProgressBar pgbLoadCurrentCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGetCurrentCode;
    }
}


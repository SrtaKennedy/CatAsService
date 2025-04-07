namespace CatAsService
{
    partial class HomeCat
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeCat));
            this.lblTitleHome = new System.Windows.Forms.Label();
            this.imageHome = new System.Windows.Forms.PictureBox();
            this.menuHome = new System.Windows.Forms.MenuStrip();
            this.buscarRacasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusFavoritosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imageHome)).BeginInit();
            this.menuHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleHome
            // 
            this.lblTitleHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHome.Location = new System.Drawing.Point(171, 288);
            this.lblTitleHome.Name = "lblTitleHome";
            this.lblTitleHome.Size = new System.Drawing.Size(161, 78);
            this.lblTitleHome.TabIndex = 0;
            this.lblTitleHome.Text = "Bem-vindo(a) ao Cat As Service";
            this.lblTitleHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageHome
            // 
            this.imageHome.Image = global::CatAsService.Properties.Resources.molly;
            this.imageHome.Location = new System.Drawing.Point(144, 89);
            this.imageHome.Name = "imageHome";
            this.imageHome.Size = new System.Drawing.Size(223, 187);
            this.imageHome.TabIndex = 1;
            this.imageHome.TabStop = false;
            // 
            // menuHome
            // 
            this.menuHome.AutoSize = false;
            this.menuHome.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.menuHome.Dock = System.Windows.Forms.DockStyle.None;
            this.menuHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarRacasMenuItem,
            this.meusFavoritosMenuItem});
            this.menuHome.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuHome.Location = new System.Drawing.Point(0, 0);
            this.menuHome.Name = "menuHome";
            this.menuHome.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuHome.Size = new System.Drawing.Size(516, 38);
            this.menuHome.TabIndex = 2;
            this.menuHome.Text = "menu";
            // 
            // buscarRacasMenuItem
            // 
            this.buscarRacasMenuItem.ForeColor = System.Drawing.Color.Black;
            this.buscarRacasMenuItem.Name = "buscarRacasMenuItem";
            this.buscarRacasMenuItem.Size = new System.Drawing.Size(95, 34);
            this.buscarRacasMenuItem.Text = "Buscar raças";
            this.buscarRacasMenuItem.Click += new System.EventHandler(this.buscarRacasMenuItem_Click);
            // 
            // meusFavoritosMenuItem
            // 
            this.meusFavoritosMenuItem.ForeColor = System.Drawing.Color.Black;
            this.meusFavoritosMenuItem.Name = "meusFavoritosMenuItem";
            this.meusFavoritosMenuItem.Size = new System.Drawing.Size(110, 34);
            this.meusFavoritosMenuItem.Text = "Meus favoritos";
            this.meusFavoritosMenuItem.Click += new System.EventHandler(this.meusFavoritosMenuItem_Click);
            // 
            // HomeCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(516, 389);
            this.Controls.Add(this.imageHome);
            this.Controls.Add(this.lblTitleHome);
            this.Controls.Add(this.menuHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuHome;
            this.Name = "HomeCat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem-vindo(a) ao Cat As Service";
            ((System.ComponentModel.ISupportInitialize)(this.imageHome)).EndInit();
            this.menuHome.ResumeLayout(false);
            this.menuHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleHome;
        private System.Windows.Forms.PictureBox imageHome;
        private System.Windows.Forms.MenuStrip menuHome;
        private System.Windows.Forms.ToolStripMenuItem buscarRacasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusFavoritosMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}


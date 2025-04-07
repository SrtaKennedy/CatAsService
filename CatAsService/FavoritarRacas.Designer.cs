namespace CatAsService
{
    partial class FavoritarRacas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritarRacas));
            this.lblTitleFvoritos = new System.Windows.Forms.Label();
            this.lblTextFavorito = new System.Windows.Forms.Label();
            this.listFavoritos = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleFvoritos
            // 
            this.lblTitleFvoritos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleFvoritos.Location = new System.Drawing.Point(22, 18);
            this.lblTitleFvoritos.Name = "lblTitleFvoritos";
            this.lblTitleFvoritos.Size = new System.Drawing.Size(237, 39);
            this.lblTitleFvoritos.TabIndex = 0;
            this.lblTitleFvoritos.Text = "Meus Favoritos";
            this.lblTitleFvoritos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextFavorito
            // 
            this.lblTextFavorito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFavorito.Location = new System.Drawing.Point(23, 57);
            this.lblTextFavorito.Name = "lblTextFavorito";
            this.lblTextFavorito.Size = new System.Drawing.Size(325, 26);
            this.lblTextFavorito.TabIndex = 1;
            this.lblTextFavorito.Text = "Aqui você encontra lista de gatinhos favoritos";
            // 
            // listFavoritos
            // 
            this.listFavoritos.FormattingEnabled = true;
            this.listFavoritos.Location = new System.Drawing.Point(26, 112);
            this.listFavoritos.Name = "listFavoritos";
            this.listFavoritos.Size = new System.Drawing.Size(322, 290);
            this.listFavoritos.TabIndex = 2;
            this.listFavoritos.SelectedIndexChanged += new System.EventHandler(this.listFavoritos_SelectedIndexChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(221, 416);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(127, 40);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir gatinho";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FavoritarRacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(373, 468);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.listFavoritos);
            this.Controls.Add(this.lblTextFavorito);
            this.Controls.Add(this.lblTitleFvoritos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FavoritarRacas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Raças Favoritas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox listRacas;
        private System.Windows.Forms.Label lblTitleFvoritos;
        private System.Windows.Forms.Label lblTextFavorito;
        private System.Windows.Forms.ListBox listFavoritos;
        private System.Windows.Forms.Button btnExcluir;
    }
}
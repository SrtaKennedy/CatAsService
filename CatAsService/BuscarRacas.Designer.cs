namespace CatAsService
{
    partial class BuscarRacas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarRacas));
            this.lblTextFavorito = new System.Windows.Forms.Label();
            this.lblTitleFavorito = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTemperamento = new System.Windows.Forms.Label();
            this.ComboxRacas = new System.Windows.Forms.ComboBox();
            this.lblTempement = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnFavoritar = new System.Windows.Forms.Button();
            this.imageBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextFavorito
            // 
            this.lblTextFavorito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFavorito.Location = new System.Drawing.Point(12, 46);
            this.lblTextFavorito.Name = "lblTextFavorito";
            this.lblTextFavorito.Size = new System.Drawing.Size(428, 85);
            this.lblTextFavorito.TabIndex = 0;
            this.lblTextFavorito.Text = "Utilize a caixa de seleção de raças para buscar características sobre determinado" +
    " gatinho e descobrir qual é a sua raça favorita";
            this.lblTextFavorito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleFavorito
            // 
            this.lblTitleFavorito.AutoSize = true;
            this.lblTitleFavorito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFavorito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleFavorito.Location = new System.Drawing.Point(12, 21);
            this.lblTitleFavorito.Name = "lblTitleFavorito";
            this.lblTitleFavorito.Size = new System.Drawing.Size(290, 25);
            this.lblTitleFavorito.TabIndex = 1;
            this.lblTitleFavorito.Text = "Encontre sua raça favorita";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblName.Location = new System.Drawing.Point(108, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Raça do gato";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblOrigem.Location = new System.Drawing.Point(146, 214);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(60, 20);
            this.lblOrigem.TabIndex = 3;
            this.lblOrigem.Text = "Origem";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDescricao.Location = new System.Drawing.Point(131, 256);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(75, 20);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblTemperamento
            // 
            this.lblTemperamento.AutoSize = true;
            this.lblTemperamento.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperamento.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTemperamento.Location = new System.Drawing.Point(94, 172);
            this.lblTemperamento.Name = "lblTemperamento";
            this.lblTemperamento.Size = new System.Drawing.Size(112, 20);
            this.lblTemperamento.TabIndex = 5;
            this.lblTemperamento.Text = "Temperamento";
            // 
            // ComboxRacas
            // 
            this.ComboxRacas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboxRacas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboxRacas.FormattingEnabled = true;
            this.ComboxRacas.Location = new System.Drawing.Point(231, 132);
            this.ComboxRacas.Name = "ComboxRacas";
            this.ComboxRacas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboxRacas.Size = new System.Drawing.Size(186, 21);
            this.ComboxRacas.TabIndex = 6;
            this.ComboxRacas.SelectedIndexChanged += new System.EventHandler(this.listRacas_SelectedIndexChanged);
            // 
            // lblTempement
            // 
            this.lblTempement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTempement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempement.Location = new System.Drawing.Point(231, 172);
            this.lblTempement.Name = "lblTempement";
            this.lblTempement.Size = new System.Drawing.Size(193, 26);
            this.lblTempement.TabIndex = 7;
            this.lblTempement.Text = "Resultado";
            this.lblTempement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(231, 256);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(193, 73);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Resultado";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrigin
            // 
            this.lblOrigin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrigin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigin.Location = new System.Drawing.Point(231, 214);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(193, 26);
            this.lblOrigin.TabIndex = 9;
            this.lblOrigin.Text = "Resultado";
            this.lblOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(231, 345);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 40);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnFavoritar
            // 
            this.btnFavoritar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFavoritar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoritar.ForeColor = System.Drawing.Color.White;
            this.btnFavoritar.Location = new System.Drawing.Point(334, 345);
            this.btnFavoritar.Name = "btnFavoritar";
            this.btnFavoritar.Size = new System.Drawing.Size(90, 40);
            this.btnFavoritar.TabIndex = 11;
            this.btnFavoritar.Text = "Favoritar";
            this.btnFavoritar.UseVisualStyleBackColor = false;
            this.btnFavoritar.Click += new System.EventHandler(this.btnFavoritar_Click);
            // 
            // imageBuscar
            // 
            this.imageBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBuscar.Image = global::CatAsService.Properties.Resources.laugh;
            this.imageBuscar.Location = new System.Drawing.Point(25, 303);
            this.imageBuscar.Name = "imageBuscar";
            this.imageBuscar.Size = new System.Drawing.Size(181, 88);
            this.imageBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageBuscar.TabIndex = 12;
            this.imageBuscar.TabStop = false;
            // 
            // BuscarRacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(460, 403);
            this.Controls.Add(this.imageBuscar);
            this.Controls.Add(this.btnFavoritar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTempement);
            this.Controls.Add(this.ComboxRacas);
            this.Controls.Add(this.lblTemperamento);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitleFavorito);
            this.Controls.Add(this.lblTextFavorito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarRacas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Raças";
            ((System.ComponentModel.ISupportInitialize)(this.imageBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextFavorito;
        private System.Windows.Forms.Label lblTitleFavorito;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTemperamento;
        private System.Windows.Forms.ComboBox ComboxRacas;
        private System.Windows.Forms.Label lblTempement;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnFavoritar;
        private System.Windows.Forms.PictureBox imageBuscar;
    }
}
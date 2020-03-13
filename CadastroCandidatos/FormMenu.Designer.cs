namespace CadastroCandidatos
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.btMaximizar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btUsuario = new System.Windows.Forms.Button();
            this.btParticipantes = new System.Windows.Forms.Button();
            this.panelSistema = new System.Windows.Forms.Panel();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.lbTituloUser = new System.Windows.Forms.Label();
            this.lbUsuarioLogado = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.DimGray;
            this.panelCabecalho.Controls.Add(this.btRestaurar);
            this.panelCabecalho.Controls.Add(this.btMaximizar);
            this.panelCabecalho.Controls.Add(this.btFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(168, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(786, 40);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // btRestaurar
            // 
            this.btRestaurar.AccessibleName = "";
            this.btRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btRestaurar.FlatAppearance.BorderSize = 0;
            this.btRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btRestaurar.Image")));
            this.btRestaurar.Location = new System.Drawing.Point(700, 0);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(40, 40);
            this.btRestaurar.TabIndex = 3;
            this.btRestaurar.UseVisualStyleBackColor = true;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // btMaximizar
            // 
            this.btMaximizar.AccessibleName = "";
            this.btMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btMaximizar.FlatAppearance.BorderSize = 0;
            this.btMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btMaximizar.Image")));
            this.btMaximizar.Location = new System.Drawing.Point(700, 0);
            this.btMaximizar.Name = "btMaximizar";
            this.btMaximizar.Size = new System.Drawing.Size(40, 40);
            this.btMaximizar.TabIndex = 2;
            this.btMaximizar.UseVisualStyleBackColor = true;
            this.btMaximizar.Click += new System.EventHandler(this.btMaximizar_Click);
            // 
            // btFechar
            // 
            this.btFechar.AccessibleName = "";
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Image = ((System.Drawing.Image)(resources.GetObject("btFechar.Image")));
            this.btFechar.Location = new System.Drawing.Point(746, 0);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(40, 40);
            this.btFechar.TabIndex = 1;
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTitulo.Location = new System.Drawing.Point(3, 12);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(151, 16);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Cadastro Participantes";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelMenu.Controls.Add(this.lbUsuarioLogado);
            this.panelMenu.Controls.Add(this.lbTituloUser);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btUsuario);
            this.panelMenu.Controls.Add(this.btParticipantes);
            this.panelMenu.Controls.Add(this.panelSistema);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(168, 579);
            this.panelMenu.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Location = new System.Drawing.Point(0, 440);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(168, 127);
            this.panelLogo.TabIndex = 0;
            // 
            // btUsuario
            // 
            this.btUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btUsuario.FlatAppearance.BorderSize = 0;
            this.btUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsuario.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsuario.ForeColor = System.Drawing.Color.White;
            this.btUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btUsuario.Image")));
            this.btUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsuario.Location = new System.Drawing.Point(0, 102);
            this.btUsuario.Name = "btUsuario";
            this.btUsuario.Size = new System.Drawing.Size(168, 50);
            this.btUsuario.TabIndex = 3;
            this.btUsuario.Text = "USUARIO";
            this.btUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUsuario.UseVisualStyleBackColor = true;
            this.btUsuario.Click += new System.EventHandler(this.btUsuario_Click);
            // 
            // btParticipantes
            // 
            this.btParticipantes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btParticipantes.FlatAppearance.BorderSize = 0;
            this.btParticipantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btParticipantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btParticipantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btParticipantes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btParticipantes.ForeColor = System.Drawing.Color.MintCream;
            this.btParticipantes.Image = ((System.Drawing.Image)(resources.GetObject("btParticipantes.Image")));
            this.btParticipantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btParticipantes.Location = new System.Drawing.Point(0, 46);
            this.btParticipantes.Name = "btParticipantes";
            this.btParticipantes.Size = new System.Drawing.Size(168, 50);
            this.btParticipantes.TabIndex = 2;
            this.btParticipantes.Text = "PARTICIPANTES";
            this.btParticipantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btParticipantes.UseVisualStyleBackColor = true;
            this.btParticipantes.Click += new System.EventHandler(this.btParticipantes_Click);
            // 
            // panelSistema
            // 
            this.panelSistema.BackColor = System.Drawing.Color.DimGray;
            this.panelSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelSistema.Controls.Add(this.labelTitulo);
            this.panelSistema.Location = new System.Drawing.Point(0, 0);
            this.panelSistema.Name = "panelSistema";
            this.panelSistema.Size = new System.Drawing.Size(168, 40);
            this.panelSistema.TabIndex = 0;
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(168, 40);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(786, 539);
            this.panelConteudo.TabIndex = 2;
            // 
            // lbTituloUser
            // 
            this.lbTituloUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTituloUser.AutoSize = true;
            this.lbTituloUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloUser.ForeColor = System.Drawing.Color.White;
            this.lbTituloUser.Location = new System.Drawing.Point(6, 421);
            this.lbTituloUser.Name = "lbTituloUser";
            this.lbTituloUser.Size = new System.Drawing.Size(54, 13);
            this.lbTituloUser.TabIndex = 4;
            this.lbTituloUser.Text = "Usuario:";
            // 
            // lbUsuarioLogado
            // 
            this.lbUsuarioLogado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsuarioLogado.AutoSize = true;
            this.lbUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarioLogado.ForeColor = System.Drawing.Color.White;
            this.lbUsuarioLogado.Location = new System.Drawing.Point(66, 421);
            this.lbUsuarioLogado.Name = "lbUsuarioLogado";
            this.lbUsuarioLogado.Size = new System.Drawing.Size(48, 13);
            this.lbUsuarioLogado.TabIndex = 5;
            this.lbUsuarioLogado.Text = "usuario";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 579);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelCabecalho.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelSistema.ResumeLayout(false);
            this.panelSistema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btRestaurar;
        private System.Windows.Forms.Button btMaximizar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btUsuario;
        private System.Windows.Forms.Button btParticipantes;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Panel panelSistema;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lbUsuarioLogado;
        private System.Windows.Forms.Label lbTituloUser;
    }
}


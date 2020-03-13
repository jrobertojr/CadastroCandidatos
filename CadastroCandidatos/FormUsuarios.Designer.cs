namespace CadastroCandidatos
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btFechar = new System.Windows.Forms.Button();
            this.lbFormUsuario = new System.Windows.Forms.Label();
            this.lbTituloCadUser = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.tboxUsuario = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tboxSenha = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tboxNome = new System.Windows.Forms.TextBox();
            this.panelDivisoriaUsuario = new System.Windows.Forms.Panel();
            this.lbTituloUsuarios = new System.Windows.Forms.Label();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.btCadastrarUsuario = new System.Windows.Forms.Button();
            this.cboxUsuarios = new System.Windows.Forms.ComboBox();
            this.lbEditUser = new System.Windows.Forms.Label();
            this.lbEditSenha = new System.Windows.Forms.Label();
            this.tboxEditSenha = new System.Windows.Forms.TextBox();
            this.lbEditNomeUsuario = new System.Windows.Forms.Label();
            this.tboxEditUsuario = new System.Windows.Forms.TextBox();
            this.lbEditNome = new System.Windows.Forms.Label();
            this.tboxEditNome = new System.Windows.Forms.TextBox();
            this.btAtualizarUser = new System.Windows.Forms.Button();
            this.cbEditStatus = new System.Windows.Forms.ComboBox();
            this.lbEditStatus = new System.Windows.Forms.Label();
            this.cbEditAdm = new System.Windows.Forms.ComboBox();
            this.lbEditAdm = new System.Windows.Forms.Label();
            this.lbAdm = new System.Windows.Forms.Label();
            this.cbAdm = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btFechar);
            this.panel1.Controls.Add(this.lbFormUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 40);
            this.panel1.TabIndex = 0;
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
            this.btFechar.Location = new System.Drawing.Point(733, 0);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(40, 40);
            this.btFechar.TabIndex = 21;
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lbFormUsuario
            // 
            this.lbFormUsuario.AutoSize = true;
            this.lbFormUsuario.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormUsuario.Location = new System.Drawing.Point(12, 5);
            this.lbFormUsuario.Name = "lbFormUsuario";
            this.lbFormUsuario.Size = new System.Drawing.Size(105, 27);
            this.lbFormUsuario.TabIndex = 0;
            this.lbFormUsuario.Text = "Usuarios";
            // 
            // lbTituloCadUser
            // 
            this.lbTituloCadUser.AutoSize = true;
            this.lbTituloCadUser.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloCadUser.Location = new System.Drawing.Point(12, 57);
            this.lbTituloCadUser.Name = "lbTituloCadUser";
            this.lbTituloCadUser.Size = new System.Drawing.Size(261, 31);
            this.lbTituloCadUser.TabIndex = 1;
            this.lbTituloCadUser.Text = "Cadastro de Usuario";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(15, 109);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(46, 13);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuario:";
            // 
            // tboxUsuario
            // 
            this.tboxUsuario.Location = new System.Drawing.Point(64, 106);
            this.tboxUsuario.Name = "tboxUsuario";
            this.tboxUsuario.Size = new System.Drawing.Size(149, 20);
            this.tboxUsuario.TabIndex = 1;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(232, 109);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(41, 13);
            this.lbSenha.TabIndex = 4;
            this.lbSenha.Text = "Senha:";
            // 
            // tboxSenha
            // 
            this.tboxSenha.Location = new System.Drawing.Point(279, 106);
            this.tboxSenha.Name = "tboxSenha";
            this.tboxSenha.Size = new System.Drawing.Size(158, 20);
            this.tboxSenha.TabIndex = 2;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(454, 109);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome:";
            // 
            // tboxNome
            // 
            this.tboxNome.Location = new System.Drawing.Point(498, 106);
            this.tboxNome.Name = "tboxNome";
            this.tboxNome.Size = new System.Drawing.Size(264, 20);
            this.tboxNome.TabIndex = 3;
            // 
            // panelDivisoriaUsuario
            // 
            this.panelDivisoriaUsuario.BackColor = System.Drawing.Color.DimGray;
            this.panelDivisoriaUsuario.Location = new System.Drawing.Point(0, 152);
            this.panelDivisoriaUsuario.Name = "panelDivisoriaUsuario";
            this.panelDivisoriaUsuario.Size = new System.Drawing.Size(773, 5);
            this.panelDivisoriaUsuario.TabIndex = 8;
            // 
            // lbTituloUsuarios
            // 
            this.lbTituloUsuarios.AutoSize = true;
            this.lbTituloUsuarios.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloUsuarios.Location = new System.Drawing.Point(12, 178);
            this.lbTituloUsuarios.Name = "lbTituloUsuarios";
            this.lbTituloUsuarios.Size = new System.Drawing.Size(280, 31);
            this.lbTituloUsuarios.TabIndex = 9;
            this.lbTituloUsuarios.Text = "Usuarios Cadastrados";
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(12, 212);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.Size = new System.Drawing.Size(554, 330);
            this.dtgUsuarios.TabIndex = 10;
            this.dtgUsuarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgUsuarios_CellMouseClick);
            // 
            // btCadastrarUsuario
            // 
            this.btCadastrarUsuario.BackColor = System.Drawing.Color.Gray;
            this.btCadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btCadastrarUsuario.Location = new System.Drawing.Point(621, 57);
            this.btCadastrarUsuario.Name = "btCadastrarUsuario";
            this.btCadastrarUsuario.Size = new System.Drawing.Size(141, 31);
            this.btCadastrarUsuario.TabIndex = 4;
            this.btCadastrarUsuario.Text = "Cadastrar";
            this.btCadastrarUsuario.UseVisualStyleBackColor = false;
            this.btCadastrarUsuario.Click += new System.EventHandler(this.btCadastrarUsuario_Click);
            // 
            // cboxUsuarios
            // 
            this.cboxUsuarios.FormattingEnabled = true;
            this.cboxUsuarios.Location = new System.Drawing.Point(572, 227);
            this.cboxUsuarios.Name = "cboxUsuarios";
            this.cboxUsuarios.Size = new System.Drawing.Size(190, 21);
            this.cboxUsuarios.TabIndex = 5;
            this.cboxUsuarios.SelectedIndexChanged += new System.EventHandler(this.cboxUsuarios_SelectedIndexChanged);
            // 
            // lbEditUser
            // 
            this.lbEditUser.AutoSize = true;
            this.lbEditUser.Location = new System.Drawing.Point(569, 211);
            this.lbEditUser.Name = "lbEditUser";
            this.lbEditUser.Size = new System.Drawing.Size(43, 13);
            this.lbEditUser.TabIndex = 13;
            this.lbEditUser.Text = "Usuario";
            // 
            // lbEditSenha
            // 
            this.lbEditSenha.AutoSize = true;
            this.lbEditSenha.Location = new System.Drawing.Point(569, 326);
            this.lbEditSenha.Name = "lbEditSenha";
            this.lbEditSenha.Size = new System.Drawing.Size(41, 13);
            this.lbEditSenha.TabIndex = 14;
            this.lbEditSenha.Text = "Senha:";
            // 
            // tboxEditSenha
            // 
            this.tboxEditSenha.Location = new System.Drawing.Point(572, 342);
            this.tboxEditSenha.Name = "tboxEditSenha";
            this.tboxEditSenha.Size = new System.Drawing.Size(190, 20);
            this.tboxEditSenha.TabIndex = 7;
            // 
            // lbEditNomeUsuario
            // 
            this.lbEditNomeUsuario.AutoSize = true;
            this.lbEditNomeUsuario.Location = new System.Drawing.Point(569, 270);
            this.lbEditNomeUsuario.Name = "lbEditNomeUsuario";
            this.lbEditNomeUsuario.Size = new System.Drawing.Size(77, 13);
            this.lbEditNomeUsuario.TabIndex = 16;
            this.lbEditNomeUsuario.Text = "Nome Usuario:";
            // 
            // tboxEditUsuario
            // 
            this.tboxEditUsuario.Location = new System.Drawing.Point(572, 286);
            this.tboxEditUsuario.Name = "tboxEditUsuario";
            this.tboxEditUsuario.Size = new System.Drawing.Size(190, 20);
            this.tboxEditUsuario.TabIndex = 6;
            // 
            // lbEditNome
            // 
            this.lbEditNome.AutoSize = true;
            this.lbEditNome.Location = new System.Drawing.Point(569, 385);
            this.lbEditNome.Name = "lbEditNome";
            this.lbEditNome.Size = new System.Drawing.Size(38, 13);
            this.lbEditNome.TabIndex = 18;
            this.lbEditNome.Text = "Nome:";
            // 
            // tboxEditNome
            // 
            this.tboxEditNome.Location = new System.Drawing.Point(572, 401);
            this.tboxEditNome.Name = "tboxEditNome";
            this.tboxEditNome.Size = new System.Drawing.Size(190, 20);
            this.tboxEditNome.TabIndex = 8;
            // 
            // btAtualizarUser
            // 
            this.btAtualizarUser.BackColor = System.Drawing.Color.Gray;
            this.btAtualizarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizarUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarUser.ForeColor = System.Drawing.Color.White;
            this.btAtualizarUser.Location = new System.Drawing.Point(621, 483);
            this.btAtualizarUser.Name = "btAtualizarUser";
            this.btAtualizarUser.Size = new System.Drawing.Size(141, 31);
            this.btAtualizarUser.TabIndex = 10;
            this.btAtualizarUser.Text = "Atualizar";
            this.btAtualizarUser.UseVisualStyleBackColor = false;
            this.btAtualizarUser.Click += new System.EventHandler(this.btAtualizarUser_Click);
            // 
            // cbEditStatus
            // 
            this.cbEditStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditStatus.FormattingEnabled = true;
            this.cbEditStatus.Location = new System.Drawing.Point(572, 456);
            this.cbEditStatus.Name = "cbEditStatus";
            this.cbEditStatus.Size = new System.Drawing.Size(57, 21);
            this.cbEditStatus.TabIndex = 9;
            // 
            // lbEditStatus
            // 
            this.lbEditStatus.AutoSize = true;
            this.lbEditStatus.Location = new System.Drawing.Point(580, 440);
            this.lbEditStatus.Name = "lbEditStatus";
            this.lbEditStatus.Size = new System.Drawing.Size(40, 13);
            this.lbEditStatus.TabIndex = 56;
            this.lbEditStatus.Text = "Status:";
            // 
            // cbEditAdm
            // 
            this.cbEditAdm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditAdm.FormattingEnabled = true;
            this.cbEditAdm.Location = new System.Drawing.Point(635, 456);
            this.cbEditAdm.Name = "cbEditAdm";
            this.cbEditAdm.Size = new System.Drawing.Size(57, 21);
            this.cbEditAdm.TabIndex = 57;
            // 
            // lbEditAdm
            // 
            this.lbEditAdm.AutoSize = true;
            this.lbEditAdm.Location = new System.Drawing.Point(642, 440);
            this.lbEditAdm.Name = "lbEditAdm";
            this.lbEditAdm.Size = new System.Drawing.Size(37, 13);
            this.lbEditAdm.TabIndex = 58;
            this.lbEditAdm.Text = "Adm?:";
            // 
            // lbAdm
            // 
            this.lbAdm.AutoSize = true;
            this.lbAdm.Location = new System.Drawing.Point(455, 70);
            this.lbAdm.Name = "lbAdm";
            this.lbAdm.Size = new System.Drawing.Size(37, 13);
            this.lbAdm.TabIndex = 60;
            this.lbAdm.Text = "Adm?:";
            // 
            // cbAdm
            // 
            this.cbAdm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdm.FormattingEnabled = true;
            this.cbAdm.Location = new System.Drawing.Point(498, 67);
            this.cbAdm.Name = "cbAdm";
            this.cbAdm.Size = new System.Drawing.Size(57, 21);
            this.cbAdm.TabIndex = 59;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 554);
            this.Controls.Add(this.lbAdm);
            this.Controls.Add(this.cbAdm);
            this.Controls.Add(this.lbEditAdm);
            this.Controls.Add(this.cbEditAdm);
            this.Controls.Add(this.cbEditStatus);
            this.Controls.Add(this.lbEditStatus);
            this.Controls.Add(this.btAtualizarUser);
            this.Controls.Add(this.tboxEditNome);
            this.Controls.Add(this.lbEditNome);
            this.Controls.Add(this.tboxEditUsuario);
            this.Controls.Add(this.lbEditNomeUsuario);
            this.Controls.Add(this.tboxEditSenha);
            this.Controls.Add(this.lbEditSenha);
            this.Controls.Add(this.lbEditUser);
            this.Controls.Add(this.cboxUsuarios);
            this.Controls.Add(this.btCadastrarUsuario);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.lbTituloUsuarios);
            this.Controls.Add(this.panelDivisoriaUsuario);
            this.Controls.Add(this.tboxNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tboxSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.tboxUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbTituloCadUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTituloCadUser;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox tboxUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tboxSenha;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tboxNome;
        private System.Windows.Forms.Panel panelDivisoriaUsuario;
        private System.Windows.Forms.Label lbTituloUsuarios;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Label lbFormUsuario;
        private System.Windows.Forms.Button btCadastrarUsuario;
        private System.Windows.Forms.ComboBox cboxUsuarios;
        private System.Windows.Forms.Label lbEditUser;
        private System.Windows.Forms.Label lbEditSenha;
        private System.Windows.Forms.TextBox tboxEditSenha;
        private System.Windows.Forms.Label lbEditNomeUsuario;
        private System.Windows.Forms.TextBox tboxEditUsuario;
        private System.Windows.Forms.Label lbEditNome;
        private System.Windows.Forms.TextBox tboxEditNome;
        private System.Windows.Forms.Button btAtualizarUser;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.ComboBox cbEditStatus;
        private System.Windows.Forms.Label lbEditStatus;
        private System.Windows.Forms.ComboBox cbEditAdm;
        private System.Windows.Forms.Label lbEditAdm;
        private System.Windows.Forms.Label lbAdm;
        private System.Windows.Forms.ComboBox cbAdm;
    }
}
namespace CadastroCandidatos
{
    partial class FormParticipantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParticipantes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btFechar = new System.Windows.Forms.Button();
            this.lbFormParticipantes = new System.Windows.Forms.Label();
            this.lbTituloCadPart = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.tboxNome = new System.Windows.Forms.TextBox();
            this.lbRg = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.lbWhatsapp = new System.Windows.Forms.Label();
            this.lbEtapa = new System.Windows.Forms.Label();
            this.cbEtapa = new System.Windows.Forms.ComboBox();
            this.panelDivisoriaUsuario = new System.Windows.Forms.Panel();
            this.dtgParticipantes = new System.Windows.Forms.DataGridView();
            this.lbTituloEditPart = new System.Windows.Forms.Label();
            this.tboxEditNome = new System.Windows.Forms.TextBox();
            this.lbEditNome = new System.Windows.Forms.Label();
            this.lbEditRg = new System.Windows.Forms.Label();
            this.tboxEditEmail = new System.Windows.Forms.TextBox();
            this.lbEditEmail = new System.Windows.Forms.Label();
            this.lbEdirWhatsapp = new System.Windows.Forms.Label();
            this.cbEditEtapa = new System.Windows.Forms.ComboBox();
            this.lbEditEtapa = new System.Windows.Forms.Label();
            this.btAtualizarParticipante = new System.Windows.Forms.Button();
            this.btCadastrarParticipante = new System.Windows.Forms.Button();
            this.mtbRg = new System.Windows.Forms.MaskedTextBox();
            this.mtbWhatsapp = new System.Windows.Forms.MaskedTextBox();
            this.lbSelecionarParticipante = new System.Windows.Forms.Label();
            this.cbSelecionarParticipante = new System.Windows.Forms.ComboBox();
            this.mtbEditRg = new System.Windows.Forms.MaskedTextBox();
            this.mtbEdirWhatsapp = new System.Windows.Forms.MaskedTextBox();
            this.cbEditStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btExportarExel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btFechar);
            this.panel1.Controls.Add(this.lbFormParticipantes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 40);
            this.panel1.TabIndex = 1;
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
            this.btFechar.Location = new System.Drawing.Point(1039, 0);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(40, 40);
            this.btFechar.TabIndex = 21;
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lbFormParticipantes
            // 
            this.lbFormParticipantes.AutoSize = true;
            this.lbFormParticipantes.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormParticipantes.Location = new System.Drawing.Point(12, 5);
            this.lbFormParticipantes.Name = "lbFormParticipantes";
            this.lbFormParticipantes.Size = new System.Drawing.Size(153, 27);
            this.lbFormParticipantes.TabIndex = 0;
            this.lbFormParticipantes.Text = "Participantes";
            // 
            // lbTituloCadPart
            // 
            this.lbTituloCadPart.AutoSize = true;
            this.lbTituloCadPart.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloCadPart.Location = new System.Drawing.Point(11, 58);
            this.lbTituloCadPart.Name = "lbTituloCadPart";
            this.lbTituloCadPart.Size = new System.Drawing.Size(319, 31);
            this.lbTituloCadPart.TabIndex = 22;
            this.lbTituloCadPart.Text = "Cadastro de Participante";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(14, 108);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 23;
            this.lbNome.Text = "Nome:";
            // 
            // tboxNome
            // 
            this.tboxNome.Location = new System.Drawing.Point(58, 105);
            this.tboxNome.Name = "tboxNome";
            this.tboxNome.Size = new System.Drawing.Size(264, 20);
            this.tboxNome.TabIndex = 1;
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Location = new System.Drawing.Point(364, 108);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(24, 13);
            this.lbRg.TabIndex = 25;
            this.lbRg.Text = "Rg:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(14, 153);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(39, 13);
            this.lbEmail.TabIndex = 27;
            this.lbEmail.Text = "E-Mail:";
            // 
            // tboxEmail
            // 
            this.tboxEmail.Location = new System.Drawing.Point(58, 150);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(264, 20);
            this.tboxEmail.TabIndex = 2;
            // 
            // lbWhatsapp
            // 
            this.lbWhatsapp.AutoSize = true;
            this.lbWhatsapp.Location = new System.Drawing.Point(482, 108);
            this.lbWhatsapp.Name = "lbWhatsapp";
            this.lbWhatsapp.Size = new System.Drawing.Size(59, 13);
            this.lbWhatsapp.TabIndex = 29;
            this.lbWhatsapp.Text = "Whatsapp:";
            // 
            // lbEtapa
            // 
            this.lbEtapa.AutoSize = true;
            this.lbEtapa.Location = new System.Drawing.Point(364, 153);
            this.lbEtapa.Name = "lbEtapa";
            this.lbEtapa.Size = new System.Drawing.Size(38, 13);
            this.lbEtapa.TabIndex = 31;
            this.lbEtapa.Text = "Etapa:";
            // 
            // cbEtapa
            // 
            this.cbEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtapa.FormattingEnabled = true;
            this.cbEtapa.Location = new System.Drawing.Point(408, 150);
            this.cbEtapa.Name = "cbEtapa";
            this.cbEtapa.Size = new System.Drawing.Size(35, 21);
            this.cbEtapa.TabIndex = 5;
            // 
            // panelDivisoriaUsuario
            // 
            this.panelDivisoriaUsuario.BackColor = System.Drawing.Color.DimGray;
            this.panelDivisoriaUsuario.Location = new System.Drawing.Point(0, 186);
            this.panelDivisoriaUsuario.Name = "panelDivisoriaUsuario";
            this.panelDivisoriaUsuario.Size = new System.Drawing.Size(1079, 5);
            this.panelDivisoriaUsuario.TabIndex = 33;
            // 
            // dtgParticipantes
            // 
            this.dtgParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParticipantes.ColumnHeadersVisible = false;
            this.dtgParticipantes.Location = new System.Drawing.Point(12, 250);
            this.dtgParticipantes.Name = "dtgParticipantes";
            this.dtgParticipantes.Size = new System.Drawing.Size(713, 289);
            this.dtgParticipantes.TabIndex = 34;
            this.dtgParticipantes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgParticipantes_CellMouseClick);
            // 
            // lbTituloEditPart
            // 
            this.lbTituloEditPart.AutoSize = true;
            this.lbTituloEditPart.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloEditPart.Location = new System.Drawing.Point(11, 204);
            this.lbTituloEditPart.Name = "lbTituloEditPart";
            this.lbTituloEditPart.Size = new System.Drawing.Size(338, 31);
            this.lbTituloEditPart.TabIndex = 35;
            this.lbTituloEditPart.Text = "Participantes Cadastrados";
            // 
            // tboxEditNome
            // 
            this.tboxEditNome.Location = new System.Drawing.Point(786, 295);
            this.tboxEditNome.Name = "tboxEditNome";
            this.tboxEditNome.Size = new System.Drawing.Size(264, 20);
            this.tboxEditNome.TabIndex = 8;
            // 
            // lbEditNome
            // 
            this.lbEditNome.AutoSize = true;
            this.lbEditNome.Location = new System.Drawing.Point(742, 298);
            this.lbEditNome.Name = "lbEditNome";
            this.lbEditNome.Size = new System.Drawing.Size(38, 13);
            this.lbEditNome.TabIndex = 36;
            this.lbEditNome.Text = "Nome:";
            // 
            // lbEditRg
            // 
            this.lbEditRg.AutoSize = true;
            this.lbEditRg.Location = new System.Drawing.Point(742, 340);
            this.lbEditRg.Name = "lbEditRg";
            this.lbEditRg.Size = new System.Drawing.Size(24, 13);
            this.lbEditRg.TabIndex = 38;
            this.lbEditRg.Text = "Rg:";
            // 
            // tboxEditEmail
            // 
            this.tboxEditEmail.Location = new System.Drawing.Point(786, 382);
            this.tboxEditEmail.Name = "tboxEditEmail";
            this.tboxEditEmail.Size = new System.Drawing.Size(264, 20);
            this.tboxEditEmail.TabIndex = 10;
            // 
            // lbEditEmail
            // 
            this.lbEditEmail.AutoSize = true;
            this.lbEditEmail.Location = new System.Drawing.Point(742, 385);
            this.lbEditEmail.Name = "lbEditEmail";
            this.lbEditEmail.Size = new System.Drawing.Size(39, 13);
            this.lbEditEmail.TabIndex = 40;
            this.lbEditEmail.Text = "E-Mail:";
            // 
            // lbEdirWhatsapp
            // 
            this.lbEdirWhatsapp.AutoSize = true;
            this.lbEdirWhatsapp.Location = new System.Drawing.Point(742, 428);
            this.lbEdirWhatsapp.Name = "lbEdirWhatsapp";
            this.lbEdirWhatsapp.Size = new System.Drawing.Size(59, 13);
            this.lbEdirWhatsapp.TabIndex = 42;
            this.lbEdirWhatsapp.Text = "Whatsapp:";
            // 
            // cbEditEtapa
            // 
            this.cbEditEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditEtapa.FormattingEnabled = true;
            this.cbEditEtapa.Location = new System.Drawing.Point(926, 424);
            this.cbEditEtapa.Name = "cbEditEtapa";
            this.cbEditEtapa.Size = new System.Drawing.Size(35, 21);
            this.cbEditEtapa.TabIndex = 12;
            // 
            // lbEditEtapa
            // 
            this.lbEditEtapa.AutoSize = true;
            this.lbEditEtapa.Location = new System.Drawing.Point(923, 408);
            this.lbEditEtapa.Name = "lbEditEtapa";
            this.lbEditEtapa.Size = new System.Drawing.Size(38, 13);
            this.lbEditEtapa.TabIndex = 44;
            this.lbEditEtapa.Text = "Etapa:";
            // 
            // btAtualizarParticipante
            // 
            this.btAtualizarParticipante.BackColor = System.Drawing.Color.Gray;
            this.btAtualizarParticipante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizarParticipante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarParticipante.ForeColor = System.Drawing.Color.White;
            this.btAtualizarParticipante.Location = new System.Drawing.Point(909, 475);
            this.btAtualizarParticipante.Name = "btAtualizarParticipante";
            this.btAtualizarParticipante.Size = new System.Drawing.Size(141, 31);
            this.btAtualizarParticipante.TabIndex = 14;
            this.btAtualizarParticipante.Text = "Atualizar";
            this.btAtualizarParticipante.UseVisualStyleBackColor = false;
            this.btAtualizarParticipante.Click += new System.EventHandler(this.btAtualizarParticipante_Click);
            // 
            // btCadastrarParticipante
            // 
            this.btCadastrarParticipante.BackColor = System.Drawing.Color.Gray;
            this.btCadastrarParticipante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarParticipante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarParticipante.ForeColor = System.Drawing.Color.White;
            this.btCadastrarParticipante.Location = new System.Drawing.Point(506, 142);
            this.btCadastrarParticipante.Name = "btCadastrarParticipante";
            this.btCadastrarParticipante.Size = new System.Drawing.Size(141, 31);
            this.btCadastrarParticipante.TabIndex = 6;
            this.btCadastrarParticipante.Text = "Cadastrar";
            this.btCadastrarParticipante.UseVisualStyleBackColor = false;
            this.btCadastrarParticipante.Click += new System.EventHandler(this.btCadastrarParticipante_Click);
            // 
            // mtbRg
            // 
            this.mtbRg.Location = new System.Drawing.Point(394, 105);
            this.mtbRg.Mask = "00.000.000-0";
            this.mtbRg.Name = "mtbRg";
            this.mtbRg.Size = new System.Drawing.Size(72, 20);
            this.mtbRg.TabIndex = 3;
            // 
            // mtbWhatsapp
            // 
            this.mtbWhatsapp.Location = new System.Drawing.Point(547, 105);
            this.mtbWhatsapp.Mask = "(99) 00000-0000";
            this.mtbWhatsapp.Name = "mtbWhatsapp";
            this.mtbWhatsapp.Size = new System.Drawing.Size(100, 20);
            this.mtbWhatsapp.TabIndex = 4;
            // 
            // lbSelecionarParticipante
            // 
            this.lbSelecionarParticipante.AutoSize = true;
            this.lbSelecionarParticipante.Location = new System.Drawing.Point(742, 250);
            this.lbSelecionarParticipante.Name = "lbSelecionarParticipante";
            this.lbSelecionarParticipante.Size = new System.Drawing.Size(80, 13);
            this.lbSelecionarParticipante.TabIndex = 50;
            this.lbSelecionarParticipante.Text = "ID Participante:";
            // 
            // cbSelecionarParticipante
            // 
            this.cbSelecionarParticipante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelecionarParticipante.FormattingEnabled = true;
            this.cbSelecionarParticipante.Location = new System.Drawing.Point(828, 247);
            this.cbSelecionarParticipante.Name = "cbSelecionarParticipante";
            this.cbSelecionarParticipante.Size = new System.Drawing.Size(30, 21);
            this.cbSelecionarParticipante.TabIndex = 7;
            this.cbSelecionarParticipante.SelectedIndexChanged += new System.EventHandler(this.cbSelecionarParticipante_SelectedIndexChanged);
            // 
            // mtbEditRg
            // 
            this.mtbEditRg.Location = new System.Drawing.Point(786, 337);
            this.mtbEditRg.Mask = "00.000.000-0";
            this.mtbEditRg.Name = "mtbEditRg";
            this.mtbEditRg.Size = new System.Drawing.Size(72, 20);
            this.mtbEditRg.TabIndex = 9;
            // 
            // mtbEdirWhatsapp
            // 
            this.mtbEdirWhatsapp.Location = new System.Drawing.Point(807, 425);
            this.mtbEdirWhatsapp.Mask = "(99) 00000-0000";
            this.mtbEdirWhatsapp.Name = "mtbEdirWhatsapp";
            this.mtbEdirWhatsapp.Size = new System.Drawing.Size(100, 20);
            this.mtbEdirWhatsapp.TabIndex = 11;
            // 
            // cbEditStatus
            // 
            this.cbEditStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditStatus.FormattingEnabled = true;
            this.cbEditStatus.Location = new System.Drawing.Point(992, 424);
            this.cbEditStatus.Name = "cbEditStatus";
            this.cbEditStatus.Size = new System.Drawing.Size(58, 21);
            this.cbEditStatus.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(999, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Status:";
            // 
            // btExportarExel
            // 
            this.btExportarExel.BackColor = System.Drawing.Color.Gray;
            this.btExportarExel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExportarExel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportarExel.ForeColor = System.Drawing.Color.White;
            this.btExportarExel.Location = new System.Drawing.Point(523, 205);
            this.btExportarExel.Name = "btExportarExel";
            this.btExportarExel.Size = new System.Drawing.Size(202, 31);
            this.btExportarExel.TabIndex = 55;
            this.btExportarExel.Text = "Exportar para Excel";
            this.btExportarExel.UseVisualStyleBackColor = false;
            this.btExportarExel.Click += new System.EventHandler(this.btExportarExel_Click);
            // 
            // FormParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 551);
            this.Controls.Add(this.btExportarExel);
            this.Controls.Add(this.cbEditStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbEdirWhatsapp);
            this.Controls.Add(this.mtbEditRg);
            this.Controls.Add(this.cbSelecionarParticipante);
            this.Controls.Add(this.lbSelecionarParticipante);
            this.Controls.Add(this.mtbWhatsapp);
            this.Controls.Add(this.mtbRg);
            this.Controls.Add(this.btCadastrarParticipante);
            this.Controls.Add(this.btAtualizarParticipante);
            this.Controls.Add(this.cbEditEtapa);
            this.Controls.Add(this.lbEditEtapa);
            this.Controls.Add(this.lbEdirWhatsapp);
            this.Controls.Add(this.tboxEditEmail);
            this.Controls.Add(this.lbEditEmail);
            this.Controls.Add(this.lbEditRg);
            this.Controls.Add(this.tboxEditNome);
            this.Controls.Add(this.lbEditNome);
            this.Controls.Add(this.lbTituloEditPart);
            this.Controls.Add(this.dtgParticipantes);
            this.Controls.Add(this.panelDivisoriaUsuario);
            this.Controls.Add(this.cbEtapa);
            this.Controls.Add(this.lbEtapa);
            this.Controls.Add(this.lbWhatsapp);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbRg);
            this.Controls.Add(this.tboxNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbTituloCadPart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormParticipantes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "FormParticipantes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label lbFormParticipantes;
        private System.Windows.Forms.Label lbTituloCadPart;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tboxNome;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.Label lbWhatsapp;
        private System.Windows.Forms.Label lbEtapa;
        private System.Windows.Forms.ComboBox cbEtapa;
        private System.Windows.Forms.Panel panelDivisoriaUsuario;
        private System.Windows.Forms.DataGridView dtgParticipantes;
        private System.Windows.Forms.Label lbTituloEditPart;
        private System.Windows.Forms.TextBox tboxEditNome;
        private System.Windows.Forms.Label lbEditNome;
        private System.Windows.Forms.Label lbEditRg;
        private System.Windows.Forms.TextBox tboxEditEmail;
        private System.Windows.Forms.Label lbEditEmail;
        private System.Windows.Forms.Label lbEdirWhatsapp;
        private System.Windows.Forms.ComboBox cbEditEtapa;
        private System.Windows.Forms.Label lbEditEtapa;
        private System.Windows.Forms.Button btAtualizarParticipante;
        private System.Windows.Forms.Button btCadastrarParticipante;
        private System.Windows.Forms.MaskedTextBox mtbRg;
        private System.Windows.Forms.MaskedTextBox mtbWhatsapp;
        private System.Windows.Forms.Label lbSelecionarParticipante;
        private System.Windows.Forms.ComboBox cbSelecionarParticipante;
        private System.Windows.Forms.MaskedTextBox mtbEditRg;
        private System.Windows.Forms.MaskedTextBox mtbEdirWhatsapp;
        private System.Windows.Forms.ComboBox cbEditStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExportarExel;
    }
}
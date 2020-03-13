namespace CadastroCandidatos
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.mtxSenha = new System.Windows.Forms.MaskedTextBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btFechar = new System.Windows.Forms.Button();
            this.btLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(105, 169);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(142, 20);
            this.txUsuario.TabIndex = 1;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(27, 168);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(72, 18);
            this.lbUsuario.TabIndex = 25;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(27, 212);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(60, 18);
            this.lbSenha.TabIndex = 27;
            this.lbSenha.Text = "Senha:";
            // 
            // mtxSenha
            // 
            this.mtxSenha.Location = new System.Drawing.Point(105, 213);
            this.mtxSenha.Name = "mtxSenha";
            this.mtxSenha.PasswordChar = '*';
            this.mtxSenha.Size = new System.Drawing.Size(142, 20);
            this.mtxSenha.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::CadastroCandidatos.Properties.Resources.Logo04;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Location = new System.Drawing.Point(154, 12);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(170, 129);
            this.panelLogo.TabIndex = 29;
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
            this.btFechar.Location = new System.Drawing.Point(417, 2);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(40, 40);
            this.btFechar.TabIndex = 30;
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btLogar
            // 
            this.btLogar.BackColor = System.Drawing.Color.Gray;
            this.btLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogar.ForeColor = System.Drawing.Color.White;
            this.btLogar.Location = new System.Drawing.Point(289, 183);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(141, 31);
            this.btLogar.TabIndex = 3;
            this.btLogar.Text = "Logar";
            this.btLogar.UseVisualStyleBackColor = false;
            this.btLogar.Click += new System.EventHandler(this.btLogar_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btLogar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(459, 276);
            this.Controls.Add(this.btLogar);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.mtxSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.lbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.MaskedTextBox mtxSenha;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btLogar;
    }
}
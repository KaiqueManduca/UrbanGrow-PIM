namespace UrbanGrow.Forms {
    partial class Usuarios {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tabFuncionario = new DataGridView();
            txtNome = new TextBox();
            lblNome = new Label();
            label1 = new Label();
            txtEndereco = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtCpf = new TextBox();
            label4 = new Label();
            txtSalario = new TextBox();
            label5 = new Label();
            dtNascimento = new DateTimePicker();
            label7 = new Label();
            dtEntrada = new DateTimePicker();
            label6 = new Label();
            btnInserir = new FontAwesome.Sharp.IconButton();
            btnAtualizar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnDeletar = new FontAwesome.Sharp.IconButton();
            txtBuscarID = new TextBox();
            btnAtt = new FontAwesome.Sharp.IconButton();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblUser = new Label();
            txtUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tabFuncionario).BeginInit();
            SuspendLayout();
            // 
            // tabFuncionario
            // 
            tabFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabFuncionario.Location = new Point(3, 263);
            tabFuncionario.Name = "tabFuncionario";
            tabFuncionario.Size = new Size(731, 150);
            tabFuncionario.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(44, 55);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite aqui";
            txtNome.Size = new Size(176, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(44, 31);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 21);
            lblNome.TabIndex = 22;
            lblNome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 81);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 24;
            label1.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(44, 105);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Digite aqui";
            txtEndereco.Size = new Size(176, 23);
            txtEndereco.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 134);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 26;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(44, 158);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite aqui";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 191);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 28;
            label3.Text = "CPF";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(44, 215);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "Digite aqui";
            txtCpf.Size = new Size(176, 23);
            txtCpf.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(244, 80);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 30;
            label4.Text = "Salário";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(244, 104);
            txtSalario.Name = "txtSalario";
            txtSalario.PlaceholderText = "Digite aqui";
            txtSalario.Size = new Size(200, 23);
            txtSalario.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(244, 81);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 32;
            // 
            // dtNascimento
            // 
            dtNascimento.Location = new Point(244, 55);
            dtNascimento.Name = "dtNascimento";
            dtNascimento.Size = new Size(200, 23);
            dtNascimento.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(244, 31);
            label7.Name = "label7";
            label7.Size = new Size(150, 21);
            label7.TabIndex = 36;
            label7.Text = "Data de Nascimento";
            // 
            // dtEntrada
            // 
            dtEntrada.Location = new Point(244, 155);
            dtEntrada.Name = "dtEntrada";
            dtEntrada.Size = new Size(200, 23);
            dtEntrada.TabIndex = 33;
            dtEntrada.Value = new DateTime(2023, 4, 20, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(244, 131);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 34;
            label6.Text = "Entrou em";
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.MediumSeaGreen;
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.ForeColor = Color.White;
            btnInserir.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnInserir.IconColor = Color.White;
            btnInserir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInserir.IconSize = 20;
            btnInserir.Location = new Point(238, 215);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 33);
            btnInserir.TabIndex = 39;
            btnInserir.Text = "Inserir";
            btnInserir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.MediumSeaGreen;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnAtualizar.IconColor = Color.White;
            btnAtualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAtualizar.IconSize = 20;
            btnAtualizar.Location = new Point(319, 215);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 33);
            btnAtualizar.TabIndex = 40;
            btnAtualizar.Text = "Update";
            btnAtualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.MediumSeaGreen;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 20;
            btnBuscar.Location = new Point(570, 215);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 33);
            btnBuscar.TabIndex = 41;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.MediumSeaGreen;
            btnDeletar.FlatAppearance.BorderSize = 0;
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.ForeColor = Color.White;
            btnDeletar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnDeletar.IconColor = Color.White;
            btnDeletar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeletar.IconSize = 20;
            btnDeletar.Location = new Point(400, 215);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 33);
            btnDeletar.TabIndex = 42;
            btnDeletar.Text = "Deletar";
            btnDeletar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // txtBuscarID
            // 
            txtBuscarID.Location = new Point(651, 221);
            txtBuscarID.Name = "txtBuscarID";
            txtBuscarID.PlaceholderText = "Digite o ID para buscar";
            txtBuscarID.Size = new Size(83, 23);
            txtBuscarID.TabIndex = 43;
            // 
            // btnAtt
            // 
            btnAtt.BackColor = Color.MediumSeaGreen;
            btnAtt.FlatAppearance.BorderSize = 0;
            btnAtt.FlatStyle = FlatStyle.Flat;
            btnAtt.ForeColor = Color.White;
            btnAtt.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnAtt.IconColor = Color.White;
            btnAtt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAtt.IconSize = 20;
            btnAtt.Location = new Point(481, 215);
            btnAtt.Name = "btnAtt";
            btnAtt.Size = new Size(83, 33);
            btnAtt.TabIndex = 44;
            btnAtt.Text = "Atualizar";
            btnAtt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtt.UseVisualStyleBackColor = false;
            btnAtt.Click += btnAtt_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(500, 88);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(53, 21);
            lblSenha.TabIndex = 48;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(500, 112);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite aqui";
            txtSenha.Size = new Size(176, 23);
            txtSenha.TabIndex = 47;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(500, 31);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(64, 21);
            lblUser.TabIndex = 46;
            lblUser.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(500, 55);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Digite aqui";
            txtUsuario.Size = new Size(176, 23);
            txtUsuario.TabIndex = 45;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblUser);
            Controls.Add(txtUsuario);
            Controls.Add(btnAtt);
            Controls.Add(txtBuscarID);
            Controls.Add(btnDeletar);
            Controls.Add(btnBuscar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Controls.Add(label7);
            Controls.Add(dtNascimento);
            Controls.Add(label6);
            Controls.Add(dtEntrada);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSalario);
            Controls.Add(label3);
            Controls.Add(txtCpf);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtEndereco);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(tabFuncionario);
            Name = "Usuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)tabFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabFuncionario;
        private TextBox txtNome;
        private Label lblNome;
        private Label label1;
        private TextBox txtEndereco;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtCpf;
        private Label label4;
        private TextBox txtSalario;
        private Label label5;
        private DateTimePicker dtNascimento;
        private Label label7;
        private DateTimePicker dtEntrada;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnInserir;
        private FontAwesome.Sharp.IconButton btnAtualizar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnDeletar;
        private TextBox txtBuscarID;
        private FontAwesome.Sharp.IconButton btnAtt;
        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblUser;
        private TextBox txtUsuario;
    }
}
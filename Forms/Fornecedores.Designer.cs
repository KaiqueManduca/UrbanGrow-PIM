namespace UrbanGrow.Forms {
    partial class Fornecedores {
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
            components = new System.ComponentModel.Container();
            npgsqlConnectionBindingSource = new BindingSource(components);
            btnDeletar = new FontAwesome.Sharp.IconButton();
            btnAtualizar = new FontAwesome.Sharp.IconButton();
            btnInserir = new FontAwesome.Sharp.IconButton();
            lblName = new Label();
            lblEndereco = new Label();
            lblEmail = new Label();
            lblCpnj = new Label();
            lblProduto = new Label();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            txtEmail = new TextBox();
            txtCnpj = new TextBox();
            txtProduto = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBuscarID = new TextBox();
            tabFornecedor = new DataGridView();
            btnAtt = new FontAwesome.Sharp.IconButton();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)npgsqlConnectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabFornecedor).BeginInit();
            SuspendLayout();
            // 
            // npgsqlConnectionBindingSource
            // 
            npgsqlConnectionBindingSource.DataSource = typeof(Npgsql.NpgsqlConnection);
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
            btnDeletar.Location = new Point(344, 166);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 33);
            btnDeletar.TabIndex = 1;
            btnDeletar.Text = "Deletar";
            btnDeletar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
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
            btnAtualizar.Location = new Point(263, 166);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 33);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "Update";
            btnAtualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
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
            btnInserir.Location = new Point(182, 166);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 33);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Inserir";
            btnInserir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(25, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 21);
            lblName.TabIndex = 4;
            lblName.Text = "Nome";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(4, 90);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(74, 21);
            lblEndereco.TabIndex = 5;
            lblEndereco.Text = "Endereço";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(30, 117);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblCpnj
            // 
            lblCpnj.AutoSize = true;
            lblCpnj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCpnj.Location = new Point(409, 61);
            lblCpnj.Name = "lblCpnj";
            lblCpnj.Size = new Size(46, 21);
            lblCpnj.TabIndex = 7;
            lblCpnj.Text = "CNPJ";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduto.Location = new Point(389, 90);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(66, 21);
            lblProduto.TabIndex = 8;
            lblProduto.Text = "Produto";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(84, 59);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite aqui";
            txtNome.Size = new Size(285, 23);
            txtNome.TabIndex = 9;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(84, 90);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Digite aqui";
            txtEndereco.Size = new Size(285, 23);
            txtEndereco.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(84, 119);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite aqui";
            txtEmail.Size = new Size(285, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(456, 59);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.PlaceholderText = "Digite aqui (formato: XX. XXX. XXX/0001-XX)";
            txtCnpj.Size = new Size(253, 23);
            txtCnpj.TabIndex = 12;
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(456, 92);
            txtProduto.Name = "txtProduto";
            txtProduto.PlaceholderText = "Digite aqui";
            txtProduto.Size = new Size(253, 23);
            txtProduto.TabIndex = 13;
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
            btnBuscar.Location = new Point(101, 166);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 33);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarID
            // 
            txtBuscarID.Location = new Point(101, 214);
            txtBuscarID.Name = "txtBuscarID";
            txtBuscarID.PlaceholderText = "Digite o ID para buscar";
            txtBuscarID.Size = new Size(139, 23);
            txtBuscarID.TabIndex = 16;
            // 
            // tabFornecedor
            // 
            tabFornecedor.Location = new Point(12, 243);
            tabFornecedor.Name = "tabFornecedor";
            tabFornecedor.Size = new Size(533, 178);
            tabFornecedor.TabIndex = 19;
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
            btnAtt.Location = new Point(551, 309);
            btnAtt.Name = "btnAtt";
            btnAtt.Size = new Size(83, 33);
            btnAtt.TabIndex = 18;
            btnAtt.Text = "Atualizar";
            btnAtt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtt.UseVisualStyleBackColor = false;
            btnAtt.Click += iconButton1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(30, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(158, 32);
            lblTitulo.TabIndex = 34;
            lblTitulo.Text = "Fornecedores";
            // 
            // Fornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(btnAtt);
            Controls.Add(tabFornecedor);
            Controls.Add(txtBuscarID);
            Controls.Add(btnBuscar);
            Controls.Add(txtProduto);
            Controls.Add(txtCnpj);
            Controls.Add(txtEmail);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(lblProduto);
            Controls.Add(lblCpnj);
            Controls.Add(lblEmail);
            Controls.Add(lblEndereco);
            Controls.Add(lblName);
            Controls.Add(btnInserir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnDeletar);
            Name = "Fornecedores";
            Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)npgsqlConnectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource npgsqlConnectionBindingSource;
        private FontAwesome.Sharp.IconButton btnDeletar;
        private FontAwesome.Sharp.IconButton btnAtualizar;
        private FontAwesome.Sharp.IconButton btnInserir;
        private Label lblName;
        private Label lblEndereco;
        private Label lblEmail;
        private Label lblCpnj;
        private Label lblProduto;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private TextBox txtEmail;
        private TextBox txtCnpj;
        private TextBox txtProduto;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBuscarID;
        private DataGridView tabFornecedor;
        private FontAwesome.Sharp.IconButton btnAtt;
        private Label lblTitulo;
    }
}
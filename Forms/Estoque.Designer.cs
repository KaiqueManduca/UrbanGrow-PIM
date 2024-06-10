namespace UrbanGrow.Forms {
    partial class Estoque {
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
            tabEstoque = new DataGridView();
            btnAtt = new FontAwesome.Sharp.IconButton();
            btnInserir = new FontAwesome.Sharp.IconButton();
            btnAtualizar = new FontAwesome.Sharp.IconButton();
            txtBuscarID = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnDeletar = new FontAwesome.Sharp.IconButton();
            lblTitulo = new Label();
            lblEstoque = new Label();
            txtEstoque = new TextBox();
            lblValor = new Label();
            txtValor = new TextBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tabEstoque).BeginInit();
            SuspendLayout();
            // 
            // tabEstoque
            // 
            tabEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabEstoque.Location = new Point(21, 82);
            tabEstoque.Name = "tabEstoque";
            tabEstoque.Size = new Size(544, 241);
            tabEstoque.TabIndex = 0;
            tabEstoque.CellContentClick += tabEstoque_CellContentClick;
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
            btnAtt.Location = new Point(21, 344);
            btnAtt.Name = "btnAtt";
            btnAtt.Size = new Size(83, 33);
            btnAtt.TabIndex = 19;
            btnAtt.Text = "Atualizar";
            btnAtt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtt.UseVisualStyleBackColor = false;
            btnAtt.Click += btnAtt_Click;
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
            btnInserir.Location = new Point(110, 344);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 33);
            btnInserir.TabIndex = 28;
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
            btnAtualizar.Location = new Point(191, 344);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 33);
            btnAtualizar.TabIndex = 29;
            btnAtualizar.Text = "Update";
            btnAtualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtBuscarID
            // 
            txtBuscarID.Location = new Point(360, 350);
            txtBuscarID.Name = "txtBuscarID";
            txtBuscarID.PlaceholderText = "Digite o ID para buscar";
            txtBuscarID.Size = new Size(139, 23);
            txtBuscarID.TabIndex = 30;
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
            btnBuscar.Location = new Point(505, 344);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 33);
            btnBuscar.TabIndex = 31;
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
            btnDeletar.Location = new Point(272, 344);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 33);
            btnDeletar.TabIndex = 32;
            btnDeletar.Text = "Deletar";
            btnDeletar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(21, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(215, 32);
            lblTitulo.TabIndex = 33;
            lblTitulo.Text = "Estoque disponível";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstoque.Location = new Point(581, 249);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(65, 21);
            lblEstoque.TabIndex = 27;
            lblEstoque.Text = "Estoque";
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(581, 273);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.PlaceholderText = "Digite aqui";
            txtEstoque.Size = new Size(141, 23);
            txtEstoque.TabIndex = 26;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(581, 199);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(46, 21);
            lblValor.TabIndex = 25;
            lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(581, 223);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Digite aqui";
            txtValor.Size = new Size(141, 23);
            txtValor.TabIndex = 24;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(581, 149);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(77, 21);
            lblDescricao.TabIndex = 23;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(581, 173);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Digite aqui";
            txtDescricao.Size = new Size(141, 23);
            txtDescricao.TabIndex = 22;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(581, 99);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 21);
            lblNome.TabIndex = 21;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(581, 123);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite aqui";
            txtNome.Size = new Size(141, 23);
            txtNome.TabIndex = 20;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtDescricao);
            Controls.Add(lblTitulo);
            Controls.Add(lblDescricao);
            Controls.Add(btnDeletar);
            Controls.Add(txtValor);
            Controls.Add(btnBuscar);
            Controls.Add(lblValor);
            Controls.Add(txtBuscarID);
            Controls.Add(txtEstoque);
            Controls.Add(btnAtualizar);
            Controls.Add(lblEstoque);
            Controls.Add(btnInserir);
            Controls.Add(btnAtt);
            Controls.Add(tabEstoque);
            Name = "Estoque";
            Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)tabEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabEstoque;
        private FontAwesome.Sharp.IconButton btnAtt;
        private FontAwesome.Sharp.IconButton btnInserir;
        private FontAwesome.Sharp.IconButton btnAtualizar;
        private TextBox txtBuscarID;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnDeletar;
        private Label lblTitulo;
        private Label lblEstoque;
        private TextBox txtEstoque;
        private Label lblValor;
        private TextBox txtValor;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Label lblNome;
        private TextBox txtNome;
    }
}
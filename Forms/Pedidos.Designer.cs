namespace UrbanGrow.Forms {
    partial class Pedidos {
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
            tabProdutos = new DataGridView();
            lblTitulo = new Label();
            txtId = new TextBox();
            txtQnt = new TextBox();
            lblID = new Label();
            label1 = new Label();
            btnComprar = new FontAwesome.Sharp.IconButton();
            btnAtt = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)tabProdutos).BeginInit();
            SuspendLayout();
            // 
            // tabProdutos
            // 
            tabProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabProdutos.Location = new Point(33, 189);
            tabProdutos.Name = "tabProdutos";
            tabProdutos.Size = new Size(579, 216);
            tabProdutos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(34, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(96, 30);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Produtos";
            // 
            // txtId
            // 
            txtId.Location = new Point(32, 160);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Digite o ID";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            // 
            // txtQnt
            // 
            txtQnt.Location = new Point(147, 160);
            txtQnt.Name = "txtQnt";
            txtQnt.PlaceholderText = "Digite aqui";
            txtQnt.Size = new Size(100, 23);
            txtQnt.TabIndex = 4;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(32, 136);
            lblID.Name = "lblID";
            lblID.Size = new Size(25, 21);
            lblID.TabIndex = 5;
            lblID.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 136);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 6;
            label1.Text = "Quantidade";
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.MediumSeaGreen;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.ForeColor = Color.White;
            btnComprar.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnComprar.IconColor = Color.White;
            btnComprar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnComprar.IconSize = 20;
            btnComprar.Location = new Point(516, 150);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(96, 33);
            btnComprar.TabIndex = 32;
            btnComprar.Text = "Comprar";
            btnComprar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
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
            btnAtt.Location = new Point(414, 150);
            btnAtt.Name = "btnAtt";
            btnAtt.Size = new Size(96, 33);
            btnAtt.TabIndex = 33;
            btnAtt.Text = "Atualizar";
            btnAtt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtt.UseVisualStyleBackColor = false;
            btnAtt.Click += btnAtt_Click;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtt);
            Controls.Add(btnComprar);
            Controls.Add(label1);
            Controls.Add(lblID);
            Controls.Add(txtQnt);
            Controls.Add(txtId);
            Controls.Add(lblTitulo);
            Controls.Add(tabProdutos);
            Name = "Pedidos";
            Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)tabProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabProdutos;
        private Label lblTitulo;
        private TextBox txtId;
        private TextBox txtQnt;
        private Label lblID;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnComprar;
        private FontAwesome.Sharp.IconButton btnAtt;
    }
}
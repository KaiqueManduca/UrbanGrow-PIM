namespace UrbanGrow.Forms {
    partial class Relatorios {
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
            tabAudFuncionarios = new DataGridView();
            tabVendas = new DataGridView();
            lblAuditoriaFuncionario = new Label();
            lblItensVenda = new Label();
            tabAudFornecedor = new DataGridView();
            lblAuditoriaFornecedor = new Label();
            btnAtt = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)tabAudFuncionarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabAudFornecedor).BeginInit();
            SuspendLayout();
            // 
            // tabAudFuncionarios
            // 
            tabAudFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabAudFuncionarios.Location = new Point(37, 68);
            tabAudFuncionarios.Name = "tabAudFuncionarios";
            tabAudFuncionarios.Size = new Size(265, 150);
            tabAudFuncionarios.TabIndex = 0;
            // 
            // tabVendas
            // 
            tabVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabVendas.Location = new Point(37, 275);
            tabVendas.Name = "tabVendas";
            tabVendas.Size = new Size(265, 150);
            tabVendas.TabIndex = 1;
            // 
            // lblAuditoriaFuncionario
            // 
            lblAuditoriaFuncionario.AutoSize = true;
            lblAuditoriaFuncionario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuditoriaFuncionario.Location = new Point(37, 30);
            lblAuditoriaFuncionario.Name = "lblAuditoriaFuncionario";
            lblAuditoriaFuncionario.Size = new Size(203, 25);
            lblAuditoriaFuncionario.TabIndex = 2;
            lblAuditoriaFuncionario.Text = "Auditoria Funcionários";
            // 
            // lblItensVenda
            // 
            lblItensVenda.AutoSize = true;
            lblItensVenda.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItensVenda.Location = new Point(37, 238);
            lblItensVenda.Name = "lblItensVenda";
            lblItensVenda.Size = new Size(73, 25);
            lblItensVenda.TabIndex = 3;
            lblItensVenda.Text = "Vendas";
            // 
            // tabAudFornecedor
            // 
            tabAudFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabAudFornecedor.Location = new Point(377, 68);
            tabAudFornecedor.Name = "tabAudFornecedor";
            tabAudFornecedor.Size = new Size(265, 150);
            tabAudFornecedor.TabIndex = 4;
            // 
            // lblAuditoriaFornecedor
            // 
            lblAuditoriaFornecedor.AutoSize = true;
            lblAuditoriaFornecedor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuditoriaFornecedor.Location = new Point(377, 30);
            lblAuditoriaFornecedor.Name = "lblAuditoriaFornecedor";
            lblAuditoriaFornecedor.Size = new Size(209, 25);
            lblAuditoriaFornecedor.TabIndex = 5;
            lblAuditoriaFornecedor.Text = "Auditoria Fornecedores";
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
            btnAtt.Location = new Point(377, 247);
            btnAtt.Name = "btnAtt";
            btnAtt.Size = new Size(83, 33);
            btnAtt.TabIndex = 19;
            btnAtt.Text = "Atualizar";
            btnAtt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtt.UseVisualStyleBackColor = false;
            btnAtt.Click += btnAtt_Click;
            // 
            // Relatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtt);
            Controls.Add(lblAuditoriaFornecedor);
            Controls.Add(tabAudFornecedor);
            Controls.Add(lblItensVenda);
            Controls.Add(lblAuditoriaFuncionario);
            Controls.Add(tabVendas);
            Controls.Add(tabAudFuncionarios);
            Name = "Relatorios";
            Text = "Relatorios";
            ((System.ComponentModel.ISupportInitialize)tabAudFuncionarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabAudFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabAudFuncionarios;
        private DataGridView tabVendas;
        private Label lblAuditoriaFuncionario;
        private Label lblItensVenda;
        private DataGridView tabAudFornecedor;
        private Label lblAuditoriaFornecedor;
        private FontAwesome.Sharp.IconButton btnAtt;
    }
}
namespace UrbanGrow {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnPedidos = new FontAwesome.Sharp.IconButton();
            btnRelatorios = new FontAwesome.Sharp.IconButton();
            btnEstoque = new FontAwesome.Sharp.IconButton();
            btnFornecedores = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            btnFechar = new FontAwesome.Sharp.IconButton();
            btnMaximizar = new FontAwesome.Sharp.IconButton();
            btnMinimizar = new FontAwesome.Sharp.IconButton();
            lblTitleChildForm = new Label();
            IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.SeaGreen;
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnSair);
            panelMenu.Controls.Add(btnPedidos);
            panelMenu.Controls.Add(btnRelatorios);
            panelMenu.Controls.Add(btnEstoque);
            panelMenu.Controls.Add(btnFornecedores);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 531);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.ForeColor = Color.Gainsboro;
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            btnUsuarios.IconColor = Color.Gainsboro;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 32;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 380);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(10, 0, 20, 0);
            btnUsuarios.Size = new Size(220, 60);
            btnUsuarios.TabIndex = 6;
            btnUsuarios.Text = "Funcionários";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Bottom;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.ForeColor = Color.Gainsboro;
            btnSair.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            btnSair.IconColor = Color.Gainsboro;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.IconSize = 32;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(0, 471);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(10, 0, 20, 0);
            btnSair.Size = new Size(220, 60);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.MiddleLeft;
            btnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Dock = DockStyle.Top;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.ForeColor = Color.Gainsboro;
            btnPedidos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnPedidos.IconColor = Color.Gainsboro;
            btnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPedidos.IconSize = 32;
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(0, 320);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Padding = new Padding(10, 0, 20, 0);
            btnPedidos.Size = new Size(220, 60);
            btnPedidos.TabIndex = 4;
            btnPedidos.Text = "Produtos";
            btnPedidos.TextAlign = ContentAlignment.MiddleLeft;
            btnPedidos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.Dock = DockStyle.Top;
            btnRelatorios.FlatAppearance.BorderSize = 0;
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.ForeColor = Color.Gainsboro;
            btnRelatorios.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            btnRelatorios.IconColor = Color.Gainsboro;
            btnRelatorios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRelatorios.IconSize = 32;
            btnRelatorios.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorios.Location = new Point(0, 260);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Padding = new Padding(10, 0, 20, 0);
            btnRelatorios.Size = new Size(220, 60);
            btnRelatorios.TabIndex = 3;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.TextAlign = ContentAlignment.MiddleLeft;
            btnRelatorios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRelatorios.UseVisualStyleBackColor = true;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.Dock = DockStyle.Top;
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.ForeColor = Color.Gainsboro;
            btnEstoque.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            btnEstoque.IconColor = Color.Gainsboro;
            btnEstoque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEstoque.IconSize = 32;
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.Location = new Point(0, 200);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Padding = new Padding(10, 0, 20, 0);
            btnEstoque.Size = new Size(220, 60);
            btnEstoque.TabIndex = 2;
            btnEstoque.Text = "Estoque";
            btnEstoque.TextAlign = ContentAlignment.MiddleLeft;
            btnEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // btnFornecedores
            // 
            btnFornecedores.Dock = DockStyle.Top;
            btnFornecedores.FlatAppearance.BorderSize = 0;
            btnFornecedores.FlatStyle = FlatStyle.Flat;
            btnFornecedores.ForeColor = Color.Gainsboro;
            btnFornecedores.IconChar = FontAwesome.Sharp.IconChar.TruckField;
            btnFornecedores.IconColor = Color.Gainsboro;
            btnFornecedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFornecedores.IconSize = 32;
            btnFornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnFornecedores.Location = new Point(0, 140);
            btnFornecedores.Name = "btnFornecedores";
            btnFornecedores.Padding = new Padding(10, 0, 20, 0);
            btnFornecedores.Size = new Size(220, 60);
            btnFornecedores.TabIndex = 1;
            btnFornecedores.Text = "Fornecedores";
            btnFornecedores.TextAlign = ContentAlignment.MiddleLeft;
            btnFornecedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFornecedores.UseVisualStyleBackColor = true;
            btnFornecedores.Click += iconButton1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(220, 137);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.MediumSeaGreen;
            panelTitleBar.Controls.Add(btnFechar);
            panelTitleBar.Controls.Add(btnMaximizar);
            panelTitleBar.Controls.Add(btnMinimizar);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(IconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(732, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.Gainsboro;
            btnFechar.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            btnFechar.IconColor = Color.White;
            btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFechar.IconSize = 25;
            btnFechar.Location = new Point(696, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(24, 23);
            btnFechar.TabIndex = 4;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.ForeColor = Color.Gainsboro;
            btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.ExpandArrowsAlt;
            btnMaximizar.IconColor = Color.White;
            btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizar.IconSize = 20;
            btnMaximizar.Location = new Point(665, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 23);
            btnMaximizar.TabIndex = 3;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += iconButton2_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.ForeColor = Color.Gainsboro;
            btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnMinimizar.IconColor = Color.White;
            btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizar.IconSize = 25;
            btnMinimizar.Location = new Point(634, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 23);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleChildForm.ForeColor = Color.Gainsboro;
            lblTitleChildForm.Location = new Point(63, 21);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(83, 32);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // IconCurrentChildForm
            // 
            IconCurrentChildForm.BackColor = Color.MediumSeaGreen;
            IconCurrentChildForm.ForeColor = Color.Gainsboro;
            IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            IconCurrentChildForm.IconColor = Color.Gainsboro;
            IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconCurrentChildForm.IconSize = 51;
            IconCurrentChildForm.Location = new Point(6, 11);
            IconCurrentChildForm.Name = "IconCurrentChildForm";
            IconCurrentChildForm.Size = new Size(51, 52);
            IconCurrentChildForm.TabIndex = 0;
            IconCurrentChildForm.TabStop = false;
            IconCurrentChildForm.Click += IconCurrentChildForm_Click;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.DarkSeaGreen;
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(220, 75);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(732, 10);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.White;
            panelDesktop.Controls.Add(label2);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Location = new Point(220, 85);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(732, 446);
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(185, 245);
            label2.Name = "label2";
            label2.Size = new Size(0, 50);
            label2.TabIndex = 4;
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(159, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(417, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 531);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnFornecedores;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnPedidos;
        private FontAwesome.Sharp.IconButton btnRelatorios;
        private FontAwesome.Sharp.IconButton btnEstoque;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnFechar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

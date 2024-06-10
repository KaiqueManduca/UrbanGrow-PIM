namespace UrbanGrow.Forms {
    partial class Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panelLoginBar = new Panel();
            btnHome = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            btnRegistrar = new Button();
            panel2 = new Panel();
            btnLogin = new Button();
            labelLoginText = new Label();
            labelPassword = new Label();
            labelUser = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            panelLoginBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelLoginBar
            // 
            panelLoginBar.BackColor = Color.MediumSeaGreen;
            panelLoginBar.Controls.Add(btnHome);
            panelLoginBar.Dock = DockStyle.Top;
            panelLoginBar.Location = new Point(0, 0);
            panelLoginBar.Name = "panelLoginBar";
            panelLoginBar.Size = new Size(414, 100);
            panelLoginBar.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(-1, -65);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(416, 230);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 1;
            btnHome.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(labelLoginText);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelUser);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtUsuario);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 258);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 202);
            label1.Name = "label1";
            label1.Size = new Size(260, 17);
            label1.TabIndex = 7;
            label1.Text = "Novo por aqui? Registre-se agora mesmo!";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.MediumSeaGreen;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(94, 167);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(104, 32);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 230);
            panel2.MaximumSize = new Size(414, 28);
            panel2.MinimumSize = new Size(414, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 28);
            panel2.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(204, 167);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelLoginText
            // 
            labelLoginText.AutoSize = true;
            labelLoginText.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLoginText.Location = new Point(163, 20);
            labelLoginText.Name = "labelLoginText";
            labelLoginText.Size = new Size(104, 45);
            labelLoginText.TabIndex = 4;
            labelLoginText.Text = "Login";
            labelLoginText.Click += labelLoginText_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(84, 123);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(53, 21);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Senha";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUser.Location = new Point(73, 81);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(64, 21);
            labelUser.TabIndex = 2;
            labelUser.Text = "Usuário";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(136, 121);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Digite aqui";
            txtSenha.Size = new Size(172, 23);
            txtSenha.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(136, 83);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Digite aqui";
            txtUsuario.Size = new Size(172, 23);
            txtUsuario.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 358);
            Controls.Add(panel1);
            Controls.Add(panelLoginBar);
            MaximumSize = new Size(430, 397);
            MinimumSize = new Size(430, 397);
            Name = "Login";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Login";
            panelLoginBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLoginBar;
        private Panel panel1;
        private Label labelPassword;
        private Label labelUser;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private PictureBox btnHome;
        private Label labelLoginText;
        private Button btnLogin;
        private Panel panel2;
        private Button btnRegistrar;
        private Label label1;
    }
}
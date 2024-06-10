using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using UrbanGrow.Forms;

namespace UrbanGrow {
    public partial class Form1 : Form {

        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Variable
        

        //Constructor
        public Form1() {
            InitializeComponent();
            if (Globals.EhFuncionario == false) {
                btnEstoque.Visible = false;
                btnFornecedores.Visible = false;
                btnRelatorios.Visible = false;
                btnUsuarios.Visible = false;

            }
            else {
               
                btnPedidos.Visible = false;
                btnRelatorios.Visible=false;
                btnUsuarios.Visible = false;
            }
            if(Globals.EhSupervisor == true) {
                btnPedidos.Visible = true;
                btnRelatorios.Visible = true;
                btnUsuarios.Visible = true;
                btnEstoque.Visible = true;
                btnFornecedores.Visible = true;
            }
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs
        private struct RGBColors {

            public static Color color1 = Color.FromArgb(46, 204, 113);
            public static Color color2 = Color.FromArgb(106, 176, 76);
            public static Color color3 = Color.FromArgb(85, 107, 47);
            public static Color color4 = Color.FromArgb(205, 220, 57);
            public static Color color5 = Color.FromArgb(0, 188, 212);
            public static Color color6 = Color.FromArgb(76, 175, 80);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color) {
            if (senderBtn != null) {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(8, 51, 2);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                IconCurrentChildForm.IconChar = currentBtn.IconChar;
                IconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton() {
            if (currentBtn != null) {
                currentBtn.BackColor = Color.FromArgb(46, 139, 87);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm) {
            if (currentChildForm != null) {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void iconButton1_Click(object sender, EventArgs e) {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Fornecedores());


        }

        private void btnEstoque_Click(object sender, EventArgs e) {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Estoque());
        }

        private void btnRelatorios_Click(object sender, EventArgs e) {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Relatorios());
        }

        private void btnPedidos_Click(object sender, EventArgs e) {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Pedidos());
        }

        private void btnSair_Click(object sender, EventArgs e) {
            ActivateButton(sender, RGBColors.color5);
            if (MessageBox.Show("Deseja realmente desconectar?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) {
                
            }
            else {
                MessageBox.Show("Desconectado(a)");
                Login form = new Login();
                this.Hide();
                form.Show();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e) {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Usuarios());

        }

        private void btnHome_Click(object sender, EventArgs e) {
            if (currentChildForm != null)
                currentChildForm.Close();
            Reset();

        }

        private void Reset() {
            DisableButton();
            leftBorderBtn.Visible = false;
            IconCurrentChildForm.IconChar = IconChar.Home;
            IconCurrentChildForm.IconColor = Color.DarkGreen;
            lblTitleChildForm.Text = "Home";
        }

        private void IconCurrentChildForm_Click(object sender, EventArgs e) {

        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void iconButton2_Click(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;

            else
                WindowState = FormWindowState.Normal;
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            Application.Exit();

        }

        private void btnMinimizar_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e) {

        }

        DateTime time;
        private void label2_Click(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            time = DateTime.Now;
            label2.Text = time.ToLocalTime().ToString();
        }

        private void btnProdutos_Click(object sender, EventArgs e) {
            ActivateButton(sender, RGBColors.color1);
        }
    }
}

namespace SistemaDeLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (nomeUsuario == "admin" && senha == "6969")
            {
                this.Hide();
                string nome = txtNome.Text;
                new menuPrincipal(nome).ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show($"O usuário ou a senha estão incorretos", "Erro ao fazer login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}

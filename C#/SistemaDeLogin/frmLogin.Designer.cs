namespace SistemaDeLogin
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtSenha = new TextBox();
            btnEnviar = new Button();
            txtNome = new TextBox();
            label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 45);
            label1.TabIndex = 0;
            label1.Text = "Usuário\r\n";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 57);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 103);
            label2.Name = "label2";
            label2.Size = new Size(106, 45);
            label2.TabIndex = 2;
            label2.Text = "Senha\r\n";
            label2.Click += label2_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 151);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(150, 31);
            txtSenha.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(12, 216);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(112, 54);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Entrar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(195, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(311, 31);
            txtNome.TabIndex = 5;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(195, 0);
            label.Name = "label";
            label.Size = new Size(324, 45);
            label.TabIndex = 6;
            label.Text = "Nome a ser chamado";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label);
            Controls.Add(txtNome);
            Controls.Add(btnEnviar);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtSenha;
        private Button btnEnviar;
        private TextBox txtNome;
        private Label label;
    }
}

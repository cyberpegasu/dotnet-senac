using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeLogin
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal(string nomeUsuario)
        {
            InitializeComponent();

            lblNomeUsuario.Text = $"Bem vindo {nomeUsuario}";
        }
    }
}

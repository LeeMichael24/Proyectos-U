using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CortoPractico3
{
    public partial class frmPrincipal : Form
    {
        private double precio = 5.99;
        private double total = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(155, 51, 153);
        }

        private void nudSubtotal_ValueChanged(object sender, EventArgs e)
        {
            total = precio * Convert.ToInt32(nudTotal.Value);
            lblTotalLabel.Text = "$" + Math.Round(total, 2);
        }


        private void btmComprarPaquete_Click(object sender, EventArgs e)
        {
            lblMostrarTodo.Text = "Hola!" + txtNombre.Text + "!";
            MessageBox.Show(text: "Felicidades! acabas de comprar un paquete de sporify sin limites",
                caption: "Compra Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
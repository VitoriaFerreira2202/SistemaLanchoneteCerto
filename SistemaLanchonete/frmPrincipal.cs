using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLanchonete
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public decimal somaLanche,totalPedi,troco,valorpedido,valorrecebido;

        private void totalLanche()
        {
            decimal hamburguer = decimal.Parse(txtTotalHamburger.Text);
            decimal ovo = decimal.Parse(txtTotalOvo.Text);
            decimal presunto = decimal.Parse(txtTotalPresunto.Text);
            decimal mussarela = decimal.Parse(txtTotalMussarela.Text);
            decimal bacon = decimal.Parse(txtTotalBacon.Text);
            decimal frango = decimal.Parse(txtTotalFrango.Text);
            decimal alface = decimal.Parse(txtTotalAlface.Text);
            decimal tomate = decimal.Parse(txtTotalTomate.Text);
            decimal milhoverde = decimal.Parse(txtTotalMilhoVerde.Text);
            decimal ervilha = decimal.Parse(txtTotalErvilha.Text);

            somaLanche = hamburguer + ovo + presunto + presunto + mussarela + bacon + frango + alface + tomate + milhoverde + ervilha;
            txtTotalLanche.Text = somaLanche.ToString();

        }
        private void Desabilitar()
        {
            numHamburger.Enabled = false;
            numOvo.Enabled = false;
            numPresunto.Enabled = false;
            numMussarela.Enabled = false;
            numBacon.Enabled = false;
            numFrango.Enabled = false;
            numAlface.Enabled = false;
            numTomate.Enabled = false;
            numMilhoVerde.Enabled = false;
            numErvilha.Enabled = false;

        }

        private void cbBacon_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBacon.Checked)
            {
                numBacon.Enabled = true;
            }
            else
            {
                Desabilitar();
            }
        }

        private void cbFrango_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFrango.Checked)
            {
                numFrango.Enabled = true;
            }
            else
            {
                Desabilitar();
            }
        }

        private void cbAlface_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlface.Checked)
            {
                numAlface.Enabled = true;
            }
            else
            {
                Desabilitar();
            }
        }

        private void cbTomate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTomate.Checked)
            {
                numTomate.Enabled = true;
            }
            else
            {
                Desabilitar();
            }
        }

        private void cbMilhoVerde_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMilhoVerde.Checked)
            {
                numMilhoVerde.Enabled = true;
            }
            else
            {
                Desabilitar();
            }
        }

        private void cbErvilha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbErvilha.Checked)
            {
                numErvilha.Enabled = true;
            }
            else
            {
                Desabilitar();
            }
        }
   
        private void numHamburger_ValueChanged(object sender, EventArgs e)
        {
            txtTotalHamburger.Text = ((int)numHamburger.Value * decimal.Parse(txtValorUniHamburger.Text)).ToString();
            totalLanche();
        }

        private void numOvo_ValueChanged(object sender, EventArgs e)
        {
            txtTotalOvo.Text = ((int)numOvo.Value * decimal.Parse(txtValorUniOvo.Text)).ToString();
            totalLanche();
        }

        private void numPresunto_ValueChanged(object sender, EventArgs e)
        {
            txtTotalPresunto.Text = ((int)numPresunto.Value * decimal.Parse(txtValorUniPresunto.Text)).ToString();
            totalLanche();
        }

        private void numMussarela_ValueChanged(object sender, EventArgs e)
        {
           // txtTotalMussarela.Text = ((int)numOvo.Value * decimal.Parse(txtValorUniOvo.Text)).ToString();
            totalLanche();
        }

        private void numBacon_ValueChanged(object sender, EventArgs e)
        {
          //  txtTotalOvo.Text = ((int)numOvo.Value * decimal.Parse(txtValorUniOvo.Text)).ToString();
            totalLanche();
        }

        private void numFrango_ValueChanged(object sender, EventArgs e)
        {
            //txtTotalOvo.Text = ((int)numOvo.Value * decimal.Parse(txtValorUniOvo.Text)).ToString();
            totalLanche();
        }

        private void numAlface_ValueChanged(object sender, EventArgs e)
        {
          //  txtTotalOvo.Text = ((int)numOvo.Value * decimal.Parse(txtValorUniOvo.Text)).ToString();
            totalLanche();
        }

        private void numTomate_ValueChanged(object sender, EventArgs e)
        {
           // txtTotalOvo.Text = ((int)numOvo.Value * decimal.Parse(txtValorUniOvo.Text)).ToString();
            totalLanche();
        }

        private void numMilhoVerde_ValueChanged(object sender, EventArgs e)
        {
           // txtTotalOvo.Text = ((int)numOvo.Value * decimal.Parse(txtValorUniOvo.Text)).ToString();
            totalLanche();
        }

        private void numErvilha_ValueChanged(object sender, EventArgs e)
        {
           // txtTotalOvo.Text = ((int)numOvo.Value * decimal.Parse(txtValorUniOvo.Text)).ToString();
            totalLanche();
        }

        private void cbMussarela_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMussarela.Checked)
            {
                numMussarela.Enabled = true;
            }
            else
            {
                Desabilitar();
            }
        }

        private void cbPresunto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPresunto.Checked)
            {
                numPresunto.Enabled = true;
            }
            else
            {
                Desabilitar();
            }
        }

        private void cbOvo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOvo.Checked)
            {
                numOvo.Enabled = true;
            }
            else
            {
                Desabilitar();
            }
        }
                         
        private void cbHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHamburger.Checked)
            {
                numHamburger.Enabled = true;
            }
            else { 
               Desabilitar();
            }
        }
        
    }

}

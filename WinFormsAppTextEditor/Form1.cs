using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsAppTextEditor
{
    public partial class txtWinForm : System.Windows.Forms.Form
    {
        public txtWinForm()
        {
            InitializeComponent();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContainer.Clear();
        }

        private void txtContainer_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = txtContainer.Text.Length.ToString() + " Letras           ";
        }

        private void nuevaVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtWinForm nuevo = new txtWinForm();
            nuevo.StartPosition = FormStartPosition.WindowsDefaultLocation;
            nuevo.Visible = true;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtContainer.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtContainer.Text);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtContainer.Text);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContainer.Undo();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContainer.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContainer.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContainer.Paste();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContainer.Text = "";
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtContainer.Font = fontDialog1.Font;
            }
        }

       
        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContainer.SelectAll();
        }
        
        private void fechaYHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContainer.AppendText(DateTime.Now.ToString());
        }

        private void colorDeTextoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtContainer.ForeColor = colorDialog1.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtContainer.BackColor = colorDialog1.Color;
            }
        }

        private void barraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barraDeEstadoToolStripMenuItem.Checked = true;
            ajusteDeLíneaToolStripMenuItem.Checked = false;
        }

        private void ajusteDeLíneaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barraDeEstadoToolStripMenuItem.Checked = false;
            ajusteDeLíneaToolStripMenuItem.Checked = true;
        }

        private void acercarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContainer.ZoomFactor = txtContainer.ZoomFactor + (float)0.5;
        }

        private void alejarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContainer.ZoomFactor = txtContainer.ZoomFactor - (float)0.5;
        }

        private void reestaurarZoomPreterminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContainer.ZoomFactor = default;
        }

    }
}

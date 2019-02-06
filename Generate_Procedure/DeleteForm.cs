using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generate_Procedure
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        String GetSentence(String nombreTabla)
        {
            return "CREATE PROCEDURE usp_eliminar_nombreTabla\n @Id INT\n AS\n BEGIN SET NOCOUNT ON;\n DELETE FROM " + nombreTabla+" WHERE Id = @Id = Id; END";
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombreTabla.Text.Trim()))
            {
                MessageBox.Show("Debe especificar el nombre de una tabla...", "Error");
                return;
            }
            String sentencia = textBoxNombreTabla.Text;
            String s = GetSentence(sentencia);
            textBoxResult.Text = s;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombreTabla.Clear();
            textBoxResult.Clear();
        }
    }
}

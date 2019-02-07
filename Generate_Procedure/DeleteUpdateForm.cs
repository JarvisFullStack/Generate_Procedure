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
    public partial class DeleteUpdateForm : Form
    {
        public DeleteUpdateForm()
        {
            InitializeComponent();
        }

        public String GetProcedure(String tableName, String clavePrimaria)
        {
            if(tableName == null)
            {
                tableName = "nombreTabla";
            }
            if(clavePrimaria == null)
            {
                clavePrimaria = "clavePrimaria";
            }
            String procedure = string.Empty;
            procedure = "CREATE PROCEDURE usp_delete_update_" + tableName + " \n @"+clavePrimaria+" INT\n" +
                "AS \n BEGIN \n UPDATE "+tableName+" \n" +
                "SET Status = 2 \n" +
                "WHERE "+clavePrimaria + " = @"+clavePrimaria+";\n END";
            return procedure;
        }
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            String tableName = textBoxNombreTabla.Text;
            String clavePrimaria = textBoxClavePrimaria.Text;
            String result = GetProcedure(tableName, clavePrimaria);
            textBoxResult.Text = result;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombreTabla.Clear();
            textBoxClavePrimaria.Clear();
            textBoxResult.Clear();
        }
    }
}

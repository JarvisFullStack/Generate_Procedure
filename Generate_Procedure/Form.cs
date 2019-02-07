using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Generate_Procedure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        public class Nodo
        {
            public String Clave { get; set; }
            public String Valor { get; set; }
            public Nodo(String Clave, String Valor)
            {
                this.Clave = Clave;
                this.Valor = Valor;
            }

            public Nodo() { }
        }

        List<Nodo> GetAllId(List<Nodo> campos)
        {
            List<Nodo> listaAllId = new List<Nodo>();
            foreach(Nodo nodo in campos)
            {
                if (nodo.Clave.Contains("Id_"))
                {
                    listaAllId.Add(nodo);
                }
            }
            return listaAllId;
        }

       
        List<Nodo> ProcessString(String sql)
        {
            List<Nodo> lista = new List<Nodo>();
            sql = sql.Trim();

            bool isValue = false;
           
            Nodo nodo = new Nodo();
            int i= 0;
            for(; i < sql.Length; i++)
            {
                bool isProcessed = false;

                i = sql.IndexOf('[');
                if (sql[i] == '[' && !isValue)
                {
                    isProcessed = true;
                    string clave = string.Empty;
                    isValue = true;
                    int j = i + 1;
                    for(; sql[j] != ']'; j++)
                    {
                        clave += sql[j];
                    }
                    sql = sql.Substring(j+1);
                    i = 0;
                    nodo.Clave = clave;

                }
                i = sql.IndexOf('[');
                if (sql[i] == '[' && isValue)
                {
                    string valor = string.Empty;
                    isValue = false;
                    int j = i + 1;
                    for (; sql[j] != ']'; j++)
                    {
                        valor += sql[j];
                    }
                    sql = sql.Substring(j+1);
                    i = 0;
                    nodo.Valor = valor;

                }

                if (isProcessed)
                {
                    lista.Add(nodo);
                    nodo = new Nodo();
                    if (sql.IndexOf('[') < 0)
                        break;
                }


            }
            
             

            return lista;
        }

        String generateMergeInsertUpdate(List<Nodo> campos)
        {
            String procedure = string.Empty;
            if (string.IsNullOrEmpty(textBoxNombreTabla.Text.Trim()))
            {
               procedure = "CREATE PROCEDURE usp_insertar_nombreTabla\n ";
            }
            else
            {
                String nombreTabla = textBoxNombreTabla.Text;
                procedure = "CREATE PROCEDURE usp_insertar_"+nombreTabla.ToLower()+"\n ";
            }
            foreach(Nodo nodo in campos)
            {
                procedure += "@" + nodo.Clave + " " + nodo.Valor + ", ";
            }
             procedure = procedure.Remove(procedure.Length-2);
           
            if (string.IsNullOrEmpty(textBoxNombreTabla.Text.Trim()))
            {
                procedure += " \n\nAS MERGE NombreTabla AS TARGET USING(SELECT ";
            }
            else
            {
                String nombreTabla = textBoxNombreTabla.Text;
                procedure += " \n\nAS MERGE "+nombreTabla+" AS TARGET USING(SELECT ";
            }
            foreach (Nodo nodo in campos)
            {
                procedure += "@" + nodo.Clave + ", ";
            }
            procedure = procedure.Remove(procedure.Length - 2);
            procedure += ") \n\nAS Source(";
            foreach (Nodo nodo in campos)
            {
                procedure += nodo.Clave + ", ";
            }

            List<Nodo> listaAllId = GetAllId(campos);
            procedure = procedure.Remove(procedure.Length - 2);
            // procedure += ") \n\nON (Source." + campos[0].Clave + " = Target." + campos[0].Clave + ") ";
            procedure += ") \n\nON (";
            foreach(Nodo n in listaAllId)
            {
                procedure += "Source." +n.Clave + " = Target." + n.Clave + " and ";
            }
            procedure = procedure.Remove(procedure.Length - 4);
            procedure += " ) ";


            procedure += "\n\n WHEN MATCHED THEN UPDATE SET ";
            int i = 0;
            foreach (Nodo nodo in campos)
            {
                if (i > 0)
                {
                    procedure += "Target." + nodo.Clave + " = @" + nodo.Clave+", ";
                }
                ++i;
                
            }
            procedure = procedure.Remove(procedure.Length - 2);
            procedure += " \n\nWHEN NOT MATCHED BY TARGET THEN INSERT(";
            i = 0;
            foreach (Nodo nodo in campos)
            {
                if (i > 0)
                {
                    procedure += nodo.Clave+", ";
                }
                ++i;

            }
            procedure = procedure.Remove(procedure.Length - 2);
            procedure += ") \n\nVALUES ( ";
            i = 0;
            foreach (Nodo nodo in campos)
            {
                if (i > 0)
                {
                    procedure += "@"+nodo.Clave + ", ";
                }
                ++i;

            }
            procedure = procedure.Remove(procedure.Length - 2);
            procedure += "); \n GO";

            return procedure;
        }

        String GetProcedure(String sql)
        {
            String s = generateMergeInsertUpdate(ProcessString(sql));

            return s;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            

           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSentenciaSQL.Text.Trim()))
            {
                MessageBox.Show("Introduzca un conjunto de campos obtenidos de un {create to}");
                return;
            }
            String sql = textBoxSentenciaSQL.Text;
            String s = GetProcedure(sql);
            textBoxSqlResult.Text = s;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxSentenciaSQL.Clear();
            textBoxSqlResult.Clear();
        }
    }
    }



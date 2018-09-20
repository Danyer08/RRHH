using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHH
{
    public partial class frmDepartamentos : MetroFramework.Forms.MetroForm
    {
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void FormDepartamentos_Load(object sender, EventArgs e)
        {
            using (var context = new RRHHEntities())
            {
                var departamentos = from dep in context.Departamento
                                    select new
                                    {
                                        dep.NombreDepartamento,
                                        dep.Estado
                                    };
                metroGridDepartamentos.DataSource = departamentos.ToList();
            }
        }
      
            private void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento
            {
                NombreDepartamento = metroTextNombreDepartamento.Text,
                Estado = metroRadioEstado.Checked
            };

            using (var context = new RRHHEntities())
            {
                context.Departamento.Add(departamento);
                context.SaveChanges();
                MessageBox.Show("Datos Guardados");
            }
            Refrescar();
        }
        

         private void metroEditar_Click(object sender, EventArgs e)
        {

            string str = "Data Source=.;Initial Catalog=RRHH;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            string query = "Delete from Departamento where NombreDepartamento= '" + this.metroTextNombreDepartamento + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Departamento set NombreDepartamento = '" + metroTextNombreDepartamento.Text + "'Where'"+ metroTextNombreDepartamento.Text +"'='" +metroTextNombreDepartamento+"'",con );
            cmd.ExecuteNonQuery();
            MessageBox.Show("Departamento Editado");
            con.Close();
            Refrescar();
        }


        private void metroEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new RRHHEntities())
            {
                if (!(metroTextNombreDepartamento.Text == string.Empty))
                {
                    string str = "Data Source=.;Initial Catalog=RRHH;Integrated Security=True";
                    SqlConnection con = new SqlConnection(str);
                    string query = "Delete from Departamento where NombreDepartamento= '" + this.metroTextNombreDepartamento + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader myreader;
                    try
                    {
                        con.Open();
                        myreader = cmd.ExecuteReader();
                        MessageBox.Show("Eliminado", "user information");
                        context.SaveChanges();
                        con.Close();
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(ec.Message);
                    }
                }
                else
                {
                    MessageBox.Show("enter ID which you want to delete", "User information");
                }
                Refrescar();
            }
                
        }

        public void Refrescar()
        {
            using (var context = new RRHHEntities())
            {
                var departamentos = from dep in context.Departamento
                                    select new
                                    {
                                        dep.NombreDepartamento,
                                        dep.Estado
                                    };
                metroGridDepartamentos.DataSource = departamentos.ToList();
            }
        }
        private void metroGridDepartamentos_CellContentClick(object sender, EventArgs e)
        {

        }

        private void metroGridDepartamentos_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = null;

            if (metroGridDepartamentos.SelectedRows.Count > 0)
            {
                selectedRow = metroGridDepartamentos.SelectedRows[0];

            }
            if (selectedRow == null)
                return;
            metroTextNombreDepartamento.Text = selectedRow.Cells["NombreDepartamento"].Value.ToString();
            metroRadioEstado.Checked = true;
        }

        private void metroButtonBuscar_Click(object sender, EventArgs e)
        {
            ConsultaFlexible();
        }

        public void ConsultaFlexible()
        {
            using (var context = new RRHHEntities())
            {
                var departamentos = from dep in context.Departamento
                                    where (dep.NombreDepartamento.StartsWith(metroTextBuscar.Text))
                                    select dep;
                metroGridDepartamentos.DataSource = departamentos.ToList();

                

            }

            
        }

    }
   

    }


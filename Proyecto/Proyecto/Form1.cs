using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPdf;
using System.IO;
using System.Diagnostics;
namespace Proyecto
{
    public partial class Form1 : Form
    {
        ToolTip informacion = new ToolTip();
        ExportarPDF guardar = new ExportarPDF();
        Datos enviarDatos = new Datos();
        private string rutaImg;
        DialogResult dlgRes;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        public double SumaColumna(string NombreCol)
        {
            double Total = 0;
            try
            {
            
                foreach (DataGridViewRow row in dtgb_miTabla.Rows)
                {                 
                    Total += Convert.ToDouble(row.Cells[NombreCol].Value); 
                }
                return Total;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al sumar las columnas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                dlgRes=MessageBox.Show("Una vez realizada la operacion calcular la tabla dejará de ser editable. \n¿Desea continuar?","Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dlgRes==DialogResult.Yes)
                {
                    lbl_Especificaciones.Text = "Tabla de especificaciones " + txt_Prueba.Text + " prueba del periodo " + cmb_periodoLectivo.Text + " , " + txt_Asignatura.Text + " " + dtp_Calendario.Value.Year;
                    dtgb_miTabla.Rows.Add("TOTAL","", "", SumaColumna("col_Lecciones"), SumaColumna("col_Puntos"), SumaColumna("col_SU"), SumaColumna("col_RC"), SumaColumna("col_ID"), SumaColumna("col_C"), SumaColumna("col_RE"), SumaColumna("col_Total"));
                    dtgb_miTabla.ReadOnly = true;
                }
                else
                {
                    dtgb_miTabla.ReadOnly = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Alguno de los datos ingresados no es válido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            informacion.ToolTipTitle = "Dirección Regional:";
            informacion.SetToolTip(cmb_Direccion, "Seleccione la dirección regional. ");
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            open.Title = "Abrir ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(open.FileName);
            }
            open.Dispose();
        }


        public void concatenardtgv()
        {
            try
            {
                string aprendizajes, estrategias, indicadores, numLecciones, puntos, SU, RC, ID, C, RE, totalAsignado;
                foreach (DataGridViewRow row in dtgb_miTabla.Rows)
                {
                    aprendizajes = Convert.ToString(row.Cells["col_Aprendizajes"].Value);
                    estrategias = Convert.ToString(row.Cells["col_Estrategias"].Value);
                    indicadores = Convert.ToString(row.Cells["col_Indicadores"].Value);
                    numLecciones = Convert.ToString(row.Cells["col_Lecciones"].Value);
                    puntos = Convert.ToString(row.Cells["col_Puntos"].Value);
                    SU = Convert.ToString(row.Cells["col_SU"].Value);
                    RC = Convert.ToString(row.Cells["col_RC"].Value);
                    ID = Convert.ToString(row.Cells["col_ID"].Value);
                    C = Convert.ToString(row.Cells["col_C"].Value);
                    RE = Convert.ToString(row.Cells["col_RE"].Value);
                    totalAsignado = Convert.ToString(row.Cells["col_Total"].Value);
                    enviarDatos.DataGridPDF(aprendizajes, estrategias, indicadores, numLecciones, puntos, SU, RC, ID, C, RE, totalAsignado);
                }
                enviarDatos.FinalizarCodHTML();
            }
            catch (Exception)
            {
                MessageBox.Show("Algun dato ingresado no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();//abre el cuadro de dialogo para seleccionar en donde guardar el archivo
            try
            {
            //parseo de variables
            int ValProc = int.Parse(txt_valorPorcentual.Text);
            int puntuacionPreeliminar = int.Parse(txt_Puntuación.Text);
            int totLecciones = int.Parse(txt_TotaldeLecciones.Text);
            int constante = int.Parse(txt_Constante.Text);
            //llamada al metodo de la clase Datos que se encarga de crear el string con html
            enviarDatos.StringPDF(cmb_Direccion.Text, cmb_Supervision.Text,txt_CentroEducativo.Text,txt_Email.Text,
                                    txt_Docente.Text,txt_Asignatura.Text,cmb_periodoLectivo.Text,txt_Nivel.Text,txt_Seccion.Text,
                                    txt_Prueba.Text,dtp_Calendario.Value,ValProc,puntuacionPreeliminar,totLecciones,constante,rutaImg);
            //el siguiente método concatena el dataGrid como codigo html
            concatenardtgv();
             MessageBox.Show("Guardado con éxito", "Guardar");
            }
            catch (Exception)
            {
                MessageBox.Show("Algun dato ingresado no es válido","Error",MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            try
            {
            //llamada al metodo encargado de exportar al pdf
            string ruta = saveFileDialog1.FileName;
            guardar.guardar(enviarDatos.datos, ruta);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error, por favor intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
  
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            informacion.ToolTipTitle = "Correo Electrónico:";
            informacion.SetToolTip(txt_Email, "Ingrese el Correo Electrónico de la institución. ");
        }

        private void txt_CentroEducativo_TextChanged(object sender, EventArgs e)
        {
            informacion.ToolTipTitle = "Centro Educativo:";
            informacion.SetToolTip(txt_CentroEducativo, "Ingrese el nombre de la institución. ");
        }

        private void txt_Docente_TextChanged(object sender, EventArgs e)
        {
            informacion.ToolTipTitle = "Docente:";
            informacion.SetToolTip(txt_Docente, "Ingrese el nombre del o la docente. ");
        }

        private void txt_Asignatura_TextChanged(object sender, EventArgs e)
        {
            informacion.ToolTipTitle = "Materia:";
            informacion.SetToolTip(txt_Asignatura, "Ingrese el nombre de la materia. ");
        }

        private void cmb_periodoLectivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            informacion.ToolTipTitle = "Trimestre:";
            informacion.SetToolTip(cmb_periodoLectivo, "Seleccione el periodo lectivo que cursa. ");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            informacion.ToolTipTitle = "Grado:";
            informacion.SetToolTip(txt_Nivel, "Ingrese el grado que cursa. ");
        }

        private void txt_Seccion_TextChanged(object sender, EventArgs e)
        {
            informacion.ToolTipTitle = "Sección:";
            informacion.SetToolTip(txt_Seccion, "Ingrese el número de la sección. ");
        }

        private void btn_TipodeItem_Click(object sender, EventArgs e)
        {
            informacion.ToolTipTitle = "Tipo de item seleccionado:";
            informacion.SetToolTip(txt_Seccion, "Oprima para ver la simbología. ");

            mbPersonalizado MB = new mbPersonalizado();
            MB.Show();
        }

       

        private void txt_Prueba_TextChanged(object sender, EventArgs e)
        {
            informacion.ToolTipTitle = "Prueba:";
            informacion.SetToolTip(txt_Seccion, "Ingrese el número de la prueba. ");
        }

        private void cmb_Supervision_SelectedIndexChanged(object sender, EventArgs e)
        {
            informacion.ToolTipTitle = "Supervisión de Centros Educativos";
            informacion.SetToolTip(txt_Seccion, "Seleccione la supervisión de centros educativos y su circuito. ");
        }

        private void btn_cambiarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                informacion.ToolTipTitle = "Seleccione una imagen:";
                informacion.SetToolTip(txt_Email, "Seleccione el escudo de la institución. ");

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Imagenes | *.jpg;*.png";
                ofd.Title = "Abriendo imagen";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string urlArchivo = ofd.FileName;
                    pbx_cambiarImagen.Load(urlArchivo);
                }

                rutaImg = ofd.FileName;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar la imagen, por favor intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public  void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Suma(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int SU, RC, ID, C, RE, total;

                SU = Convert.ToInt32(dtgb_miTabla.Rows[e.RowIndex].Cells["col_SU"].Value);
                RC = Convert.ToInt32(dtgb_miTabla.Rows[e.RowIndex].Cells["col_RC"].Value);
                ID = Convert.ToInt32(dtgb_miTabla.Rows[e.RowIndex].Cells["col_ID"].Value);
                C = Convert.ToInt32(dtgb_miTabla.Rows[e.RowIndex].Cells["col_C"].Value);
                RE = Convert.ToInt32(dtgb_miTabla.Rows[e.RowIndex].Cells["col_RE"].Value);

                total = SU + RC + ID + C + RE;

                dtgb_miTabla.Rows[e.RowIndex].Cells["col_Total"].Value = total;

            }catch(Exception)
            {
                MessageBox.Show("Algun dato ingresado no es válido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }     
        }

        private void pbx_cambiarImagen_Click(object sender, EventArgs e)
        {

        }

        private void txtx_Exportar_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_valorPorcentual_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

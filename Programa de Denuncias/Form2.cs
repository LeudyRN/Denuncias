using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TareaFinal
{
    public partial class Form2 : Form
    {
        int adc = 0;

        List<Persona> Persona = new List<Persona>();
        private bool Editar = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarDenunciasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();

            p.Nombre = txtNombre.Text;
            p.Fecha_hecho = txtFecha_hecho.Text;
            p.Cedula_denunciador = txtCedula.Text;
            p.Titulo_denuncia = txtTitulo.Text;
            p.Nombre_denunciado = txtNombre_denunciado.Text;
            p.Cedula_denunciado = txtCedula_denunciado.Text;
            p.Descripcion = txtDescripcion.Text;
            p.Tribunal = txtTribunal.Text;




            Persona.Add(p);
            gridPkm.DataSource = null;
            gridPkm.DataSource = Persona;
            gridPkm.Refresh();


        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            var json = JsonConvert.SerializeObject(Persona);
            File.WriteAllText("datos.json", json);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists("datos.json"))
            {
                var datos = File.ReadAllText("datos.json");
                try
                {
                    Persona = JsonConvert.DeserializeObject<List<Persona>>(datos);
                    gridPkm.DataSource = null;
                    gridPkm.DataSource = Persona;
                    gridPkm.Refresh();

                }
                catch
                {
                    MessageBox.Show("Error al cargar el archivo");
                }

            }
        }


        private void acercaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(@"
        
        

        
        
        Creado por: Leudy Randy Nolasco.
        Estudiante de Licenciatura Para informatica UASD.
        Matricula: 100576672
        Telefono: 829-334-3632.
        Correo: randylnolasco7@gmail.com
        
        ");

        }


        private void modificarDenuncias_Click(object sender, EventArgs e)
        {

            if (adc >= Persona.Count)
            {
                MessageBox.Show("El ID ingresado no existe");


            }
            Persona.RemoveAt(adc);
            gridPkm.DataSource = null;
            gridPkm.DataSource = Persona;
            gridPkm.Refresh();
        }


        private void Exportar_Click(object sender, EventArgs e)
        {
            var plantilla = "";

           StreamReader sr = new StreamReader("plantilla.html");
            plantilla = sr.ReadToEnd();
            sr.Close();


                plantilla = plantilla.Replace("#Nombre#", txtNombre.Text);
                plantilla = plantilla.Replace("#Fecha#", txtFecha_hecho.Text);
                plantilla = plantilla.Replace("#Cedula#", txtCedula.Text);
                plantilla = plantilla.Replace("#Titulo#", txtTitulo.Text);
                plantilla = plantilla.Replace("#Nombre Acusado#", txtNombre_denunciado.Text);
                plantilla = plantilla.Replace("#Cedula Acusado#", txtCedula_denunciado.Text);
                plantilla = plantilla.Replace("#Descripcion#", txtDescripcion.Text);
                plantilla = plantilla.Replace("#Tribunal#", txtTribunal.Text);


                System.IO.File.WriteAllText("Denuncias.html", plantilla);

                var url = "Denuncias.html";
                var psl = new System.Diagnostics.ProcessStartInfo();
                psl.UseShellExecute = true;
                psl.FileName = url;
                System.Diagnostics.Process.Start(psl);
            }
        }
    
}






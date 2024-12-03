using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public delegate void Delega(string frase, string cosa, System.Windows.Forms.ListBox listb);
        public delegate string Delega2();
        public static readonly object l = new object();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblerror.Text = "";
                txtCoincidencias.Items.Clear();
                DirectoryInfo dr = new DirectoryInfo(txtdir.Text);
                string[] extensiones = txtExtensiones.Text.Split(',');
                for (int i = 0; i < extensiones.Length; i++)
                {
                    FileInfo[] archivos = dr.GetFiles("*" + extensiones[i]);
                    int indice = 0;
                    for (int j = 0; j < archivos.Length; j++)
                    {
                        Thread hilo = new Thread(() => buscarCoincidencia(archivos[indice]));
                        hilo.Start();
                        if (indice < archivos.Length)
                        {
                            indice++;
                        }
                    }
                }
            }
            catch (Exception)
            {
                lblerror.Text = "error";
            }
        }

        public void buscarCoincidencia(FileInfo archivo)
        {
            string linea;
            Delega delegado = new Delega(cambiartxt);
            Delega2 delegado2 = new Delega2(textotxt);
            StreamReader sr;
            int veces = 0;
            string palabra = txtcadena.Text;
            using (sr = new StreamReader(archivo.FullName))
            {
                linea = sr.ReadToEnd();
            }
            if (checkBox1.Checked)
            {
                linea = linea.ToUpper();
                palabra = palabra.ToUpper();
            }
            for (int i = 0; i < linea.Length; i++)
            {
                int cantidad = linea.Length - i;
                if (cantidad > palabra.Length)
                {
                    string trozo = linea.Substring(i, palabra.Length);
                    if (trozo == palabra)
                    {
                        veces++;
                    }
                }
            }
            string trozo2 = linea.Substring(linea.Length - palabra.Length);
            if (trozo2 == palabra)
            {
                veces++;
            }
            lock (l)
            {
                this.Invoke(delegado, veces.ToString(), archivo.Name, txtCoincidencias);
            }
        }
        public void cambiartxt(string frase, string archivo, System.Windows.Forms.ListBox t)
        {
            t.Items.Add(String.Format("Nombre:{0} Veces:{1}", archivo, frase));
        }
        public string textotxt()
        {
            return txtcadena.Text;
        }

        private void txtCoincidencias_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String ruta = Environment.GetEnvironmentVariable("userprofile");
            ruta += "\\archivos.txt";
            StreamReader sr;
            using (sr = new StreamReader(ruta))
            {
                String extensiones = sr.ReadToEnd();
                txtExtensiones.Text = extensiones;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            String ruta = Environment.GetEnvironmentVariable("userprofile");
            ruta += "\\archivos.txt";
            StreamWriter sw;
            using (sw = new StreamWriter(ruta))
            {
                sw.WriteLine(txtExtensiones.Text);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

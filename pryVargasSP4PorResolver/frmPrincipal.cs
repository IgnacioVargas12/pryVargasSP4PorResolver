namespace pryVargasSP4PorResolver
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Declaración de Matriz
        float[,] vecDatos = new float[5, 4];

        //Declaración Variables
        int indiceColumnas = 0;
        int indiceFilas = 0;
        int MayorImporteTotal = 0;
        int Acumulador = 0;
        string MozoMasVenta = "";
        int TotalComidas = 0;
        int TotalBebidaConAlcohol = 0;
        int TotalBebidaSinAlcohol = 0;
        int TotalPostre = 0;
        int TotalGeneral = 0;
        int TotalAux = 0;


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Agregamos las filas
            dgvDatos.Rows.Add("Julio");
            dgvDatos.Rows.Add("Esteban");
            dgvDatos.Rows.Add("Javier");
            dgvDatos.Rows.Add("Gonzalo");
            dgvDatos.Rows.Add("Alberto");

            //Inicializamos la grilla con valor 0 en todas las posiciones
            for (indiceFilas = 0; indiceFilas < 5; indiceFilas++)
            {
                for (indiceColumnas = 1; indiceColumnas < 5; indiceColumnas++)
                {
                    dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Value = 0;
                }
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void btnConsultarMozo_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;
            for (indiceFilas = 0; indiceFilas < 5; indiceFilas++)
            {
                Acumulador = 0;
                for (indiceColumnas = 1; indiceColumnas < 5; indiceColumnas++)
                {
                    Acumulador += Convert.ToInt32(dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Value);
                }

                if (Acumulador > MayorImporteTotal)
                {
                    MayorImporteTotal = Acumulador;
                    MozoMasVenta = Convert.ToString(dgvDatos.Rows[indiceFilas].Cells[0].Value);
                }
            }
            lblMontoIndiv.Text = Convert.ToString(MayorImporteTotal);
            lblNombreMozo.Text = MozoMasVenta;
            MayorImporteTotal = 0;

        }

        private bool ValidarDatos()
        {
            for (indiceFilas = 0; indiceFilas < 5; indiceFilas++)
            {
                for (indiceColumnas = 1; indiceColumnas < 5; indiceColumnas++)
                {
                    object celda = dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Value;

                    // Si la celda está vacía o nula
                    if (celda == null || celda.ToString() == "")
                    {
                        MessageBox.Show($"Hay una celda vacía en la fila {indiceFilas + 1}, columna {indiceColumnas + 1}.",
                            "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        btnConsultarTotal.Enabled = false;
                        btnConsultarMozo.Enabled = false;
                        return false; //corta todo el método y devuelve false
                    }

                    // Si no se puede convertir a número
                    double numero;
                    if (!double.TryParse(celda.ToString(), out numero))
                    {
                        MessageBox.Show($"El valor en la fila {indiceFilas + 1}, columna {indiceColumnas + 1} no es numérico.",
                            "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        btnConsultarTotal.Enabled = false;
                        btnConsultarMozo.Enabled = false;
                        return false; //corta todo el método y devuelve false
                    }
                }
            }

            //Si pasó todas las validaciones
            btnConsultarMozo.Enabled = true;
            btnConsultarTotal.Enabled = true;
            return true;
        }

        private void btnConsultarTotal_Click(object sender, EventArgs e)
        {
            for (indiceColumnas = 1; indiceColumnas < 5; indiceColumnas++)
            {
                TotalAux = 0;
                for (indiceFilas = 0; indiceFilas < 5; indiceFilas++)
                {
                    TotalAux += Convert.ToInt32(dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Value);
                }
                switch (indiceColumnas)
                {
                    case 1:
                        TotalComidas = TotalAux;
                        break;
                    case 2:
                        TotalBebidaConAlcohol = TotalAux;
                        break;
                    case 3:
                        TotalBebidaSinAlcohol = TotalAux;
                        break;
                    case 4:
                        TotalPostre = TotalAux;
                        break;
                }
            }
            TotalGeneral = TotalComidas + TotalBebidaConAlcohol + TotalPostre + TotalBebidaSinAlcohol;

            //Limpiamos primero el contenido de la lbl
            lstResultados.Items.Clear();

            //Mostramos el resultado
            lstResultados.Items.Add("Ventas por categoría:");
            lstResultados.Items.Add("-------------------------");
            lstResultados.Items.Add("Comida: " + TotalComidas);
            lstResultados.Items.Add("Bebidas con alcohol: " + TotalBebidaConAlcohol);
            lstResultados.Items.Add("Bebidas sin alcohol: " + TotalBebidaSinAlcohol);
            lstResultados.Items.Add("Postres: " + TotalPostre);
            lstResultados.Items.Add("-------------------------");
            lstResultados.Items.Add("TOTAL GENERAL: " + TotalGeneral);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

            //No permitimos cambiar la columna de los mozos
            while (indiceFilas < 5)
            {
                dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].ReadOnly = true;
                indiceFilas++;
            }
            

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
            //Validamos que todos los datos de la grilla sean correctos
            if (!ValidarDatos())
                return;
            //Recorremos toda la grilla
            for (indiceFilas = 0; indiceFilas < 5; indiceFilas++)
            {
                Acumulador = 0;
                //Acumulamos el valor de toda la fila en una variable auxiliar
                for (indiceColumnas = 1; indiceColumnas < 5; indiceColumnas++)
                {
                    Acumulador += Convert.ToInt32(dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Value);
                }
                //El primer mozo que tenga ventas se guardará en la variable auxiliar MayorImporteTotal para luego comparar con los demas
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
            //Recorremos toda la grilla para validar los datos
            for (indiceFilas = 0; indiceFilas < 5; indiceFilas++)
            {
                for (indiceColumnas = 1; indiceColumnas < 5; indiceColumnas++)
                {
                    //Guardamos el valor de la celda en un object ya que no sabemos si es un número, texto o vacío
                    object ValorCelda = dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Value;

                    // Si la celda está vacía o nula
                    if (ValorCelda == null || ValorCelda.ToString() == "")
                    {
                        MessageBox.Show($"Hay una celda vacía en la fila {indiceFilas + 1}, columna {indiceColumnas + 1}.",
                            "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Style.BackColor = Color.Red;

                        btnConsultarTotal.Enabled = false;
                        btnConsultarMozo.Enabled = false;
                        return false; //corta todo el método y devuelve false para terminar el procedimiento
                    }

                    //Verificación de que la celda sea un número y no texto
                    //El double numero sirve como variable para guardar el valor de la conversión si se puede realizar, de ahí viene el "out numero"
                    double numero;
                    //Primero convierte ValorCelda en string para luego convertirlo en double, y si no puede, entra al if
                    if (!double.TryParse(ValorCelda.ToString(), out numero))
                    {
                        MessageBox.Show($"El valor en la fila {indiceFilas + 1}, columna {indiceColumnas + 1} no es numérico.",
                            "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Style.BackColor = Color.Red;

                        btnConsultarTotal.Enabled = false;
                        btnConsultarMozo.Enabled = false;
                        return false; //corta todo el método y devuelve false
                    }
                }
            }

            if (!ValidarColoresYCeldas())
                return false;

            //Si pasó todas las validaciones
            btnConsultarMozo.Enabled = true;
            btnConsultarTotal.Enabled = true;

            //Grabamos los datos en el array
            for (int fila = 0; fila < 5; fila++)
            {
                // Recorremos las columnas de la grilla desde la 1 (evitamos la 0 porque son nombres de los mozos)
                for (int colGrilla = 1; colGrilla < 5; colGrilla++)
                {
                    // Calculamos el índice correcto para la matriz (una columna menos)
                    int colMatriz = colGrilla - 1;

                    // Convertimos el valor de la celda a float
                    float valorCelda = Convert.ToSingle(dgvDatos.Rows[fila].Cells[colGrilla].Value);

                    // Guardamos en la matriz
                    vecDatos[fila, colMatriz] = valorCelda;
                }
            }
            return true;
        }

        private void btnConsultarTotal_Click(object sender, EventArgs e)
        {
            //Primero validamos que los datos de la grilla esten bien
            if (!ValidarDatos())
                return;
            //Recorremos todo el array
            for (indiceColumnas = 1; indiceColumnas < 5; indiceColumnas++)
            {
                TotalAux = 0;
                //Guardamos el total de cada categoría
                for (indiceFilas = 0; indiceFilas < 5; indiceFilas++)
                {
                    TotalAux += Convert.ToInt32(dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Value);
                }
                //Verifico cual es la categoría para guardarla en una variable
                switch (indiceColumnas)
                {
                    case 1:
                        TotalComidas = TotalAux;
                        break;
                    case 2:
                        TotalBebidaSinAlcohol = TotalAux;
                        break;
                    case 3:
                        TotalBebidaConAlcohol = TotalAux;
                        break;
                    case 4:
                        TotalPostre = TotalAux;
                        break;
                }
            }
            //Calculamos el total general sumando todas las variables
            TotalGeneral = TotalComidas + TotalBebidaConAlcohol + TotalPostre + TotalBebidaSinAlcohol;

            //Limpiamos primero el contenido de la etiqueta
            lstResultados.Items.Clear();

            //Mostramos el resultado
            lstResultados.Items.Add("Ventas por categoría:");
            lstResultados.Items.Add("-------------------------");
            lstResultados.Items.Add("Comida: $" + TotalComidas);
            lstResultados.Items.Add("Bebidas sin alcohol: $" + TotalBebidaSinAlcohol);
            lstResultados.Items.Add("Bebidas con alcohol: $" + TotalBebidaConAlcohol);
            lstResultados.Items.Add("Postres: $" + TotalPostre);
            lstResultados.Items.Add("-------------------------");
            lstResultados.Items.Add("TOTAL GENERAL: $" + TotalGeneral);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarColoresYCeldas()
        {
            //Este procedimiento exclusivamente otorga los colores a la celda y evita los números negativos
            bool hayNegativo = false;

            for (indiceFilas = 0; indiceFilas < dgvDatos.Rows.Count; indiceFilas++)
            {
                for (indiceColumnas = 1; indiceColumnas < dgvDatos.Columns.Count; indiceColumnas++)
                {
                    object valorCelda = dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Value;
                    //Utilizo el tryparse para tener una variable local donde guardar el valor de la celda
                    //Primero convierto el valorCelda a string para poder usar el tryparse

                    if (valorCelda != null && double.TryParse(valorCelda.ToString(), out double numero))
                    {
                        if (numero == 0)
                        {
                            dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Style.BackColor = Color.Yellow;
                        }
                        else if (numero < 0)
                        {
                            dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Style.BackColor = Color.Red;
                            hayNegativo = true; 
                        }
                        else
                        {
                            dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Style.BackColor = Color.White;
                        }
                    }
                    else
                    {
                        dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Style.BackColor = Color.White;
                    }
                }
            }

            if (hayNegativo)
            {
                MessageBox.Show("Se encontraron valores negativos en la grilla.",
                    "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnConsultarMozo.Enabled = false;
                btnConsultarTotal.Enabled = false;
                return false;
            }

            return true;
        }
    }
}

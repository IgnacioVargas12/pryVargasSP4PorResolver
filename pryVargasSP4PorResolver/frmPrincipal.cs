namespace pryVargasSP4PorResolver
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Declaración de Matriz
        float[,] vecDatos = new float[5,4];

        //Declaración Variables
        int indiceColumnas = 0;
        int indiceFilas = 0;


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Agregamos las filas
            dgvDatos.Rows.Add("Julio");
            dgvDatos.Rows.Add("Esteban");
            dgvDatos.Rows.Add("Javier");
            dgvDatos.Rows.Add("Gonzalo");
            dgvDatos.Rows.Add("Alberto");

            for (indiceFilas = 0; indiceFilas < 5; indiceFilas++)
            {
                for (indiceColumnas = 1; indiceColumnas < 5; indiceColumnas++)
                {
                    dgvDatos.Rows[indiceFilas].Cells[indiceColumnas].Value = 0;
                }  
            }
        }
    }
}

namespace pryVargasSP4PorResolver
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            dgvDatos = new DataGridView();
            ColMozos = new DataGridViewTextBoxColumn();
            colComidas = new DataGridViewTextBoxColumn();
            ColBebidasSinAlcohol = new DataGridViewTextBoxColumn();
            ColBebidasConAlcohol = new DataGridViewTextBoxColumn();
            ColPostre = new DataGridViewTextBoxColumn();
            btnConsultarMozo = new Button();
            btnConsultarTotal = new Button();
            btnValidar = new Button();
            lblMozoDia = new Label();
            lblMontoMozo = new Label();
            lstResultados = new ListBox();
            lblNombreMozo = new Label();
            lblMontoIndiv = new Label();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColMozos, colComidas, ColBebidasSinAlcohol, ColBebidasConAlcohol, ColPostre });
            dgvDatos.Location = new Point(12, 12);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.Size = new Size(526, 187);
            dgvDatos.TabIndex = 0;
            // 
            // ColMozos
            // 
            ColMozos.HeaderText = "Mozos";
            ColMozos.Name = "ColMozos";
            // 
            // colComidas
            // 
            colComidas.HeaderText = "Comidas";
            colComidas.Name = "colComidas";
            // 
            // ColBebidasSinAlcohol
            // 
            ColBebidasSinAlcohol.HeaderText = "Bebidas Sin Alcohol";
            ColBebidasSinAlcohol.Name = "ColBebidasSinAlcohol";
            // 
            // ColBebidasConAlcohol
            // 
            ColBebidasConAlcohol.HeaderText = "Bebidas Con Alcohol";
            ColBebidasConAlcohol.Name = "ColBebidasConAlcohol";
            // 
            // ColPostre
            // 
            ColPostre.HeaderText = "Postre";
            ColPostre.Name = "ColPostre";
            // 
            // btnConsultarMozo
            // 
            btnConsultarMozo.Location = new Point(8, 230);
            btnConsultarMozo.Name = "btnConsultarMozo";
            btnConsultarMozo.Size = new Size(86, 32);
            btnConsultarMozo.TabIndex = 1;
            btnConsultarMozo.Text = "Mozo del día";
            btnConsultarMozo.UseVisualStyleBackColor = true;
            btnConsultarMozo.Click += btnConsultarMozo_Click;
            // 
            // btnConsultarTotal
            // 
            btnConsultarTotal.Location = new Point(245, 230);
            btnConsultarTotal.Name = "btnConsultarTotal";
            btnConsultarTotal.Size = new Size(86, 32);
            btnConsultarTotal.TabIndex = 2;
            btnConsultarTotal.Text = "Totales";
            btnConsultarTotal.UseVisualStyleBackColor = true;
            btnConsultarTotal.Click += btnConsultarTotal_Click;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(452, 230);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(86, 32);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar datos";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblMozoDia
            // 
            lblMozoDia.AutoSize = true;
            lblMozoDia.Location = new Point(8, 274);
            lblMozoDia.Name = "lblMozoDia";
            lblMozoDia.Size = new Size(78, 15);
            lblMozoDia.TabIndex = 4;
            lblMozoDia.Text = "Mozo del día:";
            // 
            // lblMontoMozo
            // 
            lblMontoMozo.AutoSize = true;
            lblMontoMozo.Location = new Point(8, 301);
            lblMontoMozo.Name = "lblMontoMozo";
            lblMontoMozo.Size = new Size(46, 15);
            lblMontoMozo.TabIndex = 5;
            lblMontoMozo.Text = "Monto:";
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(199, 274);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(181, 124);
            lstResultados.TabIndex = 6;
            // 
            // lblNombreMozo
            // 
            lblNombreMozo.AutoSize = true;
            lblNombreMozo.Location = new Point(92, 274);
            lblNombreMozo.Name = "lblNombreMozo";
            lblNombreMozo.Size = new Size(22, 15);
            lblNombreMozo.TabIndex = 7;
            lblNombreMozo.Text = "---";
            // 
            // lblMontoIndiv
            // 
            lblMontoIndiv.AutoSize = true;
            lblMontoIndiv.Location = new Point(92, 301);
            lblMontoIndiv.Name = "lblMontoIndiv";
            lblMontoIndiv.Size = new Size(22, 15);
            lblMontoIndiv.TabIndex = 8;
            lblMontoIndiv.Text = "---";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(452, 284);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(85, 32);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 423);
            Controls.Add(btnCerrar);
            Controls.Add(lblMontoIndiv);
            Controls.Add(lblNombreMozo);
            Controls.Add(lstResultados);
            Controls.Add(lblMontoMozo);
            Controls.Add(lblMozoDia);
            Controls.Add(btnValidar);
            Controls.Add(btnConsultarTotal);
            Controls.Add(btnConsultarMozo);
            Controls.Add(dgvDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private Button btnConsultarMozo;
        private Button btnConsultarTotal;
        private Button btnValidar;
        private Label lblMozoDia;
        private Label lblMontoMozo;
        private ListBox lstResultados;
        private DataGridViewTextBoxColumn ColMozos;
        private DataGridViewTextBoxColumn colComidas;
        private DataGridViewTextBoxColumn ColBebidasSinAlcohol;
        private DataGridViewTextBoxColumn ColBebidasConAlcohol;
        private DataGridViewTextBoxColumn ColPostre;
        private Label lblNombreMozo;
        private Label lblMontoIndiv;
        private Button btnCerrar;
    }
}

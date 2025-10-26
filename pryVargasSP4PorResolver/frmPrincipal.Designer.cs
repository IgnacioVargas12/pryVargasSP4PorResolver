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
            listBox1 = new ListBox();
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
            dgvDatos.Location = new Point(94, 12);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
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
            ColMozos.ReadOnly = true;
            // 
            // colComidas
            // 
            colComidas.HeaderText = "Comidas";
            colComidas.Name = "colComidas";
            colComidas.ReadOnly = true;
            // 
            // ColBebidasSinAlcohol
            // 
            ColBebidasSinAlcohol.HeaderText = "Bebidas Sin Alcohol";
            ColBebidasSinAlcohol.Name = "ColBebidasSinAlcohol";
            ColBebidasSinAlcohol.ReadOnly = true;
            // 
            // ColBebidasConAlcohol
            // 
            ColBebidasConAlcohol.HeaderText = "Bebidas Con Alcohol";
            ColBebidasConAlcohol.Name = "ColBebidasConAlcohol";
            ColBebidasConAlcohol.ReadOnly = true;
            // 
            // ColPostre
            // 
            ColPostre.HeaderText = "Postre";
            ColPostre.Name = "ColPostre";
            ColPostre.ReadOnly = true;
            // 
            // btnConsultarMozo
            // 
            btnConsultarMozo.Location = new Point(52, 360);
            btnConsultarMozo.Name = "btnConsultarMozo";
            btnConsultarMozo.Size = new Size(86, 32);
            btnConsultarMozo.TabIndex = 1;
            btnConsultarMozo.Text = "Mozo del día";
            btnConsultarMozo.UseVisualStyleBackColor = true;
            // 
            // btnConsultarTotal
            // 
            btnConsultarTotal.Location = new Point(336, 360);
            btnConsultarTotal.Name = "btnConsultarTotal";
            btnConsultarTotal.Size = new Size(86, 32);
            btnConsultarTotal.TabIndex = 2;
            btnConsultarTotal.Text = "Totales";
            btnConsultarTotal.UseVisualStyleBackColor = true;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(593, 360);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(86, 32);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar datos";
            btnValidar.UseVisualStyleBackColor = true;
            // 
            // lblMozoDia
            // 
            lblMozoDia.AutoSize = true;
            lblMozoDia.Location = new Point(52, 404);
            lblMozoDia.Name = "lblMozoDia";
            lblMozoDia.Size = new Size(78, 15);
            lblMozoDia.TabIndex = 4;
            lblMozoDia.Text = "Mozo del día:";
            // 
            // lblMontoMozo
            // 
            lblMontoMozo.AutoSize = true;
            lblMontoMozo.Location = new Point(52, 431);
            lblMontoMozo.Name = "lblMontoMozo";
            lblMontoMozo.Size = new Size(46, 15);
            lblMontoMozo.TabIndex = 5;
            lblMontoMozo.Text = "Monto:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(336, 404);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 529);
            Controls.Add(listBox1);
            Controls.Add(lblMontoMozo);
            Controls.Add(lblMozoDia);
            Controls.Add(btnValidar);
            Controls.Add(btnConsultarTotal);
            Controls.Add(btnConsultarMozo);
            Controls.Add(dgvDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private ListBox listBox1;
        private DataGridViewTextBoxColumn ColMozos;
        private DataGridViewTextBoxColumn colComidas;
        private DataGridViewTextBoxColumn ColBebidasSinAlcohol;
        private DataGridViewTextBoxColumn ColBebidasConAlcohol;
        private DataGridViewTextBoxColumn ColPostre;
    }
}

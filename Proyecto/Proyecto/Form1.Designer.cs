namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_Direccion = new System.Windows.Forms.ComboBox();
            this.dtp_Calendario = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_CentroEducativo = new System.Windows.Forms.TextBox();
            this.lbl_CentroEducativo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Docente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Asignatura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nivel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Seccion = new System.Windows.Forms.TextBox();
            this.cmb_periodoLectivo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgb_miTabla = new System.Windows.Forms.DataGridView();
            this.col_Aprendizajes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Estrategias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Indicadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Lecciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_TipodeItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TotaldeLecciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Puntuación = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_valorPorcentual = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Constante = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Especificaciones = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Prueba = new System.Windows.Forms.TextBox();
            this.cmb_Supervision = new System.Windows.Forms.ComboBox();
            this.btn_cambiarImagen = new System.Windows.Forms.Button();
            this.pbx_cambiarImagen = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgb_miTabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_cambiarImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cyan;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // cmb_Direccion
            // 
            this.cmb_Direccion.FormattingEnabled = true;
            this.cmb_Direccion.Items.AddRange(new object[] {
            "Dirección Regional de Educación San José-Central ",
            "Dirección Regional de Educación San José-Norte",
            "Dirección Regional de Educación San José Sur-Oeste",
            "Dirección Regional de Educación Desamparados",
            "Dirección Regional de Educación Los Santos",
            "Dirección Regional de Educación Puriscal",
            "Dirección Regional de Educación Pérez Zeledón",
            "Dirección Regional de Educación Alajuela",
            "Dirección Regional de Educación Occidente",
            "Dirección Regional de Educación San Carlos",
            "Dirección Regional de Educación Zona Norte-Norte",
            "Dirección Regional de Educación Cartago",
            "Dirección Regional de Educación Turrialba",
            "Dirección Regional de Educación Heredia",
            "Dirección Regional de Educación Sarapiquí",
            "Dirección Regional de Educación Liberia",
            "Dirección Regional de Educación Cañas",
            "Dirección Regional de Educación Nicoya",
            "Dirección Regional de Educación Santa Cruz",
            "Dirección Regional de Educación Puntarenas",
            "Dirección Regional de Educación Peninsular",
            "Dirección Regional de Educación Aguirre",
            "Dirección Regional de Educación Grande de Térraba",
            "Dirección Regional de Educación Coto",
            "Dirección Regional de Educación Limón",
            "Dirección Regional de Educación Sulá",
            "Dirección Regional de Educación Guápiles"});
            this.cmb_Direccion.Location = new System.Drawing.Point(0, 26);
            this.cmb_Direccion.Name = "cmb_Direccion";
            this.cmb_Direccion.Size = new System.Drawing.Size(408, 21);
            this.cmb_Direccion.TabIndex = 1;
            this.cmb_Direccion.Text = "Dirección Regional de Educación San José-Central ";
            this.cmb_Direccion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtp_Calendario
            // 
            this.dtp_Calendario.Location = new System.Drawing.Point(934, 22);
            this.dtp_Calendario.Name = "dtp_Calendario";
            this.dtp_Calendario.Size = new System.Drawing.Size(200, 20);
            this.dtp_Calendario.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_CentroEducativo
            // 
            this.txt_CentroEducativo.Location = new System.Drawing.Point(98, 74);
            this.txt_CentroEducativo.Name = "txt_CentroEducativo";
            this.txt_CentroEducativo.Size = new System.Drawing.Size(149, 20);
            this.txt_CentroEducativo.TabIndex = 8;
            this.txt_CentroEducativo.TextChanged += new System.EventHandler(this.txt_CentroEducativo_TextChanged);
            // 
            // lbl_CentroEducativo
            // 
            this.lbl_CentroEducativo.AutoSize = true;
            this.lbl_CentroEducativo.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_CentroEducativo.Location = new System.Drawing.Point(-3, 77);
            this.lbl_CentroEducativo.Name = "lbl_CentroEducativo";
            this.lbl_CentroEducativo.Size = new System.Drawing.Size(95, 13);
            this.lbl_CentroEducativo.TabIndex = 9;
            this.lbl_CentroEducativo.Text = "Centro Educativo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(-3, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Docente :";
            // 
            // txt_Docente
            // 
            this.txt_Docente.Location = new System.Drawing.Point(98, 130);
            this.txt_Docente.Name = "txt_Docente";
            this.txt_Docente.Size = new System.Drawing.Size(149, 20);
            this.txt_Docente.TabIndex = 10;
            this.txt_Docente.TextChanged += new System.EventHandler(this.txt_Docente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(-3, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Asignatura :";
            // 
            // txt_Asignatura
            // 
            this.txt_Asignatura.Location = new System.Drawing.Point(98, 157);
            this.txt_Asignatura.Name = "txt_Asignatura";
            this.txt_Asignatura.Size = new System.Drawing.Size(149, 20);
            this.txt_Asignatura.TabIndex = 12;
            this.txt_Asignatura.TextChanged += new System.EventHandler(this.txt_Asignatura_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(253, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nivel :";
            // 
            // txt_Nivel
            // 
            this.txt_Nivel.AccessibleDescription = "";
            this.txt_Nivel.Location = new System.Drawing.Point(343, 104);
            this.txt_Nivel.MaxLength = 10;
            this.txt_Nivel.Name = "txt_Nivel";
            this.txt_Nivel.Size = new System.Drawing.Size(65, 20);
            this.txt_Nivel.TabIndex = 14;
            this.txt_Nivel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(250, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sección :";
            // 
            // txt_Seccion
            // 
            this.txt_Seccion.Location = new System.Drawing.Point(343, 130);
            this.txt_Seccion.MaxLength = 5;
            this.txt_Seccion.Name = "txt_Seccion";
            this.txt_Seccion.Size = new System.Drawing.Size(65, 20);
            this.txt_Seccion.TabIndex = 16;
            this.txt_Seccion.TextChanged += new System.EventHandler(this.txt_Seccion_TextChanged);
            // 
            // cmb_periodoLectivo
            // 
            this.cmb_periodoLectivo.FormattingEnabled = true;
            this.cmb_periodoLectivo.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero"});
            this.cmb_periodoLectivo.Location = new System.Drawing.Point(343, 77);
            this.cmb_periodoLectivo.Name = "cmb_periodoLectivo";
            this.cmb_periodoLectivo.Size = new System.Drawing.Size(65, 21);
            this.cmb_periodoLectivo.TabIndex = 18;
            this.cmb_periodoLectivo.SelectedIndexChanged += new System.EventHandler(this.cmb_periodoLectivo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(250, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = " Periodo Lectivo:";
            // 
            // dtgb_miTabla
            // 
            this.dtgb_miTabla.BackgroundColor = System.Drawing.Color.Cyan;
            this.dtgb_miTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgb_miTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Aprendizajes,
            this.col_Estrategias,
            this.col_Indicadores,
            this.col_Lecciones,
            this.col_Puntos,
            this.col_SU,
            this.col_RC,
            this.col_ID,
            this.col_C,
            this.col_RE,
            this.col_Total});
            this.dtgb_miTabla.Location = new System.Drawing.Point(0, 224);
            this.dtgb_miTabla.Name = "dtgb_miTabla";
            this.dtgb_miTabla.RowHeadersWidth = 51;
            this.dtgb_miTabla.Size = new System.Drawing.Size(1122, 284);
            this.dtgb_miTabla.TabIndex = 20;
            this.dtgb_miTabla.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Suma);
            // 
            // col_Aprendizajes
            // 
            this.col_Aprendizajes.Frozen = true;
            this.col_Aprendizajes.HeaderText = "Aprendizajes esperados";
            this.col_Aprendizajes.MinimumWidth = 6;
            this.col_Aprendizajes.Name = "col_Aprendizajes";
            this.col_Aprendizajes.Width = 125;
            // 
            // col_Estrategias
            // 
            this.col_Estrategias.HeaderText = "Estrategias de Mediación";
            this.col_Estrategias.MinimumWidth = 6;
            this.col_Estrategias.Name = "col_Estrategias";
            this.col_Estrategias.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Estrategias.Width = 125;
            // 
            // col_Indicadores
            // 
            this.col_Indicadores.HeaderText = "Indicadores";
            this.col_Indicadores.MinimumWidth = 6;
            this.col_Indicadores.Name = "col_Indicadores";
            this.col_Indicadores.Width = 125;
            // 
            // col_Lecciones
            // 
            this.col_Lecciones.HeaderText = "Número de lecciones";
            this.col_Lecciones.MinimumWidth = 6;
            this.col_Lecciones.Name = "col_Lecciones";
            this.col_Lecciones.Width = 125;
            // 
            // col_Puntos
            // 
            this.col_Puntos.HeaderText = "Puntos";
            this.col_Puntos.MinimumWidth = 6;
            this.col_Puntos.Name = "col_Puntos";
            this.col_Puntos.Width = 125;
            // 
            // col_SU
            // 
            this.col_SU.HeaderText = "SU";
            this.col_SU.MinimumWidth = 6;
            this.col_SU.Name = "col_SU";
            this.col_SU.Width = 125;
            // 
            // col_RC
            // 
            this.col_RC.HeaderText = "RC";
            this.col_RC.MinimumWidth = 6;
            this.col_RC.Name = "col_RC";
            this.col_RC.Width = 125;
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "ID";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.Width = 125;
            // 
            // col_C
            // 
            this.col_C.HeaderText = "C";
            this.col_C.MinimumWidth = 6;
            this.col_C.Name = "col_C";
            this.col_C.Width = 125;
            // 
            // col_RE
            // 
            this.col_RE.HeaderText = "RE";
            this.col_RE.MinimumWidth = 6;
            this.col_RE.Name = "col_RE";
            this.col_RE.Width = 125;
            // 
            // col_Total
            // 
            this.col_Total.HeaderText = "Total Asignado";
            this.col_Total.MinimumWidth = 6;
            this.col_Total.Name = "col_Total";
            this.col_Total.ReadOnly = true;
            this.col_Total.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(-3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(98, 100);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(149, 20);
            this.txt_Email.TabIndex = 22;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // btn_TipodeItem
            // 
            this.btn_TipodeItem.BackColor = System.Drawing.Color.Cyan;
            this.btn_TipodeItem.Location = new System.Drawing.Point(541, 204);
            this.btn_TipodeItem.Name = "btn_TipodeItem";
            this.btn_TipodeItem.Size = new System.Drawing.Size(502, 23);
            this.btn_TipodeItem.TabIndex = 23;
            this.btn_TipodeItem.Text = "Tipo de item seleccionado";
            this.btn_TipodeItem.UseVisualStyleBackColor = false;
            this.btn_TipodeItem.Click += new System.EventHandler(this.btn_TipodeItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Total de lecciones:";
            // 
            // txt_TotaldeLecciones
            // 
            this.txt_TotaldeLecciones.Location = new System.Drawing.Point(123, 68);
            this.txt_TotaldeLecciones.Name = "txt_TotaldeLecciones";
            this.txt_TotaldeLecciones.Size = new System.Drawing.Size(49, 20);
            this.txt_TotaldeLecciones.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Cyan;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Puntuación preliminar:";
            // 
            // txt_Puntuación
            // 
            this.txt_Puntuación.Location = new System.Drawing.Point(123, 42);
            this.txt_Puntuación.Name = "txt_Puntuación";
            this.txt_Puntuación.Size = new System.Drawing.Size(49, 20);
            this.txt_Puntuación.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Valor porcentual:";
            // 
            // txt_valorPorcentual
            // 
            this.txt_valorPorcentual.Location = new System.Drawing.Point(123, 19);
            this.txt_valorPorcentual.Name = "txt_valorPorcentual";
            this.txt_valorPorcentual.Size = new System.Drawing.Size(49, 20);
            this.txt_valorPorcentual.TabIndex = 24;
            this.txt_valorPorcentual.TextChanged += new System.EventHandler(this.txt_valorPorcentual_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Cyan;
            this.label10.Location = new System.Drawing.Point(6, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Constante a utilizar:";
            // 
            // txt_Constante
            // 
            this.txt_Constante.Location = new System.Drawing.Point(123, 94);
            this.txt_Constante.Name = "txt_Constante";
            this.txt_Constante.Size = new System.Drawing.Size(49, 20);
            this.txt_Constante.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cyan;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Constante);
            this.groupBox1.Controls.Add(this.txt_valorPorcentual);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Puntuación);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_TotaldeLecciones);
            this.groupBox1.Location = new System.Drawing.Point(925, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 123);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.Cyan;
            this.btn_Calcular.Location = new System.Drawing.Point(1022, 514);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(100, 23);
            this.btn_Calcular.TabIndex = 33;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Especificaciones
            // 
            this.lbl_Especificaciones.AutoSize = true;
            this.lbl_Especificaciones.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Especificaciones.Location = new System.Drawing.Point(41, 199);
            this.lbl_Especificaciones.Name = "lbl_Especificaciones";
            this.lbl_Especificaciones.Size = new System.Drawing.Size(145, 26);
            this.lbl_Especificaciones.TabIndex = 34;
            this.lbl_Especificaciones.Text = "Tabla de especificaciones \r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(253, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Prueba:";
            // 
            // txt_Prueba
            // 
            this.txt_Prueba.AccessibleDescription = "";
            this.txt_Prueba.Location = new System.Drawing.Point(343, 159);
            this.txt_Prueba.MaxLength = 10;
            this.txt_Prueba.Name = "txt_Prueba";
            this.txt_Prueba.Size = new System.Drawing.Size(65, 20);
            this.txt_Prueba.TabIndex = 36;
            this.txt_Prueba.TextChanged += new System.EventHandler(this.txt_Prueba_TextChanged);
            // 
            // cmb_Supervision
            // 
            this.cmb_Supervision.FormattingEnabled = true;
            this.cmb_Supervision.Items.AddRange(new object[] {
            "Supervisión de Centros Educativos Circuito 01",
            "Supervisión de Centros Educativos Circuito 02",
            "Supervisión de Centros Educativos Circuito 03",
            "Supervisión de Centros Educativos Circuito 04",
            "Supervisión de Centros Educativos Circuito 05",
            "Supervisión de Centros Educativos Circuito 06",
            "Supervisión de Centros Educativos Circuito 07",
            "Supervisión de Centros Educativos Circuito 08",
            "Supervisión de Centros Educativos Circuito 09",
            "Supervisión de Centros Educativos Circuito 10",
            "Supervisión de Centros Educativos Circuito 11",
            "Supervisión de Centros Educativos Circuito 12",
            "Supervisión de Centros Educativos Circuito 13",
            "Supervisión de Centros Educativos Circuito 14",
            "Supervisión de Centros Educativos Circuito 15",
            "Supervisión de Centros Educativos Circuito 16",
            "Supervisión de Centros Educativos Circuito 17",
            "Supervisión de Centros Educativos Circuito 18",
            "Supervisión de Centros Educativos Circuito 19",
            "Supervisión de Centros Educativos Circuito 20",
            "Supervisión de Centros Educativos Circuito 21",
            "Supervisión de Centros Educativos Circuito 22",
            "Supervisión de Centros Educativos Circuito 23",
            "Supervisión de Centros Educativos Circuito 24",
            "Supervisión de Centros Educativos Circuito 25",
            "Supervisión de Centros Educativos Circuito 26",
            "Supervisión de Centros Educativos Circuito 27"});
            this.cmb_Supervision.Location = new System.Drawing.Point(0, 48);
            this.cmb_Supervision.Name = "cmb_Supervision";
            this.cmb_Supervision.Size = new System.Drawing.Size(408, 21);
            this.cmb_Supervision.TabIndex = 37;
            this.cmb_Supervision.Text = "Supervisión de Centros Educativos Circuito 01";
            this.cmb_Supervision.SelectedIndexChanged += new System.EventHandler(this.cmb_Supervision_SelectedIndexChanged);
            // 
            // btn_cambiarImagen
            // 
            this.btn_cambiarImagen.BackColor = System.Drawing.Color.Cyan;
            this.btn_cambiarImagen.Location = new System.Drawing.Point(425, 149);
            this.btn_cambiarImagen.Name = "btn_cambiarImagen";
            this.btn_cambiarImagen.Size = new System.Drawing.Size(179, 23);
            this.btn_cambiarImagen.TabIndex = 39;
            this.btn_cambiarImagen.Text = "Seleccione el logo de la institución";
            this.btn_cambiarImagen.UseVisualStyleBackColor = false;
            this.btn_cambiarImagen.Click += new System.EventHandler(this.btn_cambiarImagen_Click);
            // 
            // pbx_cambiarImagen
            // 
            this.pbx_cambiarImagen.Image = global::Proyecto.Properties.Resources.índice;
            this.pbx_cambiarImagen.Location = new System.Drawing.Point(425, 24);
            this.pbx_cambiarImagen.Name = "pbx_cambiarImagen";
            this.pbx_cambiarImagen.Size = new System.Drawing.Size(179, 123);
            this.pbx_cambiarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_cambiarImagen.TabIndex = 38;
            this.pbx_cambiarImagen.TabStop = false;
            this.pbx_cambiarImagen.Click += new System.EventHandler(this.pbx_cambiarImagen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1134, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1028, 550);
            this.Controls.Add(this.btn_cambiarImagen);
            this.Controls.Add(this.pbx_cambiarImagen);
            this.Controls.Add(this.cmb_Supervision);
            this.Controls.Add(this.txt_Prueba);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_Especificaciones);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_TipodeItem);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgb_miTabla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_periodoLectivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Seccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Asignatura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Docente);
            this.Controls.Add(this.lbl_CentroEducativo);
            this.Controls.Add(this.txt_CentroEducativo);
            this.Controls.Add(this.dtp_Calendario);
            this.Controls.Add(this.cmb_Direccion);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planificador Didáctico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgb_miTabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_cambiarImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmb_Direccion;
        private System.Windows.Forms.DateTimePicker dtp_Calendario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_CentroEducativo;
        private System.Windows.Forms.Label lbl_CentroEducativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Docente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Asignatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Seccion;
        private System.Windows.Forms.ComboBox cmb_periodoLectivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgb_miTabla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_TipodeItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TotaldeLecciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Puntuación;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_valorPorcentual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Constante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Especificaciones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Prueba;
        private System.Windows.Forms.ComboBox cmb_Supervision;
        private System.Windows.Forms.PictureBox pbx_cambiarImagen;
        private System.Windows.Forms.Button btn_cambiarImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Aprendizajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Estrategias;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Indicadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Lecciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SU;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Total;
    }
}


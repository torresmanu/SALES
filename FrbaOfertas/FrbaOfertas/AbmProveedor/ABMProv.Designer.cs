﻿namespace FrbaOfertas.AbmProveedor
{
    partial class ABMProv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mostrarHabilitados = new System.Windows.Forms.CheckBox();
            this.mostrarInhabilitados = new System.Windows.Forms.CheckBox();
            this.localidad = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.nombre_de_contacto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.codigo_postal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.razonSocial = new System.Windows.Forms.TextBox();
            this.mostrarMas = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cuit = new System.Windows.Forms.TextBox();
            this.rubro = new System.Windows.Forms.ComboBox();
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2019DataSet = new FrbaOfertas.GD2C2019DataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.ProvExistentes = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.rubroTableAdapter = new FrbaOfertas.GD2C2019DataSetTableAdapters.RubroTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).BeginInit();
            this.ProvExistentes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.mostrarHabilitados);
            this.groupBox1.Controls.Add(this.mostrarInhabilitados);
            this.groupBox1.Controls.Add(this.localidad);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ciudad);
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.nombre_de_contacto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.text3);
            this.groupBox1.Controls.Add(this.codigo_postal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 695);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1281, 153);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mostrarHabilitados
            // 
            this.mostrarHabilitados.AutoSize = true;
            this.mostrarHabilitados.Checked = true;
            this.mostrarHabilitados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostrarHabilitados.Location = new System.Drawing.Point(1067, 69);
            this.mostrarHabilitados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mostrarHabilitados.Name = "mostrarHabilitados";
            this.mostrarHabilitados.Size = new System.Drawing.Size(152, 21);
            this.mostrarHabilitados.TabIndex = 50;
            this.mostrarHabilitados.Text = "Mostrar Habilitados";
            this.mostrarHabilitados.UseVisualStyleBackColor = true;
            // 
            // mostrarInhabilitados
            // 
            this.mostrarInhabilitados.AutoSize = true;
            this.mostrarInhabilitados.Location = new System.Drawing.Point(1067, 96);
            this.mostrarInhabilitados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mostrarInhabilitados.Name = "mostrarInhabilitados";
            this.mostrarInhabilitados.Size = new System.Drawing.Size(161, 21);
            this.mostrarInhabilitados.TabIndex = 49;
            this.mostrarInhabilitados.Text = "Mostrar Inhabilitados";
            this.mostrarInhabilitados.UseVisualStyleBackColor = true;
            // 
            // localidad
            // 
            this.localidad.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidad.Location = new System.Drawing.Point(752, 47);
            this.localidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(231, 25);
            this.localidad.TabIndex = 46;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(465, 47);
            this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(231, 25);
            this.email.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(461, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Email";
            // 
            // ciudad
            // 
            this.ciudad.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudad.Location = new System.Drawing.Point(467, 98);
            this.ciudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(231, 25);
            this.ciudad.TabIndex = 43;
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(187, 44);
            this.telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(231, 25);
            this.telefono.TabIndex = 36;
            // 
            // nombre_de_contacto
            // 
            this.nombre_de_contacto.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_de_contacto.Location = new System.Drawing.Point(187, 98);
            this.nombre_de_contacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre_de_contacto.Name = "nombre_de_contacto";
            this.nombre_de_contacto.Size = new System.Drawing.Size(231, 25);
            this.nombre_de_contacto.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(749, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Codigo Postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ciudad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Nombre de contacto";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.text3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.Location = new System.Drawing.Point(184, 26);
            this.text3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(71, 20);
            this.text3.TabIndex = 35;
            this.text3.Text = "Telefono";
            // 
            // codigo_postal
            // 
            this.codigo_postal.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_postal.Location = new System.Drawing.Point(753, 98);
            this.codigo_postal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codigo_postal.Name = "codigo_postal";
            this.codigo_postal.Size = new System.Drawing.Size(231, 25);
            this.codigo_postal.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(749, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Localidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Razon Social";
            // 
            // razonSocial
            // 
            this.razonSocial.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razonSocial.Location = new System.Drawing.Point(21, 43);
            this.razonSocial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.Size = new System.Drawing.Size(231, 25);
            this.razonSocial.TabIndex = 31;
            // 
            // mostrarMas
            // 
            this.mostrarMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarMas.Location = new System.Drawing.Point(533, 94);
            this.mostrarMas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mostrarMas.Name = "mostrarMas";
            this.mostrarMas.Size = new System.Drawing.Size(125, 23);
            this.mostrarMas.TabIndex = 51;
            this.mostrarMas.Text = "▼  Más filtros";
            this.mostrarMas.UseVisualStyleBackColor = true;
            this.mostrarMas.Click += new System.EventHandler(this.mostrarMas_Click);
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(277, 43);
            this.usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(231, 25);
            this.usuario.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Usuario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(275, 71);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "CUIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Rubro";
            // 
            // cuit
            // 
            this.cuit.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuit.Location = new System.Drawing.Point(277, 91);
            this.cuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(231, 25);
            this.cuit.TabIndex = 37;
            // 
            // rubro
            // 
            this.rubro.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rubro.FormattingEnabled = true;
            this.rubro.Location = new System.Drawing.Point(21, 89);
            this.rubro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(231, 27);
            this.rubro.TabIndex = 41;
            // 
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataMember = "Rubro";
            this.rubroBindingSource.DataSource = this.gD2C2019DataSet;
            // 
            // gD2C2019DataSet
            // 
            this.gD2C2019DataSet.DataSetName = "GD2C2019DataSet";
            this.gD2C2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(533, 43);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 43);
            this.button2.TabIndex = 53;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProvExistentes
            // 
            this.ProvExistentes.Controls.Add(this.button4);
            this.ProvExistentes.Controls.Add(this.button3);
            this.ProvExistentes.Controls.Add(this.groupBox2);
            this.ProvExistentes.Controls.Add(this.dataGridView1);
            this.ProvExistentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvExistentes.Location = new System.Drawing.Point(12, 117);
            this.ProvExistentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProvExistentes.Name = "ProvExistentes";
            this.ProvExistentes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProvExistentes.Size = new System.Drawing.Size(1281, 572);
            this.ProvExistentes.TabIndex = 54;
            this.ProvExistentes.TabStop = false;
            this.ProvExistentes.Text = "Proveedores Existentes";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(27, 516);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(306, 39);
            this.button4.TabIndex = 35;
            this.button4.Text = "Habilitar / Inhabilitar Seleccionado";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(27, 462);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(306, 39);
            this.button3.TabIndex = 34;
            this.button3.Text = "Modificar Seleccionado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.razonSocial);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.rubro);
            this.groupBox2.Controls.Add(this.cuit);
            this.groupBox2.Controls.Add(this.mostrarMas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.usuario);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Location = new System.Drawing.Point(555, 426);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(691, 129);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(27, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1219, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(943, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 64);
            this.button1.TabIndex = 55;
            this.button1.Text = " + NUEVO PROVEEDOR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rubroTableAdapter
            // 
            this.rubroTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 51);
            this.label3.TabIndex = 56;
            this.label3.Text = "Nota: debido al cambio de Sistema Informático, se les asignó la\r\ncontraseña FRBA2" +
    "019 a los Proveedores preexistenes, junto a un\r\nusaurio autogenerado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ABMProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1305, 873);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProvExistentes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ABMProv";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "label";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ABMProv_FormClosed);
            this.Load += new System.EventHandler(this.ABMProv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).EndInit();
            this.ProvExistentes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mostrarMas;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre_de_contacto;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox localidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cuit;
        private System.Windows.Forms.TextBox codigo_postal;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.ComboBox rubro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox razonSocial;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox mostrarInhabilitados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox ProvExistentes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox mostrarHabilitados;
        private GD2C2019DataSet gD2C2019DataSet;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private GD2C2019DataSetTableAdapters.RubroTableAdapter rubroTableAdapter;
        private System.Windows.Forms.Label label3;
    }
}
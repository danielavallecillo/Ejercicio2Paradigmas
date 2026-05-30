namespace Ejercicio2Paradigmas.vista
{
    partial class producto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            button1 = new Button();
            buttonMostrar = new Button();
            buttonCerrar = new Button();
            dataGridView1 = new DataGridView();
            MasCaro = new Button();
            MasBarato = new Button();
            Promedio = new Button();
            textBoxBuscar = new TextBox();
            Buscar = new Button();
            Ordenar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 109);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 175);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 249);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 325);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 4;
            label5.Text = "Stock";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(376, 27);
            textBox2.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(173, 242);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(173, 318);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(56, 406);
            button1.Name = "button1";
            button1.Size = new Size(221, 29);
            button1.TabIndex = 9;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonMostrar
            // 
            buttonMostrar.BackColor = Color.LightPink;
            buttonMostrar.FlatStyle = FlatStyle.Flat;
            buttonMostrar.Location = new Point(328, 406);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(221, 29);
            buttonMostrar.TabIndex = 10;
            buttonMostrar.Text = "Mostrar";
            buttonMostrar.UseVisualStyleBackColor = false;
            buttonMostrar.Click += buttonMostrar_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Location = new Point(1056, 603);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(150, 29);
            buttonCerrar.TabIndex = 11;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(620, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(586, 382);
            dataGridView1.TabIndex = 12;
            // 
            // MasCaro
            // 
            MasCaro.BackColor = Color.LightPink;
            MasCaro.FlatStyle = FlatStyle.Flat;
            MasCaro.Location = new Point(837, 501);
            MasCaro.Name = "MasCaro";
            MasCaro.Size = new Size(163, 29);
            MasCaro.TabIndex = 13;
            MasCaro.Text = "Producto mas caro";
            MasCaro.UseVisualStyleBackColor = false;
            MasCaro.Click += MasCaro_Click;
            // 
            // MasBarato
            // 
            MasBarato.BackColor = Color.LightPink;
            MasBarato.FlatStyle = FlatStyle.Flat;
            MasBarato.Location = new Point(1043, 501);
            MasBarato.Name = "MasBarato";
            MasBarato.Size = new Size(163, 29);
            MasBarato.TabIndex = 14;
            MasBarato.Text = "Producto mas barato";
            MasBarato.UseVisualStyleBackColor = false;
            MasBarato.Click += MasBarato_Click;
            // 
            // Promedio
            // 
            Promedio.BackColor = Color.LightPink;
            Promedio.FlatStyle = FlatStyle.Flat;
            Promedio.Location = new Point(620, 501);
            Promedio.Name = "Promedio";
            Promedio.Size = new Size(163, 29);
            Promedio.TabIndex = 15;
            Promedio.Text = "Calcular Promedio";
            Promedio.UseVisualStyleBackColor = false;
            Promedio.Click += Promedio_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(620, 67);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(263, 27);
            textBoxBuscar.TabIndex = 16;
            // 
            // Buscar
            // 
            Buscar.BackColor = SystemColors.ActiveCaptionText;
            Buscar.FlatStyle = FlatStyle.Flat;
            Buscar.ForeColor = SystemColors.ButtonHighlight;
            Buscar.Location = new Point(889, 67);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(136, 29);
            Buscar.TabIndex = 17;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = false;
            Buscar.Click += Buscar_Click;
            // 
            // Ordenar
            // 
            Ordenar.Location = new Point(1031, 65);
            Ordenar.Name = "Ordenar";
            Ordenar.Size = new Size(175, 29);
            Ordenar.TabIndex = 18;
            Ordenar.Text = "Ordenar por precio";
            Ordenar.UseVisualStyleBackColor = true;
            Ordenar.Click += Ordenar_Click;
            // 
            // producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 644);
            Controls.Add(Ordenar);
            Controls.Add(Buscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(Promedio);
            Controls.Add(MasBarato);
            Controls.Add(MasCaro);
            Controls.Add(dataGridView1);
            Controls.Add(buttonCerrar);
            Controls.Add(buttonMostrar);
            Controls.Add(button1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "producto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "producto";
            Load += producto_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Button button1;
        private Button buttonMostrar;
        private Button buttonCerrar;
        private DataGridView dataGridView1;
        private Button MasCaro;
        private Button MasBarato;
        private Button Promedio;
        private TextBox textBoxBuscar;
        private Button Buscar;
        private Button Ordenar;
    }
}
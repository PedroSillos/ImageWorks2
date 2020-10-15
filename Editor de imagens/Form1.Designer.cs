namespace Editor_de_imagens
{
    partial class EditorDeImagem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_carregar_imagem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_alterar_imagem = new System.Windows.Forms.Button();
            this.rbtn_escurecer = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chart_imagem_cortada = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbtn_clarear = new System.Windows.Forms.RadioButton();
            this.chart_imagem_alterada = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_suavizar = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.rbtn_mediana = new System.Windows.Forms.RadioButton();
            this.rbtn_media = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button_realcar = new System.Windows.Forms.Button();
            this.rbtn_equalizar = new System.Windows.Forms.RadioButton();
            this.btn_realcar_bordas = new System.Windows.Forms.Button();
            this.btn_passa_alta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_imagem_cortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_imagem_alterada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_carregar_imagem
            // 
            this.button_carregar_imagem.AccessibleName = "button_carregar_imagem";
            this.button_carregar_imagem.AutoSize = true;
            this.button_carregar_imagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_carregar_imagem.Location = new System.Drawing.Point(30, 12);
            this.button_carregar_imagem.Name = "button_carregar_imagem";
            this.button_carregar_imagem.Size = new System.Drawing.Size(127, 27);
            this.button_carregar_imagem.TabIndex = 0;
            this.button_carregar_imagem.TabStop = false;
            this.button_carregar_imagem.Text = "Carregar imagem";
            this.button_carregar_imagem.UseVisualStyleBackColor = true;
            this.button_carregar_imagem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_carregar_imagem_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(163, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_alterar_imagem
            // 
            this.button_alterar_imagem.AccessibleName = "button_alterar_imagem";
            this.button_alterar_imagem.AutoSize = true;
            this.button_alterar_imagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_alterar_imagem.Location = new System.Drawing.Point(529, 95);
            this.button_alterar_imagem.Name = "button_alterar_imagem";
            this.button_alterar_imagem.Size = new System.Drawing.Size(127, 27);
            this.button_alterar_imagem.TabIndex = 3;
            this.button_alterar_imagem.TabStop = false;
            this.button_alterar_imagem.Text = "Alterar imagem";
            this.button_alterar_imagem.UseVisualStyleBackColor = true;
            this.button_alterar_imagem.Click += new System.EventHandler(this.button_alterar_imagem_Click);
            // 
            // rbtn_escurecer
            // 
            this.rbtn_escurecer.AutoSize = true;
            this.rbtn_escurecer.Location = new System.Drawing.Point(538, 13);
            this.rbtn_escurecer.Name = "rbtn_escurecer";
            this.rbtn_escurecer.Size = new System.Drawing.Size(93, 21);
            this.rbtn_escurecer.TabIndex = 4;
            this.rbtn_escurecer.Text = "Escurecer";
            this.rbtn_escurecer.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(662, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 360);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // chart_imagem_cortada
            // 
            this.chart_imagem_cortada.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.chart_imagem_cortada.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_imagem_cortada.Legends.Add(legend5);
            this.chart_imagem_cortada.Location = new System.Drawing.Point(163, 378);
            this.chart_imagem_cortada.Name = "chart_imagem_cortada";
            series5.ChartArea = "ChartArea1";
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Cortada";
            this.chart_imagem_cortada.Series.Add(series5);
            this.chart_imagem_cortada.Size = new System.Drawing.Size(360, 153);
            this.chart_imagem_cortada.TabIndex = 8;
            this.chart_imagem_cortada.TabStop = false;
            this.chart_imagem_cortada.Text = "chart_imagem_cortada";
            // 
            // rbtn_clarear
            // 
            this.rbtn_clarear.AutoSize = true;
            this.rbtn_clarear.Location = new System.Drawing.Point(538, 40);
            this.rbtn_clarear.Name = "rbtn_clarear";
            this.rbtn_clarear.Size = new System.Drawing.Size(75, 21);
            this.rbtn_clarear.TabIndex = 10;
            this.rbtn_clarear.Text = "Clarear";
            this.rbtn_clarear.UseVisualStyleBackColor = true;
            // 
            // chart_imagem_alterada
            // 
            this.chart_imagem_alterada.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.chart_imagem_alterada.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_imagem_alterada.Legends.Add(legend6);
            this.chart_imagem_alterada.Location = new System.Drawing.Point(662, 378);
            this.chart_imagem_alterada.Name = "chart_imagem_alterada";
            series6.ChartArea = "ChartArea1";
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Cortada";
            this.chart_imagem_alterada.Series.Add(series6);
            this.chart_imagem_alterada.Size = new System.Drawing.Size(360, 153);
            this.chart_imagem_alterada.TabIndex = 11;
            this.chart_imagem_alterada.TabStop = false;
            this.chart_imagem_alterada.Text = "chart_imagem_alterada";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(529, 67);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(127, 22);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Tag = "";
            // 
            // button_suavizar
            // 
            this.button_suavizar.AccessibleName = "button_suavizar";
            this.button_suavizar.AutoSize = true;
            this.button_suavizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_suavizar.Location = new System.Drawing.Point(529, 227);
            this.button_suavizar.Name = "button_suavizar";
            this.button_suavizar.Size = new System.Drawing.Size(127, 27);
            this.button_suavizar.TabIndex = 13;
            this.button_suavizar.TabStop = false;
            this.button_suavizar.Text = "Suavizar";
            this.button_suavizar.UseVisualStyleBackColor = true;
            this.button_suavizar.Click += new System.EventHandler(this.button_suavizar_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(529, 145);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(127, 22);
            this.numericUpDown2.TabIndex = 16;
            this.numericUpDown2.TabStop = false;
            this.numericUpDown2.Tag = "";
            this.numericUpDown2.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // rbtn_mediana
            // 
            this.rbtn_mediana.AutoSize = true;
            this.rbtn_mediana.Location = new System.Drawing.Point(538, 200);
            this.rbtn_mediana.Name = "rbtn_mediana";
            this.rbtn_mediana.Size = new System.Drawing.Size(83, 21);
            this.rbtn_mediana.TabIndex = 15;
            this.rbtn_mediana.Text = "Mediana";
            this.rbtn_mediana.UseVisualStyleBackColor = true;
            // 
            // rbtn_media
            // 
            this.rbtn_media.AutoSize = true;
            this.rbtn_media.Location = new System.Drawing.Point(538, 173);
            this.rbtn_media.Name = "rbtn_media";
            this.rbtn_media.Size = new System.Drawing.Size(67, 21);
            this.rbtn_media.TabIndex = 14;
            this.rbtn_media.Text = "Media";
            this.rbtn_media.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Vizinhança:";
            // 
            // button_realcar
            // 
            this.button_realcar.AccessibleName = "button_realcar";
            this.button_realcar.AutoSize = true;
            this.button_realcar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_realcar.Location = new System.Drawing.Point(529, 320);
            this.button_realcar.Name = "button_realcar";
            this.button_realcar.Size = new System.Drawing.Size(127, 27);
            this.button_realcar.TabIndex = 19;
            this.button_realcar.TabStop = false;
            this.button_realcar.Text = "Realçar";
            this.button_realcar.UseVisualStyleBackColor = true;
            this.button_realcar.Click += new System.EventHandler(this.button_realcar_Click);
            // 
            // rbtn_equalizar
            // 
            this.rbtn_equalizar.AutoSize = true;
            this.rbtn_equalizar.Location = new System.Drawing.Point(538, 293);
            this.rbtn_equalizar.Name = "rbtn_equalizar";
            this.rbtn_equalizar.Size = new System.Drawing.Size(106, 21);
            this.rbtn_equalizar.TabIndex = 20;
            this.rbtn_equalizar.Text = "Equalização";
            this.rbtn_equalizar.UseVisualStyleBackColor = true;
            // 
            // btn_realcar_bordas
            // 
            this.btn_realcar_bordas.AccessibleName = "button_realcar";
            this.btn_realcar_bordas.AutoSize = true;
            this.btn_realcar_bordas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_realcar_bordas.Location = new System.Drawing.Point(529, 378);
            this.btn_realcar_bordas.Name = "btn_realcar_bordas";
            this.btn_realcar_bordas.Size = new System.Drawing.Size(127, 27);
            this.btn_realcar_bordas.TabIndex = 21;
            this.btn_realcar_bordas.TabStop = false;
            this.btn_realcar_bordas.Text = "Gradiente";
            this.btn_realcar_bordas.UseVisualStyleBackColor = true;
            this.btn_realcar_bordas.Click += new System.EventHandler(this.btn_realcar_bordas_Click);
            // 
            // btn_passa_alta
            // 
            this.btn_passa_alta.AccessibleName = "button_realcar";
            this.btn_passa_alta.AutoSize = true;
            this.btn_passa_alta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_passa_alta.Location = new System.Drawing.Point(529, 260);
            this.btn_passa_alta.Name = "btn_passa_alta";
            this.btn_passa_alta.Size = new System.Drawing.Size(127, 27);
            this.btn_passa_alta.TabIndex = 22;
            this.btn_passa_alta.TabStop = false;
            this.btn_passa_alta.Text = "Passa alta";
            this.btn_passa_alta.UseVisualStyleBackColor = true;
            this.btn_passa_alta.Click += new System.EventHandler(this.btn_passa_alta_Click);
            // 
            // EditorDeImagem
            // 
            this.AccessibleName = "EditorDeImagem";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 543);
            this.Controls.Add(this.btn_passa_alta);
            this.Controls.Add(this.btn_realcar_bordas);
            this.Controls.Add(this.rbtn_equalizar);
            this.Controls.Add(this.button_realcar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.rbtn_mediana);
            this.Controls.Add(this.rbtn_media);
            this.Controls.Add(this.button_suavizar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.chart_imagem_alterada);
            this.Controls.Add(this.rbtn_clarear);
            this.Controls.Add(this.chart_imagem_cortada);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rbtn_escurecer);
            this.Controls.Add(this.button_alterar_imagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_carregar_imagem);
            this.Name = "EditorDeImagem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Imagens";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_imagem_cortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_imagem_alterada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_carregar_imagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_alterar_imagem;
        private System.Windows.Forms.RadioButton rbtn_escurecer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_imagem_cortada;
        private System.Windows.Forms.RadioButton rbtn_clarear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_imagem_alterada;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_suavizar;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RadioButton rbtn_mediana;
        private System.Windows.Forms.RadioButton rbtn_media;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_realcar;
        private System.Windows.Forms.RadioButton rbtn_equalizar;
        private System.Windows.Forms.Button btn_realcar_bordas;
        private System.Windows.Forms.Button btn_passa_alta;
    }
}


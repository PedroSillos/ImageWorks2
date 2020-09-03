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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_imagem_cortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_imagem_alterada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.button_alterar_imagem.Location = new System.Drawing.Point(529, 100);
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
            this.rbtn_escurecer.Location = new System.Drawing.Point(538, 18);
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
            this.rbtn_clarear.Location = new System.Drawing.Point(538, 45);
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
            this.numericUpDown1.Location = new System.Drawing.Point(529, 72);
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
            // EditorDeImagem
            // 
            this.AccessibleName = "EditorDeImagem";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 543);
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
    }
}


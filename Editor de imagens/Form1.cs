using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_imagens
{
    public partial class EditorDeImagem : Form
    {
        public EditorDeImagem()
        {
            InitializeComponent();
        }

        private void button_carregar_imagem_MouseClick(object sender, MouseEventArgs e)
        {
            //zera a imagem, caso usem o botão dnv
            pictureBox1.Image = null;
            pictureBox2.Image = null;

            //zera o chat, caso usem o botão dnv
            chart_imagem_cortada.Series["Cortada"].Points.Clear();
            chart_imagem_alterada.Series["Cortada"].Points.Clear();

            //zera o valor da caixa de numero
            numericUpDown1.Value = 0;

            //zera os radio buttons
            rbtn_clarear.Checked = false;
            rbtn_escurecer.Checked = false;

            //abre o open file dialog
            OpenFileDialog dialog_carregar_imagem = new OpenFileDialog();
            //só deixa pegar imagens
            dialog_carregar_imagem.Filter = "Image |*.png;*.jpg;*.jpeg";

            //se pegar uma imagem
            if (dialog_carregar_imagem.ShowDialog() == DialogResult.OK) {
                //pega o endereço da imagem
                string endereco_da_imagem_original = dialog_carregar_imagem.FileName;
                //transforma a imagem do endereço em bitmap
                Bitmap imagem_original = new Bitmap(endereco_da_imagem_original);
                //cria um novo bitmap para a imagem cortada
                int altura = 360, largura = 360;
                Bitmap imagem_cortada = new Bitmap(largura, altura);
                //definir os deslocamentos
                int descolamento_para_direita = 400, descolamento_para_baixo = 150;
                //cria uma lista para contar quantas vezes cada cor apareceu
                int[] ocorrencias = new int[256];

                //copiar os pixels da imagem original para a cortada um por um
                for (int coluna = 0; coluna < largura; coluna++)
                {
                    for (int linha = 0; linha < altura; linha++)
                    {
                        //pega a cor (ARGB) a partir da coluna, linha e deslocamentos
                        Color cor_do_pixel_argb = imagem_original.GetPixel(coluna + descolamento_para_direita, linha + descolamento_para_baixo);
                        
                        //desenha a imagem cortada pixel por pixel
                        imagem_cortada.SetPixel(coluna, linha, cor_do_pixel_argb);
                                                
                        //Pega a cor vermelha do pixel, transforma em string e corta o inteiro relativo a cor
                        int cor_do_pixel = Convert.ToInt32(cor_do_pixel_argb.R.ToString());
                        //a cada ocorrencia da cor na imagem, somamos 1 no seu valor
                        ocorrencias[cor_do_pixel] = ocorrencias[cor_do_pixel] + 1;
                    }
                }
                //joga o bitmap imagem_cortada na picturebox
                pictureBox1.Image = imagem_cortada;

                for (int i = 0; i < ocorrencias.Length; i++) {
                    chart_imagem_cortada.Series["Cortada"].Points.AddXY(i, ocorrencias[i]);
                }
            }
        }

        private void button_alterar_imagem_Click(object sender, EventArgs e)
        {
            //zera a imagem, caso usem o botão dnv
            pictureBox2.Image = null;
            //zera o chat, caso usem o botão dnv
            chart_imagem_alterada.Series["Cortada"].Points.Clear();

            if (rbtn_escurecer.Checked == true)
            {
                //transforma a imagem da picture box da esquerda em bit map
                Bitmap imagem_cortada = new Bitmap(pictureBox1.Image);
                //cria um novo bitmap para a imagem alterada
                int altura = 360, largura = 360;
                Bitmap imagem_alterada = new Bitmap(largura, altura);
                //cria uma lista para contar quantas vezes cada cor apareceu
                int[] ocorrencias = new int[256];

                //armazena a taxa de escurecimento
                int escurecimento =  Convert.ToInt32(numericUpDown1.Value);

                //copiar os pixels da imagem cortada para a alterada um por um
                for (int coluna = 0; coluna < largura; coluna++)
                {
                    for (int linha = 0; linha < altura; linha++)
                    {
                        //pega a cor (ARGB) a partir da coluna e linha
                        Color cor_do_pixel_argb = imagem_cortada.GetPixel(coluna, linha);
                        
                        int alpha_alterada = Convert.ToInt32(cor_do_pixel_argb.A.ToString());

                        //if para evitar que a cor fique abaixo de 0
                        int red_alterada = 0;
                        if (Convert.ToInt32(cor_do_pixel_argb.R.ToString()) - escurecimento >= 0)
                        {
                            red_alterada = Convert.ToInt32(cor_do_pixel_argb.R.ToString()) - escurecimento;
                        }
                        int green_alterada = 0;
                        if (Convert.ToInt32(cor_do_pixel_argb.G.ToString()) - escurecimento >= 0)
                        {
                            green_alterada = Convert.ToInt32(cor_do_pixel_argb.G.ToString()) - escurecimento;
                        }
                        int blue_alterada = 0;
                        if (Convert.ToInt32(cor_do_pixel_argb.B.ToString()) - escurecimento >= 0)
                        {
                            blue_alterada = Convert.ToInt32(cor_do_pixel_argb.B.ToString()) - escurecimento;
                        }

                        //cria uma nova cor com os bytes definidos acima
                        Color cor_alterada_argb = new Color();
                        cor_alterada_argb = Color.FromArgb(alpha_alterada, red_alterada, green_alterada, blue_alterada);
                        //desenha a imagem alterada pixel por pixel
                        imagem_alterada.SetPixel(coluna, linha, cor_alterada_argb);

                        //Pega a cor vermelha do pixel, transforma em string e depois em int
                        int cor_do_pixel = red_alterada;
                        //a cada ocorrencia da cor na imagem, somamos 1 no seu valor
                        ocorrencias[cor_do_pixel] = ocorrencias[cor_do_pixel] + 1;
                    }
                }

                //joga o bitmap imagem_cortada na picturebox
                pictureBox2.Image = imagem_alterada;

                for (int i = 0; i < ocorrencias.Length; i++)
                {
                    chart_imagem_alterada.Series["Cortada"].Points.AddXY(i, ocorrencias[i]);
                }
            }
            if (rbtn_clarear.Checked == true)
            {
                //transforma a imagem da picture box da esquerda em bit map
                Bitmap imagem_cortada = new Bitmap(pictureBox1.Image);
                //cria um novo bitmap para a imagem alterada
                int altura = 360, largura = 360;
                Bitmap imagem_alterada = new Bitmap(largura, altura);
                //cria uma lista para contar quantas vezes cada cor apareceu
                int[] ocorrencias = new int[256];

                //armazena a taxa de clareamento
                int clareamento = Convert.ToInt32(numericUpDown1.Value);

                //copiar os pixels da imagem cortada para a alterada um por um
                for (int coluna = 0; coluna < largura; coluna++)
                {
                    for (int linha = 0; linha < altura; linha++)
                    {
                        //pega a cor (ARGB) a partir da coluna e linha
                        Color cor_do_pixel_argb = imagem_cortada.GetPixel(coluna, linha);
                        
                        int alpha_alterada = Convert.ToInt32(cor_do_pixel_argb.A.ToString());

                        //if para evitar que a cor fique acima de 255
                        int red_alterada = 255;
                        if (Convert.ToInt32(cor_do_pixel_argb.R.ToString()) + clareamento <= 255)
                        {
                            red_alterada = Convert.ToInt32(cor_do_pixel_argb.R.ToString()) + clareamento;
                        }
                        int green_alterada = 255;
                        if (Convert.ToInt32(cor_do_pixel_argb.G.ToString()) + clareamento <= 255)
                        {
                            green_alterada = Convert.ToInt32(cor_do_pixel_argb.G.ToString()) + clareamento;
                        }
                        int blue_alterada = 255;
                        if (Convert.ToInt32(cor_do_pixel_argb.B.ToString()) + clareamento <= 255)
                        {
                            blue_alterada = Convert.ToInt32(cor_do_pixel_argb.B.ToString()) + clareamento;
                        }

                        //cria uma nova cor com os bytes definidos acima
                        Color cor_alterada_argb = new Color();
                        cor_alterada_argb = Color.FromArgb(alpha_alterada, red_alterada, green_alterada, blue_alterada);
                        //desenha a imagem alterada pixel por pixel
                        imagem_alterada.SetPixel(coluna, linha, cor_alterada_argb);

                        //Pega a cor vermelha do pixel, transforma em string e depois em int
                        int cor_do_pixel = red_alterada;
                        //a cada ocorrencia da cor na imagem, somamos 1 no seu valor
                        ocorrencias[cor_do_pixel] = ocorrencias[cor_do_pixel] + 1;
                    }
                }

                //joga o bitmap imagem_cortada na picturebox
                pictureBox2.Image = imagem_alterada;

                for (int i = 0; i < ocorrencias.Length; i++)
                {
                    chart_imagem_alterada.Series["Cortada"].Points.AddXY(i, ocorrencias[i]);
                }
            }
        }
    }
}
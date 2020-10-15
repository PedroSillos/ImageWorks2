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
            //zera o chat, caso usem o botão dnv
            chart_imagem_alterada.Series["Cortada"].Points.Clear();

            if (rbtn_escurecer.Checked == true)
            {
                //transforma a imagem da picture box da esquerda em bit map
                Bitmap imagem_cortada;
                if (pictureBox2.Image == null)
                {
                    imagem_cortada = new Bitmap(pictureBox1.Image);
                }
                else
                {
                    imagem_cortada = new Bitmap(pictureBox2.Image);
                }
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
                Bitmap imagem_cortada;
                if (pictureBox2.Image == null)
                {
                    imagem_cortada = new Bitmap(pictureBox1.Image);
                }
                else
                {
                    imagem_cortada = new Bitmap(pictureBox2.Image);
                }
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

        private void button_suavizar_Click(object sender, EventArgs e)
        {
            //zera o chat, caso usem o botão dnv
            chart_imagem_alterada.Series["Cortada"].Points.Clear();

            if (rbtn_media.Checked == true)
            {
                //transforma a imagem da picture box da esquerda em bit map
                Bitmap imagem_antiga;
                if (pictureBox2.Image == null)
                {
                    imagem_antiga = new Bitmap(pictureBox1.Image);
                }
                else
                {
                    imagem_antiga = new Bitmap(pictureBox2.Image);
                }
                //cria um novo bitmap para a imagem alterada
                int altura = 360, largura = 360;
                Bitmap imagem_suave = new Bitmap(largura, altura);
                //cria uma lista para contar quantas vezes cada cor apareceu
                int[] ocorrencias = new int[256];

                //armazena o tamanho da vizinhança
                int vizinhanca = Convert.ToInt32(numericUpDown2.Value);

                int variacao = Convert.ToInt32(Math.Sqrt(vizinhanca + 1)) / 2;

                //esses 2 fors andam na imagem pixel por pixel
                for (int coluna = 0; coluna < largura; coluna++)
                {
                    for (int linha = 0; linha < altura; linha++)
                    {
                        int soma = 0;
                        int count = 0;
                        int cor_suave;

                        for (int vizinho_horizontal = coluna - variacao; vizinho_horizontal <= coluna + variacao; vizinho_horizontal += 1)
                        {
                            for (int vizinho_vertical = linha - variacao; vizinho_vertical <= linha + variacao; vizinho_vertical += 1)
                            {
                                if (vizinho_horizontal >= 0 && vizinho_vertical >= 0)
                                {
                                    if (vizinho_horizontal <= coluna && vizinho_vertical <= linha)
                                    {
                                        Color cor_do_pixel_argb = imagem_antiga.GetPixel(vizinho_horizontal, vizinho_vertical);
                                        soma += Convert.ToInt32(cor_do_pixel_argb.R.ToString());
                                        count += 1;
                                    }
                                }
                            }
                        }
                        if (count == 0) { cor_suave = 0; }
                        else
                        {
                            cor_suave = soma / count;
                        }
                        //Cria uma nova cor com os bytes definidos acima
                        Color cor_suave_argb = new Color();
                        //Alpha 255 é opaco, repetimos cor_suave 3 vezes para vermelho, azul e verde
                        cor_suave_argb = Color.FromArgb(255, cor_suave, cor_suave, cor_suave);
                        //Coloca o pixel na imagem suave
                        imagem_suave.SetPixel(coluna, linha, cor_suave_argb);
                        //A cada ocorrencia da cor na imagem, somamos 1 no seu valor do histograma
                        ocorrencias[cor_suave] = ocorrencias[cor_suave] + 1;
                    }
                }

                //Joga o bitmap imagem_cortada na picturebox
                pictureBox2.Image = imagem_suave;
                //Joga o vetor no histograma
                for (int i = 0; i < ocorrencias.Length; i++)
                {
                    chart_imagem_alterada.Series["Cortada"].Points.AddXY(i, ocorrencias[i]);
                }
            }

            if (rbtn_mediana.Checked == true)
            {
                //transforma a imagem da picture box da esquerda em bit map
                Bitmap imagem_antiga;
                if (pictureBox2.Image == null)
                {
                    imagem_antiga = new Bitmap(pictureBox1.Image);
                }
                else
                {
                    imagem_antiga = new Bitmap(pictureBox2.Image);
                }
                //cria um novo bitmap para a imagem alterada
                int altura = 360, largura = 360;
                Bitmap imagem_suave = new Bitmap(largura, altura);
                //cria uma lista para contar quantas vezes cada cor apareceu
                int[] ocorrencias = new int[256];

                //armazena o tamanho da vizinhança
                int vizinhanca = Convert.ToInt32(numericUpDown2.Value);
                int variacao = Convert.ToInt32(Math.Sqrt(vizinhanca + 1)) / 2;

                //esses 2 fors andam na imagem pixel por pixel
                for (int coluna = 0; coluna < largura; coluna++)
                {
                    for (int linha = 0; linha < altura; linha++)
                    {
                        List<int> lista_mediana = new List<int>();

                        for (int vizinho_horizontal = coluna - variacao; vizinho_horizontal <= coluna + variacao; vizinho_horizontal += 1)
                        {
                            for (int vizinho_vertical = linha - variacao; vizinho_vertical <= linha + variacao; vizinho_vertical += 1)
                            {
                                if (vizinho_horizontal >= 0 && vizinho_vertical >= 0)
                                {
                                    if (vizinho_horizontal <= coluna && vizinho_vertical <= linha)
                                    {
                                        Color cor_do_pixel_argb = imagem_antiga.GetPixel(vizinho_horizontal, vizinho_vertical);
                                        lista_mediana.Add(Convert.ToInt32(cor_do_pixel_argb.R.ToString()));
                                    }
                                }
                            }
                        }

                        int cor_suave;
                        List<int> lista_ordenada = lista_mediana.OrderBy(o => Convert.ToInt32 (o.ToString() ))
                            .ToList();

                        if (lista_ordenada.Count == 0) { cor_suave = 0; }
                        else { cor_suave = lista_ordenada[lista_ordenada.Count / 2]; }

                        //Cria uma nova cor com os bytes definidos acima
                        Color cor_suave_argb = new Color();
                        //Alpha 255 é opaco, repetimos cor_suave 3 vezes para vermelho, azul e verde
                        cor_suave_argb = Color.FromArgb(255, cor_suave, cor_suave, cor_suave);
                        //Coloca o pixel na imagem suave
                        imagem_suave.SetPixel(coluna, linha, cor_suave_argb);
                        //A cada ocorrencia da cor na imagem, somamos 1 no seu valor do histograma
                        ocorrencias[cor_suave] = ocorrencias[cor_suave] + 1;
                    }
                }

                //Joga o bitmap imagem_cortada na picturebox
                pictureBox2.Image = imagem_suave;
                //Joga o vetor no histograma
                for (int i = 0; i < ocorrencias.Length; i++)
                {
                    chart_imagem_alterada.Series["Cortada"].Points.AddXY(i, ocorrencias[i]);
                }
            }
        }

        private void button_realcar_Click(object sender, EventArgs e)
        {
            //zera o chat, caso usem o botão dnv
            chart_imagem_alterada.Series["Cortada"].Points.Clear();

            if (rbtn_equalizar.Checked == true)
            {
                //transforma a imagem anterior em bitmap
                Bitmap imagem_antiga;
                if (pictureBox2.Image == null)
                {
                    imagem_antiga = new Bitmap(pictureBox1.Image);
                }
                else
                {
                    imagem_antiga = new Bitmap(pictureBox2.Image);
                }

                //cria um bitmap para a imagem nova
                int altura = 360, largura = 360;
                Bitmap imagem_nova = new Bitmap(largura, altura);
                //cria uma lista para contar quantas vezes cada cor apareceu na imagem antiga
                int[] ocorrencias_antigas = new int[256];

                //esses 2 for's andam na imagem pixel por pixel
                for (int coluna = 0; coluna < largura; coluna++)
                {
                    for (int linha = 0; linha < altura; linha++)
                    {
                        //primeiro pegamos a cor do pixel atual
                        int cor_antiga = Convert.ToInt32(imagem_antiga.GetPixel(coluna, linha).R.ToString());

                        //somamos +1 na cor do pixel atual no histograma da imagem antiga
                        ocorrencias_antigas[cor_antiga] += 1;
                    }
                }

                int frequencia_acumulada = 0;
                int[] g_para_q = new int[256];
                //idealmente, cada nivel de cinza deveria ter a seguinte frequencia:
                int ideal_de_pixels_por_nivel_de_cinza = (largura * altura) / ocorrencias_antigas.Length;

                for (int g = 0; g < ocorrencias_antigas.Length; g+=1)
                {
                    //primeiro somamos a frequencia da cor atual à "frequencia_acumulada"
                    frequencia_acumulada += ocorrencias_antigas[g];
                    //dessa forma, "g_para_q" terá a cor antiga como chave e a nova como valor (não é um histograma)
                    g_para_q[g] = Math.Max( (frequencia_acumulada/ideal_de_pixels_por_nivel_de_cinza)-1 , 0);
                }

                //esse é o histograma final
                int[] ocorrencias_finais = new int[256];
                //esses 2 fors andam na imagem pixel por pixel
                for (int coluna = 0; coluna < largura; coluna++)
                {
                    for (int linha = 0; linha < altura; linha++)
                    {
                        //pega a cor do pixel da imagem ANTIGA
                        int cor_antiga = Convert.ToInt32(imagem_antiga.GetPixel(coluna, linha).R.ToString());
                        //usamos g_para_q para ver qual é a cor que devemos colocar no lugar da antiga
                        int cor_nova = g_para_q[cor_antiga];

                        //Alpha 255 é opaco, repetimos cor_suave 3 vezes para vermelho, verde e azul
                        Color cor_nova_argb = Color.FromArgb(255, cor_nova, cor_nova, cor_nova);
                        //Coloca o pixel na imagem nova
                        imagem_nova.SetPixel(coluna, linha, cor_nova_argb);
                        //e soma a 1 na frequencia dessa cor no histograma final
                        ocorrencias_finais[cor_nova] += 1;
                    }
                }

                //Joga o bitmap imagem_cortada na picturebox
                pictureBox2.Image = imagem_nova;
                //Joga o vetor no histograma
                for (int cor_final = 0; cor_final < ocorrencias_finais.Length; cor_final++)
                {
                    chart_imagem_alterada.Series["Cortada"].Points.AddXY(cor_final, ocorrencias_finais[cor_final]);
                }
            }
        }

        private void btn_realcar_bordas_Click(object sender, EventArgs e)
        {
            //zera o chart, caso usem o botão dnv
            chart_imagem_alterada.Series["Cortada"].Points.Clear();

            //transforma a imagem da picture box da esquerda em bit map
            Bitmap imagem_antiga;
            if (pictureBox2.Image == null)
            {
                imagem_antiga = new Bitmap(pictureBox1.Image);
            }
            else
            {
                imagem_antiga = new Bitmap(pictureBox2.Image);
            }
            //cria um novo bitmap para a imagem alterada
            int altura = 360, largura = 360;
            Bitmap imagem_gradiente = new Bitmap(largura, altura);
            //cria uma lista para contar quantas vezes cada cor apareceu
            int[] ocorrencias = new int[256];

            //esses 2 fors andam na imagem pixel por pixel
            for (int coluna_imagem = 0; coluna_imagem < largura; coluna_imagem++)
            {
                for (int linha_imagem = 0; linha_imagem < altura; linha_imagem++)
                {
                    Color pixel_atual_argb = imagem_antiga.GetPixel(coluna_imagem, linha_imagem);
                    Color pixel_direita_argb = pixel_atual_argb;
                    // se coluna +1 estiver na imagem
                    if (coluna_imagem+1 < 360)
                    { pixel_direita_argb = imagem_antiga.GetPixel(coluna_imagem + 1, linha_imagem); }
                    Color pixel_debaixo_argb = pixel_atual_argb;
                    //se linha + 1 estiver na imagem
                    if (linha_imagem+1 < 360)
                    { pixel_debaixo_argb = imagem_antiga.GetPixel(coluna_imagem, linha_imagem + 1); }
                    
                    int cor_atual = Convert.ToInt32(pixel_atual_argb.R.ToString());
                    int cor_direita = Convert.ToInt32(pixel_direita_argb.R.ToString());
                    int cor_debaixo = Convert.ToInt32(pixel_debaixo_argb.R.ToString());

                    int cor_gradiente = Math.Abs(cor_atual - cor_direita) + Math.Abs(cor_atual - cor_debaixo);
                    //caso a soma passe de 255, deixa como 255
                    if(cor_gradiente > 255) { cor_gradiente = 255; }

                    //Cria uma nova cor com os bytes definidos acima
                    //Alpha 255 é opaco, repetimos cor_suave 3 vezes para vermelho, azul e verde
                    Color pixel_gradiente_argb = Color.FromArgb(255, cor_gradiente, cor_gradiente, cor_gradiente);
                    //Coloca o pixel na imagem suave
                    imagem_gradiente.SetPixel(coluna_imagem, linha_imagem, pixel_gradiente_argb);
                    //A cada ocorrencia da cor na imagem, somamos 1 no seu valor do histograma
                    ocorrencias[cor_gradiente] = ocorrencias[cor_gradiente] + 1;
                }
            }

            //Joga o bitmap imagem_cortada na picturebox
            pictureBox2.Image = imagem_gradiente;
            //Joga o vetor no histograma
            for (int i = 0; i < ocorrencias.Length; i++)
            {
                chart_imagem_alterada.Series["Cortada"].Points.AddXY(i, ocorrencias[i]);
            }
        }
    }
}
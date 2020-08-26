using SandaliariaMontaImagem.Classes;
using SandaliariaMontaImagem.Log;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SandaliariaMontaImagem
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private List<string> ListaImagens = new List<string>();

        public Main()
        {
            InitializeComponent();
        }

        private void panelBarraJanela_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btCarregar1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Multiselect = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in file.FileNames)
                {
                    ListaImagens.Add(item.ToString());
                    lstbImagens.Items.Add(item.ToString());
                }
            }
        }

        private void btCarregar2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                pbImagem2.Image = null;
                pbImagem2.ImageLocation = file.FileName;
            }
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {
            try
            {
                RedimencionarImagem redimencionarImagem = new RedimencionarImagem();
                int contadorDeImagem = 0;

                if (txPastaSaida.Text != "")
                {
                    if (lstbImagens.Items.Count != 0)
                    {
                        if(pbImagem2.ImageLocation != null)
                        {
                            btCarregar1.Enabled = false;
                            btCarregar2.Enabled = false;
                            btLimparLista.Enabled = false;
                            btProcessar.Enabled = false;
                            btPastaSaida.Enabled = false;
                            foreach (var item in ListaImagens)
                            {
                                Image loadedImage = Image.FromFile(item.ToString());

                                int logoLargura = pbImagem2.Image.Width;
                                int logoAltura = pbImagem2.Image.Height;
                                int novaLargura = 0;
                                int novaAltura = 0;
                                int bordaX = 0;
                                int bordaY = 0;

                                if (pbImagem2.Image.Width > pbImagem2.Image.Height)
                                {
                                    logoLargura = pbImagem2.Image.Width / 2;
                                    logoAltura = pbImagem2.Image.Height / 2;
                                    novaLargura = loadedImage.Width / 2;
                                    novaAltura = novaLargura * logoAltura / logoLargura;
                                    bordaX = novaAltura / 2;
                                    bordaY = novaAltura / 2;
                                }
                                else if (pbImagem2.Image.Width < pbImagem2.Image.Height)
                                {
                                    logoLargura = pbImagem2.Image.Width / 2;
                                    logoAltura = pbImagem2.Image.Height / 2;
                                    novaLargura = loadedImage.Width / 2 * logoLargura / logoAltura;
                                    novaAltura = novaLargura * logoAltura / logoLargura;
                                    bordaX = novaLargura / 8;
                                    bordaY = novaLargura / 8;
                                }
                                else
                                {
                                    logoLargura = pbImagem2.Image.Width / 2;
                                    logoAltura = pbImagem2.Image.Height / 2;
                                    novaLargura = loadedImage.Width / 2 * logoAltura / logoLargura;
                                    novaAltura = novaLargura * logoAltura / logoLargura;
                                    bordaX = novaLargura / 8;
                                    bordaY = logoAltura / 8;
                                }

                                if (novaLargura != 0 || novaAltura != 0)
                                {
                                    using (Image image = loadedImage)
                                    using (Image watermarkImage = redimencionarImagem.ResizeImage(pbImagem2.Image, novaLargura, novaAltura))
                                    using (Graphics imageGraphics = Graphics.FromImage(image))
                                    using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
                                    {
                                        int x = (image.Width - bordaX - watermarkImage.Width);
                                        int y = (image.Height - bordaY - watermarkImage.Height);
                                        watermarkBrush.TranslateTransform(x, y);
                                        imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), new Size(watermarkImage.Width + 1, watermarkImage.Height)));
                                        image.Save($@"{txPastaSaida.Text}\Imagem{contadorDeImagem}.jpg");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Dimensão da imagem não compativel");
                                }
                                contadorDeImagem++;
                            }
                            btCarregar1.Enabled = true;
                            btCarregar2.Enabled = true;
                            btLimparLista.Enabled = true;
                            btProcessar.Enabled = true;
                            btPastaSaida.Enabled = true;

                        }
                        else
                            MessageBox.Show("Adicione uma logo marca");
                    }
                    else
                        MessageBox.Show("Adicione imagens a lista");
                }
                else
                    MessageBox.Show("Selecione uma pasta de saída");
            }
            catch (Exception ex)
            {
                RegistraLog.Log("Erro ao pressionar tecla de atalho - " + ex);
                throw ex;
            }
        }

        private void btPastaSaida_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pasta = new FolderBrowserDialog();
            if (pasta.ShowDialog() == DialogResult.OK)
            {
                txPastaSaida.Text = pasta.SelectedPath;
            }
        }

        private void btLimparLista_Click(object sender, EventArgs e)
        {
            ListaImagens.Clear();
            lstbImagens.Items.Clear();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

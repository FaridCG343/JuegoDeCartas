using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JuegoDeCartas.Modelos
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int VidaMax { get; set; }
        public int Defensa { get; set; }
        public int Ataque { get; set; }
        public int Armadura { get; set; }
        public Image Imagen { get; set; }
        public bool Muerto { get; set; } = false;
        public ProgressBar BarraVida { get; set; }
        public PictureBox pbPersona { get; set; }
        public Image Idle { get; set; }
        public Image Atacar { get; set; }
        public Image Damaged { get; set; }
        public Label lblVida { get; set; }
        public Label lblArmadura { get; set; }
        public System.Windows.Forms.Timer timer { get; set; }

        public Persona(string nombre, int vida, int ataque, int defensa, Image idle, Image atacar, Image damaged)
        {
            Nombre = nombre;
            Vida = vida;
            VidaMax = vida;
            Ataque = ataque;
            Defensa = defensa;
            Idle = idle;
            Atacar = atacar;
            Damaged = damaged;
            Armadura = 0;
            timer = new()
            {
                Interval = 1000
            };
            timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Muerto)
            {
                pbPersona.Enabled = false;
            }
            else
            {
                pbPersona.Image = Idle;
                
            }
            timer.Stop();
        }

        public void TakeDamage(int ataque)
        {
            changeImage(Damaged);
            if (Armadura > 0)
            {
                Armadura -= ataque;
                if (Armadura < 0)
                {
                    Vida += Armadura;
                    Armadura = 0;
                }
            }
            else
            {
                Vida -= ataque;
            }
            if (Vida <= 0)
            {
                Muerto = true;
                Vida = 0;
                onDeath();
            }
            lblVida.Text = Vida.ToString();
            lblArmadura.Text = Armadura.ToString();
            BarraVida.Value = Vida;
            UpdateHealthBarColor(BarraVida);
            
        }

        public void atacar(Persona enemigo, int ataque)
        {
            changeImage(Atacar);
            enemigo.TakeDamage(ataque);
        }
         public void curar(int puntos)
        {
            Vida += puntos;
            if(Vida > VidaMax)
            {
                Vida = VidaMax;
            }
            BarraVida.Value = Vida;
            UpdateHealthBarColor(BarraVida);
            lblVida.Text = Vida.ToString();
        }

        public void defenderse()
        {
            Armadura += Defensa;
            lblArmadura.Text = Armadura.ToString();
        }

        private void UpdateHealthBarColor(ProgressBar healthBar)
        {
            float healthPercentage = (float)healthBar.Value / healthBar.Maximum;
            if (healthPercentage > 0.5)
            {
                // Verde si la vida es mayor al 50%
                healthBar.ForeColor = Color.Green;
            }
            else if (healthPercentage > 0.25)
            {
                // Amarillo si la vida es mayor al 25% pero menor o igual al 50%
                healthBar.ForeColor = Color.Yellow;
            }
            else
            {
                // Rojo si la vida es menor o igual al 25%
                healthBar.ForeColor = Color.Red;
            }
        }

        public void changeImage(Image image)
        {
            timer.Interval = GetGifDuration(image) ?? 10;
            timer.Start();
            pbPersona.Image = image;
        }
        public int? GetGifDuration(Image image, int fps = 60)
        {
            var minimumFrameDelay = (1000.0 / fps);
            if (!image.RawFormat.Equals(ImageFormat.Gif)) return null;
            if (!ImageAnimator.CanAnimate(image)) return null;

            var frameDimension = new FrameDimension(image.FrameDimensionsList[0]);

            var frameCount = image.GetFrameCount(frameDimension);
            var totalDuration = 0;

            for (var f = 0; f < frameCount; f++)
            {
                var delayPropertyBytes = image.GetPropertyItem(20736).Value;
                var frameDelay = BitConverter.ToInt32(delayPropertyBytes, f * 4) * 10;
                // Minimum delay is 16 ms. It's 1/60 sec i.e. 60 fps
                totalDuration += (frameDelay < minimumFrameDelay ? (int)minimumFrameDelay : frameDelay);
            }

            return totalDuration;
        }

        public abstract void onDeath();

        //public void OnFrameChanged(object sender, EventArgs e)
        //{
       
        //    // Si ocurrió un evento y el GIF original está animándose, cambiar al siguiente GIF alternativo
        //    if (atacando && !eventoHecho)
        //    {
        //        ImageAnimator.StopAnimate(Idle, OnFrameChanged);
        //        eventoHecho = true;
        //        pbPersona.Image = Atacar;
        //        ImageAnimator.Animate(pbPersona.Image, OnFrameChanged);
        //    }

        //    if (sindoAtacado && !eventoHecho)
        //    {
        //        eventoHecho = true;
        //        ImageAnimator.StopAnimate(pbPersona.Image, OnFrameChanged);
        //        pbPersona.Image = Damaged;
        //        ImageAnimator.Animate(pbPersona.Image, OnFrameChanged);
        //    }

        //    // Avanzar al siguiente cuadro en la animación del GIF
        //    ImageAnimator.UpdateFrames(pbPersona.Image);
        //    _currentFrameIndex = (_currentFrameIndex + 1) % pbPersona.Image.GetFrameCount(FrameDimension.Time);
        //   // MessageBox.Show("Curren: " + GetCurrentFrameIndex(pbPersona.Image) + " Max: " + (pbPersona.Image.GetFrameCount(FrameDimension.Time) - 1));
        //    // Si se ha llegado al último cuadro del GIF alternativo actual, volver al GIF original
        //    if (eventoHecho && _currentFrameIndex == pbPersona.Image.GetFrameCount(FrameDimension.Time) - 1)
        //    {
        //        ImageAnimator.StopAnimate(pbPersona.Image, OnFrameChanged);
        //        pbPersona.Image = Idle;
        //        ImageAnimator.Animate(pbPersona.Image, OnFrameChanged);
        //        atacando = false;
        //    }

        //    if (eventoHecho && _currentFrameIndex == pbPersona.Image.GetFrameCount(FrameDimension.Time) - 1)
        //    {
        //        ImageAnimator.StopAnimate(pbPersona.Image, OnFrameChanged);
        //        pbPersona.Image = Idle;
        //        ImageAnimator.Animate(pbPersona.Image, OnFrameChanged);
        //        sindoAtacado = false;
        //    }

        //    pbPersona.Invalidate();
        //}

        //private int GetCurrentFrameIndex(Image image)
        //{
        //    int frameIndex;
        //    PropertyItem framePropertyItem = image.GetPropertyItem(0x5100);
        //    frameIndex = BitConverter.ToInt32(framePropertyItem.Value, 0);
        //    return frameIndex;
        //}
    }
}

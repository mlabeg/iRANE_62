using NAudio.Wave;
using NAudio.WaveFormRenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.Handlers
{
    public class WaveformHandler
    {
        private readonly PictureBox waveform;
        private readonly Label renderingLabel;
        private readonly AudioSourceHandler audioSource;
        private Image waveformImage;

        public WaveformHandler(PictureBox waveformControl, Label label, AudioSourceHandler audioSource)
        {
            this.waveform = waveformControl ?? throw new ArgumentNullException(nameof(waveformControl));
            this.renderingLabel = label ?? throw new ArgumentNullException(nameof(renderingLabel));
            this.audioSource = audioSource ?? throw new ArgumentNullException(nameof(audioSource));

            waveform.Paint += Waveform_Paint;
            waveform.MouseClick += Waveform_MouseClick;
        }

        public void RenderWaveform()
        {
            if (string.IsNullOrEmpty(audioSource.FileName)) return;

            var settings = new StandardWaveFormRendererSettings()
            {
                BackgroundColor = Color.Black,
                TopPeakPen = new Pen(Color.White),
                BottomPeakPen = new Pen(Color.White),
            };

            waveform.Image = null;
            waveform.Enabled = false;
            renderingLabel.Visible = true;

            var peakProvider = new RmsPeakProvider(100);
            Task.Factory.StartNew(() => RenderThreadFunc(peakProvider, settings));
        }

        private void RenderThreadFunc(IPeakProvider peakProvider, WaveFormRendererSettings settings)
        {
            WaveFormRenderer waveFormRenderer = new WaveFormRenderer();
            Image image = null;

            try
            {
                using (var wavestream = new AudioFileReader(audioSource.FileName))
                {
                    image = waveFormRenderer.Render(wavestream, peakProvider, settings);
                }

                waveform.BeginInvoke((Action)(() => FinishedRender(image)));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void FinishedRender(Image image)
        {
            waveformImage = image;
            waveform.Image = waveformImage;
            renderingLabel.Visible = false;
            waveform.Enabled = true;
        }

        private void Waveform_Paint(object sender, PaintEventArgs e)
        {
            if (waveformImage != null)
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawLine(pen, audioSource.CurrentPlaybackPosition, 0, audioSource.CurrentPlaybackPosition, waveform.Height);
                }
            }
        }

        private void Waveform_MouseClick(object sender, MouseEventArgs e)
        {
            if (audioSource.AudioFileReader != null)
            {
                double clickPositionRatio = (double)e.X / (double)waveform.Width;
                audioSource.AudioFileReader.CurrentTime = TimeSpan.FromSeconds(audioSource.AudioFileReader.TotalTime.TotalSeconds * clickPositionRatio);
                audioSource.CurrentPlaybackPosition = e.X;
                waveform.Invalidate();
            }
        }

        public void DrawCuePoint(TimeSpan cuePoint, Color color)
        {
            if (audioSource.Song == null || audioSource.AudioFileReader == null)
                return;

            if (waveform.Image == null)
                return;

            using (Graphics g = Graphics.FromImage(waveform.Image))
            {
                if (cuePoint.TotalSeconds >= 0 && cuePoint < audioSource.AudioFileReader.TotalTime)
                {
                    int xPos = (int)(waveform.Width * (cuePoint.TotalSeconds / audioSource.AudioFileReader.TotalTime.TotalSeconds));

                    using (Pen pen = new Pen(color, 3))
                    {
                        g.DrawLine(pen, xPos, 0, xPos, waveform.Height);
                    }
                }
            }

            waveform.Invalidate();
        }

        public void UpdatePlayingPositionLine()
        {
            if (audioSource.AudioFileReader != null && audioSource.AudioFileReader.TotalTime.TotalSeconds > 0)
            {
                double progress = audioSource.AudioFileReader.CurrentTime.TotalSeconds / audioSource.AudioFileReader.TotalTime.TotalSeconds;
                audioSource.CurrentPlaybackPosition = (int)(waveform.Width * progress);
                waveform.Invalidate();
            }
        }

        public void ClearWaveform()
        {
            waveform.Image = null;
            waveformImage = null;
            waveform.Invalidate();
        }
    }
}

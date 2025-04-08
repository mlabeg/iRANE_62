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

        private Dictionary<string, WaveFormRendererSettings> renderSettings = new Dictionary<string, WaveFormRendererSettings>();

        public WaveformHandler(PictureBox waveformControl, Label label, AudioSourceHandler audioSource)
        {
            this.waveform = waveformControl ?? throw new ArgumentNullException(nameof(waveformControl));
            this.renderingLabel = label ?? throw new ArgumentNullException(nameof(renderingLabel));
            this.audioSource = audioSource ?? throw new ArgumentNullException(nameof(audioSource));

            GenerateRenderSettings();

            waveform.Paint += Waveform_Paint;
            waveform.MouseClick += Waveform_MouseClick;
        }

        public void RenderWaveform()
        {
            if (string.IsNullOrEmpty(audioSource.FileName)) return;

            waveform.Image = null;
            waveform.Enabled = false;
            renderingLabel.Visible = true;

            var peakProvider = GetPeakProvider();
            var settings = renderSettings["SoundCloud Orange Transparent Blocks"];

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

        private void GenerateRenderSettings()
        {
            var soundcloudOriginalSettings = new SoundCloudOriginalSettings() { Name = "SoundCloud Original" };

            var soundCloudLightBlocks = new SoundCloudBlockWaveFormSettings(Color.FromArgb(102, 102, 102), Color.FromArgb(103, 103, 103), Color.FromArgb(179, 179, 179),
                Color.FromArgb(218, 218, 218))
            { Name = "SoundCloud Light Blocks" };

            var soundCloudDarkBlocks = new SoundCloudBlockWaveFormSettings(Color.FromArgb(52, 52, 52), Color.FromArgb(55, 55, 55), Color.FromArgb(154, 154, 154),
                Color.FromArgb(204, 204, 204))
            { Name = "SoundCloud Darker Blocks" };

            var soundCloudOrangeBlocks = new SoundCloudBlockWaveFormSettings(Color.FromArgb(255, 76, 0), Color.FromArgb(255, 52, 2), Color.FromArgb(255, 171, 141),
                Color.FromArgb(255, 213, 199))
            { Name = "SoundCloud Orange Blocks" };

            var topSpacerColor = Color.FromArgb(64, 83, 22, 3);
            var soundCloudOrangeTransparentBlocks = new SoundCloudBlockWaveFormSettings(Color.FromArgb(196, 197, 53, 0), topSpacerColor, Color.FromArgb(196, 79, 26, 0),
                Color.FromArgb(64, 79, 79, 79))
            {
                Name = "SoundCloud Orange Transparent Blocks",
                PixelsPerPeak = 2,
                SpacerPixels = 1,
                TopSpacerGradientStartColor = topSpacerColor,
                BackgroundColor = Color.Transparent
            };

            var topSpacerColor2 = Color.FromArgb(64, 224, 224, 224);
            var soundCloudGrayTransparentBlocks = new SoundCloudBlockWaveFormSettings(Color.FromArgb(196, 224, 225, 224), topSpacerColor2, Color.FromArgb(196, 128, 128, 128),
                Color.FromArgb(64, 128, 128, 128))
            {
                Name = "SoundCloud Gray Transparent Blocks",
                PixelsPerPeak = 2,
                SpacerPixels = 1,
                TopSpacerGradientStartColor = topSpacerColor2,
                BackgroundColor = Color.Transparent
            };

            var standardSettings = new StandardWaveFormRendererSettings()
            {
                Name = "Standard",
                BackgroundColor = Color.Black,
                TopPeakPen = new Pen(Color.White),
                BottomPeakPen = new Pen(Color.White)
            };


            renderSettings.Add(standardSettings.Name, standardSettings);
            renderSettings.Add(soundcloudOriginalSettings.Name, soundcloudOriginalSettings);
            renderSettings.Add(soundCloudLightBlocks.Name, soundCloudLightBlocks);
            renderSettings.Add(soundCloudDarkBlocks.Name, soundCloudDarkBlocks);
            renderSettings.Add(soundCloudOrangeBlocks.Name, soundCloudOrangeBlocks);
            renderSettings.Add(soundCloudOrangeTransparentBlocks.Name, soundCloudOrangeTransparentBlocks);
            renderSettings.Add(soundCloudGrayTransparentBlocks.Name, soundCloudGrayTransparentBlocks);
        }

        private IPeakProvider GetPeakProvider()
        {
            //return new MaxPeakProvider();
            //return new RmsPeakProvider(100);
            //return new SamplingPeakProvider(100);
            return new AveragePeakProvider(4);
        }

        public void ClearWaveform()
        {
            waveform.Image = null;
            waveformImage = null;
            waveform.Invalidate();
        }
    }
}

using iRANE_62.Models;
using iRANE_62.SampleProviderExtensions;
using NAudio.Extras;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.ComponentModel;

namespace iRANE_62.Handlers
{
    public class EqSectionHandler
    {
        private ISampleProvider outputProvider;

        public EqualizerWithBands EqualizerWithBands { get; set; }
        public FilterSampleProvider FilterSampleProvider { get; set; }
        public StereoPanningSampleProvider PanningProvider { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public EqSectionHandler()
        {
            EqualizerWithBands = new EqualizerWithBands();
        }

        public EqSectionHandler(ISampleProvider source, int sampleRate) : this()
        {
            SetupEqChain(source, sampleRate);
        }

        private void SetupEqChain(ISampleProvider source, int sampleRate)
        {
            FilterSampleProvider = new FilterSampleProvider(source, sampleRate);
            PanningProvider = new StereoPanningSampleProvider(FilterSampleProvider);
            EqualizerWithBands.Equalizer = new Equalizer(PanningProvider, EqualizerWithBands.Bands);
            outputProvider = EqualizerWithBands.Equalizer;
        }

        public ISampleProvider GetOutputProvider()
        {
            return outputProvider;
        }

        public void UpdateEqSection(EqSectionHolder holder)
        {
            EqualizerWithBands.UpdateEqLow(holder.Low);
            EqualizerWithBands.UpdateEqMid(holder.Mid);
            EqualizerWithBands.UpdateEqHigh(holder.High);
            EqualizerWithBands.Equalizer.Update();

            PanningProvider.Pan = holder.Pan;
            FilterSampleProvider.FilterValue = holder.HighLowPassFilter;
        }
    }
}

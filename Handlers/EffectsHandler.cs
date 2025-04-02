using iRANE_62.Models;
using iRANE_62.SampleProviderExtensions;
using iRANE_62.SampleProviderExtensions.EffectsSampleExtensions;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRANE_62.Handlers
{
    public class EffectsHandler
    {

        private ISampleProvider source;
        private ISampleProvider outputProvider;

        public Action<float, bool> EchoUpdateDelegate;
        public Action<float, bool> ReverbUpdateDelegate;


        public EffectsHandler(ISampleProvider sourceProvider)
        {
            source = sourceProvider;
            SetupEffectsChain();
        }

        public void SetupEffectsChain()
        {
            var echoSampleProvider = new EchoEffectSampleProvider(source);
            EchoUpdateDelegate = echoSampleProvider.EffectUpdate;

            var reverbSampleProvider = new ReverbEffectSampleProvider(echoSampleProvider);
            ReverbUpdateDelegate = reverbSampleProvider.EffectUpdate;

            outputProvider = reverbSampleProvider;
        }

        public void UpdateEffect(float gain, bool enabled, EffectsEnum effect)
        {
            switch (effect)
            {
                case EffectsEnum.Echo:
                    EchoUpdateDelegate?.Invoke(gain, enabled);
                    ReverbUpdateDelegate?.Invoke(gain, false);
                    break;

                case EffectsEnum.Reverb:
                    ReverbUpdateDelegate?.Invoke(gain, enabled);
                    EchoUpdateDelegate?.Invoke(gain, false);
                    break;

                case EffectsEnum.Disabled:
                default:
                    ReverbUpdateDelegate?.Invoke(gain, false);
                    EchoUpdateDelegate?.Invoke(gain, false);
                    break;

            }
        }

        public ISampleProvider GetOutputProvider()
        {
            return outputProvider;
        }
    }
}

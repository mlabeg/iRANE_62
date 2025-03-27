using iRANE_62.Models;
using iRANE_62.SampleProviderExtensions;
using NAudio.Wave;

namespace iRANE_62.Handlers
{
    public class EffectsHandler
    {
        private ISampleProvider sourceProvider;
        private IEffectSampleProvider activeEffect;
        private bool effectsEnabled;
        private float effectGain;
        private EffectsEnum effect;

        public EffectsHandler()
        {
                
        }

        public EffectsHandler(ISampleProvider source)
        {
            sourceProvider = source ?? throw new ArgumentNullException(nameof(source));
        }

        public bool EffectsEnabled
        {
            get => effectsEnabled;
            set
            {
                if (effectsEnabled != value)
                {
                    effectsEnabled = value;
                    SetActiveEffect(effect);
                }
            }
        }

        public float EffectGain
        {
            get => effectGain;
            set
            {
                effectGain = Math.Clamp(value, 0f, 1f);
                if (activeEffect is EchoEffectSampleProvider echo)
                {
                    echo.EchoGain = effectGain;
                }
                SetActiveEffect(effect);
            }
        }

        public EffectsEnum Effect
        {
            get => effect;
            set
            {
                effect = value;
                SetActiveEffect(effect);
            }
        }

        public void EffectParametesUpdate(EffectParametersHolder effectHolder)
        {
            effect = effectHolder.Effect;
            effectsEnabled = effectHolder.EffectEnabled;
            effectGain=effectHolder.Gain;
            SetActiveEffect(effect);
        }


        public void SetActiveEffect(EffectsEnum effect)
        {
            if (sourceProvider == null)
            {
                return;
            }

            switch (effect)
            {
                case EffectsEnum.Echo:
                    activeEffect = new EchoEffectSampleProvider(sourceProvider, 825, effectGain, 0.25f);
                    break;
                // Add cases for other effects here, e.g.:
                // case "Reverb":
                //     activeEffect = new ReverbEffectSampleProvider(sourceProvider, /* params */);
                //     break;
                default:
                    activeEffect = null;
                    break;
            }
        }
        public ISampleProvider GetOutputProvider()
        {
            return effectsEnabled && activeEffect != null ? activeEffect : sourceProvider;
        }

        public void SourceProviderUpdate(ISampleProvider sampleProvider)
        {
            sourceProvider = sampleProvider;
        }
    }


}


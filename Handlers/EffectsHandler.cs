using iRANE_62.Models;
using iRANE_62.SampleProviderExtensions;
using NAudio.Extras;
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
        private readonly ISampleProvider sourceProvider;
        private IEffectSampleProvider activeEffect;
        private bool effectsEnabled;
        private float effectGain;
        private EffectsEnum effect;

        public event Action EffectsChanged;

        public EffectsHandler()
        {
            //effect = EffectsEnum.Disabled;
        }

        private void SetupEffects()
        {

        }

        public EffectsHandler(ISampleProvider source) : this()
        {
            sourceProvider = source ?? throw new ArgumentNullException(nameof(source));
        }

        public EffectsHandler(ISampleProvider source, MixerEffectHolder effectHolder) : this(source)
        {
            effect=effectHolder.effect;
            effectGain=effectHolder.gain;
            effectsEnabled=effectHolder.effectEnabled;

            SetActiveEffect(currentEffectHandler.activeEffectName);
            
        }


        public EffectsHandler(ISampleProvider source, bool effectEnabled) : this(source)
        {
            effectsEnabled = effectEnabled;
        }

        public EffectsHandler(ISampleProvider source, bool effectEnabled, EffectsEnum effect) : this(source, effectEnabled)
        {
            if (effect != null)
            {
                SetActiveEffect(effect);
            }
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


        public void SetActiveEffect(EffectsEnum effect)
        {
            if (sourceProvider == null)
            {
                return;
            }

            switch (effect)
            {
                case "Echo":
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
            EffectsChanged?.Invoke();
        }

        public ISampleProvider GetOutputProvider()
        {
            return effectsEnabled && activeEffect != null ? activeEffect : sourceProvider;
        }

    }


}


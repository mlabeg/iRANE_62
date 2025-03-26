namespace iRANE_62.Models
{

    public class MixerEffectHolder
    {
        private EffectsEnum effect;
        private bool effectEnabled;
        private float gain;

        public EffectsEnum Effect => effect;
        public bool EffectEnabled => effectEnabled;

        public float Gain=>gain;

        public MixerEffectHolder(EffectsEnum effect,
            bool effectEnabled,
            float gain)
        {
            this.effect = effect;
            this.effectEnabled = effectEnabled;
            this.gain = gain;
        }

    }

}
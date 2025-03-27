namespace iRANE_62.Models
{

    public class EffectParametersHolder
    {
        private EffectsEnum effect;
        private bool effectEnabled;
        private float gain;

        public EffectsEnum Effect
        {
            get => effect;
            set
            {
                effect = value;
            }
        } 

        
        public bool EffectEnabled
        {
            get=> effectEnabled;
            set
            {
                effectEnabled = value;
            }
        } 

        public float Gain
        {
            get => gain;
            set
            {
                gain = value;
            }
        } 

        public EffectParametersHolder(EffectsEnum effect,
            bool effectEnabled,
            float gain)
        {
            this.effect = effect;
            this.effectEnabled = effectEnabled;
            this.gain = gain;
        }

    }

}
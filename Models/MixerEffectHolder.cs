namespace iRANE_62.Models
{

public class MixerEffectHolder{
    private EffectsEnum effect;
    private bool effectEnabled;
    private float gain;

    public EffectEnum Effect=>effect;
    public bool EffectEnabled=>effectEnabled;
    public float Gain;

    MixerEffectHolder(EffectEnum effect,
        bool effectEnabled,
        float gain)
        {
            this.effect=effect;
            this.effectEnabled=effectEnabled;
            this.gain=gain;
        }
        
}

}
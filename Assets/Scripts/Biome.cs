using UnityEngine;

namespace Assets.Scripts
{
    public abstract class Biome
    {
        // -- Main Settings --
        public int Id;
        public Color Color;

        // -- Temperature Settings --
        public float MinTemperature { get; protected set; }
        public float MaxTemperature { get; protected set; }


        // -- Dryness Settings --

        public float MinDryness { get; protected set; }
        public float MaxDryness { get; protected set; }


        protected Biome(int id, Color color, float minTemperature, float maxTemperature, float minDryness, float maxDryness)
        {
            Id = id;
            Color = color;
            MinTemperature = minTemperature;
            MaxTemperature = maxTemperature;
            MinDryness = minDryness;
            MaxDryness = maxDryness;
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class BiomeManager : MonoBehaviour
    {
        // -- Main Settings --
        public Material Matt;
        public int Size;
        public bool EnableTemperature;
        public bool EnableDryness;

        // -- Private settings --
        private Texture2D _tex;

        // -- Biome Colors --
        public Color TropicalForest;
        public Color TropicalSavanna;
        public Color TropicalDesert;

        // -- Biomes --
        private HashSet<Biome> _biomes;

        // -- Fields --
        private float[] _temperatureField;
        private float[] _drynessField;

        // -- Noises --
        private FastNoise _temperateNoise;

        private FastNoise _drynessNoise;
        public FastNoise.NoiseType DrynessNoiseType;
        public FastNoise.Interp DrynessInterp;
        public FastNoise.FractalType DrynessFractalType;

        // ========== Unity Internal ==========
        void Start()
        {
            _biomes = new HashSet<Biome>
            {
                new Biomes.Tropical.Forest(0, TropicalForest),
                new Biomes.Tropical.Savanna(1, TropicalSavanna),
                new Biomes.Tropical.Desert(2, TropicalDesert)
            };
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Generate(Size);
            }
        }

        // ========== Private Methods ==========
        private void Generate(int s)
        {
            _tex = new Texture2D(s, s);

            _temperatureField = new float[s * s];
            _drynessField = new float[s * s];

            for (var x = 0; x < s; x++)
            {
                for (var y = 0; y < s; y++)
                {
                    var i = x + y * s;

                    if (EnableTemperature)
                    {
                        _temperatureField[i] = (float)y / s;
                    }

                    if (EnableDryness)
                    {
                        _drynessField[i] = 0;
                    }

                    _tex.SetPixel(x, y, new Color(_temperatureField[i], _temperatureField[i], _temperatureField[i]));
                }
            }

            _tex.Apply();

            _tex.filterMode = FilterMode.Point;
            _tex.wrapMode = TextureWrapMode.Clamp;

            Matt.SetTexture(Shader.PropertyToID("_MainTex"), _tex);
        }

    }
}

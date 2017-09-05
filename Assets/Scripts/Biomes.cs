using UnityEngine;

namespace Assets.Scripts
{
    public static class Biomes
    {
        public static class Tropical
        {
            public class Forest : Biome
            {
                // -- Main Settings --
                private const float MinTemp = 0.75f;
                private const float MaxTemp = 1f;
                private const float MinDry = 0f;
                private const float MaxDry = 0.4f;

                public Forest(int id, Color color) : base(id, color, MinTemp, MaxTemp, MinDry, MaxDry) { }
            }

            public class Savanna : Biome
            {
                // -- Main Settings --
                private const float MinTemp = 0.75f;
                private const float MaxTemp = 1f;
                private const float MinDry = 0.4f;
                private const float MaxDry = 0.6f;

                public Savanna(int id, Color color) : base(id, color, MinTemp, MaxTemp, MinDry, MaxDry) { }
            }

            public class Desert : Biome
            {
                // -- Main Settings --
                private const float MinTemp = 0.75f;
                private const float MaxTemp = 1f;
                private const float MinDry = 0.6f;
                private const float MaxDry = 1f;

                public Desert(int id, Color color) : base(id, color, MinTemp, MaxTemp, MinDry, MaxDry) { }
            }
        }
        public static class Temperate
        {
            public class Forest : Biome
            {
                // -- Main Settings --
                private const float MinTemp = 0.75f;
                private const float MaxTemp = 1f;
                private const float MinDry = 0f;
                private const float MaxDry = 0.4f;

                public Forest(int id, Color color) : base(id, color, MinTemp, MaxTemp, MinDry, MaxDry) { }
            }

            public class Savanna : Biome
            {
                // -- Main Settings --
                private const float MinTemp = 0.75f;
                private const float MaxTemp = 1f;
                private const float MinDry = 0.4f;
                private const float MaxDry = 0.6f;

                public Savanna(int id, Color color) : base(id, color, MinTemp, MaxTemp, MinDry, MaxDry) { }
            }

            public class Desert : Biome
            {
                // -- Main Settings --
                private const float MinTemp = 0.75f;
                private const float MaxTemp = 1f;
                private const float MinDry = 0.6f;
                private const float MaxDry = 1f;

                public Desert(int id, Color color) : base(id, color, MinTemp, MaxTemp, MinDry, MaxDry) { }
            }
        }
        public static class SubArtic
        {
            public class Forest : Biome
            {
                // -- Main Settings --
                private const float MinTemp = 0.75f;
                private const float MaxTemp = 1f;
                private const float MinDry = 0f;
                private const float MaxDry = 0.4f;

                public Forest(int id, Color color) : base(id, color, MinTemp, MaxTemp, MinDry, MaxDry) { }
            }

            public class Savanna : Biome
            {
                // -- Main Settings --
                private const float MinTemp = 0.75f;
                private const float MaxTemp = 1f;
                private const float MinDry = 0.4f;
                private const float MaxDry = 0.6f;

                public Savanna(int id, Color color) : base(id, color, MinTemp, MaxTemp, MinDry, MaxDry) { }
            }

            public class Desert : Biome
            {
                // -- Main Settings --
                private const float MinTemp = 0.75f;
                private const float MaxTemp = 1f;
                private const float MinDry = 0.6f;
                private const float MaxDry = 1f;

                public Desert(int id, Color color) : base(id, color, MinTemp, MaxTemp, MinDry, MaxDry) { }
            }
        }
        public static class Artic
        {
            public class Forest : Biome
            {
                // -- Main Settings --
                private const float MinTemp = 0.75f;
                private const float MaxTemp = 1f;
                private const float MinDry = 0f;
                private const float MaxDry = 0.4f;

                public Forest(int id, Color color) : base(id, color, MinTemp, MaxTemp, MinDry, MaxDry) { }
            }

            public class Savanna : Biome
            {
                // -- Main Settings --
                private const float MinTemp = 0.75f;
                private const float MaxTemp = 1f;
                private const float MinDry = 0.4f;
                private const float MaxDry = 0.6f;

                public Savanna(int id, Color color) : base(id, color, MinTemp, MaxTemp, MinDry, MaxDry) { }
            }

            public class Desert : Biome
            {
                // -- Main Settings --
                private const float MinTemp = 0.75f;
                private const float MaxTemp = 1f;
                private const float MinDry = 0.6f;
                private const float MaxDry = 1f;

                public Desert(int id, Color color) : base(id, color, MinTemp, MaxTemp, MinDry, MaxDry) { }
            }
        }
    }
}

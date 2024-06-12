using System;

namespace CapakAlma.Common
{
    [Serializable]
    internal class Tool
    {
        public String Name { get; set; }

        public int Id { get; set; }

        public System.Drawing.Image Picture { get; set; }

        public int Rpm { get; set; }

        public int OffsetLocation { get; set; }

        public int Length { get; set; }
        
        public int Width { get; set; }
        
        public int PushCropPickPosition { get; set; }

        public int RevulationCount { get; set; }

    }
}
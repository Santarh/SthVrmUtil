using SthVrmUtil.Runtime.ExpressionWrapper.Interface;
using VRM;

namespace SthVrmUtil.Runtime.ExpressionWrapper.Internal
{
    internal sealed class Vrm0XBlendShapeClip : IVirtualBlendShapeClip
    {
        public BlendShapeKey Key { get; set; }
        public string BlendShapeName { get; set; }
        public BlendShapePreset Preset { get; set; }
        public bool IsBinary { get; set; }

        public Vrm0XBlendShapeClip(BlendShapeClip clip)
        {
            Key = clip.Key;
            BlendShapeName = clip.BlendShapeName;
            Preset = clip.Preset;
            IsBinary = clip.IsBinary;
        }
    }
}
using SthVrmUtil.Runtime.ExpressionWrapper.Interface;

namespace VRM
{
    public class SthBlendShapeClip : IVirtualBlendShapeClip
    {
        public string BlendShapeName { get; set; }
        public BlendShapePreset Preset { get; set; }
        public BlendShapeKey Key { get; set; }
        public bool IsBinary { get; set; }
    }
}
using SthVrmUtil.Runtime.ExpressionWrapper.Interface;
using UniVRM10;
using VRM;

namespace SthVrmUtil.Runtime.ExpressionWrapper.Internal
{
    internal sealed class Vrm10BlendShapeClip : IVirtualBlendShapeClip
    {
        public BlendShapeKey Key { get; }
        public string BlendShapeName { get; }
        public BlendShapePreset Preset { get; }
        public bool IsBinary { get; }

        public Vrm10BlendShapeClip(ExpressionKey key, VRM10Expression expression)
        {
            Key = key.ToVrm0X();
            BlendShapeName = key.Name;
            Preset = Key.Preset;
            IsBinary = expression.IsBinary;
        }
    }
}
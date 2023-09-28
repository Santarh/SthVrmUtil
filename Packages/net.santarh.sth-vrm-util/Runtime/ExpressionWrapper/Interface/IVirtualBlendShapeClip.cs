using VRM;

namespace SthVrmUtil.Runtime.ExpressionWrapper.Interface
{
    public interface IVirtualBlendShapeClip
    {
        // GameObject Prefab { get; }
        string BlendShapeName { get; }
        BlendShapePreset Preset { get; }
        BlendShapeKey Key { get; }
        // BlendShapeBinding[] Values { get; }
        // MaterialValueBinding[] MaterialValues { get; }
        bool IsBinary { get; }
        // void CopyFrom(IVirtualBlendShapeClip src);
    }
}
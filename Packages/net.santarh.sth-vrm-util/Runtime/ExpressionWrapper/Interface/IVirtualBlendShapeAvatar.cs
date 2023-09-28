using System.Collections.Generic;
using VRM;

namespace SthVrmUtil.Runtime.ExpressionWrapper.Interface
{
    public interface IVirtualBlendShapeAvatar
    {
        List<IVirtualBlendShapeClip> Clips { get; }

        // void ChangeDefaultPreset();
        // void SetClip(BlendShapeKey key, IVirtualBlendShapeClip clip);

        IVirtualBlendShapeClip GetClip(BlendShapeKey key);
        IVirtualBlendShapeClip GetClip(BlendShapePreset preset);
        IVirtualBlendShapeClip GetClip(string name);
    }
}
using System.Collections.Generic;
using SthVrmUtil.Runtime.ExpressionWrapper;
using SthVrmUtil.Runtime.ExpressionWrapper.Interface;

namespace VRM
{
    public class SthBlendShapeAvatar : IVirtualBlendShapeAvatar
    {
        public List<IVirtualBlendShapeClip> Clips { get; set; }


        public IVirtualBlendShapeClip GetClip(BlendShapeKey key)
        {
            throw new System.NotImplementedException();
        }

        public IVirtualBlendShapeClip GetClip(BlendShapePreset preset)
        {
            throw new System.NotImplementedException();
        }

        public IVirtualBlendShapeClip GetClip(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
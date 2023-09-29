using System.Collections.Generic;
using System.Linq;
using SthVrmUtil.Runtime.ExpressionWrapper.Interface;
using VRM;

namespace SthVrmUtil.Runtime.ExpressionWrapper.Internal
{
    internal sealed class Vrm0XBlendShapeAvatar : IVirtualBlendShapeAvatar
    {
        public List<IVirtualBlendShapeClip> Clips { get; }

        public Vrm0XBlendShapeAvatar(BlendShapeAvatar avatar)
        {
            Clips = avatar.Clips.Select(x => (IVirtualBlendShapeClip)new Vrm0XBlendShapeClip(x)).ToList();
        }

        public IVirtualBlendShapeClip GetClip(BlendShapeKey key)
        {
            return Clips.FirstOrDefault(x => x.Key.Equals(key));
        }

        public IVirtualBlendShapeClip GetClip(BlendShapePreset preset)
        {
            return Clips.FirstOrDefault(x => x.Key.Equals(BlendShapeKey.CreateFromPreset(preset)));
        }

        public IVirtualBlendShapeClip GetClip(string name)
        {
            return Clips.FirstOrDefault(x => x.Key.Equals(BlendShapeKey.CreateUnknown(name)));
        }
    }
}
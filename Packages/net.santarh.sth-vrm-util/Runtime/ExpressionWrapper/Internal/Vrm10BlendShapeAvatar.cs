using System;
using System.Collections.Generic;
using System.Linq;
using SthVrmUtil.Runtime.ExpressionWrapper.Interface;
using UniVRM10;
using VRM;

namespace SthVrmUtil.Runtime.ExpressionWrapper.Internal
{
    internal sealed class Vrm10BlendShapeAvatar : IVirtualBlendShapeAvatar
    {
        public List<IVirtualBlendShapeClip> Clips { get; }

        public Vrm10BlendShapeAvatar(VRM10ObjectExpression expression)
        {
            Clips = expression.Clips
                .Select(x => (IVirtualBlendShapeClip)new Vrm10BlendShapeClip(ExpressionKey.CreateFromPreset(x.Preset), x.Clip))
                .Concat(expression.CustomClips.Select(x => new Vrm10BlendShapeClip(ExpressionKey.CreateCustom(x.name), x)))
                .ToList();
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
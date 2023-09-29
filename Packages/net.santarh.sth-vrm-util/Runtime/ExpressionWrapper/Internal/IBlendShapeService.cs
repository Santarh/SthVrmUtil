using System.Collections.Generic;
using SthVrmUtil.Runtime.ExpressionWrapper.Interface;
using VRM;

namespace SthVrmUtil.Runtime.ExpressionWrapper.Internal
{
    internal interface IBlendShapeService
    {
        IVirtualBlendShapeAvatar BlendShapeAvatar { get; }
        float GetWeight(BlendShapeKey key);
        IEnumerable<(BlendShapeKey Key, float Weight)> GetWeights();
        void AccumulateWeight(BlendShapeKey key, float weight);
        void Apply();
    }
}
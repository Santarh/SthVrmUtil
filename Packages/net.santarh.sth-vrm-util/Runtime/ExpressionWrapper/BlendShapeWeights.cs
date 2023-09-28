using System.Collections.Generic;
using VRM;

namespace SthVrmUtil.Runtime.ExpressionWrapper
{
    internal sealed class BlendShapeWeights
    {
        private readonly Dictionary<BlendShapeKey, float> _weights = new Dictionary<BlendShapeKey, float>();
    }
}
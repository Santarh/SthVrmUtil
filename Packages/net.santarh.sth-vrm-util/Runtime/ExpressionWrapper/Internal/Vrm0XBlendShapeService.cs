using System.Collections.Generic;
using System.Linq;
using SthVrmUtil.Runtime.ExpressionWrapper.Interface;
using VRM;

namespace SthVrmUtil.Runtime.ExpressionWrapper.Internal
{
    internal sealed class Vrm0XBlendShapeService : IBlendShapeService
    {
        private readonly VRMBlendShapeProxy _proxy;

        public IVirtualBlendShapeAvatar BlendShapeAvatar { get; }

        public Vrm0XBlendShapeService(VRMBlendShapeProxy proxy)
        {
            _proxy = proxy;
            BlendShapeAvatar = new Vrm0XBlendShapeAvatar(proxy.BlendShapeAvatar);
        }

        public float GetWeight(BlendShapeKey key)
        {
            return _proxy.GetValue(key);
        }

        public IEnumerable<(BlendShapeKey Key, float Weight)> GetWeights()
        {
            return _proxy.GetValues().Select(x => (x.Key, x.Value));
        }

        public void AccumulateWeight(BlendShapeKey key, float weight)
        {
            _proxy.AccumulateValue(key, weight);
        }

        public void Apply()
        {
            _proxy.Apply();
        }
    }
}
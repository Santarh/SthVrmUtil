using System.Collections.Generic;
using SthVrmUtil.Runtime.ExpressionWrapper.Interface;
using Unity.Plastic.Newtonsoft.Json.Serialization;
using UniVRM10;
using VRM;

namespace SthVrmUtil.Runtime.ExpressionWrapper.Internal
{
    internal sealed class Vrm10BlendShapeService : IBlendShapeService
    {
        private readonly Dictionary<ExpressionKey, float> _weights = new Dictionary<ExpressionKey, float>();
        private readonly Vrm10Instance _vrm10Instance;

        public IVirtualBlendShapeAvatar BlendShapeAvatar { get; }

        public Vrm10BlendShapeService(Vrm10Instance vrm10Instance)
        {
            _vrm10Instance = vrm10Instance;
            BlendShapeAvatar = new Vrm10BlendShapeAvatar(_vrm10Instance.Vrm.Expression);
        }

        public float GetWeight(BlendShapeKey key)
        {
            return _vrm10Instance.Runtime.Expression.GetWeight(key.ToVrm10());
        }

        public IEnumerable<(BlendShapeKey Key, float Weight)> GetWeights()
        {
            foreach (var kv in _vrm10Instance.Runtime.Expression.GetWeights())
            {
                yield return (kv.Key.ToVrm0X(), kv.Value);
            }
        }

        public void AccumulateWeight(BlendShapeKey key, float weight)
        {
            _weights[key.ToVrm10()] = weight;
        }

        public void Apply()
        {
        #if VRM10_IS_0_114_0_OR_LATER
            _vrm10Instance.Runtime.Expression.SetWeightsNonAlloc(_weights);
        #else
            _vrm10Instance.Runtime.Expression.SetWeights(_weights);
        #endif
            _weights.Clear();
        }
    }
}
using System.Collections.Generic;
using Unity.Plastic.Newtonsoft.Json.Serialization;
using UniVRM10;
using VRM;

namespace SthVrmUtil.Runtime.ExpressionWrapper.Internal
{
    internal sealed class Vrm10RuntimeExpressionWrapper
    {
        private readonly Dictionary<ExpressionKey, float> _weights = new Dictionary<ExpressionKey, float>();
        private readonly Func<Vrm10RuntimeExpression> _expressionGetter;

        public Vrm10RuntimeExpressionWrapper(Func<Vrm10RuntimeExpression> expressionGetter)
        {
            _expressionGetter = expressionGetter;
        }

        public float GetWeight(BlendShapeKey key)
        {
            return _expressionGetter().GetWeight(key.ToVrm10());
        }

        public IEnumerable<(BlendShapeKey Key, float Weight)> GetWeights()
        {
            foreach (var kv in _expressionGetter().GetWeights())
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
            var expression = _expressionGetter();
        #if VRM10_IS_0_114_0_OR_LATER
            expression.SetWeightsNonAlloc(_weights);
        #else
            expression.SetWeights(_weights);
        #endif
            _weights.Clear();
        }
    }
}
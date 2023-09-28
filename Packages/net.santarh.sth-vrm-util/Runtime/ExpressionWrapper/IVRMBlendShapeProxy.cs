using System.Collections.Generic;
using VRM;

namespace SthVrmUtil.Runtime.ExpressionWrapper
{
    public interface IVRMBlendShapeProxy
    {
        void Reinitialize();

        // NOTE: Get
        float GetValue(BlendShapeKey key);
        float GetValue(BlendShapePreset key);
        float GetValue(string key);
        IEnumerable<KeyValuePair<BlendShapeKey, float>> GetValues();

        // NOTE: 累積させてから反映
        void AccumulateValue(BlendShapeKey key, float value);
        void AccumulateValue(BlendShapePreset key, float value);
        void AccumulateValue(string key, float value);
        void Apply();

        // NOTE: 引数によって即時反映かどうか変わる
        void SetValue(BlendShapePreset key, float value, bool apply);
        void SetValue(string key, float value, bool apply);
        void SetValue(BlendShapeKey key, float value, bool apply);

        // NOTE: 即時反映
        void SetValue(BlendShapePreset key, float value);
        void SetValue(string key, float value);
        void SetValue(BlendShapeKey key, float value);
        void SetValues(IEnumerable<KeyValuePair<BlendShapeKey, float>> values);
        void ImmediatelySetValue(BlendShapeKey key, float value);
        void ImmediatelySetValue(BlendShapePreset key, float value);
        void ImmediatelySetValue(string key, float value);
    }
}
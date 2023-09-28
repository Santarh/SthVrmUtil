using System.Collections.Generic;
using SthVrmUtil.Runtime.ExpressionWrapper;
using UnityEngine;

// NOTE: namespace は詐称する
namespace VRM
{
    public class SthVRMBlendShapeProxy : MonoBehaviour, IVRMBlendShapeProxy
    {
        public void Reinitialize()
        {
            // NOTE: 再生成は VRM 1.0 モデルを色々弄る必要があってちょっとめんどい
            throw new System.NotImplementedException();
        }

        public float GetValue(BlendShapeKey key)
        {
            throw new System.NotImplementedException();
        }

        public float GetValue(BlendShapePreset key)
        {
            throw new System.NotImplementedException();
        }

        public float GetValue(string key)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<KeyValuePair<BlendShapeKey, float>> GetValues()
        {
            throw new System.NotImplementedException();
        }

        public void AccumulateValue(BlendShapeKey key, float value)
        {
            throw new System.NotImplementedException();
        }

        public void AccumulateValue(BlendShapePreset key, float value)
        {
            throw new System.NotImplementedException();
        }

        public void AccumulateValue(string key, float value)
        {
            throw new System.NotImplementedException();
        }

        public void Apply()
        {
            throw new System.NotImplementedException();
        }

        public void SetValue(BlendShapePreset key, float value, bool apply)
        {
            throw new System.NotImplementedException();
        }

        public void SetValue(string key, float value, bool apply)
        {
            throw new System.NotImplementedException();
        }

        public void SetValue(BlendShapeKey key, float value, bool apply)
        {
            throw new System.NotImplementedException();
        }

        public void SetValue(BlendShapePreset key, float value)
        {
            throw new System.NotImplementedException();
        }

        public void SetValue(string key, float value)
        {
            throw new System.NotImplementedException();
        }

        public void SetValue(BlendShapeKey key, float value)
        {
            throw new System.NotImplementedException();
        }

        public void SetValues(IEnumerable<KeyValuePair<BlendShapeKey, float>> values)
        {
            throw new System.NotImplementedException();
        }

        public void ImmediatelySetValue(BlendShapeKey key, float value)
        {
            throw new System.NotImplementedException();
        }

        public void ImmediatelySetValue(BlendShapePreset key, float value)
        {
            throw new System.NotImplementedException();
        }

        public void ImmediatelySetValue(string key, float value)
        {
            throw new System.NotImplementedException();
        }
    }
}
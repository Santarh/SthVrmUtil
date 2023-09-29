using System;
using System.Text;
using System.Threading.Tasks;
using UniGLTF;
using UnityEngine;
using UniVRM10;
using VRM;

namespace SthVrmUtil.Example
{
    public class ExampleEntryPoint : MonoBehaviour
    {
        private SthVRMBlendShapeProxy _blendShapeProxy;

        private async void Start()
        {
            if (!Application.isEditor) return;

            var filePath = "";
        #if UNITY_EDITOR
            filePath = UnityEditor.EditorUtility.OpenFilePanel("Open VRM file", "", "vrm");
        #endif

            Vrm10Instance vrm10Instance = null;
            RuntimeGltfInstance vrm0XInstance = null;

            // NOTE: VRM 1.0 ファイルとしてロードをトライする
            try
            {
                vrm10Instance = await Vrm10.LoadPathAsync(filePath, canLoadVrm0X: false);
            }
            catch (Exception e)
            {
                Debug.Log("File is not VRM 1.0");
            }

            // NOTE: VRM 0.X ファイルとしてロードをトライする
            if (vrm10Instance == null)
            {
                try
                {
                    vrm0XInstance = await VrmUtility.LoadAsync(filePath);
                    vrm0XInstance.ShowMeshes();
                }
                catch (Exception e)
                {
                    Debug.Log("File is not VRM 0.X");
                }
            }

            // NOTE: ロード失敗
            if (vrm10Instance == null && vrm0XInstance == null) return;

            // NOTE: VRM 0.X / 1.0 両対応の SthVRMBlendShapeProxy を AddComponent
            if (vrm10Instance != null)
            {
                _blendShapeProxy = vrm10Instance.gameObject.AddComponent<SthVRMBlendShapeProxy>().Initialize();
            }
            else if (vrm0XInstance != null)
            {
                _blendShapeProxy = vrm0XInstance.gameObject.AddComponent<SthVRMBlendShapeProxy>().Initialize();
            }

            // NOTE: BlendShape 一覧をログ出力
            var sb = new StringBuilder();
            foreach (var clip in _blendShapeProxy.BlendShapeAvatar.Clips)
            {
                sb.AppendLine($"{clip.Preset}:{clip.BlendShapeName}");
            }
            Debug.Log(sb.ToString());
        }

        private void Update()
        {
            if (_blendShapeProxy == null) return;

            _blendShapeProxy.ImmediatelySetValue(BlendShapePreset.Joy, Mathf.Sin(Time.time * 3f) * 0.5f + 0.5f);
            _blendShapeProxy.ImmediatelySetValue(BlendShapePreset.A, Mathf.Cos(Time.time * 7f) * 0.5f + 0.5f);
        }
    }
}

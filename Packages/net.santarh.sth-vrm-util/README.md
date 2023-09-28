# Sth VRM Util

## ExpressionWrapper

VRM 0.X の `VRMBlendShapeProxy` コンポーネントと互換の API を使って VRM 1.0 モデルの Expression を。操作可能にします。

```csharp
private async void Start()
{
    // NOTE: VRM 1.0 モデルをロードします
    var vrm10Instance = await Vrm10.LoadPathAsync("path/to/vrm");

    // NOTE: VRM 0.X の VRMBlendShapeProxy の API をエミュレーションして表情操作可能なコンポーネントを追加します
    var blendShapeProxy10 = vrm10Instance.gameObject.AddComponent<SthVRMBlendShapeProxy>();

    // NOTE: VRM 0.X のプリセットを指定して VRM 1.0 モデルの表情を変更します
    blendShapeProxy10.SetValue(BlendShapePreset.Joy, 1.0f, apply: true);

    // NOTE: 取得もできます
    var value = blendShapeProxy10.GetValue(BlendShapePreset.Joy);
}
```
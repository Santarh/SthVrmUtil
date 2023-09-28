# Sth VRM Util

## 導入方法

Unity 上部メニューバーから `Window -> Package Manager` を選択し、 `+` ボタンを押して `Add package from git URL...` を選択します。

そして入力欄に以下の URL を入力し、 `Add` ボタンを押します。

```
https://github.com/Santarh/SthVrmUtil.git?path=/Packages/net.santarh.sth-vrm-util#1.0.0
```

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
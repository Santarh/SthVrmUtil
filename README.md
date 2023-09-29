# Sth VRM Util

以下のバージョンにて動作確認を行っています。

- Unity 2021.3
- UniVRM v0.114.0

## 導入方法

Unity 上部メニューバーから `Window -> Package Manager` を選択し、 `+` ボタンを押して `Add package from git URL...` を選択します。

そして入力欄に以下の URL を入力し、 `Add` ボタンを押します。

```
https://github.com/Santarh/SthVrmUtil.git?path=/Packages/net.santarh.sth-vrm-util#1.0.0
```

## ExpressionWrapper

VRM 0.X の `VRMBlendShapeProxy` コンポーネント互換の API を用いて VRM 1.0 モデルの Expression を操作可能にします。

VRM 0.X モデル向けの表情操作コードを流用するのに便利です。

```csharp
private async void Start()
{
    // NOTE: VRM 1.0 モデルをロードします
    var vrm10Instance = await Vrm10.LoadPathAsync("path/to/vrm");

    // NOTE: VRM 0.X の VRMBlendShapeProxy の API をエミュレーションして表情操作可能なコンポーネントを追加します
    var blendShapeProxy = vrm10Instance.gameObject.AddComponent<SthVRMBlendShapeProxy>().Initialize();

    // NOTE: VRM 0.X のプリセットを指定して VRM 1.0 モデルの表情を変更します
    blendShapeProxy.ImmediatelySetValue(BlendShapePreset.Joy, 1.0f);

    // NOTE: 取得もできます
    var value = blendShapeProxy.GetValue(BlendShapePreset.Joy);
}
```
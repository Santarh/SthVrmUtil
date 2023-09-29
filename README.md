# Sth VRM Util

以下のバージョンにて動作確認を行っています。

- Unity 2021.3
- UniVRM v0.114.0

## 導入方法

Unity 上部メニューバーから `Window -> Package Manager` を選択し、 `+` ボタンを押して `Add package from git URL...` を選択します。

そして入力欄に以下の URL を入力し、 `Add` ボタンを押します。

```
https://github.com/Santarh/SthVrmUtil.git?path=/Packages/net.santarh.sth-vrm-util#2.0.0
```

## ExpressionWrapper

`SthVRMBlendShapeProxy` コンポーネントは VRM 0.X / 1.0 両方のモデルに対応する表情操作 API です。

VRM 0.X モデル向けの表情操作コードを流用するのに便利です。

API は VRM 0.X の `VRMBlendShapeProxy` と互換の名前を持ちます。
ウェイトの Get/Set や表情リスト取得に対応しています。

ただし `VRMBlendShapeClip` の定義自体を操作したり、中身を深く操作することには対応していません。

```csharp
// NOTE: VRM 1.0 モデルの表情を操作する
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

```csharp
// NOTE: VRM 0.X モデルの表情を操作する
private async void Start()
{
    // NOTE: VRM 0.X モデルをロードします
    var vrm0XInstance = await VrmUtility.LoadAsync("path/to/vrm");
    vrm0XInstance.ShowMeshes();

    // NOTE: VRM 0.X の VRMBlendShapeProxy の API をエミュレーションして表情操作可能なコンポーネントを追加します
    var blendShapeProxy = vrm0XInstance.gameObject.AddComponent<SthVRMBlendShapeProxy>().Initialize();

    // NOTE: VRM 0.X のプリセットを指定して VRM 0.X モデルの表情を変更します
    blendShapeProxy.ImmediatelySetValue(BlendShapePreset.Joy, 1.0f);

    // NOTE: 取得もできます
    var value = blendShapeProxy.GetValue(BlendShapePreset.Joy);
}
```
# Home Run Derby ⚾

Unityで開発した3Dホームランダービーゲームです。WebGLでビルドしており、ブラウザ上で直接プレイできます。

## 🎮 ゲームについて

バットを振ってボールを飛ばし、ホームランを狙うシンプルなゲームです。

### 特徴
- 3Dグラフィックスを使用したリアルな野球体験
- 物理演算を活用したボールの軌道計算
- WebGLでブラウザ上で動作

## 🎯 プレイ方法

**WebGL版（推奨）**
[🎮 ゲームをプレイする](https://[あなたのGitHubユーザー名].github.io/HomeRunDerby/)

ブラウザ上で直接プレイできます。

### 操作方法
- マウス操作でバットを振る
- タイミングを合わせてボールを打つ

## 🛠️ 技術仕様

- **エンジン**: Unity 2022.x
- **言語**: C#
- **プラットフォーム**: WebGL
- **対応ブラウザ**: Chrome, Firefox, Safari, Edge（WebGL対応ブラウザ）

## 📁 プロジェクト構成

```
HomeRunDerby/
├── Assets/
│   ├── CameraControl.cs      # カメラ制御
│   ├── ShootBall.cs         # ボール発射制御
│   ├── SwingBat.cs          # バット振り制御
│   ├── Delete.cs            # オブジェクト削除処理
│   └── Scenes/              # ゲームシーン
├── HomeRunDerby/            # WebGLビルド
│   ├── index.html
│   ├── Build/
│   └── TemplateData/
└── Blender/                 # 3Dモデル作成ファイル
```

## 💻 開発環境

- Unity 2022.x
- Visual Studio Code
- Blender（3Dモデリング）

## 🚀 ビルド・実行方法

### WebGL版
1. Unityでプロジェクトを開く
2. File > Build Settings > WebGL を選択
3. Build してWebサーバーで実行

### ローカル実行
プロジェクトをクローンした後：
```bash
# Unity Editorで開く
# または WebGLビルド後、ローカルサーバーで実行
cd HomeRunDerby
python -m http.server 8000  # Python 3の場合
# http://localhost:8000 でアクセス
```

## 📝 開発メモ

このゲームは個人開発プロジェクトとして制作しました。Unity学習の一環として、3D物理演算とWebGL出力の技術習得を目的としています。

## 📄 ライセンス

このプロジェクトは個人のポートフォリオ用途です。

---

💼 **就活ポートフォリオ用プロジェクト**  
🔗 **GitHub Pages**: https://[あなたのGitHubユーザー名].github.io/HomeRunDerby/

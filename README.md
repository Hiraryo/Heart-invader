<h1 align="center">Heart invader</h1>

## 使用ツールについて
- ゲームエンジン
  - Unity 2019.4.20f1(LTS)
  
- テキストエディタ
  - 自由

## 命名規則について<img src="https://user-images.githubusercontent.com/60394438/107554180-f1ff7e00-6c18-11eb-8826-fd2285881a5f.png" width="13%">
| 種類 | 表記方法 |例|
---|---|---
|ローカル変数名| **ローワーキャメル** |```heartInvader```|
|クラス名、関数名、列挙体名| **アッパーキャメル** |```HeartInvader```|
|private,public,protected変数|先頭```_```(アンダースコア)を付けた **ローワーキャメル** |```_heartInvader```|
|定数|全部大文字、単語間に```_```(アンダースコア)を付けた **アッパースネーク** |```HEART_INVADER```|

# α版の仕様
## メイン部分のクラス図
### エネミー
![HeartInvader](https://user-images.githubusercontent.com/60394438/110326865-90d29b00-805c-11eb-9ce1-a8993028c833.png)

## メイン部分の抽出
## UI
- WAVE表示
- プレイヤーの状態表示
- ポーズボタン
- 「ゲームスタート」テキスト表示
- クリア条件テキスト表示
- ダイアログ表示
- 敵のHPを表示
- ヒロインのHPを表示
- ステージの経過時間を表示

## 機能
### プレイヤー
- 移動機能
- 攻撃機能
- 攻撃の切り替え機能
- 必殺技を出す機能
- 範囲攻撃機能
- リロード機能

### エネミー
- 移動機能
- 生成（生成位置：ヒロインの周囲から）機能
- 攻撃機能
  - 近距離バージョン(2パターン)
  - 体当たりするような形で攻撃
    - パターン１：高火力・低体力
    - パターン２：低火力・高体力
  - 遠距離バージョン
    - 弾をヒロインに向かって発射してくる
    - 弾は主人公に当たると消える
    - 中火力・中体力
    - (追記)弾はヒロインに当たっても消える
- ダメージ機能
#### 移動機能で異なる部分
- なし
#### 攻撃機能で異なる部分
- 近距離は体当たり攻撃
- 遠距離はヒロインに向かって弾を発射する→ヒロインの位置を把握する

### ヒロイン
- 移動機能
- ダメージ機能
- 武器を強化する機能
- 武器を回復する機能

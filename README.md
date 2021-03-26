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
![110889854-468a3c00-8332-11eb-813b-8d8be08f792b](https://user-images.githubusercontent.com/60394438/110981901-319dbf00-83ab-11eb-8f3f-479553cf2f3d.png)

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
- 移動機能◯
- ~生成（生成位置：ヒロインの周囲から）機能~◯(ランダムで範囲円状で指定可能)
- 攻撃機能◯
  - 近距離バージョン(2パターン)
  - 体当たりするような形で攻撃×
    - パターン１：高火力・低体力
    - パターン２：低火力・高体力
  - 遠距離バージョン◯
    - 弾をヒロインに向かって発射してくる△
    - 弾は主人公に当たると消える△
    - 中火力・中体力
    - (追記)弾はヒロインに当たっても消える△
- ダメージ機能△

*弾の発射方向、弾の消し方は修正すること*

#### 移動機能で異なる部分
- なし
#### 攻撃機能で異なる部分
- 近距離は体当たり攻撃(等速)
- 遠距離は弾を発射する→ヒロインの位置を把握する(~放物線 or~ ライナー)
- 敵は全てヒロインを狙う。(**プレイヤーへの攻撃はなし**)

敵：狙って、セットして、当たって、死んじゃう<br>
弾：セットされて、飛んで、消える<br>

#### 敵が生成される範囲
![2021-03-10_11 30 02](https://user-images.githubusercontent.com/60394438/112376747-28f0a580-8d28-11eb-8b16-b9257dd8ee0e.png)


#### 敵生成（パターン１）
敵を生成するタイミングがゲーム開始ごとに変わり、そのタイミングで全て生成する
![A](https://user-images.githubusercontent.com/60394438/112376394-bed80080-8d27-11eb-90e3-0f86bf4211cf.gif)

#### 敵生成（パターン２）
ゲーム開始と同時に全ての敵を生成する
![B](https://user-images.githubusercontent.com/60394438/112376352-b1bb1180-8d27-11eb-9a89-0c2e414f933c.gif)

### ヒロイン
- 移動機能
- ダメージ機能
- 武器を強化する機能
- 武器を回復する機能

### メモ
![スクリーンショット 2021-03-23 8 14 27](https://user-images.githubusercontent.com/60394438/112069883-fde34600-8baf-11eb-9167-d351f69ecfd5.png)
![スクリーンショット 2021-03-25 4 38 30](https://user-images.githubusercontent.com/60394438/112373216-0bb9d800-8d24-11eb-8228-4524a957593d.png)


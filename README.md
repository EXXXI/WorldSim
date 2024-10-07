# WorldSim(気ままに作ったモンハンシミュレータ for MHW)

## 概要

Windows上で動くモンハンワールドスキルシミュレータです

## 更新・対応状況

本体の最終更新：2024/10/07 正式公開

CSVの最終更新：2024/10/07 正式公開

今までの更新履歴は[ReleaseNote.md](./ReleaseNote.md)を参照

## 特徴

- 各種データをCSV形式(一部json形式)で保持しています
  - イベクエ追加時など、装備等の追加を、シミュの更新を待たずに自身で行えます
- 「最近検索に利用したスキル」からスキルを選択できます
- 「よく使う検索条件」を保存して、必要な時に呼び出すことができます

## 使い方

### 起動方法

- WorldSim.zipをダウンロード
- WorldSim.zipを解凍
- 中にあるWorldSim.exeをダブルクリック

### 機能説明

偉大な先人が作られたシミュに似せているので大体見ればわかるはず

詳しく知りたい人は[Reference.md](./Reference.md)を参照してください

## 注意点

- 64bitマシンのWindowsでしか動きません
- .Netのインストールが必要です(無ければ起動時に案内されるはず)
  - x64のデスクトップランタイムで動くはず
  - 持ってない場合は、Visual C++ 再頒布可能パッケージも必要
- ファイルにデータを書き出す(マイセットとかの保存用)ので、ウィルス対策ソフトが文句言ってくる場合があります
- スキルによる防御や耐性上昇は計算していません
- 極意の有無のチェックは行っていません
- 覚醒武器によるシリーズスキルは非対応です
  - 中途半端なレベルでも検索可能にしているので、シリーズスキル付きの覚醒武器を想定している場合、検索条件側を1Lv下げてください
- ワンセット防具の制御は入れていません
  - ワンセット防具で装飾品の計算等をしたい場合は固定機能を使ってください
- 装飾品の組み合わせは1通りしか検索しないため、他の組み合わせが可能な場合もあります
  - 例：研磨・達人珠【４】1つと攻撃珠【１】1つ→研磨・攻撃珠【４】1つと達人珠【１】1つ
  - 空きスロ欄に表示される空きスロは、表示されている装飾品を装備した場合の空きスロです
- 検索アルゴリズムの仕様上、1度に1000件や2000件検索するのはとても重くなります
  - 大量に検索するより、追加スキル検索や除外・固定機能をうまく使って絞り込む方がいいです
- 「WPFって何だっけ？」って状態から1週間で大枠作ったので色々甘いのは許して
  - WPFの習得もコレを作った目的の一つなので、マズイところ等ご指摘いただければ狂喜乱舞します

## ライセンス

The MIT License

### ↑このライセンスって何？

こういう使い方までならOKだよ、ってのを定める取り決め

今回のは大体こんな感じ

- 基本は好きに使ってOK
- このシミュのせいで何か起きても開発者は責任取らんよ
- 改変や再配布するときはよく調べてルールに従ってね

## お問い合わせ

不具合発見時や欲しい機能がある際は、このリポジトリのIssueか、以下の質問箱へどうぞ(質問箱は別のところでも使いまわしているので、このシミュのことだと分かるようにお願いします)

[質問箱](https://peing.net/ja/58b7c250e12e37)

## 使わせていただいたOSS(+必要であればライセンス)

### Google OR-Tools

プロジェクト：<https://github.com/google/or-tools>

ライセンス：<https://github.com/google/or-tools/blob/stable/LICENSE>

### CSV

プロジェクト：<https://github.com/stevehansen/csv/>

ライセンス：<https://raw.githubusercontent.com/stevehansen/csv/master/LICENSE>

### Prism.Wpf

プロジェクト：<https://github.com/PrismLibrary/Prism>

ライセンス：<https://www.nuget.org/packages/Prism.Wpf/8.1.97/license>

### ReactiveProperty

プロジェクト：<https://github.com/runceel/ReactiveProperty>

ライセンス：<https://github.com/runceel/ReactiveProperty/blob/main/LICENSE.txt>

### NLog

プロジェクト：<https://nlog-project.org/>

### DotNetKit.Wpf.AutoCompleteComboBox

プロジェクト：<https://github.com/vain0x/DotNetKit.Wpf.AutoCompleteComboBox/>

ライセンス：<https://www.nuget.org/packages/DotNetKit.Wpf.AutoCompleteComboBox/1.6.0/license>

## スペシャルサンクス

### 5chモンハン板シミュスレの方々

特にVer.13の>>480様の以下論文を大いに参考にしました

<https://github.com/13-480/lp-doc>

### 先人のシミュ作成者様

特に頑シミュ様のUIに大きく影響を受けています

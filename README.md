# fraction class
C#で分数の計算を行うクラス
このクラスはC#上で分数の計算を行うクラスです。int型やdouble型といった組み込み型と同様に四則演算の演算子（+,-,×,÷）や大小比較を使うことができます。

### プロジェクトの構成
本プロジェクトファイルはvisual studioで作られたものです。構成は以下のようになっています。
* Fraction: fractionクラス本体
* FractionTest: fractionクラスの動作を確認するためのFormプロジェクト

### 導入
1. dllの参照  
「Fraction/bin」フォルダ内にある「fraction.dll」を使いたいプロジェクトから参照してください。visual studioでの参照の方法は[こちら](https://msdn.microsoft.com/ja-jp/library/7314433t(v=vs.90).aspx)

2. usingディレクティブの追加  
fractionクラスを使いたいコードの頭に以下のusingディレクティブを追加してください。  
    using fraction;

### 使用例

fractionクラスはコンストラクタを明示しなければいけないこと以外はint型やdouble型などと同じように使えます。  
    fraction x = new fraction(1,3);//x=1/3    
    fraction y = new fraction(4,3);//y=4/3

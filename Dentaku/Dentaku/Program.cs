using System;
using System.Text.RegularExpressions;

namespace Dentaku
{
    /// <summary>
    /// 電卓メインクラス
    /// </summary>
    /// <remarks>
    /// 数値演算子を個別で入力した場合にも対応する
    /// </remarks>
    public class Program
    {
        /// <summary>
        /// 四則演算を行う
        /// </summary>
        /// <remarks>
        /// 数値演算子を個別で入力した場合にも対応する
        /// </remarks>
        /// <param name="args">引数</param>
        static void Main(string[] args)
        {
            LineFormula lineFormula = new LineFormula();
            Compute compute = new Compute();
            Message message = new Message();
            Check check = new Check();
            
            //初期表示
            message.InitialDisplay();
            string inputValueAndResult = Console.ReadLine();

            string[] LineFormulaValue = inputValueAndResult.Split(' ', '　');
            var valueCount = LineFormulaValue.Length;
   
            if (valueCount < 3)
            {
                check.ValueCheck(inputValueAndResult);

                decimal value1AndResult = decimal.Parse(inputValueAndResult);
                int loopCounter = 0;

                // dowhile文に変更予定
                while (true)
                {
                    loopCounter++;
                    // 入力受付
                    var enteredOpe = Console.ReadLine();
                    var testValue = Console.ReadLine();
                    check.ValueCheck(testValue);
                    // 上記dowhile変更後if削除、内部処理はwhile実行後に移動
                    if (testValue == "break")
                    {
                        message.DisplayMessage(MessageJudge.BREAKJUDGE);
                        break;
                    }
                    check.ValueDistinguish(loopCounter, testValue);
                    check.OperatorCheck(enteredOpe);
                    // 配列の追加
                    // 入力値読み取り
                    Regex.IsMatch(testValue, "[0-9]");
                    decimal enteredValue2 = decimal.Parse(testValue);
                    compute.SisokuCompute(value1AndResult, enteredOpe, enteredValue2);
                }
            }
            else
            {          
                // 一列入力時の処理
                lineFormula.LineCompute(LineFormulaValue);
            }
            Console.Read();
        }
    }
}


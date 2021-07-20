using System;
using System.Text.RegularExpressions;

namespace Dentaku
{
    /// <summary>
    /// 入力値の計算結果を返すクラス
    /// </summary>
    /// <remarks>
    /// 数値演算子を個別で入力した場合にも対応する
    /// </remarks>
    class Program
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
            Message.InitialDisplay();
            var inputValueAndResult = Console.ReadLine();
            //一列入力時の処理

            Check.ValueCheck(inputValueAndResult);

            decimal value1AndResult = decimal.Parse(inputValueAndResult);
            int loopCounter = 0;

            //dowhile文に変更予定
            while (true)
            {
                loopCounter++;
                //入力受付
                var enteredOpe = Console.ReadLine();
                var test = Console.ReadLine();
                Check.ValueCheck(test);
                //上記dowhile変更後if削除、内部処理はwhile実行後に移動
                if (test == "break")
                {
                    Message.DisplayMessage(MessageJudge.BREAKJUDGE);
                    break;
                }

                Check.ValueDistinguish(loopCounter, test);


                Check.OperatorCheck(enteredOpe);
                //配列の追加
                //入力値読み取り


                if (
                    Regex.IsMatch(test, "[0-9]"))
                {
                    decimal enteredValue2 = decimal.Parse(test);
                    switch (enteredOpe)
                    {
                        case Operator.ADD:
                            value1AndResult = decimal.Add(value1AndResult, enteredValue2);
                            Console.WriteLine(value1AndResult);
                            break;
                        case Operator.SUB:
                            value1AndResult = decimal.Subtract(value1AndResult, enteredValue2);
                            Console.WriteLine(value1AndResult);
                            break;
                        case Operator.MUL:
                            value1AndResult = decimal.Multiply(value1AndResult, enteredValue2);
                            Console.WriteLine(value1AndResult);
                            break;
                        case Operator.DIV:
                            Check.ZeroDiv(enteredValue2);
                            value1AndResult = decimal.Divide(value1AndResult, enteredValue2);
                            Console.WriteLine(value1AndResult);
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.Read();
        }
    }
}


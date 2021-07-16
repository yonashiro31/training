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
            var formula = Console.ReadLine();
            //一列入力時の処理
            string[] EnteredAllValue = formula.Split(' ');
            Check.ValueCheck(EnteredAllValue[0]);

            decimal value1AndResult = decimal.Parse(EnteredAllValue[0]);
            int loopCounter = 0;
            while (true)
            {
                loopCounter++;
                //二度目以降の計算入力受付
                if (loopCounter > 1)
                {

                    Array.Resize(ref EnteredAllValue, EnteredAllValue.Length + 1);
                    EnteredAllValue[loopCounter + 1] = Console.ReadLine();

                    if (EnteredAllValue[loopCounter + 1] == "break")
                    {
                        Message.DisplayMessage(5);
                        break;
                    }

                    Check.ValueDistinguish(loopCounter,EnteredAllValue);
            
                }
                else if (EnteredAllValue.Length < 3)
                {
                    //配列の追加
                    //入力値読み取り
                    Array.Resize(ref EnteredAllValue, EnteredAllValue.Length + 1);
                    EnteredAllValue[EnteredAllValue.Length - 1] = Console.ReadLine();
                    Check.OperatorCheck(EnteredAllValue[1]);
                    Array.Resize(ref EnteredAllValue, EnteredAllValue.Length + 1);
                    EnteredAllValue[EnteredAllValue.Length - 1] = Console.ReadLine();
                    Check.ValueCheck(EnteredAllValue[2]);
                }

                if (EnteredAllValue.Length >= 3 && true ==
                    Regex.IsMatch(EnteredAllValue[loopCounter + 1], "[0-9]"))
                {
                    decimal enteredValue2 = decimal.Parse(EnteredAllValue[loopCounter + 1]);
                    switch (EnteredAllValue[loopCounter])
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


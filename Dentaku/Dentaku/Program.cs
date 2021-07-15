using System;
using System.Text.RegularExpressions;

//桁数表示も
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
            Message.StartDisplay();
            var formula = Console.ReadLine();
            //一列入力時の処理
            string[] inputArray = formula.Split(' ');
            Check.InputCheck(inputArray[0]);

            decimal inputNumber1 = decimal.Parse(inputArray[0]);
            while (true)
            {
                //二度目以降の計算入力受付
                if (inputArray.Length > 2)
                {
                    Array.Resize(ref inputArray, inputArray.Length + 1);
                    inputArray[inputArray.Length - 1] = Console.ReadLine();
                }
                else if (inputArray.Length < 3)
                {
                    //配列の追加
                    //入力値読み取り
                    Array.Resize(ref inputArray, inputArray.Length + 1);
                    inputArray[inputArray.Length - 1] = Console.ReadLine();
                    Check.OperatorCheck(inputArray[1]);
                    Array.Resize(ref inputArray, inputArray.Length + 1);
                    inputArray[inputArray.Length - 1] = Console.ReadLine();
                    Check.InputCheck(inputArray[2]);
                }
                //演算子チェック　if以外の記述方法模索中
                if (inputArray.Length % 2 == 0)
                {
                    Check.OperatorCheck(inputArray[inputArray.Length - 1]);
                }
                else if (inputArray.Length % 2 == 1)
                {
                    Check.InputCheck(inputArray[inputArray.Length - 1]);
                }
                //ループ脱却処理　他の記述方法に変える予定
                if (inputArray[inputArray.Length - 1] == "=")
                {
                    break;
                }

                if (inputArray.Length >= 3 && true ==
                    Regex.IsMatch(inputArray[inputArray.Length - 1], "[0-9]"))
                {
                    decimal inputNumber2 = decimal.Parse(inputArray[inputArray.Length - 1]);
                    switch (inputArray[inputArray.Length - 2])
                    {
                        case Operator.ADD:
                            inputNumber1 = decimal.Add(inputNumber1, inputNumber2);
                            Console.WriteLine(inputNumber1);
                            break;
                        case Operator.SUB:
                            inputNumber1 = decimal.Subtract(inputNumber1, inputNumber2);
                            Console.WriteLine(inputNumber1);
                            break;
                        case Operator.MUL:
                            inputNumber1 = decimal.Multiply(inputNumber1, inputNumber2);
                            Console.WriteLine(inputNumber1);
                            break;
                        case Operator.DIV:
                            Check.ZeroDiv(inputNumber2);
                            inputNumber1 = decimal.Divide(inputNumber1, inputNumber2);
                            Console.WriteLine(inputNumber1);
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


using System;
//gittest
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

            if (inputArray.Length > 2)
            {
                Check.OperaterCheck(inputArray[1]);
                Check.InputCheck(inputArray[2]);
            }
            else if (inputArray.Length < 3)
            {
                //配列の追加
                //入力値読み取り
                Array.Resize(ref inputArray, inputArray.Length + 1);
                inputArray[inputArray.Length - 1] = Console.ReadLine();
                Check.OperaterCheck(inputArray[1]);
                Array.Resize(ref inputArray, inputArray.Length + 1);
                inputArray[inputArray.Length - 1] = Console.ReadLine();
                Check.InputCheck(inputArray[2]);
            }

            decimal inputNumber1 = decimal.Parse(inputArray[0]);
            decimal inputNumber2 = decimal.Parse(inputArray[2]);
            decimal result = 0;
            Console.Write("計算結果：");

            switch (inputArray[1])
            {
                case Operator.ADD:
                    result = decimal.Add(inputNumber1, inputNumber2);
                    Console.WriteLine(result);
                    break;
                case Operator.SUB:
                    result = decimal.Subtract(inputNumber1, inputNumber2);
                    Console.WriteLine(result);
                    break;
                case Operator.MUL:
                    result = decimal.Multiply(inputNumber1, inputNumber2);
                    Console.WriteLine(result);
                    break;
                case Operator.DIV:
                    Check.ZeroDiv(inputNumber2);
                    result = decimal.Divide(inputNumber1, inputNumber2);
                    Console.WriteLine(result);
                    break;
                default:
                    break;
            }

            //decimal型の桁を取得する為変換処理
            int ketasyori = decimal.ToInt32(result);
            Console.WriteLine("整数値の桁数:" + ketasyori.ToString().Length);
            Console.Read();
        }
    }
}

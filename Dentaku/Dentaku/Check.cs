using System;
using System.Text.RegularExpressions;
namespace Dentaku
{
    /// <summary>
    /// 入力値の判定を行うクラス
    /// </summary>
    /// <remarks>
    /// Message.csから出力表示を呼び出す
    /// </remarks>
    class Check
    {
        /// <summary>
        /// 入力値が空白、または数字以外かの判定を行うメソッド
        /// </summary>
        /// <remarks>
        /// Message.csから出力表示を呼び出す
        /// </remarks>
        /// <param name="checkNumber">数値の入力が想定される引数</param>
        public static void ValueCheck(string checkNumber)
        {
            bool result = Regex.IsMatch(checkNumber, "[^0-9 | .]");
            if (string.IsNullOrEmpty(checkNumber))
            {
                Message.DisplayMessage(MessageJudge.NULLJUDGE);
                Console.Read();
                Environment.Exit(0);
            }
            else if (result)
            {
                Message.DisplayMessage(MessageJudge.NUMBERJUDGE);
                Console.Read();
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// 演算子が適切であるかの判定を行うメソッド
        /// </summary>
        /// <remarks>
        /// Operators.csで定義した定数を呼び出す
        /// </remarks>
        /// <param name="checkOperator">演算子の入力が想定される引数</param>
        public static void OperatorCheck(string checkOperator)
        {
            if (checkOperator == Operator.ADD || checkOperator == Operator.SUB
                || checkOperator == Operator.MUL || checkOperator == Operator.DIV)
            {
            }
            else
            {
                Message.DisplayMessage(MessageJudge.OPERATORJUDGE);
                Console.Read();
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// 入力値の判定を行うメソッド
        /// </summary>
        /// <remarks>
        /// 0で割っているかどうかの判定に利用する
        /// </remarks>
        /// <param name="checkNumber">数値の入力が想定される引数</param>
        public static void ZeroDiv(decimal checkNumber)
        {
            if (checkNumber == 0)
            {
                Message.DisplayMessage(MessageJudge.DIVJUDGE);
                Console.Read();
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Program.csにおいて入力値が演算子か数値化を判別するメソッド
        /// </summary>
        /// <remarks>
        /// 同クラスのOperatorCheckに処理を渡す
        /// </remarks>
        /// <param name="loopCountor">繰り返し処理をカウントする引数</param>
        /// <param name="inputArray">入力値を格納する</param>
        public static void ValueDistinguish(int loopCounter, string[] inputArray)
        {
            switch (loopCounter % 2)
            {
                case 0:
                    OperatorCheck(inputArray[loopCounter + 1]);
                    break;
                case 1:
                    ValueCheck(inputArray[loopCounter + 1]);
                    break;
            }
        }
    }
}


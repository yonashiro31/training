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
        public static void InputCheck(string checkNumber)
        {
            bool result = Regex.IsMatch(checkNumber, "[^0-9,.]");
            if (string.IsNullOrEmpty(checkNumber))
            {
                Message.DisplayMessage(4);
                Console.Read();
                Environment.Exit(0);
            }
            else if (result)
            {
                Message.DisplayMessage(3);
                Console.Read();
                Environment.Exit(0);
            }
            else
            {
            }
        }
        /// <summary>
        /// 演算子が適切であるかの判定を行うメソッド
        /// </summary>
        /// <remarks>
        /// Operators.csで定義した定数を呼び出す
        /// </remarks>
        public static void OperaterCheck(string checkOperater)
        {
            if (checkOperater == Operator.ADD || checkOperater == Operator.SUB
                || checkOperater == Operator.MUL || checkOperater == Operator.DIV)
            {
            }
            else
            {
                Message.DisplayMessage(1);
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
        public static void ZeroDiv(decimal checkNumber)
        {
            if (checkNumber == 0)
            {
                Message.DisplayMessage(2);
                Console.Read();
                Environment.Exit(0);
            }
        }
    }
}


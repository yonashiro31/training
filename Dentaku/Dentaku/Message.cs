using System;

namespace Dentaku
{
    /// <summary>
    /// 出力するメッセージの呼び出し元になるクラス
    /// </summary>
    /// <remarks>
    /// switch文で出力メッセージ内容を分岐させる
    /// </remarks>
    class Message
    {
        /// <summary>
        /// 出力するメッセージの呼び出し元になる
        /// </summary>
        /// <remarks>
        /// switch文で出力メッセージ内容を分岐させる
        public static void StartDisplay()
        {
            Console.WriteLine("＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝");
            Console.WriteLine("下記の例を参考に入力してください");
            Console.WriteLine("例：1 + 1");
            Console.WriteLine("　  1[Enter] +[Enter] 1[Enter]");
            Console.WriteLine();
            Console.WriteLine("(演算子は+、-、*、/を利用して下さい。)");
            Console.WriteLine("＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝");
        }
        public static void DisplayMessage(int i)
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("+、-、*、/を使用してください。");
                    break;
                case 2:
                    Console.WriteLine("0で割ることが出来ません。");
                    break;
                case 3:
                    Console.WriteLine("半角数字を入力してください。");
                    break;
                case 4:
                    Console.WriteLine("数値が未入力です");
                    break;
            }
        }
    }
}

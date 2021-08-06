namespace Dentaku
{
    /// <summary>
    /// 判定時利用する数値の定数定義を行うクラス
    /// </summary>
    /// <remarks>
    /// 必要に応じて別クラスに渡し利用する
    /// </remarks>
    public class MessageJudge
    {
        /// <summary>演算子判定時の定数</summary>
        /// <remarks>演算子判定時の定数</remarks>
        public const int OPERATORJUDGE = 1;
        /// <summary>0割判定時の定数</summary>
        /// <remarks>0割判定時の定数</remarks>
        public const int DIVJUDGE = 2;
        /// <summary>数値入力判定時の定数</summary>
        /// <remarks>数値入力判定時の定数</remarks>
        public const int NUMBERJUDGE = 3;
        /// <summary>未入力判定時の定数</summary>
        /// <remarks>未入力判定時の定数</remarks>
        public const int NULLJUDGE = 4;
        /// <summary>プログラム終了判定時定数</summary>
        /// <remarks>プログラム終了判定時定数</remarks>
        public const int BREAKJUDGE = 5;
    }
}


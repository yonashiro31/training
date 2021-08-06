namespace Dentaku
{
    /// <summary>
    /// 四則演算クラス
    /// </summary>
    /// <remarks>
    /// 一列入力時の四則演算を行う
    /// </remarks>
    public class LineFormula
    {
        /// <summary>
        /// 四則演算メソッド
        /// </summary>
        /// <remarks>
        /// 一列入力時の四則演算を行う
        /// </remarks>
        /// <param name="lineValue">一列時の式</param>
        public void LineCompute(string[] lineValue)
        {
            Compute compute = new Compute();
            decimal valueOne = decimal.Parse(lineValue[0]);
            decimal valueTwo = decimal.Parse(lineValue[2]);
            compute.SisokuCompute(valueOne, lineValue[1], valueTwo);
        }
    }
}

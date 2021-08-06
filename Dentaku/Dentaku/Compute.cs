using Dentaku.Logic;
using System;

namespace Dentaku
{
    /// <summary>
    /// 四則演算クラス
    /// </summary>
    /// <remarks>
    /// 個別入力時の四則演算を行う
    /// </remarks>
    public class Compute
    {
        AddLogic add = new AddLogic();
        SubLogic sub = new SubLogic();
        DivLogic div = new DivLogic();
        MulLogic mul = new MulLogic();
        Check check = new Check();
        /// <summary>
        /// 四則演算メソッド
        /// </summary>
        /// <remarks>
        /// 個別入力時の四則演算を行う
        /// </remarks>
        /// <param name="enteredOpe">演算子</param>
        /// <param name="enteredValue2">二つ目以降の入力値</param>
        /// <param name="value1AndResult">一つ目の入力値</param>
        public void SisokuCompute(decimal value1AndResult
            , string enteredOpe, decimal enteredValue2)
        {
            {
                switch (enteredOpe)
                {
                    case Operator.ADD:
                        value1AndResult = add.Add(value1AndResult, enteredValue2);
                        Console.WriteLine(value1AndResult);
                        break;
                    case Operator.SUB:
                        value1AndResult = sub.Sub(value1AndResult, enteredValue2);
                        Console.WriteLine(value1AndResult);
                        break;
                    case Operator.MUL:
                        value1AndResult = mul.Mul(value1AndResult, enteredValue2);
                        Console.WriteLine(value1AndResult);
                        break;
                    case Operator.DIV:
                        check.ZeroDiv(enteredValue2);
                        value1AndResult = div.Div(value1AndResult, enteredValue2);
                        Console.WriteLine(value1AndResult);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

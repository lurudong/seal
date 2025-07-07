namespace Seal.Shared.Results;

/// <summary>
/// 代表不带返回值操作的结果。
/// </summary>
public partial class Result : Result<Result>
{


    /// <summary>
    ///  初始化类的新实例。
    /// </summary>
    public Result()
    {
    }


    /// <summary>
    ///  初始化类的新实例。
    /// </summary>
    /// <param name="isSuccess">是否成功</param>
    protected Result(bool isSuccess) => IsSuccess = isSuccess;

    /// <summary>
    /// 设置成功消息
    /// </summary>
    /// <param name="successMessage">要设置的成功消息</param>
    /// <returns>最后结果实例</returns>
    public static Result SuccessWithMessage(string successMessage) => new() { SuccessMessage = successMessage };


    /// <summary>
    /// 初始化类的新实例
    /// </summary>
    /// <param name="successMessage">成功消息</param>
    protected internal Result(string successMessage) => SuccessMessage = successMessage;






    /// <summary>
    /// 成功操作
    /// </summary>
    /// <returns>最后结果实例</returns>

    public static Result Success() => new();


    /// <summary>
    /// 成功操作
    /// </summary>
    /// <param name="successMessage">设置成功操作的消息</param>
    /// <returns>最后结果实例</returns>

    public static Result Success(string successMessage) => new(successMessage);

    /// <summary>
    /// 成功操作
    /// </summary>
    /// <param name="value">相关值</param>
    /// <returns>最后结果实例<typeparamref name="TValue"/></returns>
    public static Result<TValue> Success<TValue>(TValue value) => new(value);


    /// <summary>
    /// 成功操作
    /// </summary>
    /// <param name="value">相关值</param>
    /// <param name="successMessage">设置成功操作的消息</param>
    /// <returns>最后结果实例<typeparamref name="TValue"/></returns>

    public static Result<TValue> Success<TValue>(TValue value, string successMessage) => new(value, successMessage);



    /// <summary>
    /// 失败操作
    /// </summary>
    /// <param name="error">失败消息类型</param>
    /// <returns>最后结果实例</returns>

    public new static Result Failure([NotNull] Error error) => new(false) { Error = error };


    /// <summary>
    /// 失败操作
    /// </summary>
    /// <param name="message">失败消息</param>
    /// <param name="code">失败编码</param>
    /// <returns>最后结果实例</returns>
    public new static Result Failure(string message, string code = "") => Failure(new Error(code, message));

}

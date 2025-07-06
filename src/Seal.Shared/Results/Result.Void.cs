

namespace Seal.Shared.Results;

/// <summary>
/// 结果类
/// </summary>
public partial class Result : ResultBase
{



    public Result()
    {
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="isSuccess"></param>
    protected Result(bool isSuccess) => IsSuccess = isSuccess;

    ///// <summary>
    ///// 设置成功消息
    ///// </summary>
    ///// <param name="successMessage"></param>
    ///// <returns></returns>
    public static Result SuccessWithMessage(string successMessage) => new() { SuccessMessage = successMessage };
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="successMessage"></param>
    protected internal Result(string successMessage) => SuccessMessage = successMessage;






    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>

    public static Result Success() => new();



    public static Result Success(string successMessage) => new(successMessage);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>

    public static Result<TValue> Success<TValue>(TValue value) => new(value);


    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="successMessage"></param>
    /// <returns></returns>

    public static Result<TValue> Success<TValue>(TValue value, string successMessage) => new(value, successMessage);



    /// <summary>
    /// 
    /// </summary>
    /// <param name="error"></param>
    /// <returns></returns>

    public static Result Failure([NotNull] Error error) => new(false) { Error = error };

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public static Result Failure([NotNull] string message) => Failure(string.Empty, message);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="code"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public static Result Failure([NotNull] string code, [NotNull] string message) => Failure(new Error(code, message));


}

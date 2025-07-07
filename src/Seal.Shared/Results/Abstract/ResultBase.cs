namespace Seal.Shared.Results.Abstract;

public abstract class ResultBase
{



    /// <summary>
    /// 是否成功
    /// </summary>
    public virtual bool IsSuccess { get; protected set; } = true;


    /// <summary>
    /// 错误类型
    /// </summary>
    public virtual Error Error { get; protected set; } = Error.Empty;


    /// <summary>
    /// 成功消息
    /// </summary>

    public virtual string SuccessMessage { get; protected set; } = string.Empty;
}
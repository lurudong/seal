
/// <summary>
/// 结果
/// </summary>
public interface IResult
{

    /// <summary>
    /// 是否成功
    /// </summary>
    public bool IsSuccess { get; }

    /// <summary>
    /// 是否失败
    /// </summary>
    public bool IsFailed { get; }
}
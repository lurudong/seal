/// <summary>
/// 结果接口
/// </summary>
public interface IResult
{

    /// <summary>
    /// 得到值
    /// </summary>
    /// <returns>返回相关默认的值或者null</returns>

    public object? GetValue();

}
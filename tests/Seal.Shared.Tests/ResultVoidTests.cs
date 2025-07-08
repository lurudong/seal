using Seal.Shared.Results;

namespace Seal.Shared.Tests;


public class ResultVoidTests
{

    [Fact]
    public void SuccessWithMessage_ShouldReturnSuccessResultWithMessage()
    {
        // Arrange
        string successMessage = "Operation successful";

        // Act
        Result result = Result.SuccessWithMessage(successMessage);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal(successMessage, result.SuccessMessage);
    }

    [Fact]
    public void Success_ShouldReturnSuccessResult()
    {
        // Act
        Result result = Result.Success();

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Empty(result.SuccessMessage);
    }

    [Fact]
    public void Success_ShouldReturnSuccessResultWithMessage()
    {
        // Arrange
        string successMessage = "Operation successful";

        // Act
        Result result = Result.Success(successMessage);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal(successMessage, result.SuccessMessage);
    }

    [Fact]
    public void Success_ShouldReturnSuccessResultWithValue()
    {
        // Arrange
        int value = 42;

        // Act
        Result<int> result = Result.Success(value);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Empty(result.SuccessMessage);
        Assert.Equal(value, result.Value);
    }

    [Fact]
    public void Success_ShouldReturnSuccessResultWithValueAndMessage()
    {
        // Arrange
        int value = 42;
        string successMessage = "Operation successful";

        // Act
        Result<int> result = Result.Success(value, successMessage);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal(successMessage, result.SuccessMessage);
        Assert.Equal(value, result.Value);
    }

    [Fact]
    public void Failure_ShouldReturnFailureResult()
    {
        // Arrange
        string message = "Operation failed";
        string code = "ERROR_CODE";

        // Act
        Result result = Result.Failure(message, code);

        // Assert
        Assert.False(result.IsSuccess);
        Assert.Equal(message, result.Error.Message);
        Assert.Equal(code, result.Error.Code);
    }

    [Fact]
    public void Failure_ShouldReturnFailureResultWithError()
    {
        // Arrange
        Error error = new Error("ERROR_CODE", "Operation failed");

        // Act
        Result result = Result.Failure(error);

        // Assert
        Assert.False(result.IsSuccess);
        Assert.Equal(error.Message, result.Error.Message);
        Assert.Equal(error.Code, result.Error.Code);
    }
}
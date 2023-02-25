namespace SistemaEspecialista.Application.Common.Responses;

public static class Response
{
    /// <summary>
    /// Gives a padronized success response.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="message"></param>
    /// <returns>returns a success response of type T </returns>
    public static Response<T> Ok<T>(T data, string message) => new Response<T>(data, message, null);

    /// <summary>
    /// Gives a padronized fail response.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="message"></param>
    /// <returns>returns a fail response of type T </returns>
    public static Response<T> Fail<T>(string message, List<ErrorModel> errors) => new Response<T>(message, errors);
}

public class Response<T>
{
	public T Data { get; set; }
	public string Message { get; set; }
	public List<ErrorModel> Errors { get; set; } = new();
	public Response(T data, string message, List<ErrorModel> errors)
	{
        Data = data;
        Message = message;
        Errors = errors;
    }

	public Response(string message, List<ErrorModel> errors)
	{
        Message = message;
        Errors = errors;
    }
}

namespace SistemaEspecialista.Application.Common.Responses;

public static class Response
{
    public static Response<T> Ok<T>(T data, string message) => new Response<T>(data, message, null);
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

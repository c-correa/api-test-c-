using Npgsql;

namespace ApiTest.Utils
{
    public class SafeExecutor
    {
        public static object Execute(Func<object> func)
        {
            try
            {
                // si la función funciona, devolvemos su resultado
                return func();
            }
            catch (Exception ex)
            {
                var errorResponse = new ErrorResponse
                {
                    Name = ex.GetType().Name,
                    Message = ex.Message,
                    Status = 500
                };

                if (ex is PostgresException pgEx)
                {
                    errorResponse.Message = pgEx.MessageText;
                }

                return errorResponse;
            }
        }
    }
}

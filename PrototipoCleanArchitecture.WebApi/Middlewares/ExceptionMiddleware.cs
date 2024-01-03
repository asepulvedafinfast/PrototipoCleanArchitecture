﻿namespace PrototipoCleanArchitecture.WebApi.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;

        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "application/json";
                var statusCode = (int)HttpStatusCode.InternalServerError;
                var result = string.Empty;

                switch (ex)
                {
                    case NotFoundException notFoundException:
                        statusCode = (int)HttpStatusCode.NotFound;
                        break;

                    case ValidationException validationException:
                        statusCode = (int)HttpStatusCode.BadRequest;
                        var errors = validationException.Errors.Select(ers => ers.ErrorMessage).ToArray();
                        result = JsonConvert.SerializeObject(
                            new CodeErrorException(statusCode,"Ocurrio un error de validacion", errors)
                        );
                        break;

                    case BadRequestException badRequestException:
                        statusCode = (int)HttpStatusCode.BadRequest;
                        break;

                    default:
                        break;
                }

                if (string.IsNullOrEmpty(result))
                    result = JsonConvert.SerializeObject(
                       new CodeErrorException(statusCode,
                                               ex.Message, [ex.StackTrace]));


                context.Response.StatusCode = statusCode;

                await context.Response.WriteAsync(result);

            }

        }
    }
}

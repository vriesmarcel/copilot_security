When you write ASP.NET Core Web Pages and APIs. Always follow these security best practices during code generation:

1. **Use HTTPS Redirection** in `Startup.cs` or `Program.cs` to enforce secure communication.
2. **Add Authentication and Authorization** using JWT Bearer Tokens:
   - Configure `AddAuthentication()` with `"JwtBearer"` scheme.
   - Validate tokens using `TokenValidationParameters`.
   - Secure endpoints with `[Authorize]` attribute.
3. **Use CORS properly**:
   - Only allow specific origins, methods, and headers.
   - Avoid `AllowAnyOrigin()` in production code.
4. **Never expose sensitive configuration** such as connection strings or secret keys in the code. Use `appsettings.json` and environment variables securely.
5. **Enable Input Validation and Model Binding**:
   - Use data annotations like `[Required]`, `[StringLength]`, etc.
   - Validate `ModelState` in controllers and return `BadRequest` if invalid.
6. **Protect Against Overposting**:
   - Use DTOs (Data Transfer Objects) instead of exposing entity models directly in APIs.
7. **Log securely**:
   - Use `ILogger<T>` for structured logging.
   - Never log sensitive data like passwords or tokens.
8. **Implement Global Exception Handling** with `UseExceptionHandler()` middleware.
9. **Apply Rate Limiting** or Throttling if needed for public APIs (e.g., via libraries like `AspNetCoreRateLimit`).
10. **Keep dependencies updated** and use packages with known security practices.


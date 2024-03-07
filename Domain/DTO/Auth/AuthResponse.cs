namespace Domain.DTO.Auth
{
    public class AuthResponse
    {
        public bool Success { get; set; }
        public string AccessToken { get; set; }
        public string Message { get; set; }
    }
}

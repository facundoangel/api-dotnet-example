namespace test.auth
{
    public class JWTConfiguracion
    {
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int RefreshThresholdMinutes { get; set; }
        public int TokenExpirationMinutes { get; set; }
        public string SessionCookieName { get; set; }
    }
}

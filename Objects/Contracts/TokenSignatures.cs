namespace ReserveiAPI.Objects.Contracts
{
    public class TokenSignatures
    {
        public string Issuer { get; } = "ReserveiAPI";
        public string Audience { get; } = "ReserveiAPI website";
        public string Key { get; } = "ReserveiAPI_Barrament_API_Autentication";
    }
}

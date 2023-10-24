using System.Text;

namespace EfiBankApiIntegration.Extensions
{
    public static class ConvertExtension
    {
        public static string ToBase64Encode(this string text)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}

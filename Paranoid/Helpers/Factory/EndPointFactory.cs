using Paranoid.Enum;

namespace Paranoid.Helpers.Factory
{
    public class EndPointFactory
    {
        public static string GetEndpoint(EnumEndpoint enumEndpoint)
        {
            switch (enumEndpoint)
            {
                case EnumEndpoint.Detalhe:
                    return $"https://www.macvendorlookup.com/api/v2/";
                default:
                    return "";
            }
        }
    }
}

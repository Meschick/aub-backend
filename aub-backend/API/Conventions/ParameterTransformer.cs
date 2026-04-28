using System.Text.RegularExpressions;

namespace aub_backend.API.Conventions
{
    public class ParameterTransformer : IOutboundParameterTransformer
    {
        public string? TransformOutbound(object? value)
        {
           if (value == null) return null;

            return Regex.Replace(
                 value.ToString(),
                 "([a-z])([A-Z])",
                 "$1-$2",
                 RegexOptions.CultureInvariant
                ).ToLower();
        }
    }
}

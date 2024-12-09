using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MercadoPago_API.Persistence.ValueConverters
{
    public class TrimStringConverter : ValueConverter<string, string>
    {
        public TrimStringConverter()
            : base(v => v.TrimEnd(), v => v.TrimEnd())
        {
        }
    }
}

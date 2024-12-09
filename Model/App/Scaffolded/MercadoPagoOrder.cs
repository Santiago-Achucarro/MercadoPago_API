
namespace MercadoPago_API.Model.App.Scaffolded
{
    public class IIMercadoPagoHdr
    {
        public int Id { get; set; }
        public string PaymentId { get; set; }
        public string MerchantOrder { get; set; }

    }

    public class IIMercadoPagoBody
    {
        public int Id { get; set; }
        public string MerchantOrder { get; set; }
        public string PaymentId { get; set; }
        public string Status { get; set; }
        public string ExternalReference { get; set; }
        public decimal TransactionAmount { get; set; }
        public decimal TotalPaidAmount { get; set; }
        public string DateCreated { get; set; }
    }
}

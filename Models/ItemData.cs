namespace PaymentDetail.Models{
    public class ItemData{
        public int Id { get; set;}
        
        public int PaymentDetailId { get; set;}
        public string cardOwnerName { get; set;}
        public string cardNumber { get; set;}
        public string expirationDate { get; set;}
        public string securityCode { get; set;}
    }
}
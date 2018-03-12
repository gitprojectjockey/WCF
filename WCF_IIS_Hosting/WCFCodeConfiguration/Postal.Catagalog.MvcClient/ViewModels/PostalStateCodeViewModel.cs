namespace Postal.Catagalog.MvcClient.ViewModels
{
    public class PostalStateCodeViewModel
    {
        public int StateId { get; set; }
       
        public string Name { get; set; }
       
        public string SSCode { get; set; }
        
        public string Abbreviation { get; set; }

        public string ExceptionMessage { get; set; } = null;
    }
}
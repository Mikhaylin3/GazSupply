using Gaz.Data;


namespace Gaz.IInvoiceService
{
    public interface IdownloadService 
    {
        List<IUserData> GetInvoices();
        IUserData Save(IUserData designer);
        IUserData UploadPdf(string id, byte[] pdf);
        void DeletePdf(string id);

    }
}

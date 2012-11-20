using System.Web;

namespace AzureVideoLibraryPrototype.Models
{
    public class UploadVideoModel
    {
        public HttpPostedFileBase File
        {
            get;
            set;
        }
    }
}
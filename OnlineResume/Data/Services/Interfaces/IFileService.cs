namespace OnlineResume.Data.Services.Interfaces
{
    public interface IFileService
    {

        Task<string> UploadFile(IFormFile file , string path);
        Task<bool> RemoveFile(string path);
    }
}

using OnlineResume.Data.Services.Interfaces;

namespace OnlineResume.Data.Services
{
    public class FileService : IFileService
    {
        public async Task<string> UploadFile(IFormFile file, string path)
        {
            var name = DateTime.Now.Day.ToString() + "_" + DateTime.Now.Second.ToString() + "_" + file.FileName;
            var realPath = Path.Combine(Directory.GetCurrentDirectory(),@"wwwroot\uploads\images\" + path,name);

            using (var fileStream = new FileStream(realPath,FileMode.Create))
            {
                await file.CopyToAsync(fileStream);                
            }

            return name;
        }

        public async Task<bool> RemoveFile(string path)
        {
            var realPath = Path.Combine(Directory.GetCurrentDirectory(),@"wwwroot\uploads\images\" + path);

            if (File.Exists(realPath))
            {
                File.Delete(realPath);
                return true;
            }

            return false;
        }

    }
}

namespace Program.Interfaces {
    public interface IDownloadService
    {
        public Task<string> DownloadFileAsync(string fileName);
        public Task DownloadFilesAsync();


    }
}
namespace Program.Interfaces
{
    public interface IProcessDataService
    {

        public Task ProcessDataChunkAsync(int chunkNumber);
        public Task ProcessLargeDatasetAsync(int numberOfChunks);

    }
}
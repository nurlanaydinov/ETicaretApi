namespace ETicaretApi.Application.Abstractions
{
    public interface IStorageService : IStorage
    {
        public string StorageName { get; }
    }
}

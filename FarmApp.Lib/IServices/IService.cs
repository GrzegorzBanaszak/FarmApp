namespace FarmApp.Lib.IServices
{
    public interface IService<T, TDC, TDU>
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T?> GetById(Guid id);
        public Task<T> Add(TDC entity);
        public Task<bool> Update(TDU entity);
        public Task<bool> Delete(Guid id);
    }
}

namespace FarmApp.Api.IServices
{
    public interface IService<T, TDC, TDU>
    {
        /// <summary>
        ///  Get all items from database
        /// </summary>
        /// <returns>List of <typeparamref name="T"/></returns>
        public Task<IEnumerable<T>> GetAll();
        public Task<T?> GetById(Guid id);
        public Task<T> Add(TDC entity);
        public Task<bool> Update(TDU entity);
        public Task<bool> Delete(Guid id);
    }
}

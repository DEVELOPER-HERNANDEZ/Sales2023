namespace Sales.WEB.Repositories
{
    public interface IRepository
    {
        Task<HttpReponseWrapper<T>> Get<T>(string url);
        Task<HttpReponseWrapper<object>> Post<T>(string url,T mode);
        Task<HttpReponseWrapper<TReponse>> Post<T,TReponse>(string url,T mode);

    }
}

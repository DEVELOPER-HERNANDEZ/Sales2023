namespace Sales.WEB.Repositories
{
    public interface IRepository
    {
        Task<HttpReponseWrapper<T>> Get<T>(string url);
        Task<HttpReponseWrapper<object>> Post<T>(string url,T mode);
        Task<HttpReponseWrapper<TReponse>> Post<T,TReponse>(string url,T mode);


        Task<HttpReponseWrapper<object>> Delete(string url);
        Task<HttpReponseWrapper<object>> Put<T>(string url, T mode);
        Task<HttpReponseWrapper<TReponse>> Put<T, TReponse>(string url, T mode);
    }
}

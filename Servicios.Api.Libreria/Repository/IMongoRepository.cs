using Servicios.Api.Libreria.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Servicios.Api.Libreria.Repository
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        Task<IEnumerable<TDocument>> GetAll();
    }
}

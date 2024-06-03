// using Data.Factory.Interfaces;

// namespace Data.Factory
// {
//     public class Repository<T> : IRepository<T>
//     {
//         private readonly List<T> _items = new List<T>();
//         private readonly Func<T, int> _getIdFunc;

//         public Repository(Func<T, int> getIdFunc)
//         {
//             _getIdFunc = getIdFunc;
//         }


//         public IEnumerable<T> GetAll()
//         {
//             return _items;
//         }

//         public T GetById(int id)
//         {
//             return _items.Find(entity => _getIdFunc(entity) == id);
//         }

//         public void Insert(T entity)
//         {
//              _items.Add(entity);
//         }

//         public void Update(T entity)
//         {
//             var model = GetById(_getIdFunc(entity));

//             if(entity != null){
//                 model = entity;
//             }
//         }

//         public void Delete(int id)
//         {
//             var entity = GetById(id);
//             if(entity != null){
//                 _items.Remove(entity);
//             }
//         }
//     }
// }
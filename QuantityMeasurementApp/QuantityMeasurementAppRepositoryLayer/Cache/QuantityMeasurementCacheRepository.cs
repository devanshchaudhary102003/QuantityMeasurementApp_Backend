// using QuantityMeasurementAppModelLayer.Models;
// using QuantityMeasurementAppRepositoryLayer.Interface;

// namespace QuantityMeasurementAppRepositoryLayer.Cache
// {
//     public class QuantityMeasurementCacheRepository : IQuantityMeasurementRepository
//     {
//         private readonly List<QuantityMeasurementEntity> _storage = new();
//         private int _idCounter = 1;

//         public void Save(QuantityMeasurementEntity entity)
//         {
//             entity.Id = _idCounter++;
//             _storage.Add(entity);
//         }

//         public void SaveUser(UserEntity user)
//         {
//             // For simplicity, we're not implementing user storage in the cache repository.
//             // In a real application, you would want to implement this or throw a NotImplementedException.
//             throw new NotImplementedException("User storage is not implemented in the cache repository.");
//         }

//         public UserEntity GetUserByUserName(string username)
//         {
//             // For simplicity, we're not implementing user retrieval in the cache repository.
//             // In a real application, you would want to implement this or throw a NotImplementedException.
//             throw new NotImplementedException("User retrieval is not implemented in the cache repository.");
//         }

//         public List<QuantityMeasurementEntity> GetAll()
//         {
//             return _storage;
//         }
//     }
// }
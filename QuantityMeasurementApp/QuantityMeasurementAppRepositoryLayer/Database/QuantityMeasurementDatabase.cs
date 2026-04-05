// using Microsoft.Data.SqlClient;
// using QuantityMeasurementAppModelLayer.Models;
// using QuantityMeasurementAppRepositoryLayer.Interface;
// using QuantityMeasurementAppRepositoryLayer.Utils;

// namespace QuantityMeasurementAppRepositoryLayer.Database
// {
//     public class QuantityMeasurementDatabase: IQuantityMeasurementRepository
//     {
//         public void Save(QuantityMeasurementEntity entity)
//         {
//             using SqlConnection connection = DbConnectionFactory.CreateConnection();
//             connection.Open();

//             string query = @"INSERT INTO QuantityMeasurements(Value, Unit, Category) VALUES (@value, @unit, @category)";

//             using SqlCommand command = new SqlCommand(query, connection);

//             command.Parameters.AddWithValue("@value", entity.Value);
//             command.Parameters.AddWithValue("@unit", entity.Unit);
//             command.Parameters.AddWithValue("@category", entity.Category);

//             command.ExecuteNonQuery();
//         }

//         public UserEntity GetUserByUserName(string username)
//         {
//             using SqlConnection connection = DbConnectionFactory.CreateConnection();
//             connection.Open();

//             string query = @"SELECT Id, Username, Password FROM Users WHERE Username = @username";

//             using SqlCommand command = new SqlCommand(query,connection);
//             command.Parameters.AddWithValue("@username",username);

//             using SqlDataReader reader = command.ExecuteReader();
//             if (reader.Read())
//             {
//                 return new UserEntity
//                 {
//                     Id = Convert.ToInt32(reader["Id"]),
//                     UserName = reader["UserName"].ToString(),
//                     Password = reader["Password"].ToString()    // hashed password
//                 };
//             }

//             return null; //When User Not Found
//         }

//         public void SaveUser(UserEntity user)
//         {
//             using SqlConnection connection = DbConnectionFactory.CreateConnection();
//             connection.Open();

//             string query = @"INSERT INTO Users(Username,Password) VALUES(@username,@password)";
//             using SqlCommand command = new SqlCommand(query,connection);

//             command.Parameters.AddWithValue("@username",user.UserName);
//             command.Parameters.AddWithValue("@password",user.Password);

//             command.ExecuteNonQuery();
//         }

//         public List<QuantityMeasurementEntity> GetAll()
//         {
//             List<QuantityMeasurementEntity> list = new();

//             using SqlConnection connection = DbConnectionFactory.CreateConnection();
//             connection.Open();

//             string query = "SELECT Id, Value, Unit, Category FROM QuantityMeasurements";

//             using SqlCommand command = new SqlCommand(query, connection);

//             using SqlDataReader reader = command.ExecuteReader();

//             while (reader.Read())
//             {
//                 list.Add(new QuantityMeasurementEntity
//                 {
//                     Id = reader.GetInt32(0),
//                     Value = reader.GetDouble(1),
//                     Unit = reader.GetString(2),
//                     Category = reader.GetString(3)
//                 });
//             }

//             return list;
//         }
//     }
// }
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ATM
{
    class db
    {
        public static string[] userInfo = new string[] { "-1", "test" };

        public static SqlConnection connection = new SqlConnection(@"Data Source=ADCLG1; Initial Catalog=!419/6 Nesterovich ATM;Integrated Security=true");

        // Запрос к БД и возврат результирующей таблицы
        public static List<string[]> Select(string request)
        {
            connection.Open();

            var command = new SqlCommand(String.Format(request), connection);
            var tempList = new List<string>(); // Запись из БД
            var result = new List<string[]>(); // Результат запроса к БД

            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempList.Clear();
                        for (var i = 0; i < reader.FieldCount; i++)
                        {
                            tempList.Add(Convert.ToString(reader.GetValue(i)));
                        }
                        var tempArray = new string[tempList.Count];
                        tempList.CopyTo(tempArray);
                        result.Add(tempArray);
                    }
                }
            }
            connection.Close();
            return result;
        }
    }
}
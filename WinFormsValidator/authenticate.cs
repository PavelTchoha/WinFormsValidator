using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsDemo;

namespace WinFormsValidator
{
    public class authenticate
    {

        public class User
        {
            public string Username { get; set; } 
            public byte[] Image { get; set; }

            public string Email { get; set; }

            public string Gender { get; set; }

            public DateTime Bday { get; set; }

        }


        public class DatabaseManager
        {
            public static User AuthenticateUser(string username, string password)
            {
                User user = RetrieveUserInformation(username, password);
                return user;
            }

            private static User RetrieveUserInformation(string username, string password)
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC06\SQLEXPRESS; Initial Catalog=LoginData; Integrated Security=True;"))
                {
                    sqlCon.Open();

                    string Query = "SELECT COUNT(1) FROM UserPassTable WHERE username=@username AND password=@password";
                    string imgQ = "SELECT * FROM UserPassTable WHERE username = @username";

                    SqlCommand cmd = new SqlCommand(Query, sqlCon);
                    SqlCommand imgCmd = new SqlCommand(imgQ, sqlCon);

                    imgCmd.CommandType = CommandType.Text;
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    imgCmd.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {

                        using (SqlDataReader reader = imgCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] imageData = reader["img"] as byte[];
                                string gender = reader["gender"] as string;
                                string email = reader["email"] as string;
                                DateTime bday = Convert.ToDateTime(reader["dateOfBirth"]);

                                return new User { Username = username, Image = imageData, Gender = gender, Email = email, Bday = bday };
                            }
                        }
                    }
                        return null; 
                    
                    
                }
            }
        }

    }
}
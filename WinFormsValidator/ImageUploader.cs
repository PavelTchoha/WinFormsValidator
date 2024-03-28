using System;  // Importing the System namespace
using System.Collections.Generic;  // Importing namespaces for various functionalities
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  // Importing namespaces for database-related functionalities
using System.Data;

namespace WinFormsDemo
{
    public class imageUploader
    {
        public static void UploadImage(string username, byte[] image)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source= LAB109PC06\SQLEXPRESS; Initial Catalog=LoginData; Integrated Security=True;"))
            {
                sqlCon.Open();  

                string uploadImgQ = "UPDATE UserPassTable SET img=@image WHERE username=@username"; 

                using (SqlCommand uploadCmd = new SqlCommand(uploadImgQ, sqlCon))
                {
                    uploadCmd.CommandType = CommandType.Text;
                    uploadCmd.Parameters.AddWithValue("@username", username);
                    uploadCmd.Parameters.AddWithValue("@image", image); 
                    uploadCmd.ExecuteNonQuery();  
                }
            }
        }

        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
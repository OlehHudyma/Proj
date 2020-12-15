using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebPage
{
    public class DataBase
    {

         /// <summary>
         /// 12321
         /// </summary>
        private static readonly string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\DataBase1.mdf';Integrated Security = True;";

        public Users Load(string Login, string Pasword )
        {
            
            Users users = new Users();

            using (SqlConnection connection = new SqlConnection(cs))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Select * from Users where Login = @Login and Pasword = @Pasword", connection);
                    command.Parameters.Add(new SqlParameter("@Login", Login));
                    command.Parameters.Add(new SqlParameter("@Pasword", Pasword));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            users = new Users(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        }
                    }

                }
                catch (Exception )

                {
                    
                }

            }
            return users;
           
        }


        public void Save(string Login, string Sesion)
        {
            

            using (SqlConnection connection = new SqlConnection(cs))
            {
                try
                {
                    connection.Open();
                     SqlCommand command = new SqlCommand("Insert into Sesion(Login,Sesion) values (@Login,@Sesion)", connection);

                 //   SqlCommand command = new SqlCommand("MERGE INTO Sesion AS t USING(SELECT @Login AS LOGIN) AS t1 ON t.Login = t1.LOGIN WHEN MATCHED THEN UPDATE SET Sesion = @Sesion WHEN NOT MATCHED THEN Insert into Sesion(Login, Sesion) values(t1.LOGIN, @Sesion)", connection);
                    //  command.Parameters.Add(new SqlParameter("@id", id));
                    command.Parameters.Add(new SqlParameter("@Login", Login));
                    command.Parameters.Add(new SqlParameter("@Sesion", Sesion));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                    }

                }
                catch (Exception )

                {
                }

            }
           
        }


        public Users LoadSesion(string Sesion)
        {
            Users users = new Users();

            using (SqlConnection connection = new SqlConnection(cs))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Select * from Sesion where Sesion = @Sesion", connection);
                    command.Parameters.Add(new SqlParameter("@Sesion", Sesion));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            users = new Users(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        }
                    }

                }
                catch (Exception)

                {
                }

            }
            return users;
           
        }

        public void Clear(string Login)
        {
           

            using (SqlConnection connection = new SqlConnection(cs))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Delete from Sesion where Login = @Login", connection);

                    //   SqlCommand command = new SqlCommand("MERGE INTO Sesion AS t USING(SELECT @Login AS LOGIN) AS t1 ON t.Login = t1.LOGIN WHEN MATCHED THEN UPDATE SET Sesion = @Sesion WHEN NOT MATCHED THEN Insert into Sesion(Login, Sesion) values(t1.LOGIN, @Sesion)", connection);
                    //  command.Parameters.Add(new SqlParameter("@id", id));
                    command.Parameters.Add(new SqlParameter("@Login", Login));
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                    }

                }
                catch (Exception)

                {
                }

            }
           
        }

        public void SaveUsers(string Login, string Pasword)
        {
    

            using (SqlConnection connection = new SqlConnection(cs))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Insert into Users(Login,Pasword) values (@Login,@Pasword)", connection);

                    //   SqlCommand command = new SqlCommand("MERGE INTO Sesion AS t USING(SELECT @Login AS LOGIN) AS t1 ON t.Login = t1.LOGIN WHEN MATCHED THEN UPDATE SET Sesion = @Sesion WHEN NOT MATCHED THEN Insert into Sesion(Login, Sesion) values(t1.LOGIN, @Sesion)", connection);
                    //  command.Parameters.Add(new SqlParameter("@id", id));
                    command.Parameters.Add(new SqlParameter("@Login", Login));
                    command.Parameters.Add(new SqlParameter("@Pasword", Pasword));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                    }

                }
                catch (Exception)

                {
                }

            }
            
        }


        public void SaveMessage(string Login, string Message)
        {


            using (SqlConnection connection = new SqlConnection(cs))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Insert into Message(Login,Message) values (@Login,@Message)", connection);

                    //   SqlCommand command = new SqlCommand("MERGE INTO Sesion AS t USING(SELECT @Login AS LOGIN) AS t1 ON t.Login = t1.LOGIN WHEN MATCHED THEN UPDATE SET Sesion = @Sesion WHEN NOT MATCHED THEN Insert into Sesion(Login, Sesion) values(t1.LOGIN, @Sesion)", connection);
                    //  command.Parameters.Add(new SqlParameter("@id", id));
                    command.Parameters.Add(new SqlParameter("@Login", Login));
                    command.Parameters.Add(new SqlParameter("@Message", Message));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                    }

                }
                catch (Exception)

                {
                }

            }
          
        }

        public string[] LoadMessage(string Login, int countM)
        {

            string[] message = new string[countM];
            using (SqlConnection connection = new SqlConnection(cs))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Select * from Message where Login = @Login order by 1 desc", connection);
                    command.Parameters.Add(new SqlParameter("@Login", Login));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.HasRows)
                        {

                            if (i <= countM)
                            {

                                reader.Read();
                                message[i] = reader.GetString(2);
                                i++;
                            }

                        }
                    }

                }
                catch (Exception)

                {
                }

            }
            return message;
           
        }

        public void ClearMessage(string Login)
        {
            

            using (SqlConnection connection = new SqlConnection(cs))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Delete from Message where Login = @Login", connection);

                    //   SqlCommand command = new SqlCommand("MERGE INTO Sesion AS t USING(SELECT @Login AS LOGIN) AS t1 ON t.Login = t1.LOGIN WHEN MATCHED THEN UPDATE SET Sesion = @Sesion WHEN NOT MATCHED THEN Insert into Sesion(Login, Sesion) values(t1.LOGIN, @Sesion)", connection);
                    //  command.Parameters.Add(new SqlParameter("@id", id));
                    command.Parameters.Add(new SqlParameter("@Login", Login));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                    }

                }
                catch (Exception)

                {
                }

            }
            
        
        }


    }
}
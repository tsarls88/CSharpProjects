using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_console_APP
{
     class CRUD
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = "Data Source=.;Initial Catalog=ConsoleCRUD;Integrated Security=True;Encrypt=False";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            try
            {
                Console.WriteLine("Connection to database established successfully.");
                string answer;
                do
                {
                    Console.WriteLine("Select an option:\n");
                    Console.WriteLine("\n 1: Create");
                    Console.WriteLine("\n 2: Retrieve");
                    Console.WriteLine("\n 3: Update");
                    Console.WriteLine("\n 4: Delete");
                    int options = int.Parse(Console.ReadLine());
                    switch (options)
                    {
                        case 1:
                            //ADD
                            Console.WriteLine("Enter the name of the person you want to add:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the Email of the person you want to add:");
                            string email = Console.ReadLine();
                            Console.WriteLine("Enter the Age of the person you want to add");
                            int age = int.Parse(Console.ReadLine());
                            String insertQuery = "INSERT INTO Details (name, email, age) VALUES ('" + name + "','" + email + "', " + age + ")";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                            insertCommand.ExecuteNonQuery();
                            Console.WriteLine("Record inserted successfully.");
                            break;
                        case 2:
                            //Retrieve
                            string displayQuery = "SELECT * FROM Details";
                            SqlCommand ViewCommand = new SqlCommand(displayQuery, sqlConnection);

                            SqlDataReader dataReader = ViewCommand.ExecuteReader();
                            while(dataReader.Read())
                            {
                                Console.WriteLine("ID:" + dataReader.GetValue(0).ToString());
                                Console.WriteLine("Name:" + dataReader.GetValue(1).ToString());
                                Console.WriteLine("Email:" + dataReader.GetValue(2).ToString());
                                Console.WriteLine("Age:" + dataReader.GetValue(3).ToString());
                            }
                            dataReader.Close();
                            break;
                        case 3:
                            string u_name;
                            int u_id; 
                            //string u_email;
                            //int u_age;
                            Console.WriteLine("Enter the ID of the Entry you want to Updated");
                            u_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Name of the Entry you would like to change");
                            u_name = Console.ReadLine();
                            //Console.WriteLine("Enter the Email of the Entry you would like to change");
                            //u_email = Console.ReadLine();
                            //Console.WriteLine("Enter the Age of the Entry you would like to change");
                            //u_age = int.Parse(Console.ReadLine());

                            string updateQuery = "UPDATE Details SET name = '" + u_name+"' WHERE User_Id = "+u_id +""; 
                            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                            updateCommand.ExecuteNonQuery();
                            Console.WriteLine("Successfully Updated!");
                            break;
                        case 4:
                            int d_id;
                            Console.WriteLine("Enter the ID of the Entry you want to Delete");
                            u_id = int.Parse(Console.ReadLine());
                            string deleteQuery = "DELETE FROM Details WHERE User_Id = " + u_id + "";
                            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                            deleteCommand.ExecuteNonQuery();
                            Console.WriteLine("Successfully Deleted!");
                            break;
                        default:
                            Console.WriteLine("Please Enter a Valid Entry!");
                            break;
                    }

                    Console.WriteLine("Do you want to Continue? Yes/No");
                    answer = Console.ReadLine();
                } while (answer != "No" && answer != "no");

                
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}

        using System;
        using System.Collections.Generic;
        using System.Data.SqlClient;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace CrudConsole_App
        {
            class Program
            {
                static void Main(string[] args)
                {
                    SqlConnection sqlConnection;
                    string connectionsString = @"Data Source=.;Initial Catalog=CrudDATABASE;Integrated Security=True";
                    sqlConnection = new SqlConnection(connectionsString);
                    sqlConnection.Open();
                    try
                    {
          
                        Console.WriteLine("Connections successfully Installed!");
                        string answer;
                        do
                        {
                            Console.WriteLine("Select from the Options \n1.Create\n2.Retrieve\n3.Update\n4.Delete");
                            int choice = int.Parse(Console.ReadLine());
                            switch (choice) {
                                case 1:
                                 //Create = Crud 
                            Console.WriteLine("Enter Your Name:");
                            string userName = Console.ReadLine();
                            Console.WriteLine("Enter Age!");
                            int userAge = int.Parse(Console.ReadLine());
                            string insertQuery = "INSERT INTO DETAILS(user_name, user_age) VALUES ( '" + userName + "' ," + userAge + " )";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                            insertCommand.ExecuteNonQuery();
                            Console.WriteLine("DATA WAS SUCCESSFULLY RESTORED!");
                                    break;
                                case 2:

                            //  Retrieve -> R 
                            string displayQuery = "SELECT * FROM Details";
                            SqlCommand viewCommand = new SqlCommand(displayQuery, sqlConnection);
                            SqlDataReader dataReader = viewCommand.ExecuteReader();
                            while (dataReader.Read())
                            {
                                Console.WriteLine("Id:" + dataReader.GetValue(0).ToString());
                                Console.WriteLine("Name:" + dataReader.GetValue(1).ToString());
                                Console.WriteLine("Age:" + dataReader.GetValue(2).ToString());
                            }
                            dataReader.Close();
                                    break;
                                case 3:
                            // Update 
                            String u_name;
                            int u_id;
                            Console.WriteLine("Enter the Id of the entry to be Updated");
                            u_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the name you would like to change");
                            u_name = Console.ReadLine();
                            String updateQuery = "UPDATE Details SET user_name  = '" + u_name + "' WHERE user_id = " + u_id + "";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                            updateCommand.ExecuteNonQuery();
                            Console.WriteLine("Successfully Updated");
                                    break;
                            case 4:
                            // DELETE
                            int d_id;
                            Console.WriteLine("Enter the id of the Entry to be removed");
                            d_id = int.Parse(Console.ReadLine());
                            String deleteQuery = "DELETE FORM Details WHERE user_id =" + d_id;
                            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                            deleteCommand.ExecuteNonQuery();
                            Console.WriteLine("Successfully deleted");
                                    break;
                                default:
                                    Console.WriteLine("Please Enter Valid Choice");
                                    break;
                        }

                            Console.WriteLine("Press Enter to Continue");
                            answer = Console.ReadLine();
                        } while (answer != "NO");
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }

                }
            }
        }

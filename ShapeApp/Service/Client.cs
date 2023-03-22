using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ShapeApp.Model;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace ShapeApp.Service
{
    internal class Client
    {
        Shape shape;

        public Client(Shape shape) { 
            this.shape = shape;
        }
        public void sendHttpRequest(string jsonString) {
            //Create HttpRequest and send to server

            SqlConnection conn =  new SqlConnection(@""); //Add Connection string here

            double perimeter = shape.calculatePerimeter();
            int shape_id = 0;
            switch (shape.shapeType) {
                case "Circle":
                    shape_id = 1;
                    break;
                case "Square":
                    shape_id = 2;
                    break;
                case "Rectangle":
                    shape_id = 3;
                    break;
            }
            string query = "insert into Request (Request_Shape_Id, Request_Shape_Perimeter) values (" + shape_id + ", "+ perimeter + ")";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {

            }
            finally { 
                conn.Close();
            }
        }

    }
}

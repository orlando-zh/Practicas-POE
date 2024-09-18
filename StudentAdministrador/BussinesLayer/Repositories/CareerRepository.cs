using CommonLayer.Entities;
using DataAccessLayey.DBConnection;
using Microsoft.AspNet.SignalR.Infrastructure;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayey.Repositories
{
    public class CareerRepository
    {
        private SqlDataAccess _dbConnetion;

        public CareerRepository()
        {
            _dbConnetion = new  SqlDataAccess();
        }

        public DataTable GetCareers()
        {
            DataTable careersTable = new DataTable();

            using (var connection = _dbConnetion.GetSqlConnetion())
            {
                string query = "SELECT * FROM career";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                careersTable.Load(reader);
            }
            
            return careersTable;
        }

        public void AddCareer(Career career)
        {
            using (var connetion = _dbConnetion.GetSqlConnetion())
            {
                string query = "INSERT INTO career VALUES(@NameCareer, @DescriptionCareer";

                SqlCommand command = new SqlCommand(@query, connetion);
                command.Parameters.AddWithValue("@NameCareer", career.nameCareer);
                command.Parameters.AddWithValue("@DescriptionCareer", career.descriptionCareer);
                connetion.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}

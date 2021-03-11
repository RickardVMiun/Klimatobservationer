using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klimatobservationer
{
    public class ClimateObservationRepository
    {

        private static readonly string connectionString = "Server=localhost;Port=5432;Database=klimatobseervationer;User ID=postgres; Password=SaltaGrodor1!;";

        #region
        public Area GetArea(int id)
        {
            string statment = "select * from area where ID = @id";


           
        
        }

        #endregion

        public Observation GetAllObservation()
        {
            string statment = "select * from area where ID = @id";
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            using var command = new NpgsqlCommand(statement, conn);
        
        }
    }
}

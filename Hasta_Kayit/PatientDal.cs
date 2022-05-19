using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasta_Kayit
{
    public class PatientDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; initial catalog=MyDatabase; integrated security=false");

        public List<Patient> GetAll()
        {
            ConnectionCheck();

            SqlCommand command = new SqlCommand("SELECT * FROM Patients", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Patient> patients = new List<Patient>();

            while (reader.Read())
            {
                Patient patient = new Patient()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Age = Convert.ToInt32(reader["Age"])
                };

                patients.Add(patient);
            }

            reader.Close();
            _connection.Close();

            return patients;
        }

        private void ConnectionCheck()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Patient patient)
        {
            ConnectionCheck();

            SqlCommand command = new SqlCommand("INSERT INTO Patients VALUES(@name, @age)", _connection);
            command.Parameters.AddWithValue("@name", patient.Name);
            command.Parameters.AddWithValue("@age", patient.Age);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Patient patient)
        {
            ConnectionCheck();

            SqlCommand command = new SqlCommand("UPDATE Patients SET Name=@name, Age=@age WHERE Id=@id", _connection);
            command.Parameters.AddWithValue("@name", patient.Name);
            command.Parameters.AddWithValue("@age", patient.Age);
            command.Parameters.AddWithValue("@id", patient.Id);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionCheck();

            SqlCommand command = new SqlCommand("DELETE FROM Patients WHERE Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}

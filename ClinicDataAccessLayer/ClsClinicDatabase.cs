using System;
using System.Data;
using System.Data.SqlClient;
using static ClsBasicQueries;
using static ClinicDALayer.ClsClinicContract.Person;
using static ClinicDALayer.ClsClinicContract.Users;
using static ClinicDALayer.ClsClinicContract.Patient;
using static ClinicDALayer.ClsClinicContract.Department;
using static ClinicDALayer.ClsClinicContract.Employee;
using static ClinicDALayer.ClsClinicContract.Phone;
using static ClinicDALayer.ClsClinicContract.Appointment;
using static ClinicDALayer.ClsClinicContract.MedicalRecord;
using static ClinicDALayer.ClsClinicContract.Payment;
using static ClinicDALayer.ClsClinicContract.PaymentMethod;
using static ClinicDALayer.ClsClinicContract.Prescription;
using static ClinicDALayer.ClsClinicContract.Medication;
using static ClinicDALayer.ClsClinicContract.Tables;
using System.Collections.Generic;
using System.Linq;

namespace ClinicDALayer
{
    public class ClsClinicDatabase
    {
        private static void LoadDataToDataTable(ref DataTable dt, SqlCommand command)
        {

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
                dt.Load(reader);

            reader.Close();
        }

        private static void LoadID(ref int id, SqlCommand command, string clm)
        {
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                id = (int)reader[clm];
            else id = 0;
        }

        public static int AddNewPersonToDB
            (
            string firstName, string midName, string lastName,
            DateTime dateOfBirth, string email, char gender, string address
            )
        {   
            
            int personID = -1; // The last auto ID of an added Person object.

            // Connect to database
            SqlConnection conn = ClsDataAccessSettings.Connection();

            // Prepare Sql Query.
            string query = $@"INSERT INTO PERSONS
                            ({PERSON_COLUMN_FIRST_NAME},
                            {PERSON_COLUMN_MID_NAME}, 
                            {PERSON_COLUMN_LAST_NAME},
                            {PERSON_COLUMN_DATE}, 
                            {PERSON_COLUMN_EMAIL}, 
                            {PERSON_COLUMN_GENDER}, 
                            {PERSON_COLUMN_ADDRESS})
                            VALUES 
                            (@firstName, @midName, @lastName, @dateOfBirth, @email, @gender, @address);
                            SELECT SCOPE_IDENTITY();";

            // Execute command.
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@midName", midName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@address", address);

            try
            {
                conn.Open(); // Start the database connection.
                object result = command.ExecuteScalar();
                // Get the last inserted Person ID.
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    personID = insertedID;
            }
            catch (Exception)
            {
                personID = -1;
            }
            finally
            {
                conn.Close(); // Close database connection.
            }

            return personID;
        }


        public static int GetLastID(string clm, string tableName) 
        {
            int lastId = -1;

            SqlConnection conn = ClsDataAccessSettings.Connection(); // Connect to DB.
            string sql = ClsBasicQueries.GetLastID(clm, tableName); // SQL Query.
            SqlCommand command = new SqlCommand(sql, conn); // Command To Execute.
            
            // Execute Command.
            try
            {
                conn.Open(); // Start Connection.
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.Read())
                    lastId = reader.GetInt32(0);

                reader.Close();
            } 
            catch (Exception)
            {
                lastId = -1;
            }
            finally
            {
                conn.Close(); // Close Connection.
            }

            return lastId;
        }

        public static bool IsExists(int id, string tableName, string clm) {

            bool isFound = false; // Trak if Element Exists.

            // Conntect to Database.
            SqlConnection conn = ClsDataAccessSettings.Connection();

            // Prepare Sql Query.
            string query = $"{Select(tableName)} WHERE {clm} = @id";

            // Prepare command.
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);


            try
            {
                conn.Open(); // Statr Database connection.

                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.Read();
                
                reader.Close();
            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }


            return isFound;
        }

        public static bool DeleteByID(int id, string tableName, string pkColumnName)
        {
            int rowEfficted = 0;

            // Connect to Database.
            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $"{Delete(tableName, pkColumnName)} @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);


            // Execute command.
            try
            {
                conn.Open();
                rowEfficted = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                rowEfficted = -1;
            }
            finally
            {
                conn.Close();
            }

            return rowEfficted > 0;
        }

        public static DataTable GetAll(string tableName)
        {

            DataTable dt = new DataTable();

            // Connect to Database.
            SqlConnection conn = ClsDataAccessSettings.Connection();


            // Prepare Sql Query using join.
            string query = $"{Select(tableName)}";

            // Perpare command.
            SqlCommand command = new SqlCommand(query, conn);

            // Execute command.
            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static string JoinForSqlIn(List<string> stringList)
        {
            if (stringList == null || !stringList.Any())
                return ""; // Empty list results in an empty string

            return string.Join(",", stringList.Select(s => "'" + s + "'"));
        }



        /************Queries For Patients*************/
        public static bool AddNewPateintToDB(int personID)
        {
            if (personID <= 0)
                return false;

            int rowEffected = 0;


            // Connect to database
            SqlConnection conn = ClsDataAccessSettings.Connection();

            // Prepare Sql Query.
            string query = $@"{Insert(PATIENTS)}
                            ({PATIENT_COLUMN_FK})
                            VALUES
                            (@personID)";


            // Prepare command
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@personID", personID);

            // Execute command.
            try
            {
                conn.Open();  // Start Database Connection.
                rowEffected = command.ExecuteNonQuery();

            }
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static bool UpdatePatient
            (
            int id,
            string firstName, string midName, string lastName,
            DateTime dateOfBirth, string email, char gender, string address
            )
        {

            int rowEffected = 0;

            // Connect to Database.
            SqlConnection conn = ClsDataAccessSettings.Connection();


            // Prepare Sql Query.
            string query = PersonUpdate();


            // Prepare command.
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@MidName", midName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Gender", gender);
            command.Parameters.AddWithValue("@Address", address);


            try
            {
                conn.Open(); // Start Database connection.
                rowEffected = command.ExecuteNonQuery(); // Execute command.
            }
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static bool GetPatientByID
            (
            int id, ref int personPK,
            ref string firstName, ref string midName, ref string lastName,
            ref DateTime dateOfBirth, ref string email, ref char gender, ref string address
            )
        {

            bool isFound = false; // Trak if Pateint Exists.

            // Conntect to Database.
            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"SELECT
                            {PATIENTS}.*,
                            {PERSONS}.*
                            FROM {PATIENTS}
                            JOIN {PERSONS}
                            ON {PATIENTS}.{PATIENT_COLUMN_FK} = {PERSONS}.{PERSON_COLUMN_PK}
                            WHERE {PATIENT_COLUMN_PK} = @id";

            // Prepare command.
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);


            try
            {
                conn.Open(); // Statr Database connection.
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true; // The Pateint was found.

                    // Fill the Pateint Data.
                    personPK = (int)reader[PERSON_COLUMN_PK];
                    firstName = (string)reader[PERSON_COLUMN_FIRST_NAME];
                    midName = (string)reader[PERSON_COLUMN_MID_NAME];
                    lastName = (string)reader[PERSON_COLUMN_LAST_NAME];
                    dateOfBirth = (DateTime)reader[PERSON_COLUMN_DATE];
                    email = (string)reader[PERSON_COLUMN_EMAIL];
                    gender = Convert.ToChar(reader[PERSON_COLUMN_GENDER]);
                    address = (string)reader[PERSON_COLUMN_ADDRESS];
                }
                else isFound = false;

                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }


            return isFound;
        }

        public static bool GetPatientByName(ref int id, string name)
        {

            // Conntect to Database.
            SqlConnection conn = ClsDataAccessSettings.Connection();

            // Prepare Sql Query.
            string query = $@"SELECT {PATIENT_COLUMN_PK}
                            FROM {PATIENTS}
                            JOIN {PERSONS} ON {PATIENTS}.{PATIENT_COLUMN_FK} = {PERSONS}.{PERSON_COLUMN_PK}
                            WHERE 
                            {PERSON_COLUMN_FIRST_NAME} + ' ' + 
                            {PERSON_COLUMN_MID_NAME} + ' ' +
                            {PERSON_COLUMN_LAST_NAME} = @name";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@name", name);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                    id = (int)reader[PATIENT_COLUMN_PK]; // Get the Pateint ID (PK).

                reader.Close();
            }
            catch
            {
                id = -1;
            }
            finally
            {
                conn.Close();
            }

            return id > 0;
        }

        public static DataTable SelectAllPateints()
        {
            DataTable dt = new DataTable();

            // Connect to Database.
            SqlConnection conn = ClsDataAccessSettings.Connection();


            // Prepare Sql Query using join.
            string query = $@"SELECT
            {PATIENTS}.{PATIENT_COLUMN_PK},
            {PERSONS}.{PERSON_COLUMN_FIRST_NAME} + ' ' +
            {PERSONS}.{PERSON_COLUMN_MID_NAME} + ' ' +
            {PERSONS}.{PERSON_COLUMN_LAST_NAME} AS Name,
            {PERSONS}.{PERSON_COLUMN_DATE},
            {PERSONS}.{PERSON_COLUMN_EMAIL},
            {PERSONS}.{PERSON_COLUMN_GENDER},
            {PERSONS}.{PERSON_COLUMN_ADDRESS}
            FROM {PATIENTS} 
            JOIN {PERSONS} 
            ON {PATIENTS}.{PATIENT_COLUMN_FK} = {PERSONS}.{PERSON_COLUMN_PK}";

            
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static DataTable GetPateintAccountStatement(int id)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"SELECT
            {PATIENTS}.{PATIENT_COLUMN_PK},
            Name =
            {PERSONS}.{PERSON_COLUMN_FIRST_NAME} + ' ' +
            {PERSONS}.{PERSON_COLUMN_MID_NAME} + ' ' +
            {PERSONS}.{PERSON_COLUMN_LAST_NAME},
            {PAYMENTS}.{PAYMENT_COLUMN_DATE},
            {PAYMENTS}.{PAYMENT_COLUMN_NOTE},
            {PAYMENTS}.{PAYMENT_COLUMN_AMOUNT}
            FROM {PAYMENTS}
            JOIN {PATIENTS} ON {PAYMENTS}.{PAYMENT_COLUMN_PAITENT_ID} = {PATIENTS}.{PATIENT_COLUMN_PK}
            JOIN {PERSONS} ON {PATIENTS}.{PATIENT_COLUMN_FK} = {PERSONS}.{PERSON_COLUMN_PK}
            WHERE {PAYMENTS}.{PAYMENT_COLUMN_PAITENT_ID} = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static DataTable GetPatienAppointment(int paitentID)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"SELECT 
                            {APPOINTMENTS}.{APPOINTMENT_COLUMN_PK},
                            {APPOINTMENTS}.{APPOINTMENT_COLUMN_STATUS},
                            {APPOINTMENTS}.{APPOINTMENT_COLUMN_DATE},
                            Name = 
                            {PERSONS}.{PERSON_COLUMN_FIRST_NAME} + ' ' +
                            {PERSONS}.{PERSON_COLUMN_MID_NAME} + ' ' +
                            {PERSONS}.{PERSON_COLUMN_LAST_NAME},
                            Age = DATEDIFF(YEAR, {PERSONS}.{PERSON_COLUMN_DATE}, GETDATE()) 
                            FROM {APPOINTMENTS}
                            JOIN {PATIENTS}
                            ON {APPOINTMENTS}.{APPOINTMENT_COLUMN_PATIENT_ID} = {PATIENTS}.{PATIENT_COLUMN_PK}
                            JOIN {PERSONS}
                            ON {PATIENTS}.{PATIENT_COLUMN_FK} = {PERSONS}.{PERSON_COLUMN_PK}
                            WHERE {APPOINTMENTS}.{APPOINTMENT_COLUMN_PATIENT_ID} = @patientID";


            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@patientID", paitentID);

            
            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;

        }



        /************Queries For Departments*************/
        public static DataTable SelectAllDepartments()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $"{Select(DEPARTMENTS)}";

            // Perpare command.
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static bool GetDepIDByNameAndSpecialization(ref int id, string depName, string specialization)
        {
            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"SELECT {DEP_COLUMN_PK} FROM {DEPARTMENTS}
                              WHERE 
                              {DEP_COLUMN_NAME} = '{depName}'
                               AND
                              {DEP_COLUMN_SPECIALIZATION} = '{specialization}'";

            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                LoadID(ref id, command, DEP_COLUMN_PK);
            } 
            catch
            {

            } 
            finally
            {
                conn.Close();
            }

            return id > 0;
        }

        public static bool GetDepartmentByID(int id, ref string dep, ref string spe)
        {
            bool isFound = false;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $"{Select(DEPARTMENTS)} WHERE {DEP_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    dep = (string)reader[DEP_COLUMN_NAME];
                    spe = (string)reader[DEP_COLUMN_SPECIALIZATION];
                }
                else isFound = false;

                reader.Close();
            } 
            catch
            {
                isFound = false;
            } 
            finally
            {
                conn.Close();
            }

            return isFound;
        }

        public static bool AddNewDepartmentToDB(string dep, string spe)
        {
            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"INSERT INTO {DEPARTMENTS} 
                            ({DEP_COLUMN_NAME}, {DEP_COLUMN_SPECIALIZATION})
                            VALUES
                            (@dep , @spe)";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@dep", dep);
            command.Parameters.AddWithValue("@spe", spe);

            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            } 
            catch
            {
                rowEffected = -1;
            } 
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static bool UpdateDepartment(int id, string dep, string spe)
        {
            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"UPDATE {DEPARTMENTS} 
                            SET 
                            {DEP_COLUMN_NAME} = @dep, 
                            {DEP_COLUMN_SPECIALIZATION} = @spe
                            WHERE {DEP_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@dep", dep);
            command.Parameters.AddWithValue("@spe", spe);

            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static bool DeleteDepartment(int id)
        {
            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $"DELETE {DEPARTMENTS} WHERE {DEP_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            } 
            catch
            {
                rowEffected = -1;
            } 
            finally
            {
                conn.Close();
            }


            return rowEffected > 0;
        }


        /************Queries For Employees*************/
        public static bool AddNewEmployeeToDB(int personID, int depID)
        {

            if (personID <= 0)
                return false;

            int rowEffected = 0;

            // Connect to Database.
            SqlConnection conn = ClsDataAccessSettings.Connection();

            // Prepare query.
            string query = $@"{Insert(EMPLOYEES)}
                            ({EMPLOYEE_COLUMN_PERSON_ID}, {EMPLOYEE_COLUMN_DEP_ID})
                            VALUES
                            (@PersonID, @depID)";


            // Prepare Command.
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@depID", depID);

            // Execute query.
            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }


            return rowEffected > 0;
        }

        public static bool GetEmployeeByID
            (
            int id, ref int personPK,
            ref string firstName, ref string midName, ref string lastName,
            ref DateTime dateOfBirth, ref string email, ref char gender, ref string address,
            ref int dep_ID
            )
        {

            bool isFound = false;
            
            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"SELECT
                            {EMPLOYEES}.{EMPLOYEE_COLUMN_PERSON_ID},
                            {EMPLOYEES}.{EMPLOYEE_COLUMN_DEP_ID},
                            {PERSONS}.*
                            FROM {EMPLOYEES}
                            JOIN {PERSONS}
                            ON {EMPLOYEES}.{EMPLOYEE_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                            WHERE {EMPLOYEE_COLUMN_PK} = @id";


            // Prepare command.
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    
                    personPK = (int)reader[EMPLOYEE_COLUMN_PERSON_ID];
                    firstName = (string)reader[PERSON_COLUMN_FIRST_NAME];
                    midName = (string)reader[PERSON_COLUMN_MID_NAME];
                    lastName = (string)reader[PERSON_COLUMN_LAST_NAME];
                    dateOfBirth = (DateTime)reader[PERSON_COLUMN_DATE];
                    email = (string)reader[PERSON_COLUMN_EMAIL];
                    gender = Convert.ToChar(reader[PERSON_COLUMN_GENDER]);
                    address = (string)reader[PERSON_COLUMN_ADDRESS];
                    dep_ID = (int)reader[EMPLOYEE_COLUMN_DEP_ID];
                }
                else isFound = false;

                reader.Close();

            }
            catch
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }


        public static bool GetEmployeeByName(ref int id, string name)
        {

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"SELECT {EMPLOYEE_COLUMN_PK}
                            FROM {EMPLOYEES}
                            JOIN {PERSONS} ON {EMPLOYEES}.{EMPLOYEE_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                            WHERE 
                            {PERSON_COLUMN_FIRST_NAME} + ' ' + 
                            {PERSON_COLUMN_MID_NAME} + ' ' +
                            {PERSON_COLUMN_LAST_NAME} = @name";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@name", name);

            try
            {
                conn.Open();
                LoadID(ref id, command, EMPLOYEE_COLUMN_PK);
            }
            catch
            {
                id = -1;
            }
            finally
            {
                conn.Close();
            }

            return id > 0;
        }


        public static bool UpdateEmployee
            (
            int id,
            string firstName, string midName, string lastName,
            DateTime dateOfBirth, string email, char gender, string address,
            int  depID, int empID
            )
        {

            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query1 = PersonUpdate();
            string query2 = $@"UPDATE {EMPLOYEES}
                            SET {EMPLOYEE_COLUMN_DEP_ID} = @depID
                            WHERE {EMPLOYEE_COLUMN_PK} = @empID";

            // Prepare Command.
            SqlCommand command1 = new SqlCommand(query1, conn);
            SqlCommand command2 = new SqlCommand(query2, conn);

            command1.Parameters.AddWithValue("@id", id);
            command1.Parameters.AddWithValue("@firstName", firstName);
            command1.Parameters.AddWithValue("@midName", midName);
            command1.Parameters.AddWithValue("@lastName", lastName);
            command1.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            command1.Parameters.AddWithValue("@email", email);
            command1.Parameters.AddWithValue("@gender", gender);
            command1.Parameters.AddWithValue("@address", address);

            command2.Parameters.AddWithValue("@empID", empID);
            command2.Parameters.AddWithValue("@depID", depID);

            // Start connction.

            try
            {
                conn.Open();
                rowEffected = command1.ExecuteNonQuery(); // Execute Update Person.
                rowEffected += command2.ExecuteNonQuery(); // Execute Update Employee.

            }
            catch (Exception)
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }

            // Execute Command.
            return rowEffected > 0;
        }

        public static DataTable SelectAllEmployees()
        {
            DataTable dt = new DataTable();

            // Connect to Database.
            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"SELECT 
                            {EMPLOYEES}.{EMPLOYEE_COLUMN_PK},
                            {EMPLOYEES}.{EMPLOYEE_COLUMN_DEP_ID},
                            {PERSONS}.{PERSON_COLUMN_FIRST_NAME} + ' ' +
                            {PERSONS}.{PERSON_COLUMN_MID_NAME} + ' ' +
                            {PERSONS}.{PERSON_COLUMN_LAST_NAME} AS Name,
                            {PERSONS}.{PERSON_COLUMN_DATE},
                            {PERSONS}.{PERSON_COLUMN_EMAIL},
                            {PERSONS}.{PERSON_COLUMN_GENDER},
                            {PERSONS}.{PERSON_COLUMN_ADDRESS}
                            FROM {EMPLOYEES}
                            JOIN {PERSONS}
                            ON {EMPLOYEES}.{EMPLOYEE_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}";

            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static DataTable SelectAllDoctors()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"SELECT
                            {PERSONS}.{PERSON_COLUMN_FIRST_NAME} + ' ' +
                            {PERSONS}.{PERSON_COLUMN_MID_NAME} + ' ' +
                            {PERSONS}.{PERSON_COLUMN_LAST_NAME} AS Name
                            FROM {EMPLOYEES}
                            JOIN {PERSONS} ON {EMPLOYEES}.{EMPLOYEE_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                            JOIN {DEPARTMENTS} ON {EMPLOYEES}.{EMPLOYEE_COLUMN_DEP_ID} = {DEPARTMENTS}.{DEP_COLUMN_PK}
                            WHERE {DEP_COLUMN_NAME} = 'Medical'";

            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            } 
            catch
            {

            } 
            finally
            {
                conn.Close();
            }

            return dt;

        }

        /************Queries For Users*************/
        public static bool AddNewUserToDB(int employeeID, string userName, string password, bool isActive, int permission)
        {

            if (employeeID <= 0)
                return false;

            int rowEffected = 0;


            SqlConnection conn = ClsDataAccessSettings.Connection();

            
            string query = $@"INSERT INTO {USERS}
                            ({USERS_COLUMN_EMPLOYEE_ID}, 
                             {USERS_COLUMN_USERNAME}, 
                             {USERS_COLUMN_PASSWORD}, 
                             {USERS_COLUMN_IS_ACTIVE}, 
                             {USERS_COLUMN_PERMISSION})
                             VALUES
                             (@employeeID, @userName, @password, @isActive, @permission)";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@permission", permission);


            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch
            {
                rowEffected = -1;
            } 
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static bool GetUserByID
            (
            int userID, ref int employeeID, 
            ref string userName, ref string password, 
            ref bool isActive, ref int permission
            )
        {
            bool isFound = false;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"{Select(USERS)} WHERE {USERS_COLUMN_PK} = @userID";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@userID", userID);


            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    employeeID = (int)reader[USERS_COLUMN_EMPLOYEE_ID];
                    userName = (string)reader[USERS_COLUMN_USERNAME];
                    password = (string)reader[USERS_COLUMN_PASSWORD];
                    permission = (int)reader[USERS_COLUMN_PERMISSION];
                    isActive = (bool)reader[USERS_COLUMN_IS_ACTIVE];
                    
                }
                else isFound = false;

                reader.Close();
            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }


            return isFound;
        }

        public static bool GetUserByUserAndPassword
            (
            ref int userID, ref int employeeID,
            string userName, string password,
            ref bool isActive, ref int permission
            )
        {
            bool isFound = false;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"{Select(USERS)}
                            WHERE 
                            {USERS_COLUMN_USERNAME} = '{userName}' 
                            AND 
                            {USERS_COLUMN_PASSWORD} = '{password}'";

            
            SqlCommand command = new SqlCommand(query, conn);
            
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    userID = (int)reader[USERS_COLUMN_PK];
                    userName = (string)reader[USERS_COLUMN_USERNAME];
                    password = (string)reader[USERS_COLUMN_PASSWORD];
                    isActive = (bool)reader[USERS_COLUMN_IS_ACTIVE];
                    permission = (int)reader[USERS_COLUMN_PERMISSION];
                    employeeID = (int)reader[USERS_COLUMN_EMPLOYEE_ID];
                    
                }
                else isFound = false;

                reader.Close();
            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }


            return isFound;
        }


        public static bool UpdateUserInfo
            (int userID, 
            string userName, string password, int permission, bool isActive)
        {
            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"Update {USERS}
                            SET 
                            {USERS_COLUMN_USERNAME} = @user,
                            {USERS_COLUMN_PASSWORD} = @pass,
                            {USERS_COLUMN_PERMISSION} = @permission,
                            {USERS_COLUMN_IS_ACTIVE} = @isActive
                            WHERE {USERS_COLUMN_PK} = @userID";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@userID", userID);
            command.Parameters.AddWithValue("@user", userName);
            command.Parameters.AddWithValue("@pass", password);
            command.Parameters.AddWithValue("@permission", permission);
            command.Parameters.AddWithValue("@isActive", isActive);

            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            } 
            catch
            {
                rowEffected = -1;
            } 
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"SELECT 
                           {USERS}.{USERS_COLUMN_PK},
                           Employee = 
                           {PERSONS}.{PERSON_COLUMN_FIRST_NAME} + ' ' +
                           {PERSONS}.{PERSON_COLUMN_MID_NAME} + ' ' +
                           {PERSONS}.{PERSON_COLUMN_LAST_NAME},
                           {USERS}.{USERS_COLUMN_USERNAME},
                           {USERS}.{USERS_COLUMN_PASSWORD},
                           {USERS}.{USERS_COLUMN_PERMISSION}
                           FROM {USERS}
                           JOIN {EMPLOYEES} ON {USERS}.{USERS_COLUMN_EMPLOYEE_ID} = {EMPLOYEES}.{EMPLOYEE_COLUMN_PK}
                           JOIN {PERSONS} ON {EMPLOYEES}.{EMPLOYEE_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}";

            SqlCommand command = new SqlCommand(query, conn);
            
            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            } 
            catch
            {

            } 
            finally
            {
                conn.Close();
            }

            return dt;
        }


        public static bool DeleteUserByID(int id)
        {
            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $"DELETE {USERS} WHERE {USERS_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            } 
            catch
            {
                rowEffected = -1;
            } 
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        /************Queries For Phones*************/
        public static bool AddNewPhoneToDB(int personID, string phoneNumber)
        {
            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"{Insert(PHONES)} 
                            ({PHONE_COLUMN_FK}, {PHONE_COLUMN_NUMBER})
                            VALUES
                            (@PersonID, @Number)";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@Number", phoneNumber);

            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }



            return rowEffected > 0;
        }

        public static bool GetPhoneByID(int id, ref int personID, ref string number)
        {
            bool isFound = false;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $"{Select(PHONES)} WHERE {PHONE_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);


            try
            {
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    personID = (int)reader[PHONE_COLUMN_FK];
                    number = (string)reader[PHONE_COLUMN_NUMBER];

                }
                else isFound = false;

                reader.Close();

            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }
            return isFound;
        }

        public static bool UpdatePhone(int id, int personID, string phoneNumber)
        {
            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();


            string query = $@"UPDATE {PHONES}
                                {phoneNumber} = @phoneNumber
                            WHERE {PHONE_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            
            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static DataTable SelectAllPersonPhones(int personID)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"SELECT 
                            {PHONE_COLUMN_PK},
                            {PHONE_COLUMN_NUMBER} 
                            FROM {PHONES}
                            WHERE {PHONE_COLUMN_FK} = @personID";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }


        /************Queries For Appointment*************/

        public static bool GetAppointmentByID
            (
            int id,
            ref int DoctorID, ref int PateintID, ref int PaymentID,
            ref int RecordID, ref string AppointmentStatus, ref DateTime DateAndTime
            )
        {

            bool isFound = false;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $"{Select(APPOINTMENTS)} WHERE {APPOINTMENT_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    DoctorID = (int)reader[APPOINTMENT_COLUMN_DOCTOR_ID];
                    PateintID = (int)reader[APPOINTMENT_COLUMN_PATIENT_ID];
                    PaymentID = (int)reader[APPOINTMENT_COLUMN_PAYMENT_ID];
                    RecordID = (int)reader[APPOINTMENT_COLUMN_RECORD_ID];
                    AppointmentStatus = (string)reader[APPOINTMENT_COLUMN_STATUS];
                    DateAndTime = (DateTime)reader[APPOINTMENT_COLUMN_DATE];
                }
                else isFound = false;

                reader.Close();

            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }

        public static DataTable GetAllAppointemnts()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"{APPOINTMENT_INFO_QUERY}";

            // Perpare command.
            SqlCommand command = new SqlCommand(query, conn);

            // Execute command.
            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;       
        }

        public static DataTable GetAppointmentByStatusAndDate(List<string> statusesList, DateTime date)
        {
            string statuses = JoinForSqlIn(statusesList); // Used for (in operator).


            DataTable dt = new DataTable();

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"{APPOINTMENT_INFO_QUERY}
                            WHERE {APPOINTMENT_COLUMN_STATUS} in ({statuses})
                            AND {APPOINTMENT_COLUMN_DATE} = @date";

            SqlCommand command = new SqlCommand(query, conn);
            //command.Parameters.AddWithValue("@Status", statuses);
            command.Parameters.AddWithValue("@date", date);

            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            } 
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static DataTable GetAppointmentBetweenDate(DateTime s, DateTime e)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"{APPOINTMENT_INFO_QUERY} WHERE {APPOINTMENT_COLUMN_DATE} BETWEEN @s AND @e";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@s", s);
            command.Parameters.AddWithValue("@e", e);

            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            } 
            catch
            {

            } 
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static bool AddNewAppointmentToDB
            (
            int DoctorID, int PatientID, int PaymentID, int RecordID, string Status, DateTime DateAndTime
            )
        {
            int rowEffected = 0;

            // Connect to Database.
            SqlConnection conn = ClsDataAccessSettings.Connection();

            // Prepare Sql Query.
            string query = $@"INSERT INTO {APPOINTMENTS}
                            ({APPOINTMENT_COLUMN_DOCTOR_ID},
                            {APPOINTMENT_COLUMN_PATIENT_ID},
                            {APPOINTMENT_COLUMN_PAYMENT_ID}, 
                            {APPOINTMENT_COLUMN_RECORD_ID},
                            {APPOINTMENT_COLUMN_STATUS}, 
                            {APPOINTMENT_COLUMN_DATE})
                            VALUES
                            (@DoctorID, @PatientID, @PaymentID, @RecordID, @Status, @DateAndTime)";

            // Prepare Command
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            command.Parameters.AddWithValue("@PatientID", PatientID);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);
            command.Parameters.AddWithValue("@RecordID", RecordID);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@DateAndTime", DateAndTime);


            // Execute Command
            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static bool UpdateAppointment
            (
            int AppointmentID,
            int PateintID, int DoctorID, DateTime DateAndTime, 
            int PaymentID, int RecordID, string AppointmentStatus
            )
        {
            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"UPDATE {APPOINTMENTS}
                            SET {APPOINTMENT_COLUMN_DOCTOR_ID} = @doctorID,
                                {APPOINTMENT_COLUMN_PATIENT_ID} = @pateintID,
                                {APPOINTMENT_COLUMN_PAYMENT_ID} = @paymentID,
                                {APPOINTMENT_COLUMN_RECORD_ID} = @recordID,
                                {APPOINTMENT_COLUMN_STATUS} = @status,
                                {APPOINTMENT_COLUMN_DATE} = @dateAndTime
                            WHERE {APPOINTMENT_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", AppointmentID);
            command.Parameters.AddWithValue("@doctorID", DoctorID);
            command.Parameters.AddWithValue("@pateintID", PateintID);
            command.Parameters.AddWithValue("@paymentID", PaymentID);
            command.Parameters.AddWithValue("@recordID", RecordID);
            command.Parameters.AddWithValue("@status", AppointmentStatus);
            command.Parameters.AddWithValue("@dateAndTime", DateAndTime);


            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            } 
            catch (Exception)
            {
                rowEffected = -1;
            }
             finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static bool RescheduleDate(int AppointmentID, DateTime DateAndTime, string AppointmentStatus)
        {
            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"UPDATE {APPOINTMENTS}
                            SET {APPOINTMENT_COLUMN_DATE} = @dateAndTime,
                                {APPOINTMENT_COLUMN_STATUS} = @status
                            WHERE {APPOINTMENT_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", AppointmentID);
            command.Parameters.AddWithValue("@status", AppointmentStatus);
            command.Parameters.AddWithValue("@dateAndTime", DateAndTime);

            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }


        /************Queries For Medical Record*************/
        public static bool AddNewMedicalRecordToDB(ref int recordID, string description, string diagnosis, string note)
        {

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"{Insert(MEDICAL_RECORDS)}
                            ({MEDICAL_RECORD_DESCRIPTION}, {MEDICAL_RECORD_DIAGNOSIS}, {MEDICAL_RECORD_NOTE})
                            VALUES
                            (@description, @diagnosis, @note);
                            SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@diagnosis", diagnosis);
            command.Parameters.AddWithValue("@note", note);

            try
            {
                conn.Open();
                object result = command.ExecuteScalar();
                // Get the last inserted Record ID.
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    recordID = insertedID;
            } 
            catch (Exception)
            {
                recordID = -1;
            } 
            finally
            {
                conn.Close();
            }

            return recordID > 0;
        }
        
        public static bool UpdateMedicalRecord
            (
            int RecordID,
            string Description, string Diagnosis, string Note
            )
        {
            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"UPDATE {MEDICAL_RECORDS}
                            SET {MEDICAL_RECORD_DESCRIPTION} = @description,
                                {MEDICAL_RECORD_DIAGNOSIS} = @diagnosis,
                                {MEDICAL_RECORD_NOTE} = @note
                            WHERE {MEDICAL_RECORD_COLUMN_PK} = @recordID";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@recordID", RecordID);
            command.Parameters.AddWithValue("@description", Description);
            command.Parameters.AddWithValue("@diagnosis", Diagnosis);
            command.Parameters.AddWithValue("@note", Note);


            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static bool GetMedicalRecordByID
           (
           int RecordID,
           ref string Description, ref string Diagnosis, ref string Note
           )
        {

            bool isFound = false;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $"{Select(MEDICAL_RECORDS)} WHERE {MEDICAL_RECORD_COLUMN_PK} = @recordID";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@recordID", RecordID);


            try
            {
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true; // The Phone was found.

                    // Fill the Phone Data.
                    Description = (string)reader[MEDICAL_RECORD_DESCRIPTION];
                    Diagnosis = (string)reader[MEDICAL_RECORD_DIAGNOSIS];
                    Note = (string)reader[MEDICAL_RECORD_NOTE];
                }
                else isFound = false;

                reader.Close();

            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }


        /************Queries For Payment*************/
        public static bool AddNewPaymentToDB
            (ref int paymentID, int patientID, int methodID, 
            DateTime paymentDate, decimal paymentAmount, string note)
        {

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"{Insert(PAYMENTS)}
                            ({PAYMENT_COLUMN_PAITENT_ID}, {PAYMENT_COLUMN_METHOD_ID},
                            {PAYMENT_COLUMN_AMOUNT}, {PAYMENT_COLUMN_DATE},
                            {PAYMENT_COLUMN_NOTE})
                            VALUES
                            (@patientID, @MethodID, @paymentAmount, @paymentDate, @note);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@patientID", patientID);
            command.Parameters.AddWithValue("@methodID", methodID);
            command.Parameters.AddWithValue("@paymentDate", paymentDate);
            command.Parameters.AddWithValue("@paymentAmount", paymentAmount);
            command.Parameters.AddWithValue("@note", note);

            try
            {
                conn.Open();
                
                object result = command.ExecuteScalar();
                // Get the last inserted Payment ID.
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    paymentID = insertedID;
            } 
            catch (Exception)
            {
                paymentID = -1;
            } 
            finally
            {
                conn.Close();
            }

            return paymentID > 0;
        }

        public static bool UpdatePayment
            (int PaymentID, int PateintID, decimal PaymentAmount, DateTime PaymentDate, string Note)
        {

            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"UPDATE {PAYMENTS}
                            SET {PAYMENT_COLUMN_PAITENT_ID} = @pateintID,
                                {PAYMENT_COLUMN_AMOUNT} = @paymentAmount,
                                {PAYMENT_COLUMN_DATE} = @paymentDate,
                                {PAYMENT_COLUMN_NOTE} = @note,
                            WHERE {PAYMENT_COLUMN_PK} = @paymentID";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@paymentID", PaymentID);
            command.Parameters.AddWithValue("@pateintID", PateintID);
            command.Parameters.AddWithValue("@paymentAmount", PaymentAmount);
            command.Parameters.AddWithValue("@note", Note);
            command.Parameters.AddWithValue("@paymentDate", PaymentDate);


            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            } 
            catch (Exception) 
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static bool GetPaymentByID
            (
            int id,
            ref int PateintID, ref decimal PaymentAmount, 
            ref DateTime PaymentDate, ref string Note
            )
        {

            bool isFound = false;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $"{Select(PAYMENTS)} WHERE {PAYMENT_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    PateintID = (int)reader[PAYMENT_COLUMN_PAITENT_ID];
                    PaymentAmount = (decimal)reader[PAYMENT_COLUMN_AMOUNT];
                    PaymentDate = (DateTime)reader[PAYMENT_COLUMN_DATE];
                    Note = (string)reader[PAYMENT_COLUMN_NOTE];
                }
                else isFound = false;

                reader.Close();
            } 
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }

        public static DataTable GetAllPayments()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"Select
                            {PERSONS}.{PERSON_COLUMN_FIRST_NAME} + ' ' +
                            {PERSONS}.{PERSON_COLUMN_MID_NAME} + ' ' +
                            {PERSONS}.{PERSON_COLUMN_LAST_NAME} as Name,
                            {PAYMENT_METHOD_COLUMN_METHOD},
                            {PAYMENTS}.{PAYMENT_COLUMN_AMOUNT},
                            {PAYMENTS}.{PAYMENT_COLUMN_DATE},
                            {PAYMENTS}.{PAYMENT_COLUMN_NOTE}
                            FROM {PAYMENTS}
                            JOIN {PATIENTS} ON {PAYMENTS}.{PAYMENT_COLUMN_PAITENT_ID} = {PATIENTS}.{PATIENT_COLUMN_PK}
                            JOIN {PERSONS} ON {PATIENTS}.{PATIENT_COLUMN_FK} = {PERSONS}.{PERSON_COLUMN_PK}
                            JOIN {PAYMENT_METHODS} ON {PAYMENTS}.{PAYMENT_COLUMN_METHOD_ID} = {PAYMENT_METHODS}.{PAYMENT_METHOD_COLUMN_PK}";


            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static DataTable GetPaymentByDateAndMethod(DateTime from, DateTime to, int id)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"Select
                            {PAYMENTS}.*,
                            {PAYMENT_METHOD_COLUMN_METHOD}
                            FROM {PAYMENTS}
                            JOIN {PAYMENT_METHODS} ON {PAYMENTS}.{PAYMENT_COLUMN_METHOD_ID} = {PAYMENT_METHODS}.{PAYMENT_METHOD_COLUMN_PK}
                            WHERE {PAYMENTS}.{PAYMENT_COLUMN_DATE} BETWEEN @from AND @to
                            AND {PAYMENT_METHODS}.{PAYMENT_METHOD_COLUMN_PK} = @methodID";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@from", from);
            command.Parameters.AddWithValue("@to", to);
            command.Parameters.AddWithValue("@methodID", id);

            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        /************Queries For Payment Method*************/
        public static bool AddNewPaymentMethodToDB(string PaymentMethod)
        {
            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"{Insert(PAYMENT_METHODS)}
                              ({PAYMENT_METHOD_COLUMN_METHOD})
                              VALUES
                              (@method)";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@method", PaymentMethod);

            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static bool UpdatePaymentMethod(int PM_ID, string PaymentMethod)
        {
            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"UPDATE {PAYMENT_METHODS}
                            SET {PAYMENT_METHOD_COLUMN_METHOD} = @method,
                            WHERE {PAYMENT_METHOD_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", PM_ID);
            command.Parameters.AddWithValue("@method", PaymentMethod);
            
            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static bool GetPaymentMethodByID(int id, ref string PaymentMethod)
        {

            bool isFound = false;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $"{Select(PAYMENT_METHODS)} WHERE {PAYMENT_METHOD_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    PaymentMethod = (string)reader[PAYMENT_METHOD_COLUMN_METHOD];
                }
                else isFound = false;

                reader.Close();
            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }

        public static bool GetPaymentMethodIDByName(ref int id, string name)
        {
            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"SELECT {PAYMENT_METHOD_COLUMN_PK}
                               FROM {PAYMENT_METHODS}
                               WHERE 
                              {PAYMENT_METHOD_COLUMN_METHOD} = '{name}'";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@name", name);

            try
            {
                conn.Open();
                LoadID(ref id, command, PAYMENT_METHOD_COLUMN_PK);
            }
            catch
            {
                id = -1;
            }
            finally
            {
                conn.Close();
            }

            return id > 0;
        }



        /************Queries For Prescriptions*************/

        public static bool AddNewPrescriptionToDB(int RecordID, ref int insID)
        {

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"{Insert(PRESCRIPTIONS)}
                            ({PRESCRIPTION_COLUMN_FK})
                            VALUES
                            (@recordID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@recordID", RecordID);
            

            try
            {
                conn.Open();
                object result = command.ExecuteScalar();
                // Get the last inserted ID.
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    insID = insertedID;
            }
            catch (Exception)
            {
                insID = -1;
            }
            finally
            {
                conn.Close();
            }

            return insID > 0;
        }

        public static bool GetPrescriptionByFK(ref int prescriptionID, int recordID)
        {
            bool isFound = false;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"{Select(PRESCRIPTIONS)}
                            WHERE {PRESCRIPTION_COLUMN_FK} = @recordID";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@recordID", recordID);

            try
            {
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    prescriptionID = (int)reader[PRESCRIPTION_COLUMN_PK];
                }
                else isFound = false;

                reader.Close();

            } 
            catch
            {
                isFound = false;
            } 
            finally
            {
                conn.Close();
            }

            return isFound;
        }


        /************Queries For Medication*************/
        public static bool AddNewMedication
            (
            int PrescriptionID,
            string MedicationName, int Freq, string Dosage,
            DateTime SDate, DateTime EDate
            )
        {
            int rowEffected = 0;

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"{Insert(MEDICATIONS)}
                              ({MEDICATION_COLUMN_FK},
                              {MEDICATION_NAME}, {MEDICATION_FREQ}, {MEDICATION_DOSAGE},
                              {MEDICATION_S_DATE}, {MEDICATION_E_DATE})
                              VALUES 
                              (@PrescriptionID, 
                               @MedicationName, @Freq, @Dosage, 
                               @SDate, @EDate)";

            SqlCommand command = new SqlCommand(query, conn);            
            command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
            command.Parameters.AddWithValue("@MedicationName", MedicationName);
            command.Parameters.AddWithValue("@Freq", Freq);
            command.Parameters.AddWithValue("@Dosage", Dosage);
            command.Parameters.AddWithValue("@SDate", SDate);
            command.Parameters.AddWithValue("@EDate", EDate);

            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            } 
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                conn.Close();
            }

            return rowEffected > 0;
        }

        public static DataTable GetMedicationsByFK(int prescriptionID)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = ClsDataAccessSettings.Connection();

            string query = $@"{Select(MEDICATIONS)}
                            WHERE {MEDICATION_COLUMN_FK} = @fk";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@fk", prescriptionID);

            try
            {
                conn.Open();
                LoadDataToDataTable(ref dt, command);
            }
            catch
            {
            } 
            finally
            {
                conn.Close();
            }

            return dt;
        }
    }
}
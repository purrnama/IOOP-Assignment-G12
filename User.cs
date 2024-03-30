using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPAssignment_G12
{
    internal class User
    {
        //User class is used only during login, requiring only username and password
        //Role-specific methods and additional data are located in their respective classes

        private string _username;
        private string _password;
        private string _fullName;
        private string _email;
        private string _phone;
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string RealName { get => _fullName; set => _fullName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }

        public User(string username, string password, string fullName, string email, string phone)
        {
            _username = username;
            _password = password;
            _fullName = fullName;
            _email = email;
            _phone = phone;
        }
        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string Login()
        {
            string status = null;
            conn.Open();
            SqlCommand getUser = new SqlCommand("select count(*) from users where username=@u and password=@p", conn);
            getUser.Parameters.AddWithValue("@u", _username);
            getUser.Parameters.AddWithValue("@p", _password);

            int count = Convert.ToInt32(getUser.ExecuteScalar());
            if(count > 0)
            {

                //username exists, get role and full name to open respective menu
                SqlCommand getLoginInfo = new SqlCommand("select fullName, role from users where username=@u and password=@p", conn);
                getLoginInfo.Parameters.AddWithValue("@u", _username);
                getLoginInfo.Parameters.AddWithValue("@p", _password);

                SqlDataReader rd = getLoginInfo.ExecuteReader();
                while (rd.Read())
                {
                    string displayName;
                    string role;
                    role = rd.GetString(1);
                    try
                    {
                        displayName = rd.GetString(0);
                    }
                    catch
                    {
                        displayName = _username;
                    }
                    if (role == "admin")
                    {
                        frmAdmin a = new frmAdmin(displayName);
                        a.Show();
                    }
                    if (role == "member")
                    {
                        FormMember m = new FormMember(displayName);
                        m.Show();
                    }
                }
            }
            else
            {
                status = "Incorrect username or password";
            }
            conn.Close();
            return status;
        }

        //create a user with no additional data, such as admin
        //for other roles, create method in their respective classes
        public string AddUser(string role)
        {
            string status = null;
            conn.Open();

            //prepare SQL command for adding new user
            SqlCommand addUser = new SqlCommand("INSERT INTO Users(username, password, fullName, email, phone, role) VALUES(@u, @p, @rn, @e, @ph, @r)", conn);
            addUser.Parameters.AddWithValue("@u", _username);
            addUser.Parameters.AddWithValue("@p", _password);
            addUser.Parameters.AddWithValue("@rn", _fullName);
            addUser.Parameters.AddWithValue("@e", _email);
            addUser.Parameters.AddWithValue("@ph", _phone);
            addUser.Parameters.AddWithValue("@r", role);

            //prepare SQL command for checking username availability
            SqlCommand checkUsername = new SqlCommand("SELECT count(*) FROM users WHERE username=@u", conn);
            checkUsername.Parameters.AddWithValue("@u", _username);

            int count = Convert.ToInt32(checkUsername.ExecuteScalar());
            if (count > 0)
            {
                status = "User already exists with username " + _username;
            }
            else
            {
                int i = addUser.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Successfully added user " + _username;
                }
                else
                {
                    status = "Unable to add user " + _username;
                }
            }
            conn.Close();
            return status;
        }
    }
}

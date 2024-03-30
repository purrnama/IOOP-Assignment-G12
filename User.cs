using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace IOOPAssignment_G12
{
    internal class User
    {
        private string _username;
        private string _password;
        private string _fullName;
        private string _email;
        private string _phone;
        private string _role;
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Role { get => _role; set => _role = value; }

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

        //for use with ViewProfile
        public User(string fullName)
        {
            _fullName = fullName;
        }

        public string Login()
        {
            string status = null;
            SqlCommand getUser = new SqlCommand("select count(*) from users where username=@u and password=@p", conn);
            getUser.Parameters.AddWithValue("@u", _username);
            getUser.Parameters.AddWithValue("@p", _password);

            conn.Open();
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
                    if(role == "manager")
                    {

                    }
                    if(role == "coach")
                    {
                        frmCoach c = new frmCoach();
                        c.Show();
                    }
                    if(role == "member")
                    {

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

            conn.Open();
            int count = Convert.ToInt32(checkUsername.ExecuteScalar());
            if (count > 0)
            {
                status = "User already exists with username " + _username;
            }
            else
            {
                int i = addUser.ExecuteNonQuery();
                if (i == 0)
                {
                    status = "Unable to add user " + _username;
                }
            }
            conn.Close();
            return status;
        }

        public static string DeleteUser(User user)
        {
            string status = null;
            //prepare sql command for deleting user
            SqlCommand deleteUser = new SqlCommand("DELETE FROM users WHERE username=@u", conn);
            deleteUser.Parameters.AddWithValue("@u", user.Username);

            conn.Open();
            int i = deleteUser.ExecuteNonQuery();
            if(i == 0)
            {
                status = "Unable to delete user " + user.Username;
            }
            conn.Close();
            return status;
        }

        public static ArrayList ViewAll(string role = null)
        {
            ArrayList users = new ArrayList();
            conn.Open();

            SqlCommand viewAll;
            if(role != null)
            {
                viewAll = new SqlCommand("SELECT fullName FROM users WHERE role=@r", conn);
                viewAll.Parameters.AddWithValue("@r", role);
            }
            else
            {
                viewAll = new SqlCommand("SELECT fullName FROM users", conn);
            }
            SqlDataReader rd = viewAll.ExecuteReader();
            while (rd.Read())
            {
                try
                {
                    users.Add(rd.GetString(0));
                }
                catch
                {
                    continue;
                }
            }
            conn.Close();
            return users;
        }

        public static void ViewProfile(User user)
        {
            SqlCommand viewProfileByFullName = new SqlCommand("SELECT * FROM users WHERE fullName=@fn", conn);
            viewProfileByFullName.Parameters.AddWithValue("@fn", user.FullName);
            conn.Open();
            SqlDataReader rd = viewProfileByFullName.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    try
                    {
                        user.FullName = rd.GetString(3);
                    }
                    catch
                    {
                        user.FullName = string.Empty;
                    }
                    try
                    {
                        user.Email = rd.GetString(4);
                    }
                    catch
                    {
                        user.Email = string.Empty;
                    }
                    try
                    {
                        user.Phone = rd.GetString(5);
                    }
                    catch
                    {
                        user.Phone = string.Empty;
                    }
                    user.Username = rd.GetString(1);
                    user.Password = rd.GetString(2);
                    user.Role = rd.GetString(6);
                }
                rd.Close();
            }
            else
            {
                rd.Close();
                //fallback: try search by username instead
                SqlCommand viewProfileByUser = new SqlCommand("SELECT * FROM users WHERE username=@u", conn);
                viewProfileByUser.Parameters.AddWithValue("@u", user.FullName);
                SqlDataReader rd2 = viewProfileByUser.ExecuteReader();
                while (rd2.Read())
                {
                    try
                    {
                        user.FullName = rd2.GetString(3);
                    }
                    catch
                    {
                        user.FullName = string.Empty;
                    }
                    try
                    {
                        user.Email = rd2.GetString(4);
                    }
                    catch
                    {
                        user.Email = string.Empty;
                    }
                    try
                    {
                        user.Phone = rd2.GetString(5);
                    }
                    catch
                    {
                        user.Phone = string.Empty;
                    }
                    user.Username = rd2.GetString(1);
                    user.Password = rd2.GetString(2);
                    user.Role = rd2.GetString(6);
                }
                rd2.Close();
            }
            conn.Close();
        }

        public static string UpdateProfile(User currentUser, string username, string password, string fullName, string email, string phone)
        {
            string status = null;
            conn.Open();
            //prepare sql command for updating profile
            SqlCommand updateProfile = new SqlCommand("UPDATE users SET username=@un, password=@p, fullName=@fn, email=@e, phone=@ph WHERE username=@cu", conn);
            updateProfile.Parameters.AddWithValue("@un", username);
            updateProfile.Parameters.AddWithValue("@p", password);
            updateProfile.Parameters.AddWithValue("@fn", fullName);
            updateProfile.Parameters.AddWithValue("@e", email);
            updateProfile.Parameters.AddWithValue("@ph", phone);
            updateProfile.Parameters.AddWithValue("@cu", currentUser.Username);

            //prepare sql command to check if username already exists
            SqlCommand checkUsername = new SqlCommand("SELECT count(*) FROM users WHERE username=@u", conn);
            checkUsername.Parameters.AddWithValue("@u", username);

            int count = Convert.ToInt32(checkUsername.ExecuteScalar());
            if(currentUser.Username != username && count > 0)
            {
                status = "Cannot update username, user of name " + username + " already exists.";
            }
            else
            {
                int i = updateProfile.ExecuteNonQuery();
                if(i == 0)
                {
                    status = "Unable to update profile.";
                }
            }
            conn.Close();
            return status;
        }
    }
}

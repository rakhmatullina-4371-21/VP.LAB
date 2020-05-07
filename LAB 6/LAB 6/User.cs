using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LAB_6
{
    public class User
    {
        public string Loginn;
        public string Passwordd;
        public string NameUser;

        public bool u;
        public void SearchUser(string login,string password) 
        {
            u = false;

            string adress = "../../TextFile1.txt";
            string[] lines = File.ReadAllLines(adress);
            foreach (string line in lines)
            {
                string[] str = line.Split(' ');
                if (login == str[0] && password == str[1])
                {
                    Loginn = str[0];
                    Passwordd = str[1];
                    NameUser = str[2];
                    u = true;
                }
            }
             if(!u) MessageBox.Show("НЕВЕРНЫЙ ЛОГИН ИЛИ ПАРОЛЬ");
        }
        public void EditLogPas(string login, string password,string name) 
        {
            string adress = "../../TextFile1.txt";
            string[] lines = File.ReadAllLines(adress);
            List<string> listUesr = new List<string>();
                for (int i = 0; i <= lines.Length-1;i++)
                {
                    string[] str = lines[i].Split(' ');
                    if (name == str[2])
                    {
                    str[0] = login;
                    str[1] = password;
                    str[2] = NameUser;
                    listUesr.Add(str[0]+" "+str[1]+" "+str[2]);
                    }
                    else
                     listUesr.Add(str[0] + " " + str[1] + " " + str[2]);
                }
            MessageBox.Show("ЛОГИН ИЛИ ПАРОЛЬ УСПЕШНО ИЗМЕНЕН");
                File.WriteAllLines(adress, listUesr);
        }
    }
}

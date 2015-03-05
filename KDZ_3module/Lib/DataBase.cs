using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{

    public class DataBase : Singleton<DataBase>
    {
        static private Exception GetDataErrorException()
        {
            return new Exception("Строка имеет неверный формат");
        }
        private DataBase()
            : base()
        {
        }
        List<ListVersion> History = new List<ListVersion>();
        List<Notary> list;
        List<string> ErrorList;
        public List<string> GetErrorList
        {
            get
            {
                return ErrorList;
            }
        }
        public void GetNewDataBaseFromString(string s)
        {
            ErrorList = new List<string>();
            list = new List<Notary>();
            int start = 0;
            while (s[start] < '0' || s[start] > '9')
            {
                if (start >= s.Length) throw GetDataErrorException();
                start++;
            }
            int i = start;
            while (i < s.Length)
            {
                int temp = i;
                string number;
                string fullname;
                string phonenumber;
                string address;
                string metrostations;
                if (ReadNumber(s, ref i, out number)&&
                    ReadString(s, ref i, out fullname) &&
                    ReadString(s, ref i, out phonenumber)&&
                    ReadString(s, ref i, out address)&&
                    ReadString(s, ref i, out metrostations))
                {
                    list.Add(new Notary(int.Parse(number), fullname, phonenumber, address, metrostations));
                }
                else
                {
                    string str = "";
                    for (int j = temp; j<= i;j++)
                    {
                        str += s[j];
                    }
                    ErrorList.Add(str);
                }
            }
            History.Add(new ListVersion("Загруженный файл", list));
        }
        private bool ReadNumber(string s, ref int i, out string res)
        {
            res = "";
            if (s[i] < '0' || s[i] > '9')
                throw GetDataErrorException();
            while (s[i] >= '0' && s[i] <= '9')
            {
                res += s[i];
                i++;
                if (i >= s.Length)
                {
                    i++;
                    return false;
                }
            }
            if (res != "")
            {
                i++;
                return true;
            }
            else
            {
                i++;
                return false;
            }
        }
        private bool ReadString(string s, ref int i, out string res)
        {
            try
            {
                while(s[i] == ' ')
                {
                    s.Remove(i, 1);
                }
                bool f = s[i] == '\"';
                if (f) i++;
                res = "";
                while (true)
                {
                    if (!f && i >= s.Length)
                        break;
                    if (f && s[i] == '\"')
                    {
                        if (i >= s.Length)
                            throw GetDataErrorException();
                        if (s[i + 1] != '\"')
                        {
                            i++;
                            break;
                        }
                        i++;
                    }
                    if (!f && s[i] == ',' || s[i] == '\n')
                        break;
                    res += s[i];
                    i++;
                }
                while (res.IndexOf("\"\"") > -1)
                {
                    res.Remove(res.IndexOf("\"\""), 1);
                }
                if (res == "")
                    throw GetDataErrorException();
                i++;
                return true;
            }
            catch(Exception)
            {
                i++;
                res = "";
                return false;
            }
        }
        public List<Notary> GetList
        {
            get
            {
                return list;
            }
        }
        public List<ListVersion> GetHistory
        {
            get
            {
                return History;
            }
        }
    }
}

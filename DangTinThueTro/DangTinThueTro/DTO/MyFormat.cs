using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangTinThueTro.DTO
{
    public class MyFormat
    {
        private static string resourceDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources\\";
        public static string FormatMoney(int money)
        {
            return String.Format("{0:n0}", money);
        }
        public static string FormatNgayThatSangDb(DateTime date)
        {
            return String.Format("{0:yyyy-MM-dd}", date);
        }
        public static string FormatNgayThatSangDb(DateOnly date)
        {
            return String.Format("{0:yyyy-MM-dd}", date);
        }
        public static string FormatNgayGioSangGio(DateTime date)
        {
            return String.Format("{0:hh:mm}", date);
        }
        public static string FormatNgayDbSangNgayThat(DateTime date)
        {
            return String.Format("{0:dd-MM-yyyy}", date);
        }
        public static string FormatDateTime(DateTime dateTime)
        {
            return String.Format("{0:ddMMyyyy_HHmmss}", dateTime);
        }
        public static string GetFilePath(string tenFile)
        {
            return resourceDir + tenFile;
        }
    }
}

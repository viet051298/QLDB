using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra.DAL.Entity
{
    class LienLac
    {
        private string maNhom;
        private string tenGoi;
        private string email;
        private string sdt;

        public string MaNhom { get => maNhom; set => maNhom = value; }
        public string TenGoi { get => tenGoi; set => tenGoi = value; }
        public string Email { get => email; set => email = value; }
        public string SDT { get => sdt; set => sdt = value; }

        // lấy liên lạc từ file txt
        public static List<LienLac> getLienlacfromfile(string path)
        {
            List<LienLac> lstLienLac = new List<LienLac>();
            string[] data = File.ReadAllLines(path);

            foreach (var line in data)
            {

                var lsValue = line.Split(new char[] { '#' });
                var lienlac = new LienLac
                {
                    MaNhom = lsValue[0],
                    TenGoi = lsValue[1],
                    Email = lsValue[2],
                    SDT = lsValue[3]
                };
                lstLienLac.Add(lienlac);
            }
            return lstLienLac;

        }

        // lấy liên lạc theo ma nhóm
        public static List<LienLac> getLienLacTuMaNhom(string maNhom, string path)
        {
            List<LienLac> lstLienLac = getLienlacfromfile(path);
            List<LienLac> lstLienLacNhom = new List<LienLac>();

            foreach(LienLac lienlac in lstLienLac)
            {
                if (lienlac.MaNhom.Equals(maNhom))
                {
                    lstLienLacNhom.Add(lienlac);
                }
            }
            return lstLienLacNhom;
        }

        //lấy Email từ tên gọi
        public static string getEmailTuTenGoi(string tenGoi, string path)
        {
            List<LienLac> lstlienlac = getLienlacfromfile(path);
            foreach (LienLac lienlac in lstlienlac)
            {
                if (lienlac.TenGoi == tenGoi)
                {
                    return lienlac.Email;
                }
            }
            return null;
        }

        //thêm liên lạc
        public static void add(string maNhom, string tenGoi,string email,string sdt, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
           
                writer.WriteLine(maNhom + "#" + tenGoi + "#" + email + "#" +sdt);
                writer.Flush();
                writer.Close();

            }
        }

        // xóa liên lạc

        public static void xoalienlac(string Email, string path)
        {
            string[] lines = File.ReadAllLines(path);
            // xóa hết
            File.WriteAllText(path, "");

            //ghi lại nếu không trùng mã
            using(StreamWriter write = new StreamWriter(path))
            {
                foreach(string line in lines)
                {
                    var lsValue = line.Split('#');
                    //lấy email
                    string email = lsValue[2];
                    if (!email.Equals(Email))
                    {
                        write.WriteLine(line);
                    }
                   
                }
                write.Flush();
                write.Close();

            }
        }

        // Tìm kiếm liên lạc theo tên
        public static List<LienLac> timLienLac(string path, string tengoi)
        {
            List<LienLac> lstLienLac = getLienlacfromfile(path);
            List<LienLac> lstNew = new List<LienLac>();
            foreach (LienLac lienLac in lstLienLac)
            {
                if (string.Compare(lienLac.TenGoi, tengoi, true) == 0)
                {
                    lstNew.Add(lienLac);
                }
            }
            return lstNew;
        }


    }
}

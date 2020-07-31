using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra.DAL.Entity
{
    class Nhom
    {
        private string maNhom;
        private string tenNhom;

        public string MaNhom { get => maNhom; set => maNhom = value; }
        public string TenNhom { get => tenNhom; set => tenNhom = value; }

        //lấy nhóm từ file txt
        public static List<Nhom> getNhomfromfile(string path)
        {
            List<Nhom> lstNhom = new List<Nhom>();
            string[] data = File.ReadAllLines(path);

            foreach (var line in data)
            {
               
                    var lsValue = line.Split(new char[] { '#' });
                     var nhom = new Nhom
                    {    MaNhom = lsValue[0],         
                         TenNhom = lsValue[1]
                    };
                lstNhom.Add(nhom);
                

            }
            return lstNhom;

        }

        //lấy ma từ tên nhóm
        public static string getMaTuTenNhom(string tenNhom, string path)
        {
            List<Nhom> lstNhom = getNhomfromfile(path);
            foreach(Nhom nhom in lstNhom)
            {
                if(nhom.TenNhom == tenNhom)
                {
                    return nhom.MaNhom;
                }
            }
            return null;
        }

        //lấy mã nhóm cuối cùng
        public static int getMaNhomCuoiCung(string path)
        {
            List<Nhom> list = Nhom.getNhomfromfile(path);
            return Int32.Parse(list[list.Count - 1].MaNhom);
        }

        //thêm nhóm
        public static void add(string tenNhom, string path)
        {
            int maNhom = getMaNhomCuoiCung(path)+1;
            using (StreamWriter writer = new StreamWriter(path, true))
            {
             
                writer.WriteLine(maNhom + "#" + tenNhom);
                writer.Flush();
                writer.Close();

            }
        }

        // Xoa nhom
        public static void xoaNhom(string path, string maNhom)
        {

            string[] lines = File.ReadAllLines(path);

            // Xóa hết
            File.WriteAllText(path, "");

            // Ghi lại nếu không trùng mã 
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string line in lines)
                {
                    var lsValue = line.Split('#');
                    // Lấy mã 
                    string ma = lsValue[0];
                    if (!ma.Contains(maNhom))
                    {
                        writer.WriteLine(line);
                    }
                }
                writer.Flush();
                writer.Close();
            }
        }
    }
}

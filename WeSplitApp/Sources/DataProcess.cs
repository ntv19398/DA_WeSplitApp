using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WeSplitApp.Sources
{
    class DataProcess
    {
        public static List<ChuyenDi> getListChuyenDi()
        {
            List<ChuyenDi> lstChuyenDi = new List<ChuyenDi>();
            string line;
            using (var file = new StreamReader("ChuyenDi.txt"))
            { 
                while((line = file.ReadLine()) != null)
                {
                    ChuyenDi cd = new ChuyenDi();
                    string[] element = line.ToString().Split(new string[] { "\t" }, StringSplitOptions.None);
                    cd.maCD = element[0];
                    cd.tenCD = element[1];
                    cd.urlImage = element[2];
                    cd.loTrinh = element[3];
                    cd.tinhTrang = element[4];
                    lstChuyenDi.Add(cd);
                }
            }
            return lstChuyenDi;
        }

        public static List<DiaDiem> getListDiaDiem()
        {
            List<DiaDiem> lstDiaDiem = new List<DiaDiem>();
            string line;
            using (var file = new StreamReader("DiaDiem.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    DiaDiem dd = new DiaDiem();
                    string[] element = line.ToString().Split(new string[] { "\t" }, StringSplitOptions.None);
                    dd.maCD = element[0];
                    dd.maDD = element[1];
                    dd.tenDD = element[2];
                    lstDiaDiem.Add(dd);
                }
            }
            return lstDiaDiem;
        }
        public static List<ThanhVien> getListThanhVien()
        {
            List<ThanhVien> lstThanhVien = new List<ThanhVien>();
            string line;
            using (var file = new StreamReader("ThanhVien.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    ThanhVien tv = new ThanhVien();
                    string[] element = line.ToString().Split(new string[] { "\t" }, StringSplitOptions.None);
                    tv.maCD = element[0];
                    tv.maTV = element[1];
                    tv.tenTV = element[2];
                    lstThanhVien.Add(tv);
                }
            }
            return lstThanhVien;
        }
        public static List<ThuChi> getListThuChi()
        {
            List<ThuChi> lstThuChi = new List<ThuChi>();
            string line;
            using (var file = new StreamReader("ThuChi.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    ThuChi tc = new ThuChi();
                    string[] element = line.ToString().Split(new string[] { "\t" }, StringSplitOptions.None);
                    tc.maCD = element[0];
                    tc.maTC = element[1];
                    tc.tenKhoanThu = element[2];
                    tc.soTien = Convert.ToInt32(element[3]);
                    lstThuChi.Add(tc);
                }
            }
            return lstThuChi;
        }
        public static List<Splash> getSplash()
        {
            List<Splash> lstSplash = new List<Splash>();
            string line;
            using (var file = new StreamReader("ThongTin.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    Splash sp = new Splash();
                    string[] element = line.ToString().Split(new string[] { "\t" }, StringSplitOptions.None);
                    sp.id = element[0];
                    sp.thongTin = element[1];
                    sp.urlImage = element[2];
                    lstSplash.Add(sp);
                }
            }
            return lstSplash;
        }
        public static List<Img> getListImage()
        {
            List<Img> lstImage = new List<Img>();
            string line;
            using (var file = new StreamReader("Images.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    Img img = new Img();
                    string[] element = line.ToString().Split(new string[] { "\t" }, StringSplitOptions.None);
                    img._maCD = element[0];
                    img._maImage = element[1];
                    img._urlImage = element[2];
                    lstImage.Add(img);
                }
            }
            return lstImage;
        }
    }
}

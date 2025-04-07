/*//Bài tập 1: Quản lý cán bộ
using System;
using System.Collections.Generic;

class CanBo
{
    public string HoTen;
    public int NamSinh;
    public string GioiTinh;
    public string DiaChi;

    public virtual void Nhap()
    {
        Console.Write("Nhập họ tên: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhập năm sinh: ");
        NamSinh = int.Parse(Console.ReadLine());
        Console.Write("Nhập giới tính: ");
        GioiTinh = Console.ReadLine();
        Console.Write("Nhập địa chỉ: ");
        DiaChi = Console.ReadLine();
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Giới tính: {GioiTinh}, Địa chỉ: {DiaChi}");
    }
}

class CongNhan : CanBo
{
    public string Bac;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhập bậc (vd: 3/7): ");
        Bac = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Bậc: {Bac}");
    }
}

class KySu : CanBo
{
    public string NganhDaoTao;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhập ngành đào tạo: ");
        NganhDaoTao = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Ngành đào tạo: {NganhDaoTao}");
    }
}

class NhanVien : CanBo
{
    public string CongViec;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhập công việc: ");
        CongViec = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Công việc: {CongViec}");
    }
}

class QLCB
{
    private List<CanBo> danhSach = new List<CanBo>();

    public void NhapCanBo()
    {
        Console.WriteLine("Chọn loại cán bộ muốn nhập:");
        Console.WriteLine("1. Công nhân");
        Console.WriteLine("2. Kỹ sư");
        Console.WriteLine("3. Nhân viên");
        Console.Write("Lựa chọn: ");
        int loai = int.Parse(Console.ReadLine());

        CanBo cb;
        switch (loai)
        {
            case 1:
                cb = new CongNhan();
                break;
            case 2:
                cb = new KySu();
                break;
            case 3:
                cb = new NhanVien();
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                return;
        }

        cb.Nhap();
        danhSach.Add(cb);
        Console.WriteLine("Đã thêm cán bộ thành công.\n");
    }

    public void TimKiemTheoTen()
    {
        Console.Write("Nhập họ tên cần tìm: ");
        string ten = Console.ReadLine();
        bool timThay = false;

        foreach (var cb in danhSach)
        {
            if (cb.HoTen.ToLower().Contains(ten.ToLower()))
            {
                cb.HienThi();
                Console.WriteLine("-------------------");
                timThay = true;
            }
        }

        if (!timThay)
        {
            Console.WriteLine("Không tìm thấy cán bộ với tên đó.");
        }
    }

    public void HienThiDanhSach()
    {
        Console.WriteLine("Danh sách cán bộ:");
        foreach (var cb in danhSach)
        {
            cb.HienThi();
            Console.WriteLine("-------------------");
        }
    }
}

class Program
{
    static void Main()
    {
        QLCB qlcb = new QLCB();
        while (true)
        {
            Console.WriteLine("\n----- MENU -----");
            Console.WriteLine("1. Nhập thông tin cán bộ");
            Console.WriteLine("2. Tìm kiếm theo họ tên");
            Console.WriteLine("3. Hiển thị danh sách cán bộ");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn chức năng: ");
            string chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    qlcb.NhapCanBo();
                    break;
                case "2":
                    qlcb.TimKiemTheoTen();
                    break;
                case "3":
                    qlcb.HienThiDanhSach();
                    break;
                case "4":
                    Console.WriteLine("Thoát chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
*/


/*//Bài tập 2: Quản lý tài liệu
using System;
using System.Collections.Generic;

class TaiLieu
{
    public string MaTaiLieu;
    public string TenNhaXuatBan;
    public int SoBanPhatHanh;

    public virtual void Nhap()
    {
        Console.Write("Nhập mã tài liệu: ");
        MaTaiLieu = Console.ReadLine();
        Console.Write("Nhập tên nhà xuất bản: ");
        TenNhaXuatBan = Console.ReadLine();
        Console.Write("Nhập số bản phát hành: ");
        SoBanPhatHanh = int.Parse(Console.ReadLine());
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Mã: {MaTaiLieu}, NXB: {TenNhaXuatBan}, Số bản PH: {SoBanPhatHanh}");
    }

    public virtual string LoaiTaiLieu()
    {
        return "Chung";
    }
}

class Sach : TaiLieu
{
    public string TenTacGia;
    public int SoTrang;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhập tên tác giả: ");
        TenTacGia = Console.ReadLine();
        Console.Write("Nhập số trang: ");
        SoTrang = int.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Tác giả: {TenTacGia}, Số trang: {SoTrang}");
    }

    public override string LoaiTaiLieu()
    {
        return "Sách";
    }
}

class TapChi : TaiLieu
{
    public int SoPhatHanh;
    public int ThangPhatHanh;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhập số phát hành: ");
        SoPhatHanh = int.Parse(Console.ReadLine());
        Console.Write("Nhập tháng phát hành: ");
        ThangPhatHanh = int.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Số PH: {SoPhatHanh}, Tháng PH: {ThangPhatHanh}");
    }

    public override string LoaiTaiLieu()
    {
        return "Tạp chí";
    }
}

class Bao : TaiLieu
{
    public string NgayPhatHanh;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhập ngày phát hành (dd/MM/yyyy): ");
        NgayPhatHanh = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Ngày phát hành: {NgayPhatHanh}");
    }

    public override string LoaiTaiLieu()
    {
        return "Báo";
    }
}

class QuanLyTaiLieu
{
    private List<TaiLieu> danhSach = new List<TaiLieu>();

    public void NhapTaiLieu()
    {
        Console.WriteLine("Chọn loại tài liệu:");
        Console.WriteLine("1. Sách");
        Console.WriteLine("2. Tạp chí");
        Console.WriteLine("3. Báo");
        Console.Write("Lựa chọn: ");
        int loai = int.Parse(Console.ReadLine());

        TaiLieu tl;
        switch (loai)
        {
            case 1:
                tl = new Sach();
                break;
            case 2:
                tl = new TapChi();
                break;
            case 3:
                tl = new Bao();
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                return;
        }

        tl.Nhap();
        danhSach.Add(tl);
        Console.WriteLine("Đã thêm tài liệu thành công.\n");
    }

    public void HienThiTatCa()
    {
        Console.WriteLine("\n--- Danh sách tài liệu ---");
        foreach (var tl in danhSach)
        {
            Console.WriteLine($"[Loại: {tl.LoaiTaiLieu()}]");
            tl.HienThi();
            Console.WriteLine("-------------------------");
        }
    }

    public void TimKiemTheoLoai()
    {
        Console.Write("Nhập loại tài liệu cần tìm (Sách / Tạp chí / Báo): ");
        string loai = Console.ReadLine().ToLower();
        bool timThay = false;

        foreach (var tl in danhSach)
        {
            if (tl.LoaiTaiLieu().ToLower() == loai)
            {
                tl.HienThi();
                Console.WriteLine("-------------------------");
                timThay = true;
            }
        }

        if (!timThay)
        {
            Console.WriteLine("Không tìm thấy tài liệu thuộc loại này.");
        }
    }
}

class Program
{
    static void Main()
    {
        QuanLyTaiLieu qltl = new QuanLyTaiLieu();
        while (true)
        {
            Console.WriteLine("\n==== MENU ====");
            Console.WriteLine("1. Nhập thông tin tài liệu");
            Console.WriteLine("2. Hiển thị tất cả tài liệu");
            Console.WriteLine("3. Tìm kiếm theo loại tài liệu");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn chức năng: ");
            string chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    qltl.NhapTaiLieu();
                    break;
                case "2":
                    qltl.HienThiTatCa();
                    break;
                case "3":
                    qltl.TimKiemTheoLoai();
                    break;
                case "4":
                    Console.WriteLine("Thoát chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
*/

/*//Bài tập 3: Quản lý tuyển sinh
using System;
using System.Collections.Generic;

class ThiSinh
{
    public string SoBaoDanh;
    public string HoTen;
    public string DiaChi;
    public string UuTien;
    public double Diem1, Diem2, Diem3;

    public virtual void Nhap()
    {
        Console.Write("Nhập số báo danh: ");
        SoBaoDanh = Console.ReadLine();
        Console.Write("Nhập họ tên: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhập địa chỉ: ");
        DiaChi = Console.ReadLine();
        Console.Write("Nhập diện ưu tiên: ");
        UuTien = Console.ReadLine();

        Console.Write("Nhập điểm môn 1: ");
        Diem1 = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm môn 2: ");
        Diem2 = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm môn 3: ");
        Diem3 = double.Parse(Console.ReadLine());
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"SBD: {SoBaoDanh}, Họ tên: {HoTen}, Địa chỉ: {DiaChi}, Ưu tiên: {UuTien}");
        Console.WriteLine($"Điểm: {Diem1}, {Diem2}, {Diem3} | Tổng: {TongDiem()}");
    }

    public double TongDiem()
    {
        return Diem1 + Diem2 + Diem3;
    }

    public virtual string Khoi()
    {
        return "Chung";
    }

    public virtual bool IsTrungTuyen()
    {
        return false;
    }
}

class ThiSinhKhoiA : ThiSinh
{
    public override string Khoi() => "A";

    public override bool IsTrungTuyen()
    {
        return TongDiem() >= 15;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine("Khối A: Toán - Lý - Hóa");
    }
}

class ThiSinhKhoiB : ThiSinh
{
    public override string Khoi() => "B";

    public override bool IsTrungTuyen()
    {
        return TongDiem() >= 16;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine("Khối B: Toán - Hóa - Sinh");
    }
}

class ThiSinhKhoiC : ThiSinh
{
    public override string Khoi() => "C";

    public override bool IsTrungTuyen()
    {
        return TongDiem() >= 13.5;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine("Khối C: Văn - Sử - Địa");
    }
}

class TuyenSinh
{
    private List<ThiSinh> danhSach = new List<ThiSinh>();

    public void NhapThiSinh()
    {
        Console.WriteLine("Chọn khối thi:");
        Console.WriteLine("1. Khối A (Toán, Lý, Hóa)");
        Console.WriteLine("2. Khối B (Toán, Hóa, Sinh)");
        Console.WriteLine("3. Khối C (Văn, Sử, Địa)");
        Console.Write("Lựa chọn: ");
        int chon = int.Parse(Console.ReadLine());

        ThiSinh ts;
        switch (chon)
        {
            case 1:
                ts = new ThiSinhKhoiA();
                break;
            case 2:
                ts = new ThiSinhKhoiB();
                break;
            case 3:
                ts = new ThiSinhKhoiC();
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                return;
        }

        ts.Nhap();
        danhSach.Add(ts);
        Console.WriteLine("Đã thêm thí sinh.\n");
    }

    public void HienThiTrungTuyen()
    {
        Console.WriteLine("\n--- Danh sách thí sinh trúng tuyển ---");
        bool timThay = false;

        foreach (var ts in danhSach)
        {
            if (ts.IsTrungTuyen())
            {
                ts.HienThi();
                Console.WriteLine("---------------------------");
                timThay = true;
            }
        }

        if (!timThay)
        {
            Console.WriteLine("Không có thí sinh nào trúng tuyển.");
        }
    }

    public void TimKiemTheoSBD()
    {
        Console.Write("Nhập số báo danh cần tìm: ");
        string sbd = Console.ReadLine();
        bool timThay = false;

        foreach (var ts in danhSach)
        {
            if (ts.SoBaoDanh == sbd)
            {
                ts.HienThi();
                Console.WriteLine("---------------------------");
                timThay = true;
            }
        }

        if (!timThay)
        {
            Console.WriteLine("Không tìm thấy thí sinh có số báo danh này.");
        }
    }
}

class Program
{
    static void Main()
    {
        TuyenSinh ts = new TuyenSinh();
        while (true)
        {
            Console.WriteLine("\n==== MENU TUYỂN SINH ====");
            Console.WriteLine("1. Nhập thí sinh mới");
            Console.WriteLine("2. Hiển thị danh sách trúng tuyển");
            Console.WriteLine("3. Tìm kiếm theo số báo danh");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn chức năng: ");
            string chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    ts.NhapThiSinh();
                    break;
                case "2":
                    ts.HienThiTrungTuyen();
                    break;
                case "3":
                    ts.TimKiemTheoSBD();
                    break;
                case "4":
                    Console.WriteLine("Kết thúc chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
*/

/*//Bài tập 4: Quản lý khu phố
using System;
using System.Collections.Generic;

class Nguoi
{
    public string CMND;
    public string HoTen;
    public int Tuoi;
    public int NamSinh;
    public string NgheNghiep;

    public void Nhap()
    {
        Console.Write("Nhập số CMND: ");
        CMND = Console.ReadLine();
        Console.Write("Nhập họ tên: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhập tuổi: ");
        Tuoi = int.Parse(Console.ReadLine());
        Console.Write("Nhập năm sinh: ");
        NamSinh = int.Parse(Console.ReadLine());
        Console.Write("Nhập nghề nghiệp: ");
        NgheNghiep = Console.ReadLine();
    }

    public void HienThi()
    {
        Console.WriteLine($"CMND: {CMND}, Họ tên: {HoTen}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Nghề nghiệp: {NgheNghiep}");
    }
}

class HoDan
{
    public int SoNha;
    public int SoThanhVien;
    public List<Nguoi> ThanhVien = new List<Nguoi>();

    public void Nhap()
    {
        Console.Write("Nhập số nhà: ");
        SoNha = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thành viên: ");
        SoThanhVien = int.Parse(Console.ReadLine());

        for (int i = 0; i < SoThanhVien; i++)
        {
            Console.WriteLine($"\n-- Nhập thông tin thành viên thứ {i + 1} --");
            Nguoi nguoi = new Nguoi();
            nguoi.Nhap();
            ThanhVien.Add(nguoi);
        }
    }

    public void HienThi()
    {
        Console.WriteLine($"\n>> Số nhà: {SoNha}, Số thành viên: {SoThanhVien}");
        foreach (var nguoi in ThanhVien)
        {
            nguoi.HienThi();
        }
    }

    public bool CoNguoiTen(string ten)
    {
        foreach (var nguoi in ThanhVien)
        {
            if (nguoi.HoTen.ToLower().Contains(ten.ToLower()))
                return true;
        }
        return false;
    }
}

class KhuPho
{
    private List<HoDan> danhSachHoDan = new List<HoDan>();

    public void NhapDanhSachHoDan()
    {
        Console.Write("Nhập số hộ dân: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n=== Nhập hộ dân thứ {i + 1} ===");
            HoDan hoDan = new HoDan();
            hoDan.Nhap();
            danhSachHoDan.Add(hoDan);
        }
    }

    public void HienThiTatCa()
    {
        Console.WriteLine("\n===== Danh sách tất cả các hộ dân =====");
        foreach (var hoDan in danhSachHoDan)
        {
            hoDan.HienThi();
        }
    }

    public void TimKiemTheoTen()
    {
        Console.Write("Nhập họ tên cần tìm: ");
        string ten = Console.ReadLine();
        bool timThay = false;

        foreach (var hoDan in danhSachHoDan)
        {
            if (hoDan.CoNguoiTen(ten))
            {
                hoDan.HienThi();
                timThay = true;
            }
        }

        if (!timThay)
            Console.WriteLine("Không tìm thấy hộ dân nào có người tên như vậy.");
    }

    public void TimKiemTheoSoNha()
    {
        Console.Write("Nhập số nhà cần tìm: ");
        int soNha = int.Parse(Console.ReadLine());
        bool timThay = false;

        foreach (var hoDan in danhSachHoDan)
        {
            if (hoDan.SoNha == soNha)
            {
                hoDan.HienThi();
                timThay = true;
            }
        }

        if (!timThay)
            Console.WriteLine("Không tìm thấy hộ dân có số nhà này.");
    }
}

class Program
{
    static void Main()
    {
        KhuPho khuPho = new KhuPho();
        while (true)
        {
            Console.WriteLine("\n===== MENU QUẢN LÝ KHU PHỐ =====");
            Console.WriteLine("1. Nhập danh sách hộ dân");
            Console.WriteLine("2. Hiển thị tất cả hộ dân");
            Console.WriteLine("3. Tìm kiếm theo họ tên");
            Console.WriteLine("4. Tìm kiếm theo số nhà");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");
            string chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    khuPho.NhapDanhSachHoDan();
                    break;
                case "2":
                    khuPho.HienThiTatCa();
                    break;
                case "3":
                    khuPho.TimKiemTheoTen();
                    break;
                case "4":
                    khuPho.TimKiemTheoSoNha();
                    break;
                case "5":
                    Console.WriteLine("Chương trình kết thúc.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
*/

/*//Bài tập 5: Quản lý khách sạn
using System;
using System.Collections.Generic;

class Nguoi
{
    public string HoTen;
    public int NamSinh;
    public string CMND;

    public void Nhap()
    {
        Console.Write("Nhập họ tên: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhập năm sinh: ");
        NamSinh = int.Parse(Console.ReadLine());
        Console.Write("Nhập số CMND: ");
        CMND = Console.ReadLine();
    }

    public void HienThi()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, CMND: {CMND}");
    }
}

class KhachThue
{
    public Nguoi ThongTinCaNhan = new Nguoi();
    public int SoNgayTro;
    public string LoaiPhong;
    public double GiaPhong;

    public void Nhap()
    {
        Console.WriteLine("\n--- Nhập thông tin cá nhân ---");
        ThongTinCaNhan.Nhap();

        Console.Write("Nhập số ngày trọ: ");
        SoNgayTro = int.Parse(Console.ReadLine());
        Console.Write("Nhập loại phòng: ");
        LoaiPhong = Console.ReadLine();
        Console.Write("Nhập giá phòng mỗi ngày: ");
        GiaPhong = double.Parse(Console.ReadLine());
    }

    public void HienThi()
    {
        ThongTinCaNhan.HienThi();
        Console.WriteLine($"Số ngày trọ: {SoNgayTro}, Loại phòng: {LoaiPhong}, Giá phòng: {GiaPhong} VNĐ/ngày");
    }

    public double TinhTien()
    {
        return SoNgayTro * GiaPhong;
    }
}

class KhachSan
{
    private List<KhachThue> danhSachKhach = new List<KhachThue>();

    public void NhapDanhSachKhach()
    {
        Console.Write("Nhập số lượng khách thuê phòng: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n== Nhập thông tin khách hàng thứ {i + 1} ==");
            KhachThue khach = new KhachThue();
            khach.Nhap();
            danhSachKhach.Add(khach);
        }
    }

    public void HienThiTatCa()
    {
        Console.WriteLine("\n== Danh sách tất cả các khách thuê phòng ==");
        foreach (var khach in danhSachKhach)
        {
            khach.HienThi();
            Console.WriteLine("-------------------------------------");
        }
    }

    public void TimKiemTheoTen()
    {
        Console.Write("Nhập họ tên cần tìm: ");
        string ten = Console.ReadLine();
        bool timThay = false;

        foreach (var khach in danhSachKhach)
        {
            if (khach.ThongTinCaNhan.HoTen.ToLower().Contains(ten.ToLower()))
            {
                khach.HienThi();
                Console.WriteLine("-------------------------------------");
                timThay = true;
            }
        }

        if (!timThay)
            Console.WriteLine("Không tìm thấy khách hàng có tên như vậy.");
    }

    public void TinhTienTheoCMND()
    {
        Console.Write("Nhập CMND khách cần tính tiền: ");
        string cmnd = Console.ReadLine();
        bool timThay = false;

        foreach (var khach in danhSachKhach)
        {
            if (khach.ThongTinCaNhan.CMND == cmnd)
            {
                Console.WriteLine($"\nKhách hàng: {khach.ThongTinCaNhan.HoTen}");
                Console.WriteLine($"Số ngày trọ: {khach.SoNgayTro}, Giá phòng/ngày: {khach.GiaPhong}");
                Console.WriteLine($"=> Tổng tiền: {khach.TinhTien()} VNĐ");
                timThay = true;
            }
        }

        if (!timThay)
            Console.WriteLine("Không tìm thấy khách có CMND này.");
    }
}

class Program
{
    static void Main()
    {
        KhachSan khachSan = new KhachSan();

        while (true)
        {
            Console.WriteLine("\n===== MENU QUẢN LÝ KHÁCH SẠN =====");
            Console.WriteLine("1. Nhập danh sách khách thuê phòng");
            Console.WriteLine("2. Hiển thị tất cả khách thuê phòng");
            Console.WriteLine("3. Tìm kiếm khách theo họ tên");
            Console.WriteLine("4. Tính tiền cho khách khi trả phòng");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");
            string chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    khachSan.NhapDanhSachKhach();
                    break;
                case "2":
                    khachSan.HienThiTatCa();
                    break;
                case "3":
                    khachSan.TimKiemTheoTen();
                    break;
                case "4":
                    khachSan.TinhTienTheoCMND();
                    break;
                case "5":
                    Console.WriteLine("Chương trình kết thúc.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
*/
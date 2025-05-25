using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using System.Diagnostics;

namespace DemoMVC.Controllers
{
    public class HoaDonController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(HoaDon Hd)
        {
            string? Tenmon = Hd.TenMon;
            int SoLuong = Hd.SoLuong;
            int DonGia = Hd.DonGia;
            int ThanhTien = SoLuong * DonGia;
            string strOutput = "Số lượng: " + SoLuong + ", Đơn giá: " + DonGia + ", Thành tiềnVND: " + ThanhTien;
            ViewBag.infoHoaDon = strOutput;
            return View();
        }
    }
}
Buổi học số 3: 
<<<<<<< HEAD
=======
2. Cấu trúc thư mục của dự án .Net MVC:

Dự án .NET MVC = một website
Gõ link → web hiện ra
Có giao diện
Có xử lý phía server

MVC: Model - Views - Controller
Tạo project MVC: dotnet new mvc

📄 DemoController.cs là gì?
Ví dụ:

public class DemoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

👉 Nghĩa là:
Có 1 controller tên Demo
Có 1 hành động (action) tên Index
>>>>>>> 2d7056f907b3a3576eae8c8b5a6004dd8b2b7246

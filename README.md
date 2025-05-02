TODO WEB APP - CLEAN ARCHITECTURE DEMO
======================================

MÔ TẢ
-----
Đây là một ứng dụng web đơn giản quản lý danh sách công việc (TODO list) được phát triển theo mô hình Clean Architecture. Giao diện web xây dựng bằng ASP.NET Core MVC, sử dụng AJAX để thêm công việc và tự động cập nhật danh sách mà không cần tải lại trang.

CẤU TRÚC DỰ ÁN
--------------
Solution gồm các project chính:
1. TodoApp.Domain
   - Chứa các Entity (TodoItem) và Interface (ITodoRepository)
2. TodoApp.Application
   - Chứa các Service xử lý logic nghiệp vụ (TodoService)
3. TodoApp.Infrastructure
   - Cài đặt cụ thể của các Repository, ví dụ InMemoryTodoRepository
4. TodoApp.Web
   - Giao diện người dùng với ASP.NET Core MVC + Razor + AJAX

CÁCH CHẠY DỰ ÁN
---------------
1. Mở solution trong Visual Studio 2022.
2. Thiết lập project khởi động là "TodoApp.Web".
3. Nhấn F5 hoặc Ctrl+F5 để chạy.

TÍNH NĂNG CHÍNH
---------------
✔ Xem danh sách công việc  
✔ Thêm công việc mới  
✔ Xóa công việc mới 
✔ Đánh dấu hoàn thành công việc
✔ Danh sách tự động cập nhật sau khi thêm/xóa


TƯ DUY CLEAN ARCHITECTURE
-------------------------
- Domain chỉ chứa các Entity và Interface thuần C#.
- Application chứa logic nghiệp vụ độc lập.
- Infrastructure cung cấp cài đặt cụ thể (InMemory, Database, v.v).
- Web chỉ lo hiển thị giao diện và giao tiếp với Application.

THÔNG TIN KỸ THUẬT
------------------
- ASP.NET Core MVC (.NET 8)
- Razor View Engine
- Dữ liệu tạm thời lưu bằng InMemory Repository (List<TodoItem>)

LIÊN HỆ / HỖ TRỢ
---------------
Người phát triển: [Nguyễn Nhật Minh]
Email: [04nhatminh@gmail.com]  
Github: [[link nếu](https://github.com/04nhatminh)]


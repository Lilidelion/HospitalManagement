using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
// Đăng ký dịch vụ Authentication & Authorization
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";  // Đường dẫn đến trang đăng nhập
        options.LogoutPath = "/Account/Logout"; // Đường dẫn đến trang đăng xuất
        options.AccessDeniedPath = "/Account/AccessDenied"; // Trang lỗi quyền hạn (nếu cần)
    });

builder.Services.AddAuthorization();
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseRouting();

app.UseAuthentication(); // Kích hoạt Authentication
app.UseAuthorization();  // Kích hoạt Authorization

app.UseStaticFiles();



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();

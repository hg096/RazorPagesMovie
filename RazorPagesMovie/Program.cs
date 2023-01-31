using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;

    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddRazorPages();

    builder.Services.AddDbContext<RazorPagesMovieContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesMovieContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesMovieContext' not found.")));

    var app = builder.Build();

// 개발자 옵션 설정
    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }
// 미들웨어 사용 설정
    app.UseHttpsRedirection();      // HTTP 요청을 HTTPS로 리디렉션
    app.UseStaticFiles();           // HTML, CSS, 이미지, JavaScript와 같은 정적 파일이 제공
    app.UseRouting();               // 경로 일치를 미들웨어 파이프라인에 추가
    app.UseAuthorization();         // 사용자에게 보안 리소스에 액세스할 수 있는 권한을 부여
    app.MapRazorPages();            // Razor Pages에 대한 엔드포인트 라우팅
    app.Run();                      // 앱 실행
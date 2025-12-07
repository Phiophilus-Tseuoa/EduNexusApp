using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DemoMVP;
using DemoMVP.Services;
using AttendanceManagementSystem.Services;




var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//builder.Services.AddSingleton<TeacherService>();
builder.Services.AddSingleton<TeacherDataService>();
builder.Services.AddSingleton<StudentService>();
builder.Services.AddSingleton<TeacherClassService>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddScoped<TeacherSubjectService>();



await builder.Build().RunAsync();

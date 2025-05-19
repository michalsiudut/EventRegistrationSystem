using EventRegistrationSystem.Models;

namespace EventRegistrationSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            InMemoryDatabase.Participants.AddRange(new List<ParticipantModel>
            {
                new ParticipantModel { Id = 1, Name = "Micha³", Email = "michal@gmail.com", EventID = 1 },
                new ParticipantModel { Id = 2, Name = "Piotr", Email = "C#developer@gmail.com", EventID = 2 },
            });

            InMemoryDatabase.Events.AddRange(new List<EventModel>
            {
                new EventModel { Id = 1, Title = "C# meeting", Date = DateTime.MinValue, Description = "C# meeting when we are discussing everyhing" },
                new EventModel { Id = 2, Title = "cryptocurrencies meeting", Date = DateTime.MaxValue, Description = "free to join meeting" },
            });
            app.Run();
        }
    }
}

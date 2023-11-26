using SignalR_BusinessLayer.Abstract;
using SignalR_BusinessLayer.Concrete;
using SignalR_DataAccessLayer.Abstract;
using SignalR_DataAccessLayer.Concrete;
using SignalR_DataAccessLayer.EntityFramework;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<SignalRContext>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IAboutService,AboutManager>();
builder.Services.AddScoped<IAboutDal,EFAboutDal>();

builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IBookingDal, EFBookingDal>();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EFCategoryDal>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EFContactDal>();

builder.Services.AddScoped<IDiscountService, DiscountManager>();
builder.Services.AddScoped<IDiscountDal, EFDiscountDal>();

builder.Services.AddScoped<IFeatureService, FeatureManager>();
builder.Services.AddScoped<IFeatureDal, EFFeatureDal>();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDal, EFProductDal>();

builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDal, EFSocialMediaDal>();

builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<ITestimonialDal, EFTestimonialDal>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

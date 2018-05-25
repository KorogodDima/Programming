using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Service.Web.Migrations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Service.Web.Models
{
    // Чтобы добавить данные профиля для пользователя, можно добавить дополнительные свойства в класс ApplicationUser. Дополнительные сведения см. по адресу: http://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<DbRepairRequest> RepairRequests { get; set; }
        public DbSet<DbFaultType> DbFaults { get; set; }
    }


    /// <summary>
    /// Информация о поездке
    /// </summary>
    public class DbRepairRequest
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Дата заполнения
        /// </summary>
        public DateTime Filled { get; set; }
        /// <summary>
        /// ФИО пассажира
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Описание пути
        /// </summary>
        public virtual Collection<DbFaultType> Faults { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }
        
    }
  
    public class DbFaultType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Описание неисправности
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Коэффициент сложности
        /// </summary>
        public string Coefficient { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Cost { get; set; }

        public override string ToString()
        {
            return string.Format("{0}      Цена {1} руб.", Description, Cost);
        }
    }

    public enum DeviceType
    {

        Smartphone,
        Tablet,
        Laptop,
        PC,
    }
}
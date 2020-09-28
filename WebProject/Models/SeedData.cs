using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using WebProject.Domain;

namespace WebProject.Models
{
    public class SeedData
    {

        /// <summary>
        /// Наполнение БД данными
        /// </summary>

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<AppDbContext>>()))
            {
                if (!context.Projects.Any())
                {
                    context.Projects.AddRange(

                    new Project
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116371"),
                        Name = "Web-приложения для управления проектами",
                        CompanyOwner = "SibDev",
                        CompanyContractor = "AlphaSoftware",
                        CompanyOwnerContactPerson = "Иванов И.И.",
                        CompanyContractorContactPerson = "Си Цзиньпин",
                        StartDate = DateTime.Parse("2020-9-21"),
                        FinishDate = DateTime.Parse("2020-9-28"),
                        Priority = 1
                    },

                    new Project
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116372"),
                        Name = "Поисковая оптимизация движка web-ресурса",
                        CompanyOwner = "LimeFruts",
                        CompanyContractor = "AlphaSoftware",
                        CompanyOwnerContactPerson = "Петров А.А.",
                        CompanyContractorContactPerson = "Си Цзиньпин",
                        StartDate = DateTime.Parse("2020-9-07"),
                        FinishDate = DateTime.Parse("2020-9-24"),
                        Priority = 3
                    },

                    new Project
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116373"),
                        Name = "Разработка информационной системы учета производства бетона",
                        CompanyOwner = "iCement",
                        CompanyContractor = "AlphaSoftware",
                        CompanyOwnerContactPerson = "Скакун В.П.",
                        CompanyContractorContactPerson = "Си Цзиньпин",
                        StartDate = DateTime.Parse("2020-8-3"),
                        FinishDate = DateTime.Parse("2020-10-15"),
                        Priority = 4
                    },

                    new Project
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116374"),
                        Name = "Проектирование и описание системы управления клиентским сервисом",
                        CompanyOwner = "YaBank",
                        CompanyContractor = "AlphaSoftware",
                        CompanyOwnerContactPerson = "Тиньков О.Ю.",
                        CompanyContractorContactPerson = "Си Цзиньпин",
                        StartDate = DateTime.Parse("2020-9-1"),
                        FinishDate = DateTime.Parse("2020-9-30"),
                        Priority = 2
                    },

                    new Project
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116375"),
                        Name = "Разработка MVP версии системы парсинга контактных данных пользователей сайта",
                        CompanyOwner = "GreenTech",
                        CompanyContractor = "AlphaSoftware",
                        CompanyOwnerContactPerson = "Греф Г.О.",
                        CompanyContractorContactPerson = "Си Цзиньпин",
                        StartDate = DateTime.Parse("2020-9-14"),
                        FinishDate = DateTime.Parse("2020-11-2"),
                        Priority = 7
                    });

                    context.SaveChanges();
                }

                if (!context.EnumExecutorTypes.Any())
                {
                    context.EnumExecutorTypes.AddRange(

                    new EnumExecutorType
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116301"),
                        Type = "Project manager",
                        Description = "Менеджер проекта компании-имполнителя"
                    },

                    new EnumExecutorType
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116302"),
                        Type = "Frontend developer",
                        Description = "Фронтенд-разработчик компании-имполнителя"
                    },

                    new EnumExecutorType
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116303"),
                        Type = "Backend developer",
                        Description = "Бэкенд-разработчик компании-имполнителя"
                    },

                    new EnumExecutorType
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116304"),
                        Type = "DB developer",
                        Description = "Разработчик баз данных компании-имполнителя"
                    },

                    new EnumExecutorType
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116305"),
                        Type = "Designer",
                        Description = "Дизайнер компании-имполнителя"
                    });

                    context.SaveChanges();
                };

                if (!context.Executors.Any())
                {
                    context.Executors.AddRange(

                    new Executor
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116101"),
                        Name = "Си Цзиньпин",
                        ExecutorType = "Project manager",
                        ProjectId = new Guid("00000000-0000-0000-0000-000000000000"),
                        TaskId = new Guid("00000000-0000-0000-0000-000000000000")

                    },

                    new Executor
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116102"),
                        Name = "Ан Сяо",
                        ExecutorType = "Frontend developer",
                        ProjectId = new Guid("00000000-0000-0000-0000-000000000000"),
                        TaskId = new Guid("00000000-0000-0000-0000-000000000000")
                    },

                    new Executor
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116103"),
                        Name = "Бэнь Мин",
                        ExecutorType = "Backend developer",
                        ProjectId = new Guid("00000000-0000-0000-0000-000000000000"),
                        TaskId = new Guid("00000000-0000-0000-0000-000000000000")
                    },

                    new Executor
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116104"),
                        Name = "Вай Чжао",
                        ExecutorType = "DB developer",
                        ProjectId = new Guid("00000000-0000-0000-0000-000000000000"),
                        TaskId = new Guid("00000000-0000-0000-0000-000000000000")
                    },

                    new Executor
                    {
                        Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E116105"),
                        Name = "Цянь Фэй",
                        ExecutorType = "Designer",
                        ProjectId = new Guid("00000000-0000-0000-0000-000000000000"),
                        TaskId = new Guid("00000000-0000-0000-0000-000000000000")
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}

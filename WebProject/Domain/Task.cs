using System;
using System.ComponentModel.DataAnnotations;
using WebProject.Domain.Base;

namespace WebProject.Domain
{
    public class Task : BaseEntity
    {
        /// <summary>
        /// Модель данных Задачи
        /// </summary>

        [Required(ErrorMessage = "Заполните название задачи"),
        Display(Name = "Задача")]
        public string Name { get; set; }

        [Display(Name = "Проект")]
        public string ProjectId { get; set; }
        public Project Project { get; set; }
        
        
        [Display(Name = "Исполнитель")]
        public string ExecutorId { get; set; }
        public Executor Executor { get; set; }
    }
}

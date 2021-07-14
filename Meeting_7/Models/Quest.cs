using Meeting_7.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meeting_7.Models
{
    public class Quest : IEntity
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Название")]
        public string Title { get; set; }

        [Display(Name = "Краткое описание")]
        public string Description { get; set; }

        [Display(Name = "Путь к картинке")]
        public string ImagePath { get; set; }

        [Display(Name = "Сложность (1 - 5)")]
        public int Difficulty { get; set; }

        [Display(Name = "Размер группы")]
        public string Size { get; set; }

        [Display(Name = "Время (мин)")]
        public int Time { get; set; }

        [Display(Name = "Заголовок описания")]
        public string LongDescriptionHeader { get; set; }

        [Display(Name = "Описание")]
        public string LongDescription { get; set; }
    }
}
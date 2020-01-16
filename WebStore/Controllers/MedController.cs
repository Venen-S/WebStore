using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class MedController : Controller
    {
        private readonly List<MedicalScience> _medicalSciences = new List<MedicalScience>()
        {
            new MedicalScience
            {
                id=1,
                Science="Анатомия",
                Difficulty="Очень трудно",
                System="Все органы и системы",
                Mortality="Нулевая",
                Payment="Не оплачивается вовсе"
            },
            new MedicalScience
            {
                id=2,
                Science="Фармакология",
                Difficulty="Хардкорище",
                System="Все органы и системы",
                Mortality="В зависимости от препарата (от 0 до 100)",
                Payment="Очень высокая"
            },
            new MedicalScience
            {
                id=3,
                Science="Хирургия",
                Difficulty="Чуть выше среднего",
                System="Все органы и системы",
                Mortality="В зависимости от тяжести состояния и операции",
                Payment="Высокая"
            },
            new MedicalScience
            {
                id=4,
                Science="Наркология",
                Difficulty="Легко",
                System="Как правило ЦНС + зависит от препарата",
                Mortality="100% без отказа от наркотиков, высокая после отказа",
                Payment="Очень высокая"
            },
            new MedicalScience
            {
                id=5,
                Science="Медицина катастроф",
                Difficulty="Чуть выше среднего",
                System="Все органы и системы",
                Mortality="от 20-30 до 100%",
                Payment="Средняя"
            },
            new MedicalScience
            {
                id=6,
                Science="Спортивная медицина",
                Difficulty="Легко",
                System="Все органы и системы",
                Mortality="Единичные случаи",
                Payment="Очень высокая"
            },
            new MedicalScience
            {
                id=7,
                Science="Инфекционные болезни",
                Difficulty="Очень высокая",
                System="Все органы и системы",
                Mortality="вплоть до 100%, в зависимости от инфекции",
                Payment="очень низкая"
            },
            new MedicalScience
            {
                id=8,
                Science="Ортопедия",
                Difficulty="Сложно",
                System="Пассивный опорно-двигательный аппарат (кости)",
                Mortality="Нулевая",
                Payment="В основном низкая"
            },
            new MedicalScience
            {
                id=9,
                Science="Травматология",
                Difficulty="Сложно",
                System="Опорно-двигательный аппарат",
                Mortality="От низкой до средней",
                Payment="Средняя"
            },
            new MedicalScience
            {
                id=10,
                Science="Кардиология",
                Difficulty="Средне",
                System="Сердце и крупные сосуды",
                Mortality="Высокая",
                Payment="Очень низкая"
            },
            new MedicalScience
            {
                id=11,
                Science="Скорая помощь",
                Difficulty="Высокая",
                System="Все и вся",
                Mortality="Варьируется",
                Payment="Очень низкая"
            },
        };

        public IActionResult MedIndex()
        {
            return View(_medicalSciences);
        }
        public IActionResult MedDetails(int id)
        {
            var medicalScines = _medicalSciences.FirstOrDefault(y => y.id == id);
            if (medicalScines == null)
            {
                return NotFound();
            }
            return View(medicalScines);
        }
    }
}

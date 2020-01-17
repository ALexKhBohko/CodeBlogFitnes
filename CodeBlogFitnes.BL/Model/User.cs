using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitnes.BL.Model
{/// <summary>
/// Данные пользователя.
/// </summary>
    class User
    {
        #region Свойства
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get;  }
        /// <summary>
        /// Пол пользователя.
        /// </summary>
        public Gendar Gendar { get;  }
        /// <summary>
        /// день рождения пользователя.
        /// </summary>
        public DateTime BirthData { get; }
        /// <summary>
        /// Вес пользователя.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост пользователя.
        /// </summary>
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// Создание нового пользователя.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="gendar">Пол.</param>
        /// <param name="birthData">Дата рождения.</param>
        /// <param name="weight">Вес.</param>
        /// <param name="height">Рост.</param>
        public User(string name, 
                     Gendar gendar, 
                     DateTime birthData, 
                     double weight, 
                     double height)
        {
            #region Проверка входных словий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя вользователя не может быть пустым.", nameof(name));
            }
            if (gendar == null)
            {
                throw new ArgumentNullException("Пол неможет быть NULL.", nameof(gendar));
            }
            if (birthData < DateTime.Parse("01.01.1900") || birthData>=DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения.", nameof(birthData));
            }
            if(weight<= 35)
            {
                throw new ArgumentException("Вес не может быть меньше 35кг.", nameof(weight));
            }
            if (height <= 100)
            {
                throw new ArgumentException("Рост не может быть 100см.", nameof(height));
            }


            #endregion
            Name = name;
            Gendar = gendar;
            BirthData = birthData;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

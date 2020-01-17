using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitnes.BL.Model
{/// <summary>
/// Пол.
/// </summary>
    class Gendar
    {/// <summary>
    /// Названия.
    /// </summary>
        public string Name { get;  }
        /// <summary>
        /// Создать новый пол.
        /// </summary>
        /// <param name="name">Пол</param>
        public Gendar(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new ArgumentNullException("Имя пола неможет быть пусвтыи или null", nameof(name));
            }
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}

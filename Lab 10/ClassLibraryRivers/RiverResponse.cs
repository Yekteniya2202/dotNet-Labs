using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRivers
{
    /// <summary>
    /// Ответ от справочника рек
    /// </summary>
    [Serializable]
    public class RiverResponse
    {
        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Признак успешного выполнения запроса
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Информация о реке
        /// </summary>
        public River River { get; set; }
    }
}

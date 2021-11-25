using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS_1._2.Classes.Core
{
    /// <summary>
    /// SSO логика
    /// </summary>
    public class Autharization
    {
        /// <summary>
        /// Метод авторизации пользователя
        /// </summary>
        /// <param name="userLogin">Введённый пользователем логин</param>
        /// <param name="userPassword">Введённый пользователем пароль</param>
        /// <returns>Возращает True - авторизован, False - не авторизован</returns>
        /// <remarks>Используется только при первичной аторизации</remarks>
        public bool Auth(string userLogin, string userPassword)
        {
            if (userLogin == userPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebApplication1.Domain.Entities.Responces;
using WebApplication1.Domain.Entities.User;
using WebApplication1.BusinessLogic.Core;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication.Domain.Entities.Responces;
using WebApplication.Domain.Entities.User;

namespace WebApplication1.BusinessLogic.MainBL
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResponce UserLoginAction(ULoginData data)
        {
            return RLogInUpService(data);
        }
        public URegisterResponse UserRegisterAction(URegisterData data)
        {
            return RRegisterUpService(data);
        }
        public HttpCookie GenCookie(string loginCredential)
        {
            return Cookie(loginCredential);
        }
        public UserMinimal GetUserByCookie(string apiCookieValue)
        {
            return UserCookie(apiCookieValue);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySandwitchFactory.Web.UI.Services
{
    public interface IFacebookConnectionManager
    {
        bool AuthenticateUser();
    }
}

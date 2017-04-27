using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySandwitchFactory.Web.UI.Services
{
    public class FacebookConnectionManager : IFacebookConnectionManager
    {
        private readonly string _userName;
        private readonly string _authenticationToken;
        private readonly string _faceBookConnectionUrl;
        
        public FacebookConnectionManager(string userName, string authenticationToken, string faceBookConnectionUrl)
        {
            _userName = userName;
            _authenticationToken = authenticationToken;
            _faceBookConnectionUrl = faceBookConnectionUrl;
        }

        //public FacebookConnectionManager()
        //{
        //    // TODO: Complete member initialization
        //}

        public bool AuthenticateUser()
        {
            if (!string.IsNullOrEmpty(_userName) && !string.IsNullOrEmpty(_authenticationToken) &&
                !string.IsNullOrEmpty(_faceBookConnectionUrl))
            {
                return true;
            }

            return false;
            //throw new NotImplementedException();
        }
    }
}
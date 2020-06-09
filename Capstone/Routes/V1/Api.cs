﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Routes.V1
{
    public static class Api
    {
        internal const string Root = "api";
        internal const string Version = "v1";
        internal const string Base = Root + "/" + Version;

        public static class Values
        {
            public const string GetAll = Base + "/Values";
            public const string Get = Base + "/Values/{id}";
        }

        public static class User
        {   
            public const string Login = Base + "/Auth/Login";
            public const string Register = Base + "/Auth/Register";
            public const string Refresh = Base + "/Auth/Refresh";
        }

        public static class Favorite
        {
            public const string GetAll = Base + "/Favorites";
            public const string Get = Base + "/Favorites/{id}";
            public const string Delete = Base + "/Favorites/{id}";
            public const string Update = Base + "/Favorites/{id}";
           





        }


        public static class Comment
        {
            public const string GetAll = Base + "/Comments";
            public const string Get = Base + "/Comments/{id}";
            public const string Delete = Base + "/Comments/{id}";
            public const string Update = Base + "/Comments/{id}";




        }
    }
}

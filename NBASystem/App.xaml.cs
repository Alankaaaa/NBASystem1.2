﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NBASystem.Model;

namespace NBASystem
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static NBA_DTBSEntities22 DB = new NBA_DTBSEntities22();
        bool isadminpages = false;
    }
}

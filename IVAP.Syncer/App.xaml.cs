using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using AutoMapper;

namespace IVAP.Syncer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            Mapper.CreateMap<Survey, SyncedSurvey>();
        }
    }
}

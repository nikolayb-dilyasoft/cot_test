﻿
using System;

namespace TestCompany.Services
{
	public partial class ApplicationServices
    {
        
        /// The first three numbers in the version reflect the version of the app generator.
        /// The last number is the value stored in DataAquarium.Version.xml file located in the root of the project.
        /// The number is automatically incremented when the application is published from the app generator.
        public static string Version
        {
            get
            {
                return "8.6.11.0";
            }
        }
        
        /// The version of jQuery Mobile integrated in the app generator.
        public static string JqmVersion
        {
            get
            {
                return "1.4.6";
            }
        }
        
        /// The version reported to mobile clients adding this application.
        public static string HostVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }
    }
}

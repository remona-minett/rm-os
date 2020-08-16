﻿using System;
using System.IO;
using rm_os.Configuration;

namespace rm_os.Kernel
{
    class KInit
    {
        public static void KCheck()
        {
            string confloc;
            string[] configuration;
            Console.Title = "RM-OS Alpha"; // update version number here
            string progdir = AppDomain.CurrentDomain.BaseDirectory;
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string rmosfo = Path.Combine(appdata, "rm-os");
            Directory.CreateDirectory(rmosfo); Directory.SetCurrentDirectory(rmosfo); // sets current directory to the program's appdata folder
            if (File.Exists("config.txt")) // begin init config
            {
                confloc = Path.Combine(rmosfo, "config.txt");
                configuration = LoadConfig.LoadCFile(confloc); // loads configuration into memory
            }
            else { File.Create("config.txt"); confloc = Path.Combine(rmosfo, "config.txt"); } // if config file doesn't exist, create a blank one. usually only done on first run
        }
    }
}
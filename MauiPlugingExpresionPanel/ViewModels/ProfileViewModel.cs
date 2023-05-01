using MauiPlugingExpresionPanel.Models;
using Microsoft.Maui.ApplicationModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPlugingExpresionPanel.ViewModels
{
    public class ProfileViewModel
    {
        public ObservableCollection<Profils> val { get; set; }
           
        public ProfileViewModel()
        {
            val = new ObservableCollection<Profils>()
            {
                new Profils() {Profil = "Profilo Programmatore 1" , Name = "Michel",  Description = ".Net Developer", Email = "E-mail : xxx.xxxxx@gmail.com0"},
                new Profils() {Profil = "Profilo Programmatore 2" , Name = "Alex",  Description = "Software Developer", Email = "E-mail : xxx.xxxxx@gmail.com0"},
                new Profils() {Profil = "Profilo Programmatore 3" , Name = "John",  Description = "Web Developer", Email = "E-mail : xxx.xxxxx@gmail.com0"},
                new Profils() {Profil = "Profilo Programmatore 4" , Name = "Franck",  Description = "Software Developer", Email = "E-mail : xxx.xxxxx@gmail.com0"}
            };
        }
    }
}

using LanchesApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanchesApp.ViewModels
{
    public class HomeViewModel 
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}

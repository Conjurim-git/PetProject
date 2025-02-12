using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PetProject.Pages
{
    [IgnoreAntiforgeryToken]
    public class FuelAnalysisModel : PageModel
    {
        [BindProperty]
        
        public string Message { get; private set; } = "";
        public string ResultMessage { get; private set; } = "";
        [BindProperty]
        public string SiO2 { get; set; }
        [BindProperty]
        public string Al2O3 { get; set; }
        [BindProperty]
        public string TiO2 { get; set; }
        [BindProperty]
        public string CaO { get; set; }
        [BindProperty]
        public string MgO { get; set; }
        [BindProperty]
        public string Na2O { get; set; }
        [BindProperty]
        public string Ka2O { get; set; }

        
        public void OnGet()
        {
            Message = "Введите свои данные в %";
        }

        public void OnPost()
        {

            var firstOxidation = SiO2;
            var secondOxidation = Al2O3;
            var thirdOxidation = TiO2;
            var fourthOxidation = CaO;
            var fifthOxidation = MgO;
            var sixthOxidation = Na2O;
            var seventhOxidation = Ka2O;

            var acidOxides = (firstOxidation + secondOxidation + thirdOxidation);
            var basicOxides = (fourthOxidation + fifthOxidation + sixthOxidation + seventhOxidation);
            
            double result = Convert.ToDouble(acidOxides) / Convert.ToDouble(basicOxides);
            if (result > 6)
            {
                ResultMessage = $"K/O = {result}, К/О > 6 следовательно топливо является нешлакующим";
            }
            else
            {
                ResultMessage = $"K/O = {result}, K/O < 6 следовательно топливо является шлакующим";
            }
        }
        ////////////////
        //public IActionResult OnGet(string? name)
        //{
        //    if (string.IsNullOrEmpty(name)) return BadRequest("Name undefined");
        //    return Page();
        //}
        ////////////////
    }
}

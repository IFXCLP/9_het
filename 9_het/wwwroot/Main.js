using Microsoft.AspNetCore.Mvc;

namespace _9_het.wwwroot
{
    public class Main : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        fetch('/questions/1')
            .then(response => response.json())
            .then(data => kérdésMegjelenítés(data)
            );

        function kérdésMegjelenítés(kérdés) {
            console.log(kérdés);
            document.getElementById("kérdés_szöveg").innerText = kérdés.questionText
            document.getElementById("válasz1").innerText = kérdés.answer1
            document.getElementById("válasz2").innerText = kérdés.answer2
            document.getElementById("válasz3").innerText = kérdés.answer3
            document.getElementById("kép").src = "https://szoft1.comeback.hu/hajo/" + kérdés.image;
        }
    }
}

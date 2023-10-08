using AUT02_03_The_Simpsoms.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using System.Diagnostics;

namespace AUT02_03_The_Simpsoms.Controllers
{
    public class SimpsonsController : Controller
    {

        static int currentId = 3;
        static List<Character> simpsonsCharacters = new List<Character>
        {
            new Character { ID = 1, Name = "Homer Simpson", Age = 40, Job = "Planta Nuclear" },
            new Character { ID = 2, Name = "Marge Simpson", Age = 38, Job = "Ama de casa" }
        };

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CharacterList()
        {
            return View(simpsonsCharacters);
        }

        public IActionResult CharacterDetails(int ID)
        {
            Character character = simpsonsCharacters.SingleOrDefault(c => c.ID == ID);
            if (character == null)
            {
                return View("Error");
            }
            return View(character);
        }

        [HttpGet]
        public IActionResult CharacterCreation()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CharacterCreation(Character character)
        {
            if (ModelState.IsValid)
            {
                character.ID = currentId++;
                simpsonsCharacters.Add(character);
                return RedirectToAction("CharacterList");
            }
            return View(character);
        }

        [HttpGet]
        public IActionResult CharacterEdit(int ID)
        {
            Character character = simpsonsCharacters.SingleOrDefault(c => c.ID == ID);
            if (character == null)
            {
                return View("Error");
            }
            return View(character);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CharacterEdit(Character editedCharacter)
        {
            if (ModelState.IsValid)
            {
                Character characterToUpdate = simpsonsCharacters.FirstOrDefault(c => c.ID == editedCharacter.ID);
                if (characterToUpdate != null)
                {
                    characterToUpdate.Name = editedCharacter.Name;
                    characterToUpdate.Age = editedCharacter.Age;
                    characterToUpdate.Job = editedCharacter.Job;
                }
                else
                {
                    return View("Error");
                }
                return RedirectToAction("CharacterList");
            }
            return View(editedCharacter);
        }

        public IActionResult CharacterDelete(int ID)
        {
            Character character = simpsonsCharacters.SingleOrDefault(c => c.ID == ID);
            simpsonsCharacters.Remove(character);
            return RedirectToAction("CharacterList");
        }
    }
}

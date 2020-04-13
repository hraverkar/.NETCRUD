using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using test.Modals;

namespace test.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CharacterController : ControllerBase
  {
    private readonly ICharacterService _characterService;
    public CharacterController(ICharacterService characterService)
    {
      _characterService = characterService;
    }
    private static Character knight = new Character();

    public static List<Character> characters = new List<Character>
        {
          new Character(),
          new Character {Id=1, Name = "Sam"}
        };

    [HttpGet("{id}")]
    public IActionResult GetSingle(int id)
    {
      return Ok(_characterService.GetCharacterById(id));
    }

    [HttpGet("GetAll")]
    public IActionResult Get()
    {
      return Ok(_characterService.AllCharacters());
    }

    [HttpPost]
    public IActionResult AddCharacter(Character newCharacter){
      
      return Ok(_characterService.AddCharacter(newCharacter));
    }
  }
}
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using test.Modals;

public class CharacterService : ICharacterService
{

  public static List<Character> characters = new List<Character>
        {
          new Character(),
          new Character {Id=1, Name = "Sam"}
        };

    
  public List<Character> AddCharacter(Character newCharacter)
  {
    characters.Add(newCharacter);
    return characters;
  }

  public List<Character> AllCharacters()
  {
    return characters;
  }

  public Character GetCharacterById(int id)
  {
    return characters.FirstOrDefault(c => c.Id == id);
  }


  
}
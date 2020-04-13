using System.Collections.Generic;
using test.Modals;

public interface ICharacterService
{
  List<Character> AllCharacters ();
  Character GetCharacterById(int id);

 List<Character> AddCharacter(Character newCharacter);

}
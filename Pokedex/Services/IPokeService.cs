namespace Pokedex.Services;

// Dentro da interface definimos os métodos que queremos possuir em nosso serviço
public interface IPokeService
{
    // Para buscar todos os Pokemons
    List<Pokemon> GetPokemons();
    
    // Para buscar todos os Tipos
    List<Tipo> GetTipos();
    
    // Para buscar um Pokemon específico por seu Número
    Pokemon GetPokemon(int Numero);
   
    // Para retornar um objeto do tipo PokedexDto, com os tipos e pokemons
    PokedexDto GetPokedexDto();

    // Para retornar um objeto do tipo DetailsDto, com um pokemon específico
    // O anterior e o próximo, como está no DetailsDto
    DetailsDto GetDetailedPokemon(int Numero);

    // Para retornar um tipo específico por se nome
    Tipo GetTipo(string Nome);
}
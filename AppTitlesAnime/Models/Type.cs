using System.ComponentModel.DataAnnotations.Schema;

namespace AppTitlesAnime.Models;

public partial class Type
{
    public short Id { get; set; }

    public string GenreName { get; set; } = null!;

    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
    public object? TypeName { get; set; }
}

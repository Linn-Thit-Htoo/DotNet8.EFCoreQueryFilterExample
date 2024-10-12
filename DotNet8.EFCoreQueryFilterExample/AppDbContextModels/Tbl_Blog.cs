using System.ComponentModel.DataAnnotations;

namespace DotNet8.EFCoreQueryFilterExample.AppDbContextModels;

public class Tbl_Blog
{
    [Key]
    public int BlogId { get; set; }
    public string BlogTitle { get; set; }
    public string BlogAuthor { get; set; }
    public string BlogContent { get; set; }
    public bool IsDeleted { get; set; }
}

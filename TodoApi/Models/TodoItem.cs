// A pasta models não é estritamente necessaria, ou seja, é por convenção.
// Nela pode conter todos os modelos/classes.
// Sendo "TodoItem" uma classe.

namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}